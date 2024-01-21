using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Exceptions;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.GroupModule;
using UTEHY.DatabaseCoursePortal.Api.Models.Section;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class SectionService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserService _userService;
        private readonly IMapper _mapper;

        public SectionService(ApplicationDbContext dbContext, IMapper mapper, UserService userService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _userService = userService;
        }

        public async Task<PagingResult<Section>> Get(GetSectionRequest request)
        {
            try
            {
                var query = _dbContext.Sections.Where(x => x.DeletedAt == null).AsQueryable();

                if (!string.IsNullOrEmpty(request.Title))
                {
                    query = query.Where(b => b.Title.ToLower().Contains(request.Title.ToLower()));
                }

                int total = await query.CountAsync();

                if (request.PageIndex == null) request.PageIndex = 1;
                if (request.PageSize == null) request.PageSize = total;

                int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

                if (string.IsNullOrEmpty(request.SortBy) || request.SortBy == SortByConstant.Desc)
                {
                    query = request.OrderBy switch
                    {
                        OrderByConstant.Priority => query.OrderByDescending(b => b.Priority),
                        OrderByConstant.Id or _ => query.OrderByDescending(b => b.Id),
                    };
                }
                else if (request.SortBy == SortByConstant.Asc)
                {
                    query = request.OrderBy switch
                    {
                        OrderByConstant.Priority => query.OrderBy(b => b.Priority),
                        OrderByConstant.Id or _ => query.OrderBy(b => b.Id),
                    };
                }

                var items = await query
                    .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
                    .Take(request.PageSize.Value)
                    .ToListAsync();

                var result = new PagingResult<Section>(items, request.PageIndex.Value, request.PageSize.Value, request.SortBy, request.OrderBy, total, totalPages);

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<Section> Create(CreateSectionRequest request)
        {
            try
            {
                var section = _mapper.Map<Section>(request);

                var userCurrent = await _userService.GetCurrentUserAsync();
                section.CreatedAt = DateTime.Now;
                section.CreatedBy = userCurrent?.Id;

                await _dbContext.Sections.AddAsync(section);
                await _dbContext.SaveChangesAsync();

                return section;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<Section> Edit(EditSectionRequest request)
        {
            try
            {
                var section = await _dbContext.Sections.FindAsync(request.Id);

                if (section == null)
                {
                    throw new ApiException("Không tìm thấy chương học phần hợp lệ!", HttpStatusCode.InternalServerError);
                }

                _mapper.Map(request, section);
                var userCurrent = await _userService.GetCurrentUserAsync();
                section.UpdatedAt = DateTime.Now;
                section.CreatedBy = userCurrent?.Id;

                await _dbContext.SaveChangesAsync();

                return section;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<Section> Delete(int id)
        {
            try
            {
                var section = await _dbContext.Sections.FindAsync(id);

                if (section == null)
                {
                    throw new ApiException("Không tìm chương học phần hợp lệ!", HttpStatusCode.InternalServerError);
                }

                var userCurrent = await _userService.GetCurrentUserAsync();
                section.DeletedAt = DateTime.Now;
                section.CreatedBy = userCurrent?.Id;

                await _dbContext.SaveChangesAsync();

                return section;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<List<Section>> DeleteMultiple(List<int?> ids)
        {
            using (var transaction = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var sections = await _dbContext.Sections
                                                   .Where(s => ids.Contains(s.Id) && s.DeletedAt == null)
                                                   .ToListAsync();

                    if (!sections.Any())
                    {
                        throw new ApiException("Không tìm thấy phần học nào hợp lệ để xoá.", HttpStatusCode.BadRequest);
                    }

                    foreach (var section in sections)
                    {
                        section.DeletedAt = DateTime.Now;
                    }

                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return sections;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new ApiException($"Lỗi khi xoá các phần học: {ex.Message}", HttpStatusCode.InternalServerError, ex);
                }
            }
        }
    }
}
