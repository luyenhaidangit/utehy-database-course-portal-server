using AutoMapper;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Question;

namespace UTEHY.DatabaseCoursePortal.Api.Mappers
{
    public class QuestionMapper : Profile
    {
        public QuestionMapper()
        {
            CreateMap<Question, QuestionDto>();

            CreateMap<QuestionDto, Question>();

            CreateMap<CreateQuestionRequest, QuestionDto>();

            CreateMap<CreateQuestionRequest, Question>()
            .ForMember(dest => dest.Score, opt => opt.MapFrom(src => src.QuestionAnswers.Sum(a => a.Score)))
            .ForMember(dest => dest.QuestionAnswers, opt => opt.Ignore());
        }
    }
}
