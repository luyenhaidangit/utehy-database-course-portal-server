using Microsoft.AspNetCore.Identity;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Seeders
{
    public static class UserSeeder
    {
        public static User Data()
        {
            var hasher = new PasswordHasher<User>();
            return new User
            {
                Id = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"),
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "luyenhaidangit@gmail.com",
                NormalizedEmail = "luyenhaidangit@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null!, "haidang106"),
                SecurityStamp = string.Empty,
                FirstName = "Luyện",
                LastName = "Đăng",
            };
        }
    }
}
