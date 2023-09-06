using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.UserViewModels;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _config;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ApiResult<string>> Login([FromBody] LoginRequest request)
        {
            //Verify
            var user = await _userManager.FindByNameAsync(request.UserName);

            if (user == null)
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Tên người dùng không tồn tại!",
                };
            }

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);

            if(!result.Succeeded) 
            {
                return new ApiResult<string>()
                {
                    Status = false,
                    Message = "Tài khoản hoặc mật khẩu người dùng không hợp lệ!",
                };
            }

            //Create token
            var issuer = _config["Jwt:Issuer"];
            var audience = _config["Jwt:Audience"];
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, string.Join(";",roles)),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.UtcNow.AddDays(30);

            var token = new JwtSecurityToken(issuer,audience,claims,expires,signingCredentials: creds);
            var tokenHandler = new JwtSecurityTokenHandler();

            return new ApiResult<string>()
            {
                Status = true,
                Message = "Đăng nhập thành công!",
                Data = tokenHandler.WriteToken(token)
            };
        }
    }
}
