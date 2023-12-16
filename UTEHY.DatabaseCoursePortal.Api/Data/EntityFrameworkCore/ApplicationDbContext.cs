﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities.Interface;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Configurations;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Initializers;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Seeders;

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Banner> Banners { get; set; } = null!;
        public virtual DbSet<Blog>? Blogs { get; set; }
        public virtual DbSet<Post>? Posts { get; set; }
        public virtual DbSet<BlogTopic>? BlogTopics { get; set; }
        public virtual DbSet<Comment>? Comments { get; set; }
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<VideoCourse>? VideoCourses { get; set; }
        //public virtual DbSet<TrackCourse>? TrackCourses { get; set; }
        public virtual DbSet<Permission>? Permissions { get; set; }
        public virtual DbSet<RolePermission>? RolePermissions { get; set; }
        public virtual DbSet<Config>? Configs { get; set; } = null!;
        public virtual DbSet<UserCourse> UserCourses { get; set; } = null!;
        public virtual DbSet<Page> Pages { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<Track> Tracks { get; set; } = null!;
        public virtual DbSet<AssignmentCourse> AssignmentCourses { get; set; } = null!;
        public virtual DbSet<QuizCourse> QuizCourses { get; set; } = null!;
        public virtual DbSet<TypeStepTrack> TypeStepTracks { get; set; } = null!;
        public virtual DbSet<StepTrack> StepTracks { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<QuestionCategory> QuestionCategories { get; set; } = null!;
        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; } = null!;
        public virtual DbSet<QuestionTag> QuestionTags { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            QuestionCategoryInitializer.Initialize(builder);

            //Configuration
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new BannerConfiguration());
            builder.ApplyConfiguration(new PermissionConfiguration());
            builder.ApplyConfiguration(new RolePermissionConfiguration());
            builder.ApplyConfiguration(new BlogConfiguration());
            builder.ApplyConfiguration(new BlogTopicConfiguration());
            builder.ApplyConfiguration(new ConfigConfiguration());
            builder.ApplyConfiguration(new UserCourseConfiguration());
            builder.ApplyConfiguration(new PageConfiguration());
            builder.ApplyConfiguration(new TrackConfiguration());
            builder.ApplyConfiguration(new AssignmentCourseConfiguration());
            builder.ApplyConfiguration(new QuizCourseConfiguration());
            builder.ApplyConfiguration(new TypeStepTrackConfiguration());
            builder.ApplyConfiguration(new StepTrackConfiguration());
            builder.ApplyConfiguration(new QuestionConfiguration());
            builder.ApplyConfiguration(new QuestionCategoryConfiguration());
            builder.ApplyConfiguration(new QuestionAnswerConfiguration());
            builder.ApplyConfiguration(new TagConfiguration());
            builder.ApplyConfiguration(new QuestionTagConfiguration());

            //Entity
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles");
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins");
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens");
            builder.Entity<Banner>().HasQueryFilter(x => x.DeletedAt == null);
            builder.Entity<Blog>().HasQueryFilter(x => x.DeletedAt == null);
            builder.Entity<BlogTopic>().HasQueryFilter(x => x.DeletedAt == null);
            builder.Entity<Comment>().HasQueryFilter(x => x.DeletedAt == null);

            //Seeder 
            builder.Seed();
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
