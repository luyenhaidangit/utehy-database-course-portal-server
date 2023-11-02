using UTEHY.DatabaseCoursePortal.Api.Data.Entities;

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Seeders
{
    public class CourseSeeder
    {
        public static List<Course> Data()
        {
            var course = new List<Course>()
            {
                new Course
                {
                    Id = 1,
                    Title = "SQL căn bản",
                    ImageUrl = "/Course/Course.png",
                },
                new Course
                {
                    Id = 2,
                    Title = "SQL Advanced Queries",
                    ImageUrl = "/Course/Course.png",
                },
                new Course
                {
                    Id = 3,
                    Title = "Bảo mật Cơ sở dữ liệu",
                    ImageUrl = "/Course/Course.png",
                },
                new Course
                {
                    Id = 4,
                    Title = "Thiết kế Cơ sở dữ liệu",
                    ImageUrl = "/Course/Course.png",
                },
            };

            return course;
        }
    }
}
