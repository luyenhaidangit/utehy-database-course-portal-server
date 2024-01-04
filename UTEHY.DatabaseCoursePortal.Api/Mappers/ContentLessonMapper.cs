using AutoMapper;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Lesson;
using UTEHY.DatabaseCoursePortal.Api.Models.Comment;
using UTEHY.DatabaseCoursePortal.Api.Models.LessonContent;

namespace UTEHY.DatabaseCoursePortal.Api.Mappers
{
    public class ContentLessonMapper : Profile
    {
        public ContentLessonMapper()
        {
            CreateMap<LessonContent, CreateLessonContentRequest>();
            CreateMap<CreateLessonContentRequest, LessonContent>();

        }
    }
}
