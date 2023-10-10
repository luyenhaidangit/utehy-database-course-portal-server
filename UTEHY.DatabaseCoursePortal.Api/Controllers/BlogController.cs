using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BlogService _blogService;

        public BlogController(BlogService blogService)
        {
            _blogService = blogService;
        }
        [HttpGet]
        public async Task<ApiResult<PagingResult<Blog>>> Get([FromQuery] PagingRequest request)
        {
            var result = await _blogService.Get(request);

            return new ApiResult<PagingResult<Blog>>()
            {
                Status = true,
                Message = "Danh sách blog đã được lấy thành công!",
                Data = result
            };
        }
    }
}
