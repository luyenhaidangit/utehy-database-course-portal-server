using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Exam;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.QuestionCategory;
using UTEHY.DatabaseCoursePortal.Api.Models.Teacher;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers.Admin
{
    [Route("api/admin/exam")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly ExamService _examService;

        public ExamController(ExamService examService)
        {
            _examService = examService;
        }

        [HttpGet("get")]
        public async Task<ApiResult<PagingResult<Exam>>> Get([FromQuery] GetExamRequest request)
        {
            var result = await _examService.Get(request);

            return new ApiResult<PagingResult<Exam>>()
            {
                Status = true,
                Message = "Lấy thông tin danh sách đề thi thành công!",
                Data = result
            };
        }

        //[HttpGet("get-by-id")]
        //public async Task<ApiResult<ExamDto>> GetById([FromQuery] int id)
        //{
        //    var result = await _ExamService.GetById(id);

        //    return new ApiResult<ExamDto>()
        //    {
        //        Status = true,
        //        Message = "Danh sách Exam đã được lấy thành công!",
        //        Data = result
        //    };
        //}

        //[HttpPost("create")]
        //public async Task<ApiResult<Exam>> Create([FromForm] CreateExamRequest request)
        //{
        //    var result = await _ExamService.Create(request);

        //    return new ApiResult<Exam>()
        //    {
        //        Status = true,
        //        Message = "Tạo đề thi thành công",
        //        Data = result
        //    };
        //}
    }
}
