using AutoMapper;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Course;
using UTEHY.DatabaseCoursePortal.Api.Models.Post;
using UTEHY.DatabaseCoursePortal.Api.Models.User;

namespace UTEHY.DatabaseCoursePortal.Api.Mappers
{
    public class PostMapper : Profile
    {
        public PostMapper()
        {
            CreateMap<Post, PostHomeDto>().ForMember(dest => dest.User, opt => opt.MapFrom(src => new UserProfileDto { Name = src.User.Name })); ;
        }
    }
}
