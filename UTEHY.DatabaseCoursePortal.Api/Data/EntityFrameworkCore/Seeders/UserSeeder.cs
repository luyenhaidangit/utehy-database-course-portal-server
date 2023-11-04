using Microsoft.AspNetCore.Identity;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Seeders
{
    public static class UserSeeder
    {
        public static List<User> Data()
        {
            var hasher = new PasswordHasher<User>();
            var users = new List<User>()
            {
                new User
                {
                    Id = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"),
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "luyenhaidangit@gmail.com",
                    NormalizedEmail = "luyenhaidangit@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null!, "haidang106"),
                    SecurityStamp = string.Empty,
                    Name = "Luyện Hải Đăng"
                },
                new User
                {
                    Id = new Guid("C4F97A72-6B4A-47D3-BA1B-6FE15E62C192"),
                    UserName = "caovandan",
                    NormalizedUserName = "caovandan",
                    Email = "caovandan@gmail.com",
                    NormalizedEmail = "caovandan@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null!, "haidang106"),
                    SecurityStamp = string.Empty,
                    Name = "Cao Văn Dân"
                },
                new User
                {
                    Id = new Guid("1A3E854A-843D-4E65-AB88-9D5736C831F2"),
                    UserName = "nguyenvanthang",
                    NormalizedUserName = "nguyenvanthang",
                    Email = "nguyenvanthang@gmail.com",
                    NormalizedEmail = "nguyenvanthang@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null!, "haidang106"),
                    SecurityStamp = string.Empty,
                    Name = "Nguyễn Văn Thắng"
                },
            };

            return users;
        }
    }
}
