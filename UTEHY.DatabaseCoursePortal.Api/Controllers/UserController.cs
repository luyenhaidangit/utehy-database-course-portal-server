using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Twilio.TwiML.Voice;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;

        public UserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("check-exists")]
        public async Task<ApiResult<string>> CheckUserExists([FromQuery] string field, string value)
        {
            User user = new User();

            switch (field.ToLower())
            {
                case "email":
                    user = await _userManager.FindByEmailAsync(value);
                    break;
                default:
                    return new ApiResult<string>()
                    {
                        Status = false,
                        Message = "Tên trường tìm kiếm không hợp lệ!",
                    };
            }

            if (user == null)
            {
                return new ApiResult<string>()
                {
                    Status = true,
                    Message = "Người dùng không tồn tại!",
                    Data = null
                };
            }

            return new ApiResult<string>()
            {
                Status = true,
                Message = "Người dùng tồn tại!",
                Data = null
            };
        }
    }
}
