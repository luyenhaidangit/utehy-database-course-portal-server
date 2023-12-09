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
using UTEHY.DatabaseCoursePortal.Api.Models.Question;
using UTEHY.DatabaseCoursePortal.Api.Models.QuestionCategory;
using UTEHY.DatabaseCoursePortal.Api.Models.Teacher;
using UTEHY.DatabaseCoursePortal.Api.Models.User;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class QuestionService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly FileService _fileService;
        private readonly UserService _userService;
        private readonly UserManager<User> _userManager;
        private readonly MailService _mailService;
        private readonly TwilioService _twilioService;
        private readonly IMapper _mapper;

        public QuestionService(ApplicationDbContext dbContext, FileService fileService, IMapper mapper, UserService userService, UserManager<User> userManager, MailService mailService, TwilioService twilioService)
        {
            _dbContext = dbContext;
            _fileService = fileService;
            _mapper = mapper;
            _userService = userService;
            _userManager = userManager;
            _mailService = mailService;
            _twilioService = twilioService;
        }

        public async Task<PagingResult<QuestionDto>> Get(GetQuestionRequest request)
        {
            var query = _dbContext.Questions.AsQueryable();

            var demo = _dbContext.Questions.ToList();

            int total = await query.CountAsync();

            if (request.PageIndex == null) request.PageIndex = 1;
            if (request.PageSize == null) request.PageSize = total;

            int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

            if (string.IsNullOrEmpty(request.OrderBy) && string.IsNullOrEmpty(request.SortBy))
            {
                query = query.OrderByDescending(b => b.Id);
            }
            else if (string.IsNullOrEmpty(request.OrderBy))
            {
                if(request.SortBy == SortByConstant.Asc)
                {
                    query = query.OrderBy(b => b.Id);
                }
                else
                {
                    query = query.OrderByDescending(b => b.Id);
                }
            }
            else if (string.IsNullOrEmpty(request.SortBy))
            {
                query = query.OrderByDescending(b => b.Id);
            }
            else
            {
                if(request.OrderBy == OrderByConstant.Id && request.SortBy == SortByConstant.Asc)
                {
                    query = query.OrderBy(b => b.Id);
                }
                else if(request.OrderBy == OrderByConstant.Id && request.SortBy == SortByConstant.Desc)
                {
                    query = query.OrderByDescending(b => b.Id);
                }
            }

            var items = await query
            .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
            .Take(request.PageSize.Value)
            .ToListAsync();

            var itemsMapper = _mapper.Map<List<QuestionDto>>(items);

            var result = new PagingResult<QuestionDto>(itemsMapper, request.PageIndex.Value, request.PageSize.Value, total, totalPages);

            return result;
        }

        public async Task<QuestionDto> Create(CreateQuestionRequest request)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var question = _mapper.Map<Question>(request);

                    _dbContext.Questions.Add(question);
                    _dbContext.SaveChanges();

                    if (request.QuestionAnswers != null && request.QuestionAnswers.Any())
                    {
                        var questionAnswersEntities = request.QuestionAnswers
                            .Select(answerDto => _mapper.Map<QuestionAnswer>(answerDto))
                            .ToList();

                        foreach (var answerEntity in questionAnswersEntities)
                        {
                            answerEntity.QuestionId = question.Id;
                        }

                        _dbContext.QuestionAnswers.AddRange(questionAnswersEntities);
                        _dbContext.SaveChanges();
                    }

                    transaction.Commit();

                    var questionDto = _mapper.Map<QuestionDto>(question);

                    return questionDto;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    throw new ApiException("Có lỗi xảy ra trong quá trình xử lý!", HttpStatusCode.InternalServerError, ex);
                }
            }
        }
    }   
}
