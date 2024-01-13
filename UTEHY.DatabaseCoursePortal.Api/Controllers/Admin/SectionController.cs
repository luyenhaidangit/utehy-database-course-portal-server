using DocumentFormat.OpenXml.Office2010.PowerPoint;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Section;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly SectionService _sectionService;

        public SectionController(SectionService sectionService)
        {
            _sectionService = sectionService;
        }

        [HttpGet("get")]
        public async Task<ApiResult<PagingResult<Data.Entities.Section>>> Get([FromQuery] GetSectionRequest request)
        {
            var result = await _sectionService.Get(request);

            return new ApiResult<PagingResult<Data.Entities.Section>>()
            {
                Status = true,
                Message = "Danh sách section đã được lấy thành công!",
                Data = result
            };
        }

        [HttpPost("create")]
        public async Task<ApiResult<Data.Entities.Section>> Create([FromBody] CreateSectionRequest request)
        {
            var result = await _sectionService.Create(request);

            return new ApiResult<Data.Entities.Section>()
            {
                Status = true,
                Message = "Danh sách banner đã được lấy thành công!",
                Data = result
            };
        }

        [HttpPost("edit")]
        public async Task<ApiResult<Data.Entities.Section>> Edit([FromBody] EditSectionRequest request)
        {
            var result = await _sectionService.Edit(request);

            return new ApiResult<Data.Entities.Section>()
            {
                Status = true,
                Message = "Danh sách banner đã được lấy thành công!",
                Data = result
            };
        }

        [HttpPost("delete")]
        public async Task<ApiResult<Data.Entities.Section>> Delete([FromBody] EntityIdentityRequest<int> request)
        {
            var result = await _sectionService.Delete(request.Id);

            return new ApiResult<Data.Entities.Section>()
            {
                Status = true,
                Message = "Danh sách banner đã được lấy thành công!",
                Data = result
            };
        }

        [HttpPost("delete-multiple")]
        public async Task<ApiResult<List<Data.Entities.Section>>> DeleteMultiple([FromBody] ListEntityIdentityRequest<int?> request)
        {
            var result = await _sectionService.DeleteMultiple(request.Ids);

            return new ApiResult<List<Data.Entities.Section>>()
            {
                Status = true,
                Message = "Danh sách banner đã được lấy thành công!",
                Data = result
            };
        }
    }
}
