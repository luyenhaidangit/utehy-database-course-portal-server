using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Twilio.Exceptions;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Lesson;
using UTEHY.DatabaseCoursePortal.Api.Models.QuestionCategory;
using UTEHY.DatabaseCoursePortal.Api.Exceptions;


namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class LessonService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public LessonService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<PagingResult<Lesson>> Get(GetLessonRequest request)
        {
            var query = _dbContext.Lessons.AsQueryable();

            if (!string.IsNullOrEmpty(request.Title))
            {
                query = query.Where(b => b.Title.ToLower().Contains(request.Title.ToLower()));
            }
            if (!string.IsNullOrEmpty(request.Content))
            {
                query = query.Where(b => b.Content.ToLower().Contains(request.Content.ToLower()));
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

            var result = new PagingResult<Lesson>(items, request.PageIndex.Value, request.PageSize.Value, total, totalPages);

            return result;
        }

        public async Task<Lesson> GetById(int id)
        {
            try
            {
                var lesson = await _dbContext.Lessons.FindAsync(id);

                if (lesson == null)
                {
                    throw new Exceptions.ApiException("Không tìm thấy lesson hợp lệ!", HttpStatusCode.InternalServerError);
                }

                return lesson;
            }
            catch (Exception ex)
            {
                throw new Exceptions.ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }
        public async Task<Lesson> Create(CreateLessonRequest request)
        {
        

            var lesson = _mapper.Map<Lesson>(request);
            lesson.CreatedAt = DateTime.Now;

            await _dbContext.Lessons.AddAsync(lesson);
            await _dbContext.SaveChangesAsync();

            return lesson;
        }

        public async Task<Lesson> Edit(EditLessonRequest request)
        {
            var lesson = await _dbContext.Lessons.FindAsync(request.Id);

            if (lesson == null)
            {
                throw new Exception("Lessson không tồn tại!");
            }


            _mapper.Map(request, lesson);
            lesson.UpdatedAt = DateTime.Now;

            await _dbContext.SaveChangesAsync();

            return lesson;
        }

        public async Task<Lesson> Delete(int id)
        {
            var lesson = await _dbContext.Lessons.FindAsync(id);

            if (lesson == null)
            {
                throw new Exception("Lesson không tồn tại!");
            }

            lesson.DeletedAt = DateTime.Now;

            _dbContext.Lessons.Remove(lesson);


            await _dbContext.SaveChangesAsync();

            return lesson;
        }

        public async Task<List<Lesson>> DeleteMultiple(List<int> ids)
        {
            var lessons = await _dbContext.Lessons.Where(x => ids.Contains(x.Id)).ToListAsync();

            var invalidIds = ids.Except(lessons.Select(b => b.Id)).ToList();

            if (invalidIds.Any())
            {
                throw new Exception($"Danh sách Ids lesson không tồn tại: {string.Join(", ", invalidIds)}");
            }

            _dbContext.Lessons.RemoveRange(lessons);

            await _dbContext.SaveChangesAsync();

            return lessons;
        }
    }
}
