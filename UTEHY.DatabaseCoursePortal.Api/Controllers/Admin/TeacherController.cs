using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Attributes;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Teacher;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly TeacherService _teacherService;

        public TeacherController(TeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("get")]
        public async Task<ApiResult<PagingResult<TeacherDto>>> Get([FromQuery] GetTeacherRequest request)
        {
            var result = await _teacherService.Get(request);

            return new ApiResult<PagingResult<TeacherDto>>()
            {
                Status = true,
                Message = "Lấy thông tin danh sách giáo viên thành công!",
                Data = result
            };
        }
    }
}
