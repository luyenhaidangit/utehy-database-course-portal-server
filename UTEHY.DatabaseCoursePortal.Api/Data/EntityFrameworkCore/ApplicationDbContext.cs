using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Configurations;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Seeders;

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Banner>? Banners { get; set; }
        public virtual DbSet<Blog>? Blogs { get; set; }
        public virtual DbSet<Comment>? Comments { get; set; }
        public virtual DbSet<Permission>? Permissions { get; set; }
        public virtual DbSet<RolePermission>? RolePermissions { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Configuration
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new BannerConfiguration());
            builder.ApplyConfiguration(new PermissionConfiguration());
            builder.ApplyConfiguration(new RolePermissionConfiguration());
            builder.ApplyConfiguration(new BlogConfiguration());

            //Entity
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles");
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins");
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens");
            builder.Entity<Banner>().HasQueryFilter(x => x.DeletedAt == null);

            //Seeder
            builder.Seed();
        }
    }
}
