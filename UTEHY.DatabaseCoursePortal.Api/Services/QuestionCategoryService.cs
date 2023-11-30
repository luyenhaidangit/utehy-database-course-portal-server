using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using Twilio.Http;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Enums;
using UTEHY.DatabaseCoursePortal.Api.Exceptions;
using UTEHY.DatabaseCoursePortal.Api.Models.Banner;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Mail;
using UTEHY.DatabaseCoursePortal.Api.Models.QuestionCategory;
using UTEHY.DatabaseCoursePortal.Api.Models.Teacher;
using UTEHY.DatabaseCoursePortal.Api.Models.User;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class QuestionCategoryService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public QuestionCategoryService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<PagingResult<QuestionCategoryDto>> Get(GetQuestionCategoryRequest request)
        {
            var query = _dbContext.QuestionCategories.Where(x => x.DeletedAt == null).AsQueryable();

            if (!string.IsNullOrEmpty(request.Name))
            {
                query = query.Where(b => b.Name.ToLower().Contains(request.Name.ToLower()));
            }

            int total = await query.CountAsync();

            if (request.PageIndex == null) request.PageIndex = 1;
            if (request.PageSize == null) request.PageSize = total;

            int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

            if (string.IsNullOrEmpty(request.OrderBy) && string.IsNullOrEmpty(request.SortBy))
            {
                query = query.OrderByDescending(b => b.Priority);
            }
            else if (string.IsNullOrEmpty(request.OrderBy))
            {
                if (request.SortBy == SortByConstant.Asc)
                {
                    query = query.OrderBy(b => b.Priority);
                }
                else
                {
                    query = query.OrderByDescending(b => b.Priority);
                }
            }
            else if (string.IsNullOrEmpty(request.SortBy))
            {
                query = query.OrderByDescending(b => b.Id);
            }
            else
            {
                if (request.OrderBy == OrderByConstant.Priority && request.SortBy == SortByConstant.Asc)
                {
                    query = query.OrderBy(b => b.Priority);
                }
                else if (request.OrderBy == OrderByConstant.Priority && request.SortBy == SortByConstant.Desc)
                {
                    query = query.OrderByDescending(b => b.Priority);
                }
            }

            var items = await query
            .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
            .Take(request.PageSize.Value)
            .ToListAsync();

            var itemsMapper = _mapper.Map<List<QuestionCategoryDto>>(items);

            var result = new PagingResult<QuestionCategoryDto>(itemsMapper, request.PageIndex.Value, request.PageSize.Value, total, totalPages);

            return result;
        }

        public async Task<QuestionCategoryDto> Create(CreateQuestionCategoryRequest request)
        {
            var questionCategory = new QuestionCategory
            {
                Name = request.Name,
                Description = request.Description,
                ParentQuestionCategoryId = request.ParentQuestionCategoryId,
                Priority = request.Priority
            };

            await _dbContext.QuestionCategories.AddAsync(questionCategory);
            await _dbContext.SaveChangesAsync();

            var questionCategoryDto = _mapper.Map<QuestionCategoryDto>(questionCategory);
            return questionCategoryDto;
        }

        public async Task<QuestionCategoryDto> Edit(EditQuestionCategoryRequest request)
        {
            var questionCategory = await _dbContext.QuestionCategories.FindAsync(request.Id);

            if (questionCategory == null)
            {
                throw new Exception("Danh mục câu hỏi không tồn tại!");
            }

            _mapper.Map(request, questionCategory);

            await _dbContext.SaveChangesAsync();

            var questionCategoryDto = _mapper.Map<QuestionCategoryDto>(questionCategory);
            return questionCategoryDto;
        }

        public async Task<QuestionCategoryDto> Delete(DeleteRequest request)
        {
            var query = _dbContext.QuestionCategories.Include(x => x.Questions).Where(x => x.DeletedAt == null).AsQueryable();

            var questionCategory = await _dbContext.QuestionCategories.FindAsync(request.Id);

            if (questionCategory == null)
            {
                throw new ApiException("Câu hỏi không tồn tại!", HttpStatusCode.BadRequest);
            }

            questionCategory.DeletedAt = DateTime.Now;

            await _dbContext.SaveChangesAsync();

            var questionCategoryDto = _mapper.Map<QuestionCategoryDto>(questionCategory);

            return questionCategoryDto;
        }
    }
}
