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
            var query = _dbContext.Questions.Where(x => x.DeletedAt == null).AsQueryable();

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

        public async Task<Teacher> Create(CreateTeacherRequest request)
        {
            if (string.IsNullOrEmpty(request.Email) && request.VerificationType == VerificationType.Email)
            {
                throw new ApiException("Dữ liệu trường email không được để trống khi chọn kiểu xác thực là email!", HttpStatusCode.BadRequest);
            }

            if (string.IsNullOrEmpty(request.Phone) && request.VerificationType == VerificationType.Phone)
            {
                throw new ApiException("Dữ liệu trường số điện thoại không được để trống khi chọn kiểu xác thực là số điện thoại!", HttpStatusCode.BadRequest);
            }

            var createUserRequest = _mapper.Map<CreateUserRequest>(request);
            createUserRequest.Role = Constants.Role.Teacher;

            var user = await _userService.Create(createUserRequest);

            var newTeacher = new Teacher()
            {
                UserId = user.Id,
                TeacherId = request.TeacherId,
            };

            await _dbContext.Teachers.AddAsync(newTeacher);
            await _dbContext.SaveChangesAsync();

            if (request.VerificationType == VerificationType.Email)
            {
                var otpCode = await _userManager.GenerateChangePhoneNumberTokenAsync(user, user.PhoneNumber);

                var mail = new SendMailRequest
                {
                    ToEmail = request.Email,
                    Subject = "Mã xác nhận tài khoản giáo viên UTEHY Database Course Portal",
                    Body = "Mã xác thực đăng nhập UTEHY DatabaseCourse của bạn là " + otpCode,
                };

                await _mailService.Send(mail);
            }
            else
            {
                var otpCode = await _userManager.GenerateChangePhoneNumberTokenAsync(user, user.PhoneNumber);

                string message = "Mã xác thực tài khoản giáo viên UTEHY Database Course của bạn là " + otpCode;
                await _twilioService.SendMessage(message, user.PhoneNumber);
            }

            return newTeacher;
        }
    }   
}
