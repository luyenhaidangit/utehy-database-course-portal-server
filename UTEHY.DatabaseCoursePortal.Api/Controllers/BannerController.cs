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

            if(result == null)
            {
                return new ApiResult<PageResult<Banner>>()
                {
                    Status = false,
                    Message = "Có lỗi xảy ra trong quá trình lấy dữ liệu!",
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

            if (result == null)
            {
                return new ApiResult<Banner>()
                {
                    Status = false,
                    Message = "Có lỗi xảy ra trong quá trình tạo banner!",
                    Data = null
                };
            }

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

            if (result == null)
            {
                return new ApiResult<Banner>()
                {
                    Status = false,
                    Message = "Có lỗi xảy ra trong quá trình sửa banner!",
                    Data = null
                };
            }

            return new ApiResult<Banner>()
            {
                Status = true,
                Message = "Cập nhật banner thành công!",
                Data = result
            };
        }

        [HttpPost("delete")]
        public async Task<ApiResult<Banner>> Delete([FromBody] int id)
        {
            var result = await _bannerService.Delete(id);

            if (result == null)
            {
                return new ApiResult<Banner>()
                {
                    Status = false,
                    Message = "Có lỗi xảy ra trong quá trình xoá banner!",
                    Data = null
                };
            }

            return new ApiResult<Banner>()
            {
                Status = true,
                Message = "Xoá banner thành công!",
                Data = result
            };
        }
    }
}
