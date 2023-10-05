using AutoMapper;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Banner;

namespace UTEHY.DatabaseCoursePortal.Api.Mappers
{
    public class BannerMapper : Profile
    {
        public BannerMapper()
        {
            CreateMap<Banner, CreateBannerRequest>();
            CreateMap<CreateBannerRequest, Banner>();
            CreateMap<EditBannerRequest, Banner>();
            CreateMap<Banner, EditBannerRequest>();
        }
    }
}
