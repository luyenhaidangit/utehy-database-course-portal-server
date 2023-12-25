using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.LessonContent;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonContentController : ControllerBase
    {
        private readonly LessonContentService _lessonContentService;

        public LessonContentController(LessonContentService lessonContentService)
        {
            _lessonContentService = lessonContentService;
        }

        [HttpGet("get")]
        public async Task<ApiResult<PagingResult<LessonContent>>> Get([FromQuery] GetLessonContentRequest request)
        {
            var result = await _lessonContentService.Get(request);

            return new ApiResult<PagingResult<LessonContent>>()
            {
                Status = true,
                Message = "Lấy thông tin danh sách nội dung bài giảng thành công!",
                Data = result
            };
        }
    }
}
