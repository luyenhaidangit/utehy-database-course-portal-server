using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Banner;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Teacher;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class TeacherService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly FileService _fileService;
        private readonly IMapper _mapper;

        public TeacherService(ApplicationDbContext dbContext, FileService fileService, IMapper mapper)
        {
            _dbContext = dbContext;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<PagingResult<TeacherDto>> Get(GetTeacherRequest request)
        {
            var query = _dbContext.Teachers.Include(x => x.User).AsQueryable();

            if (!string.IsNullOrEmpty(request.NameOrEmail))
            {
                string search = request.NameOrEmail.ToLower();
                query = query.Where(b => b.User.UserName.ToLower().Contains(request.NameOrEmail.ToLower()) || b.User.Email.ToLower().Contains(request.NameOrEmail.ToLower()));
            }

            if (!string.IsNullOrEmpty(request.PhoneNumber))
            {
                query = query.Where(b => b.User.PhoneNumber.ToLower().Contains(request.PhoneNumber.ToLower()));
            }

            if (request.Status != null)
            {
                query = query.Where(b => b.User.Status == request.Status);
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
                if(request.SortBy == SortByConstant.Asc)
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
                if(request.OrderBy == OrderByConstant.Id && request.SortBy == SortByConstant.Asc)
                {
                    query = query.OrderBy(b => b.Id);
                }
                else if(request.OrderBy == OrderByConstant.Id && request.SortBy == SortByConstant.Desc)
                {
                    query = query.OrderByDescending(b => b.Id);
                }
            }

            var items = await query
            .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
            .Take(request.PageSize.Value)
            .ToListAsync();

            var itemsMapper = _mapper.Map<List<TeacherDto>>(items);

            var result = new PagingResult<TeacherDto>(itemsMapper, request.PageIndex.Value, request.PageSize.Value, total, totalPages);

            return result;
        }

        public async Task<Banner> Create(CreateBannerRequest request)
        {
            if (request.ImageFile?.Length > 0)
            {
                request.Image = await _fileService.UploadFileAsync(request.ImageFile, PathFolder.Banner);
            }

            var banner = _mapper.Map<Banner>(request);
            banner.CreatedAt = DateTime.Now;

            await _dbContext.Banners.AddAsync(banner);
            await _dbContext.SaveChangesAsync();

            return banner;
        }

        public async Task<Banner> Edit(EditBannerRequest request)
        {
            var banner = await _dbContext.Banners.FindAsync(request.Id);

            if (banner == null)
            {
                throw new Exception("Banner không tồn tại!");
            }

            if (request.ImageFile?.Length > 0)
            {
                request.Image = await _fileService.UploadFileAsync(request.ImageFile, PathFolder.Banner);
                await _fileService.DeleteFileAsync(banner.Image);
            }
            else
            {
                request.Image = banner.Image;
            }

            _mapper.Map(request, banner);
            banner.UpdatedAt = DateTime.Now;

            await _dbContext.SaveChangesAsync();

            return banner;
        }

        public async Task<Banner> Delete(int id)
        {
            var banner = await _dbContext.Banners.FindAsync(id);

            if (banner == null)
            {
                throw new Exception("Banner không tồn tại!");
            }

            banner.DeletedAt = DateTime.Now;

            _dbContext.Banners.Remove(banner);

            await _fileService.DeleteFileAsync(banner.Image);

            await _dbContext.SaveChangesAsync();

            return banner;
        }

        public async Task<List<Banner>> DeleteMultiple(List<int> ids)
        {
            var banners = await _dbContext.Banners.Where(x => ids.Contains(x.Id)).ToListAsync();

            var invalidIds = ids.Except(banners.Select(b => b.Id)).ToList();

            if (invalidIds.Any())
            {
                throw new Exception($"Danh sách Ids banner không tồn tại: {string.Join(", ", invalidIds)}");
            }

            _dbContext.Banners.RemoveRange(banners);

            var fileUrls = banners.Select(banner => banner.Image).ToList();

            await _fileService.DeleteFilesAsync(fileUrls);

            await _dbContext.SaveChangesAsync();

            return banners;
        }
    }
}
