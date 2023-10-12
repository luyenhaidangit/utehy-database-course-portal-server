using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Blog;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class BlogService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly FileService _fileService;
        private readonly IMapper _mapper;

        public BlogService(ApplicationDbContext dbContext, FileService fileService, IMapper mapper)
        {
            _dbContext = dbContext;
            _fileService = fileService;
            _mapper = mapper;
        }
        public async Task<PagingResult<Blog>> Get(PagingRequest request)
        {
            var query = _dbContext.Blogs.AsQueryable();

            int total = await query.CountAsync();

            if (request.PageIndex == null) request.PageIndex = 1;
            if (request.PageSize == null) request.PageSize = total;

            int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

            var items = await query
            .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
            .Take(request.PageSize.Value)
            .ToListAsync();

            var result = new PagingResult<Blog>(items, request.PageIndex.Value, request.PageSize.Value, total, totalPages);

            return result;
        }

        public async Task<Blog> Create(CreateBlogRequest request)
        {
            if (request.Image?.Length > 0)
            {
                request.ImageUrl = await _fileService.UploadFileAsync(request.Image, PathFolder.Banner);
            }

            var blog = _mapper.Map<Blog>(request);

            _dbContext.AddAsync(blog);
            _dbContext.SaveChanges();

            return blog;
        }

        public async Task<Blog> Edit(EditBlogRequest request)
        {
            var blog = await _dbContext.Blogs.FindAsync(request.Id);
            if (blog == null)
            {
                throw new Exception("Banner không tồn tại!");
            }

            if (request.Image?.Length > 0)
            {
                request.ImageUrl = await _fileService.UploadFileAsync(request.Image, PathFolder.Blog);
                await _fileService.DeleteFileAsync(blog.ImageUrl);
            }
            else
            {
                request.ImageUrl = blog.ImageUrl;
            }

            _mapper.Map(request, blog);

            await _dbContext.SaveChangesAsync();

            return blog;
        }

        public async Task<Blog> Delete(int id)
        {
            var blog = await _dbContext.Blogs.FindAsync(id);

            _dbContext.Blogs.Remove(blog);

            await _dbContext.SaveChangesAsync();

            return blog;
        }
    }
}
