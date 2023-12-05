using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Question;
using UTEHY.DatabaseCoursePortal.Api.Models.Teacher;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers.Admin
{
    [Route("api/admin/question")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly QuestionService _questionService;

        public QuestionController(QuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet("get")]
        public async Task<ApiResult<PagingResult<QuestionDto>>> Get([FromQuery] GetQuestionRequest request)
        {
            var result = await _questionService.Get(request);

            return new ApiResult<PagingResult<QuestionDto>>()
            {
                Status = true,
                Message = "Lấy thông tin danh sách câu hỏi thành công!",
                Data = result
            };
        }
    }
}
