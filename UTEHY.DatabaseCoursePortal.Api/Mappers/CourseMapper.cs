using AutoMapper;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Config;
using UTEHY.DatabaseCoursePortal.Api.Models.Course;

namespace UTEHY.DatabaseCoursePortal.Api.Mappers
{
    public class CourseMapper : Profile
    {
        public CourseMapper()
        {
            CreateMap<Course, CourseDto>()
            .ForMember(dest => dest.UserCourseRegistrations, opt => opt.MapFrom(src => src.UserCourses));

            CreateMap<UserCourse, UserCourseRegistration>();
        }
    }
}
