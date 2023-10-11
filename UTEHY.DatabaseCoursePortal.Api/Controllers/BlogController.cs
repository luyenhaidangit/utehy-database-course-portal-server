using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Blog;
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
        [HttpGet("get")]
        public async Task<ApiResult<PagingResult<Blog>>> Get([FromQuery] PagingRequest request)
        {
            var result = await _blogService.Get(request);

            return new ApiResult<PagingResult<Blog>>()
            {
                Status = true,
                Message = "Danh sách bài viết đã được lấy thành công!",
                Data = result
            };
        }
        [HttpPost("post")]
        public async Task<ApiResult<Blog>> Create([FromForm] CreateBlogRequest request)
        {
            var result = await _blogService.Create(request);

            return new ApiResult<Blog>()
            {
                Status = true,
                Message = "Bài viết đã được thêm thành công!",
                Data = result
            };
        }
        [HttpPut("put")]
        public async Task<ApiResult<Blog>> Edit([FromForm] EditBlogRequest request)
        {
            var result = await _blogService.Edit(request);

            return new ApiResult<Blog>()
            {
                Status = true,
                Message = "Bài viết đã được sửa thành công!",
                Data = result
            };
        }
        [HttpDelete("delete")]
        public async Task<ApiResult<Blog>> Delete([FromBody] int id)
        {
            var result = await _blogService.Delete(id);

            return new ApiResult<Blog>()
            {
                Status = true,
                Message = "Xoá bài viết thành công!",
                Data = result
            };
        }
    }
}
