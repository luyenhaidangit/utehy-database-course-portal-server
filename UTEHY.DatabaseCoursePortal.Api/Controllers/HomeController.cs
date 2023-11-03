using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Banner;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Home;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers
{
    [Route("api/[controller]")]
    public class HomeController
    {
        private readonly HomeService _homeService;

        public HomeController(HomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet("get-banners")]
        public async Task<ApiResult<List<BannerDto>>> GetBanners(Models.Home.GetBannerRequest request)
        {
            var result = await _homeService.GetBanners(request);

            return new ApiResult<List<BannerDto>>()
            {
                Status = true,
                Message = "Danh sách banner đã được lấy thành công!",
                Data = result
            };
        }

        [HttpGet("get-courses")]
        public async Task<ApiResult<List<Course>>> GetCourses()
        {
            var result = await _homeService.GetCourses();

            return new ApiResult<List<Course>>()
            {
                Status = true,
                Message = "Danh sách khoá học thành công!",
                Data = result
            };
        }
    }
}
