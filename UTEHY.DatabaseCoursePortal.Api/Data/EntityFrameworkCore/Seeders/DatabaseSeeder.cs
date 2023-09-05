using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Seeders
{
    public static class DatabaseSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(RoleSeeder.Data());
            modelBuilder.Entity<User>().HasData(UserSeeder.Data());
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = RoleSeeder.Data().Id,
                UserId = UserSeeder.Data().Id
            });
        }
    }
}
