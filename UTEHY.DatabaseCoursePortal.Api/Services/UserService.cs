using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Security.Claims;
using System.Xml.Linq;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Exceptions;
using UTEHY.DatabaseCoursePortal.Api.Models.Account;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.User;
using static System.Net.WebRequestMethods;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        private readonly FileService _fileService;
        private readonly ConfigService _configService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(ApplicationDbContext dbContext, UserManager<User> userManager, FileService fileService, ConfigService configService, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _fileService = fileService;
            _configService = configService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<string>> GetPermissionAsync(User user)
        {
            var roles = await _userManager.GetRolesAsync(user);

            var permissions = await _dbContext.Roles.Where(role => roles.Contains(role.Name))
            .SelectMany(role => role.RolePermissions)
            .Select(rolePermission => rolePermission.Permission.Name).ToListAsync();

            return permissions;
        }

        public async Task<User> Create(CreateUserRequest request)
        {
            var existingUser = _dbContext.Users.FirstOrDefault(user =>
                (user.PhoneNumber == request.Phone && user.PhoneNumberConfirmed && !string.IsNullOrEmpty(request.Phone)) ||
                (user.Email == request.Email && user.EmailConfirmed && !string.IsNullOrEmpty(request.Email)));

            var userCreationCountConfig = await _configService.GetConfigValue(ConfigConstant.UserCreationCount);
            var userCreationCount = int.Parse(userCreationCountConfig);
            var username = Prefix.Username + (userCreationCount + 1);

            if (existingUser != null)
            {
                string duplicateField = existingUser.PhoneNumber == request.Phone ? "Số điện thoại" : "Email";
                throw new ApiException($"{duplicateField} đã tồn tại trong hệ thống!", HttpStatusCode.BadRequest);
            }

            if (request.AvatarFile?.Length > 0)
            {
                request.AvatarUrl = await _fileService.UploadFileAsync(request.AvatarFile, PathFolder.User);
            }

            var newUser = new User()
            {
                UserName = username,
                Name = request.Name,
                Email = request.Email,
                PhoneNumber = request.Phone,
                AvatarUrl = string.IsNullOrEmpty(request.AvatarUrl) ? ResourceConstant.DefaultAvatarUrl : request.AvatarUrl,
                Status = request.Status,
            };

            if (string.IsNullOrEmpty(request.Password))
            {
                var result = await _userManager.CreateAsync(newUser);

                if (!result.Succeeded)
                {
                    throw new ApiException($"Không thể tạo người dùng. Lỗi: {string.Join(", ", result.Errors)}", HttpStatusCode.BadRequest);
                }
            }
            else
            {
                var result = await _userManager.CreateAsync(newUser, request.Password);

                if (!result.Succeeded)
                {
                    throw new ApiException($"Không thể tạo người dùng. Lỗi: {string.Join(", ", result.Errors)}", HttpStatusCode.BadRequest);
                }
            }

            await _userManager.AddToRoleAsync(newUser, request.Role);

            await _configService.UpdateConfigValue(ConfigConstant.UserCreationCount, (userCreationCount + 1).ToString());

            return newUser;
        }

        public async Task<User> GetUserInfo(HttpContext httpContext)
        {
            var email = httpContext.User.Claims.First(x => x.Type == "Email").Value;

            var user = await _userManager.FindByEmailAsync(email);

            return user;
        }

        public async Task<User> GetUserCurrent()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userId != null)
            {
                var user = await _userManager.FindByIdAsync(userId);

                return user;
            }

            return null;
        }

        public async Task<List<User>> Test()
        {
            var test = await _dbContext.Users.ToListAsync();


            return test;
        }


        //public async Task<string> GenerateAutoUsername()
        //{
        //    //var userCount = await _dbContext.Users.fi;

        //    return $"User{userCount + 1}";
        //}
    }
}
