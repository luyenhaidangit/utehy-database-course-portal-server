using AutoMapper;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.BlogTopic;

namespace UTEHY.DatabaseCoursePortal.Api.Mappers;

public class BlogTopicMapper : Profile
{
    public BlogTopicMapper()
    {
        CreateMap<BlogTopic, RequestBlogTopicViewModel>();
        CreateMap<RequestBlogTopicViewModel, BlogTopic>();
    }
}