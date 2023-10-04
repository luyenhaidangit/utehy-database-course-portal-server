using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Account;
using Twilio.Types;
using Google.Apis.Auth;
using UTEHY.DatabaseCoursePortal.Api.Services;
using Newtonsoft.Json.Linq;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _dbContext;
        private readonly AuthService _authService;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration config, ApplicationDbContext dbContext,AuthService authService, IHttpClientFactory httpClientFactory)
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

        [HttpPost]
        [Route("login-by-facebook")]
        public async Task<ApiResult<string>> LoginByFacebook(string accessToken)
        {
            //Validate access token
            var httpClient = new HttpClient();
            var requestUri = $"https://graph.facebook.com/v2.8/me?fields=id,email,first_name,last_name,name,gender,locale,birthday,picture&access_token={accessToken}";
            var response = await httpClient.GetAsync(requestUri);

            if (!response.IsSuccessStatusCode)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Gửi yêu cầu đăng nhập facebook thất bại!",
                };
            }

            var facebookProfile = await response.Content.ReadAsStringAsync();

            var jProfile = JObject.Parse(facebookProfile);

            var email = jProfile["email"]?.ToString();

            if (string.IsNullOrEmpty(email))
            {
                return new ApiResult<string>()
                {
                    Status = true,
                    Message = "Mã xác thực facebook không hợp lệ!",
                };
            }

            //Verify user
            var userLoginInfo = new UserLoginInfo("facebook", jProfile["id"]?.ToString(), "facebook");

            var user = await _userManager.FindByLoginAsync(userLoginInfo.LoginProvider, userLoginInfo.ProviderKey);

            if (user == null)
            {
                user = await _userManager.FindByEmailAsync(jProfile["email"]?.ToString());

                if (user == null)
                {
                    user = new User
                    {
                        Email = jProfile["email"]?.ToString(),
                        UserName = jProfile["email"]?.ToString(),
                        EmailConfirmed = true,
                        FirstName = jProfile["first_name"]?.ToString(),
                        LastName = jProfile["last_name"]?.ToString(),
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

        [HttpPost]
        [Route("login-by-github")]
        public async Task<ApiResult<string>> LoginByGithub(string accessToken)
        {
            //Validate token
            //Get id
            var httpClientGetId = new HttpClient();
            var requestGetId = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/user");
            requestGetId.Headers.Add("Authorization", "Bearer " + accessToken);
            requestGetId.Headers.Add("User-Agent", "HttpClient");

            var responseGetId = await httpClientGetId.SendAsync(requestGetId);

            if (!responseGetId.IsSuccessStatusCode)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Gửi yêu cầu đăng nhập facebook thất bại!",
                };
            }

            var githubProfileId = await responseGetId.Content.ReadAsStringAsync();
            var jProfileId = JObject.Parse(githubProfileId);
            var id = jProfileId["id"]?.ToString();

            //Get email
            var httpClientGetEmail = new HttpClient();
            var requestGetEmail = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/user/emails");
            requestGetEmail.Headers.Add("Authorization", "Bearer " + accessToken);
            requestGetEmail.Headers.Add("User-Agent", "HttpClient");

            var responseGetEmail = await httpClientGetEmail.SendAsync(requestGetEmail);

            if (!responseGetEmail.IsSuccessStatusCode)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Gửi yêu cầu đăng nhập github thất bại!",
                };
            }

            var githubProfileEmail = await responseGetEmail.Content.ReadAsStringAsync();
            var jProfileEmail = JArray.Parse(githubProfileEmail).First;
            var email = jProfileEmail["email"]?.ToString();

            if (string.IsNullOrEmpty(email))
            {
                return new ApiResult<string>()
                {
                    Status = true,
                    Message = "Mã xác thực github không hợp lệ!",
                };
            }

            //Verify user
            var userLoginInfo = new UserLoginInfo("github", id, "github");

            var user = await _userManager.FindByLoginAsync(userLoginInfo.LoginProvider, userLoginInfo.ProviderKey);

            if (user == null)
            {
                user = await _userManager.FindByEmailAsync(email);

                if (user == null)
                {
                    user = new User
                    {
                        Email = email,
                        UserName = email,
                        EmailConfirmed = true,
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
