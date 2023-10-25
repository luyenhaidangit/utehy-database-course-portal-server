using Microsoft.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class CourseService
    {
        ApplicationDbContext _dbContext;
        public CourseService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Course>> GetCourses()
        {
            var listCourses = await _dbContext.Courses.ToListAsync();

            return listCourses;
        }
        public async Task<Course> GetCourseById(int id)
        {
            var course = await _dbContext.Courses.FindAsync(id);

            return course;
        }
        public async Task<List<VideoCourse>> GetListVideoCourseByIdCourse(int courseId)
        {
            var listVideoCourse = await _dbContext.VideoCourses.Where(x => x.CourseId == courseId).ToListAsync();
            return listVideoCourse;
        }

    }
}
