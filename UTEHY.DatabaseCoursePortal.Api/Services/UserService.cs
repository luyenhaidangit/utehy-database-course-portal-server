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

        public UserService(ApplicationDbContext dbContext, UserManager<User> userManager, FileService fileService)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _fileService = fileService;
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
            (user.PhoneNumber == request.Phone && user.PhoneNumberConfirmed && request.Phone != null) ||
            (user.Email == request.Email && user.EmailConfirmed && request.Email != null));

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
                Name = request.Name,
                Email = request.Email,
                PhoneNumber = request.Phone,
                AvatarUrl = string.IsNullOrEmpty(request.AvatarUrl) ? ResourceConstant.DefaultAvatarUrl : request.AvatarUrl,
                Status = request.Status,
            };

            var resultCreateUser = await _userManager.CreateAsync(newUser, request.Password);

            await _userManager.AddToRoleAsync(newUser, request.Role);

            return newUser;
        }

        public async Task<User> GetUserInfo(HttpContext httpContext)
        {
            var email = httpContext.User.Claims.First(x => x.Type == "Email").Value;

            var user = await _userManager.FindByEmailAsync(email);

            return user;
        }
    }
}
