using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Exceptions;
using UTEHY.DatabaseCoursePortal.Api.Models.Account;
using UTEHY.DatabaseCoursePortal.Api.Models.Auth;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.User;
using UTEHY.DatabaseCoursePortal.Api.Services;

namespace UTEHY.DatabaseCoursePortal.Api.Controllers.Guest
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly AuthService _authService;
        private readonly IMapper _mapper;

        public AuthController(UserService userService, IMapper mapper, AuthService authService)
        {
            _userService = userService;
            _mapper = mapper;
            _authService = authService;                           
        }

        [HttpGet("user-current")]
        public async Task<ApiResult<UserDto>> GetUserInfo()
        {
            try
            {
                var user = await _authService.GetUserInfo();

                return new ApiResult<UserDto>()
                {
                    Status = true,
                    Message = "Lấy thông tin người dùng thành công!",
                    Data = user
                };
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<ApiResult<LoginResult>> LoginByUsername([FromBody] LoginUsernameRequest request)
        {
            try
            {
                var loginResult = await _authService.LoginByUsername(request);

                return new ApiResult<LoginResult>()
                {
                    Status = true,
                    Message = "Đăng nhập thành công!",
                    Data = loginResult
                };
            }
            catch (BadHttpRequestException ex)
            {
                throw new BadHttpRequestException(ex.Message);
            }
            catch(UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
