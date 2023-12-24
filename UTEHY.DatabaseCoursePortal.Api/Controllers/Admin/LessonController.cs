using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Lesson;
using UTEHY.DatabaseCoursePortal.Api.Models.QuestionCategory;
using UTEHY.DatabaseCoursePortal.Api.Models.Teacher;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers.Admin
{
    [Route("api/admin/lesson")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly LessonService _lessonService;

        public LessonController(LessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet("get")]
        public async Task<ApiResult<PagingResult<Lesson>>> Get([FromQuery] GetLessonRequest request)
        {
            var result = await _lessonService.Get(request);

            return new ApiResult<PagingResult<Lesson>>()
            {
                Status = true,
                Message = "Lấy thông tin danh sách bài giảng thành công!",
                Data = result
            };
        }
    }
}
