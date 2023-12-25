using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Lesson;
using UTEHY.DatabaseCoursePortal.Api.Models.LessonContent;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class LessonContentService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public LessonContentService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<PagingResult<LessonContent>> Get(GetLessonContentRequest request)
        {
            var query = _dbContext.LessonContents.AsQueryable();

            //if (!string.IsNullOrEmpty(request.Title))
            //{
            //    query = query.Where(b => b.Title.ToLower().Contains(request.Title.ToLower()));
            //}

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
    }
}
