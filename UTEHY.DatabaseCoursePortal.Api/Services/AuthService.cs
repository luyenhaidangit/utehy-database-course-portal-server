using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Exceptions;
using UTEHY.DatabaseCoursePortal.Api.Models.Account;
using UTEHY.DatabaseCoursePortal.Api.Models.Mail;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class AuthService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _config;
        private readonly UserService _userService;
        private readonly UserManager<User> _userManager;
        private readonly TwilioService _twilioService;
        private readonly MailService _mailService;

        public AuthService(ApplicationDbContext dbContext, IConfiguration config, UserService userService, UserManager<User> userManager,TwilioService twilioService, MailService mailService)
        {
            _dbContext = dbContext;
            _config = config;
            _userService = userService;
            _userManager = userManager;
            _twilioService = twilioService;
            _mailService = mailService;
        }

        public async Task<string> CreateToken(User user)
        {
            var key = _config["Jwt:Key"];

            var permissions = await _userService.GetPermissionAsync(user);

            var claims = new List<Claim>
            {
                new Claim(ClaimType.UserName, user.UserName),
                new Claim(ClaimType.Email, user.Email),
            };

            foreach (var permission in permissions)
            {
                claims.Add(new Claim(ClaimType.Permission, permission));
            }

            var subject = new ClaimsIdentity(claims);
            var creds = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)), SecurityAlgorithms.HmacSha256Signature);
            var expires = DateTime.UtcNow.AddDays(30);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = subject,
                Expires = expires,
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);

            return token;
        }

        public async Task<bool> SendOtpLoginPhone(SendOtpLoginPhoneRequest request)
        {
            var user = _dbContext.Users.FirstOrDefault(user => user.PhoneNumber == request.Phone && user.PhoneNumberConfirmed == true);

            //Create user
            if (user == null)
            {
                user = new User
                {
                    PhoneNumber = request.Phone,
                    PhoneNumberConfirmed = true,
                    Name = request.Name,
                };

                await _userManager.CreateAsync(user);
                await _userManager.AddToRoleAsync(user, "Student");
            }

            //Verify login
            var otpCode = await _userManager.GenerateChangePhoneNumberTokenAsync(user, user.PhoneNumber);

            //Send otp
            string message = "Mã xác thực đăng nhập UTEHY DatabaseCourse của bạn là " + otpCode;
            await _twilioService.SendMessage(message, user.PhoneNumber);

            return true;
        }

        public async Task<string> VerifyOtpLoginPhone(VerifyOtpLoginPhoneRequest request)
        {
            var user = _dbContext.Users.FirstOrDefault(user => user.PhoneNumber == request.Phone && user.PhoneNumberConfirmed == true);

            //Create user
            if (user == null)
            {
                throw new ApiException("Số điện thoại không tồn tại trong hệ thống!",HttpStatusCode.BadRequest);
            }
            else
            {
                if (request.Name != null)
                {
                    user.Name = request.Name;
                }
                await _userManager.UpdateAsync(user);
            }

            var isOtpValid = await _userManager.VerifyChangePhoneNumberTokenAsync(user, request.Otp, user.PhoneNumber);

            if (!isOtpValid)
            {
                throw new ApiException("Mã OTP không hợp lệ!",HttpStatusCode.BadRequest);
            }

            //Create token
            var token = await CreateToken(user);

            if (token == null)
            {
                throw new ApiException("Tạo mã token thất bại!", HttpStatusCode.BadRequest);
            }

            return token;
        }

        public async Task<bool> SendOtpLoginEmail(SendOtpLoginEmailRequest request)
        {
            var user = _dbContext.Users.FirstOrDefault(user => user.Email == request.Email && user.EmailConfirmed == true);

            //Create user
            if (user == null)
            {
                user = new User
                {
                    Email = request.Email,
                    EmailConfirmed = true,
                    Name = request.Name,
                };

                await _userManager.CreateAsync(user);
                await _userManager.AddToRoleAsync(user, Constants.Role.Student);
            }

            //Verify logins
            var otpCode = await _userManager.GenerateChangePhoneNumberTokenAsync(user, user.PhoneNumber);

            //Send otp
            var mail = new SendMailRequest
            {
                ToEmail = request.Email,
                Subject = "Mã xác nhận đăng nhập UTEHY DatabaseCourse",
                Body = "Mã xác thực đăng nhập UTEHY DatabaseCourse của bạn là " + otpCode,
            };
            await _mailService.Send(mail);

            return true;
        }

        public async Task<string> VerifyOtpLoginEmail(VerifyOtpLoginEmailRequest request)
        {
            var user = _dbContext.Users.FirstOrDefault(user => user.Email == request.Email && user.EmailConfirmed == true);

            //Get user
            if (user == null)
            {
                throw new ApiException("Số điện thoại không tồn tại trong hệ thống!", HttpStatusCode.BadRequest);
            }
            else
            {
                if (request.Name != null)
                {
                    user.Name = request.Name;
                }
                await _userManager.UpdateAsync(user);
            }

            var isOtpValid = await _userManager.VerifyChangePhoneNumberTokenAsync(user, request.Otp, user.PhoneNumber);

            if (!isOtpValid)
            {
                throw new ApiException("Mã OTP không hợp lệ!", HttpStatusCode.BadRequest);
            }

            //Create token
            var token = await CreateToken(user);

            if (token == null)
            {
                throw new ApiException("Tạo mã token thất bại!", HttpStatusCode.BadRequest);
            }

            return token;
        }
    }
}
