using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.UserViewModels;
using Twilio.TwiML.Messaging;
using Twilio.Types;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.Cookies;
using Google.Apis.Auth;
using System.Linq;
using Google.Apis.Auth.OAuth2;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _dbContext;
        private readonly AuthService _authService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration config, ApplicationDbContext dbContext,AuthService authService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
            _dbContext = dbContext;
            _authService = authService;
        }

        [HttpPost]
        [Route("login-by-email")]
        public async Task<ApiResult<string>> LoginByEmail([FromBody] LoginEmailRequest request)
        {
            //Check exists user
            var user = _dbContext.Users.FirstOrDefault(user => user.Email == request.Email && user.EmailConfirmed == true);

            if (user == null)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Email người dùng không tồn tại!",
                };
            }

            //Verify login
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);

            if (!result.Succeeded)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Tài khoản hoặc mật khẩu người dùng không chính xác!",
                };
            }

            //Create token
            var token = await _authService.CreateToken(user);

            if (token == null)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Tạo mã thông báo thất bại!",
                };
            }

            return new ApiResult<string>()
            {
                Status = true,
                Message = "Đăng nhập thành công!",
                Data = token
            };
        }

        [HttpPost]
        [Route("send-otp-login-numberphone")]
        public async Task<ApiResult<string>> SendOtpLoginNumberphone(string numberphone)
        {
            //Check exists user
            var user = _dbContext.Users.FirstOrDefault(user => user.PhoneNumber == numberphone && user.PhoneNumberConfirmed == true);

            if (user == null)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Số điện thoại không tồn tại trong hệ thống!",
                };
            }

            //Verify login
            var otpCode = await _userManager.GenerateChangePhoneNumberTokenAsync(user, user.PhoneNumber);

            //Send otp
            TwilioClient.Init(_config["Twilio:AccountSID"], _config["Twilio:AuthToken"]);

            var twilioMessage = MessageResource.CreateAsync(
                body: "Mã xác thực đăng nhập UTEHY DatabaseCourse của bạn là " + otpCode,
                from: new PhoneNumber(_config["Twilio:PhoneNumber"]),
                to: new PhoneNumber(numberphone)
            );

            int counter = 0;
            while (!twilioMessage.IsCompleted)
            {
                await Task.Delay(1000);

                counter++;

                if (counter >= 10)
                {
                    return new ApiResult<string>()
                    {
                        Status = false,
                        Message = "Gửi tin nhắn thất bại, quá thời gian chờ!",
                    };
                }
            }

            if (!twilioMessage.IsCompletedSuccessfully)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = twilioMessage.Result.ErrorMessage
                };
            }

            return new ApiResult<string>()
            {
                Status = true,
                Message = "Mã OTP được gửi tới người dùng thành công!",
            };
        }

        [HttpPost]
        [Route("login-by-verify-otp-numberphone")]
        public async Task<ApiResult<string>> LoginByVerifyOtpNumberphone(string numberphone, string otp)
        {
            //Verify login
            var user = _dbContext.Users.FirstOrDefault(user => user.PhoneNumber == numberphone && user.PhoneNumberConfirmed == true);

            if (user == null)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Số điện thoại không tồn tại trong hệ thống!",
                };
            }

            // Check valid otp
            var isOtpValid = await _userManager.VerifyChangePhoneNumberTokenAsync(user, otp, numberphone);

            if (!isOtpValid)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Mã OTP không chính xác!",
                };
            }

            //Create token
            var token = await _authService.CreateToken(user);

            if (token == null)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Tạo mã thông báo thất bại!",
                };
            }

            return new ApiResult<string>()
            {
                Status = true,
                Message = "Đăng nhập thành công!",
                Data = token
            };
        }

        [HttpPost]
        [Route("login-by-google")]
        public async Task<ApiResult<string>> LoginByGoogle(string idToken)
        {
            //Validate id token
            var settings = new GoogleJsonWebSignature.ValidationSettings()
            {
                Audience = new List<string>() { _config["Google:ClientId"] }
            };

            GoogleJsonWebSignature.Payload tokenPayload;

            try
            {
                tokenPayload = await GoogleJsonWebSignature.ValidateAsync(idToken, settings);
            }
            catch (Exception ex)
            {
                tokenPayload = null;
            }

            if(tokenPayload == null)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Mã xác thực google không hợp lệ!",
                };
            }

            // Verify user
            var userLoginInfo = new UserLoginInfo("google", tokenPayload.Subject, "google");

            var user = await _userManager.FindByLoginAsync(userLoginInfo.LoginProvider, userLoginInfo.ProviderKey);

            if(user == null)
            {
                user = await _userManager.FindByEmailAsync(tokenPayload.Email);

                if (user == null)
                {
                    user = new User 
                    { 
                        Email = tokenPayload.Email, 
                        UserName = tokenPayload.Email,
                        EmailConfirmed = tokenPayload.EmailVerified,
                        FirstName = "Luyện",
                        LastName = "Đăng",
                    };

                    await _userManager.CreateAsync(user);
                    await _userManager.AddToRoleAsync(user, "admin");
                }
                await _userManager.AddLoginAsync(user, userLoginInfo);
            }

            //Create token
            var token = await _authService.CreateToken(user);

            if (token == null)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Tạo mã thông báo thất bại!",
                };
            }

            return new ApiResult<string>()
            {
                Status = true,
                Message = "Đăng nhập thành công!",
                Data = token
            };
        }
    }
}
