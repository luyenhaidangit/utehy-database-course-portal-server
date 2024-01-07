using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.GroupModule;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers.Admin
{
    [Route("api/admin/group-module")]
    [ApiController]
    public class GroupModuleController : ControllerBase
    {
        private readonly GroupModuleService _groupModuleService;

        public GroupModuleController(GroupModuleService groupModuleService)
        {
            _groupModuleService = groupModuleService;
        }

        [HttpGet("get")]
        public async Task<ApiResult<PagingResult<GroupModule>>> Get([FromQuery] GetGroupModuleRequest request)
        {
            var result = await _groupModuleService.Get(request);

            return new ApiResult<PagingResult<GroupModule>>()
            {
                Status = true,
                Message = "Lấy thông tin danh sách nhóm học phần thành công!",
                Data = result
            };
        }

        [HttpPost("create")]
        public async Task<ApiResult<GroupModule>> Create([FromBody] CreateGroupModuleRequest request)
        {
            var result = await _groupModuleService.Create(request);

            return new ApiResult<GroupModule>()
            {
                Status = true,
                Message = "Tạo mới nhóm học phần thành công!",
                Data = result
            };
        }

        [HttpPost("edit")]
        public async Task<ApiResult<GroupModule>> Edit([FromBody] EditGroupModuleRequest request)
        {
            var result = await _groupModuleService.Edit(request);

            return new ApiResult<GroupModule>()
            {
                Status = true,
                Message = "Cập nhật nhóm học phần thành công!",
                Data = result
            };
        }

        [HttpPost("delete")]
        public async Task<ApiResult<GroupModule>> Delete([FromBody] int id)
        {
            var result = await _groupModuleService.Delete(id);

            return new ApiResult<GroupModule>()
            {
                Status = true,
                Message = "Xoá nhóm học phần thành công!",
                Data = result
            };
        }
    }
}
