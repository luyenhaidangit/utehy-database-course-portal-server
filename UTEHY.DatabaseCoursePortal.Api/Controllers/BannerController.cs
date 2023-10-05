using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Banner;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        private readonly BannerService _bannerService;

        public BannerController(BannerService bannerService)
        {
            _bannerService = bannerService;
        }

        [HttpGet("get")]
        public async Task<ApiResult<PageResult<Banner>>> Get([FromQuery] GetBannerRequest request)
        {
            var result = await _bannerService.Get(request);

            if (result?.Items?.Count == 0)
            {
                return new ApiResult<PageResult<Banner>>()
                {
                    Status = true,
                    Message = "Không tìm thấy banner phù hợp!",
                    Data = null
                };
            }

            return new ApiResult<PageResult<Banner>>()
            {
                Status = true,
                Message = "Danh sách banner đã được lấy thành công!",
                Data = result
            };
        }

        [HttpPost("create")]
        public async Task<ApiResult<Banner>> Create([FromForm] CreateBannerRequest request)
        {
            var result = await _bannerService.Create(request);

            return new ApiResult<Banner>()
            {
                Status = true,
                Message = "Tạo mới banner thành công!",
                Data = result
            };
        }

        [HttpPost("edit")]
        public async Task<ApiResult<Banner>> Edit([FromForm] EditBannerRequest request)
        {
            var result = await _bannerService.Edit(request);

            return new ApiResult<Banner>()
            {
                Status = true,
                Message = "Cập nhật banner thành công!",
                Data = result
            };
        }
    }
}
