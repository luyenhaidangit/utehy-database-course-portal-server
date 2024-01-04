using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Banner;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Lesson;
using UTEHY.DatabaseCoursePortal.Api.Models.LessonContent;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class LessonContentService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly FileService _fileService;

        public LessonContentService(ApplicationDbContext dbContext, IMapper mapper, FileService fileService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _fileService = fileService;
        }

        public async Task<PagingResult<LessonContent>> Get(GetLessonContentRequest request)
        {
            var query = _dbContext.LessonContents.AsQueryable();

            if (request.LessonId.ToString()!=null && !string.IsNullOrEmpty(request.LessonId.ToString()))
            {
                query = query.Where(b => b.LessonId == request.LessonId);
            }

            if (!string.IsNullOrEmpty(request.Title))
            {
                query = query.Where(b => b.Title.ToLower().Contains(request.Title.ToLower()));
            }
            if (!string.IsNullOrEmpty(request.Description))
            {
                query = query.Where(b => b.Description.ToLower().Contains(request.Description.ToLower()));
            }
            int total = await query.CountAsync();

            if (request.PageIndex == null) request.PageIndex = 1;
            if (request.PageSize == null) request.PageSize = total;

            int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

            var items = await query
            .OrderByDescending(b => b.Id)
            .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
            .Take(request.PageSize.Value)
            .ToListAsync();

            var result = new PagingResult<LessonContent>(items, request.PageIndex.Value, request.PageSize.Value, total, totalPages);

            return result;
        }



        public async Task<LessonContent> Create(CreateLessonContentRequest request)
        {
           
            var lessonContent = _mapper.Map<LessonContent>(request);
            lessonContent.CreatedAt = DateTime.Now;

            await _dbContext.LessonContents.AddAsync(lessonContent);
            await _dbContext.SaveChangesAsync();

            return lessonContent;
        }
    }
}
