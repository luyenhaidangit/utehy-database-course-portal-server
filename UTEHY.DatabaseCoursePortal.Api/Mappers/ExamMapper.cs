using AutoMapper;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Lesson;
using UTEHY.DatabaseCoursePortal.Api.Models.Comment;
using UTEHY.DatabaseCoursePortal.Api.Models.Exam;

namespace UTEHY.DatabaseCoursePortal.Api.Mappers
{
    public class ExamMapper : Profile
    {
        public ExamMapper()
        {
            CreateMap<Exam, CreateExamRequest>();
            CreateMap<CreateExamRequest, Exam>();
            CreateMap<Exam, GetExamRequest>();
            CreateMap<GetExamRequest, Exam>();
        
        }
    }
}
