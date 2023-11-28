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

        [HttpPost("create")]
        public async Task<ApiResult<Teacher>> Create([FromBody] CreateTeacherRequest request)
        {
            var result = await _teacherService.Create(request);

            return new ApiResult<Teacher>()
            {
                Status = true,
                Message = "Tạo mới giáo viên thành công!",
                Data = result
            };
        }

        [HttpGet("get-by-id")]
        public async Task<ApiResult<TeacherDto>> GetById([FromQuery]int id)
        {
            var result = await _teacherService.GetById(id);

            return new ApiResult<TeacherDto>()
            {
                Status = true,
                Message = "Lấy thông tin giáo viên thành công!",
                Data = result
            };
        }

        [HttpPost("edit")]
        public async Task<ApiResult<TeacherDto>> Edit([FromBody] EditTeacherRequest request)
        {
            var result = await _teacherService.Edit(request);

            return new ApiResult<TeacherDto>()
            {
                Status = true,
                Message = "Cập nhật giáo viên thành công!",
                Data = result
            };
        }
    }
}
