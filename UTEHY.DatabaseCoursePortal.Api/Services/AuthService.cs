using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class AuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _config;
        private readonly UserService _userService;

        public AuthService(UserManager<User> userManager, IConfiguration config,UserService userService)
        {
            _userManager = userManager;
            _config = config;
            _userService = userService;
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

    }
}
