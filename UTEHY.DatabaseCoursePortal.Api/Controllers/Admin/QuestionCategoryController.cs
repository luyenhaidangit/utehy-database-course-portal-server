using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.QuestionCategory;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    public class QuestionCategory : ControllerBase
    {
        private readonly QuestionCategoryService _questionCategoryService;

        public QuestionCategory(QuestionCategoryService questionCategoryService)
        {
            _questionCategoryService = questionCategoryService;
        }

        [HttpGet("get")]
        public async Task<ApiResult<PagingResult<QuestionCategoryDto>>> Get([FromQuery] GetQuestionCategoryRequest request)
        {
            var result = await _questionCategoryService.Get(request);

            return new ApiResult<PagingResult<QuestionCategoryDto>>()
            {
                Status = true,
                Message = "Lấy thông tin danh sách loại câu hỏi thành công!",
                Data = result
            };
        }

        [HttpPost("create")]
        public async Task<ApiResult<QuestionCategoryDto>> Create([FromBody] CreateQuestionCategoryRequest request)
        {
            var result = await _questionCategoryService.Create(request);

            return new ApiResult<QuestionCategoryDto>()
            {
                Status = true,
                Message = "Tạo mới loại câu hỏi thành công!",
                Data = result
            };
        }

        [HttpPost("edit")]
        public async Task<ApiResult<QuestionCategoryDto>> Edit([FromBody] EditQuestionCategoryRequest request)
        {
            var result = await _questionCategoryService.Edit(request);

            return new ApiResult<QuestionCategoryDto>()
            {
                Status = true,
                Message = "Cập nhật loại câu hỏi thành công!",
                Data = result
            };
        }

        [HttpPost("delete")]
        public async Task<ApiResult<QuestionCategoryDto>> Delete([FromBody] DeleteRequest request)
        {
            var result = await _questionCategoryService.Delete(request);

            return new ApiResult<QuestionCategoryDto>()
            {
                Status = true,
                Message = "Xoá loại câu hỏi thành công!",
                Data = result
            };
        }
    }
}
