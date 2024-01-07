using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Twilio.Http;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Exceptions;
using UTEHY.DatabaseCoursePortal.Api.Models.Banner;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.GroupModule;
using UTEHY.DatabaseCoursePortal.Api.Models.Student;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class GroupModuleService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserService _userService;
        private readonly IMapper _mapper;

        public GroupModuleService(ApplicationDbContext dbContext, IMapper mapper, UserService userService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _userService = userService;
        }

        public async Task<PagingResult<GroupModule>> Get(GetGroupModuleRequest request)
        {
            try
            {
                var query = _dbContext.GroupModules.Where(x => x.DeletedAt == null)
                    .Include(x => x.StudentGroupModules)
                    .Include(x => x.Teacher).ThenInclude(t => t.User).Where(t => t.DeletedAt == null)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(request.Name))
                {
                    query = query.Where(b => b.Name.ToLower().Contains(request.Name.ToLower()));
                }

                if (request.Status != null)
                {
                    query = query.Where(b => b.Status == request.Status);
                }

                if (request.Year != null)
                {
                    query = query.Where(b => b.Year == request.Year);
                }

                if (request.Semester != null)
                {
                    query = query.Where(b => b.Semester == request.Semester);
                }

                if (request.TeacherId != null)
                {
                    query = query.Where(b => b.TeacherId == request.TeacherId);
                }

                int total = await query.CountAsync();

                if (request.PageIndex == null) request.PageIndex = 1;
                if (request.PageSize == null) request.PageSize = total;

                int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

                if (string.IsNullOrEmpty(request.OrderBy) && string.IsNullOrEmpty(request.SortBy))
                {
                    query = query.OrderByDescending(b => b.Id);
                }
                else if (string.IsNullOrEmpty(request.OrderBy))
                {
                    if (request.SortBy == SortByConstant.Asc)
                    {
                        query = query.OrderBy(b => b.Id);
                    }
                    else
                    {
                        query = query.OrderByDescending(b => b.Id);
                    }
                }
                else if (string.IsNullOrEmpty(request.SortBy))
                {
                    query = query.OrderByDescending(b => b.Id);
                }
                else
                {
                    if (request.OrderBy == OrderByConstant.Id && request.SortBy == SortByConstant.Asc)
                    {
                        query = query.OrderBy(b => b.Id);
                    }
                    else if (request.OrderBy == OrderByConstant.Id && request.SortBy == SortByConstant.Desc)
                    {
                        query = query.OrderByDescending(b => b.Id);
                    }
                }

                var items = await query
                .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
                .Take(request.PageSize.Value)
                .ToListAsync();

                var result = new PagingResult<GroupModule>(items, request.PageIndex.Value, request.PageSize.Value, request.SortBy, request.OrderBy, total, totalPages);

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<GroupModule> GetById(int id)
        {
            try
            {
                var banner = await _dbContext.GroupModules.FindAsync(id);

                if (banner == null)
                {
                    throw new ApiException("Không tìm thấy nhóm học phần hợp lệ!", HttpStatusCode.InternalServerError);
                }

                return banner;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<GroupModule> Create(CreateGroupModuleRequest request)
        {
            try
            {
                //Validate lớp trùng năm, kỳ
                //...

                var groupModule = _mapper.Map<GroupModule>(request);

                var userCurrent = await _userService.GetCurrentUserAsync();
                groupModule.CreatedAt = DateTime.Now;
                groupModule.CreatedBy = userCurrent?.Id;

                await _dbContext.GroupModules.AddAsync(groupModule);
                await _dbContext.SaveChangesAsync();

                return groupModule;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<GroupModule> Edit(EditGroupModuleRequest request)
        {
            try
            {
                //Validate lớp trùng năm, kỳ
                //...

                var groupModule = await _dbContext.GroupModules.FindAsync(request.Id);

                if (groupModule == null)
                {
                    throw new ApiException("Không tìm thấy nhóm học phần hợp lệ!", HttpStatusCode.InternalServerError);
                }

                _mapper.Map(request, groupModule);
                var userCurrent = await _userService.GetCurrentUserAsync();
                groupModule.UpdatedAt = DateTime.Now;
                groupModule.CreatedBy = userCurrent?.Id;

                await _dbContext.SaveChangesAsync();

                return groupModule;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<GroupModule> Delete(int id)
        {
            try
            {
                var groupModule = await _dbContext.GroupModules.FindAsync(id);

                if (groupModule == null)
                {
                    throw new ApiException("Không tìm thấy nhóm học phần hợp lệ!", HttpStatusCode.InternalServerError);
                }

                var userCurrent = await _userService.GetCurrentUserAsync();
                groupModule.DeletedAt = DateTime.Now;
                groupModule.CreatedBy = userCurrent?.Id;

                await _dbContext.SaveChangesAsync();

                return groupModule;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
