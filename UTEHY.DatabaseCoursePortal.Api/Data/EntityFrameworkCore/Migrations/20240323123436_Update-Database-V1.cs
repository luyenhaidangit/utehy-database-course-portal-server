using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class UpdateDatabaseV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroupModules_GroupModule_GroupModuleId",
                table: "StudentGroupModules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrackCourses",
                table: "TrackCourses");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_GroupModule_TempId",
                table: "GroupModule");

            migrationBuilder.DropColumn(
                name: "CertificateName",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "PublishedAt",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "TrackCourses",
                newName: "TypeStepTracks");

            migrationBuilder.RenameTable(
                name: "GroupModule",
                newName: "GroupModules");

            migrationBuilder.RenameColumn(
                name: "LandingPage",
                table: "Courses",
                newName: "ShortDescription");

            migrationBuilder.RenameColumn(
                name: "TempId",
                table: "GroupModules",
                newName: "Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "VideoCourses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "VideoCourses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "VideoCourses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "UserRoles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessonContentCurrentId",
                table: "UserCourses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Sections",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Reaction",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "Reaction",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Reaction",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Posts",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Permissions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "Permissions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Permissions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Configs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "Configs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Configs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Comments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "Comments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Comments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "BlogTopics",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "BlogTopics",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "BlogTopics",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Blogs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "Blogs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Blogs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Banners",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "Banners",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Banners",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "GroupModules",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupModules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "GroupModules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "GroupModules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "GroupModules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "GroupModules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryTimeInvitation",
                table: "GroupModules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvitationCode",
                table: "GroupModules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "GroupModules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Semester",
                table: "GroupModules",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "GroupModules",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "GroupModules",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "GroupModules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "GroupModules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "GroupModules",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeStepTracks",
                table: "TypeStepTracks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupModules",
                table: "GroupModules",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsShowContent = table.Column<bool>(type: "bit", nullable: true),
                    IsSeeScore = table.Column<bool>(type: "bit", nullable: true),
                    IsMixQuestion = table.Column<bool>(type: "bit", nullable: true),
                    IsMixQuestionAnswer = table.Column<bool>(type: "bit", nullable: true),
                    IsAllowChangeTab = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    NumberQuestionDifficult = table.Column<int>(type: "int", nullable: true),
                    NumberQuestionModerate = table.Column<int>(type: "int", nullable: true),
                    NumberQuestionEasy = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupModuleId = table.Column<int>(type: "int", nullable: false),
                    ClassPeriods = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSchool = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_GroupModules_GroupModuleId",
                        column: x => x.GroupModuleId,
                        principalTable: "GroupModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExamGroupModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupModuleId = table.Column<int>(type: "int", nullable: true),
                    ExamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamGroupModules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamGroupModules_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamGroupModules_GroupModules_GroupModuleId",
                        column: x => x.GroupModuleId,
                        principalTable: "GroupModules",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExamQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamQuestions_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DurationTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    NumberCorrectAnswers = table.Column<int>(type: "int", nullable: true),
                    NumberChangeTab = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamResults_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamResults_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LessonContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoType = table.Column<int>(type: "int", nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    EstimatedStudyTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonContents_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotificationGroupModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupModuleId = table.Column<int>(type: "int", nullable: true),
                    NotificationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationGroupModules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationGroupModules_GroupModules_GroupModuleId",
                        column: x => x.GroupModuleId,
                        principalTable: "GroupModules",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotificationGroupModules_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfPeriod = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassPeriods_Attendances_AttendanceId",
                        column: x => x.AttendanceId,
                        principalTable: "Attendances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BlogId", "CommentsCount", "Content", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsAnswered", "IsApproved", "IsReacted", "IsRemoved", "IsVoted", "ParentCommentId", "PostId", "TypeCommentable", "UpdatedAt", "UpdatedBy", "UserId", "VideoCourseId", "VotersCount" },
                values: new object[,]
                {
                    { 1, 1, 1, "Học đi nào SGP", null, null, null, null, true, true, true, false, false, null, 1, "", null, null, null, 1, 1 },
                    { 2, 1, 1, "Học đi nào VGM", null, null, null, null, true, true, true, false, false, 1, 1, "", null, null, null, 1, 1 },
                    { 3, 1, 1, "Học đi nào GGL", null, null, null, null, true, true, true, false, false, 1, 2, "", null, null, null, 1, 1 },
                    { 4, 1, 1, "Học đi nào FL", null, null, null, null, true, true, true, false, false, null, 3, "", null, null, null, 1, 1 },
                    { 5, 1, 1, "Học đi nào TLN", null, null, null, null, true, true, true, false, false, 1, 1, "", null, null, null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Configs",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Key", "UpdatedAt", "UpdatedBy", "Value" },
                values: new object[] { 7, null, null, null, null, "Số người dùng đã tạo", "UserCreationCount", null, null, "0" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "IsDefault", "Title" },
                values: new object[] { "/Course/Default.jpg", true, "Cơ sở dữ liệu" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDefault",
                value: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDefault",
                value: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0548eee3-7f53-4599-b523-d0d11c9c03e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "0a2cdd41-8ff4-4ab5-935c-293d9b94156a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "9aeed886-f9fa-494e-b77a-08e88a754c29");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator", "UserId1" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"), "UserRole", null },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"), "UserRole", null },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"), "UserRole", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Status" },
                values: new object[] { "82a6f95f-017e-4be9-9b4e-d578bea279ff", "AQAAAAEAACcQAAAAEBOYxruh0rnDroDkM9jc3z4xZkGWZUEtRCAfHvaI0ICA8CR2DBbe1zt8vD3DxP0uew==", true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Status" },
                values: new object[] { "12276242-66f9-481f-9776-198ff49f24a3", "AQAAAAEAACcQAAAAELU0rVDHeFcQFe4q+DOMuaggj5gyBrovnKnMKB6SM8LZlShfjRmYjhRc1Aw+xzthfA==", true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Status" },
                values: new object[] { "fdda44db-7077-4dcb-bb53-0033e4ab5987", "AQAAAAEAACcQAAAAEGa+qhh+5MANDLsnmSlg3a3er36vL6Wa5qmlEAa4hQlXfrH0R4efEKo0k6JPpfZDMQ==", true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3bc772f4-6b1d-4734-8ea3-a7886b6539e1", "AQAAAAEAACcQAAAAEE0ySgOOQiytZHfCFpzwXOciJaD2hCHIvGEvnJuAKqZqU3GPyoo8zj+0Th8Rs+2vDQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "228d8b09-a9b6-4c3a-864d-c2c81fa22087", "AQAAAAEAACcQAAAAEOE/14f+xGItEVXQ51pkEB9mak1SKdFEyUVeJD+Q4EmOLb/yjk0SWNKJ3gpJ6zjTKw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cda6ddca-36de-4b1c-a0b2-379b9edc646f", "AQAAAAEAACcQAAAAELbvr9u2U37QfprMMo8cVHTVmIfhOy8ChB5xmNhj7G8mK1AYJdBAFm7IinVpJE9LvA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "140fac77-1e63-4bbf-af31-4c0b585ad127", "AQAAAAEAACcQAAAAEMCS2PmKPn8bEujnMe1RAWYcU8WMKintkN8aUiwT83n3npr7n0+eTdngPm+o2MoF1A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9a6fd5e-a815-4764-93e1-fd1af598186b", "AQAAAAEAACcQAAAAEFo4lgSHME/+TPZGTPFv0zcWS2B92qaZOhhEgB7MGEJCZ5yQAm7eqc7ksTTS05tapw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b97a46f0-3a45-4db7-8602-2433ba93e22a", "AQAAAAEAACcQAAAAEJr/ckzMU9hf+LzZo+WFrMj/zLJbdcsnmPBY4vP15Z/kQn8Trokh/fbfzNUPhTSifA==" });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId1",
                table: "UserRoles",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CourseId",
                table: "Sections",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupModules_TeacherId",
                table: "GroupModules",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_ScheduleId",
                table: "Attendances",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassPeriods_AttendanceId",
                table: "ClassPeriods",
                column: "AttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamGroupModules_ExamId",
                table: "ExamGroupModules",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamGroupModules_GroupModuleId",
                table: "ExamGroupModules",
                column: "GroupModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestions_ExamId",
                table: "ExamQuestions",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestions_QuestionId",
                table: "ExamQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamResults_ExamId",
                table: "ExamResults",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamResults_StudentId",
                table: "ExamResults",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonContents_LessonId",
                table: "LessonContents",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationGroupModules_GroupModuleId",
                table: "NotificationGroupModules",
                column: "GroupModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationGroupModules_NotificationId",
                table: "NotificationGroupModules",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_GroupModuleId",
                table: "Schedules",
                column: "GroupModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TeacherId",
                table: "Schedules",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupModules_Teachers_TeacherId",
                table: "GroupModules",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswers_Questions_QuestionId",
                table: "QuestionAnswers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuestionCategories_QuestionCategoryId",
                table: "Questions",
                column: "QuestionCategoryId",
                principalTable: "QuestionCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Sections_SectionId",
                table: "Questions",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionTags_Questions_QuestionId",
                table: "QuestionTags",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionTags_Tags_TagId",
                table: "QuestionTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Courses_CourseId",
                table: "Sections",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroupModules_GroupModules_GroupModuleId",
                table: "StudentGroupModules",
                column: "GroupModuleId",
                principalTable: "GroupModules",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroups_Groups_GroupId",
                table: "UserGroups",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId1",
                table: "UserRoles",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupModules_Teachers_TeacherId",
                table: "GroupModules");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswers_Questions_QuestionId",
                table: "QuestionAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuestionCategories_QuestionCategoryId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Sections_SectionId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionTags_Questions_QuestionId",
                table: "QuestionTags");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionTags_Tags_TagId",
                table: "QuestionTags");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Courses_CourseId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroupModules_GroupModules_GroupModuleId",
                table: "StudentGroupModules");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGroups_Groups_GroupId",
                table: "UserGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId1",
                table: "UserRoles");

            migrationBuilder.DropTable(
                name: "ClassPeriods");

            migrationBuilder.DropTable(
                name: "ExamGroupModules");

            migrationBuilder.DropTable(
                name: "ExamQuestions");

            migrationBuilder.DropTable(
                name: "ExamResults");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "LessonContents");

            migrationBuilder.DropTable(
                name: "NotificationGroupModules");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId1",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_Sections_CourseId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeStepTracks",
                table: "TypeStepTracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupModules",
                table: "GroupModules");

            migrationBuilder.DropIndex(
                name: "IX_GroupModules_TeacherId",
                table: "GroupModules");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1") });

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "LessonContentCurrentId",
                table: "UserCourses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "ExpiryTimeInvitation",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "InvitationCode",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "Semester",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "GroupModules");

            migrationBuilder.RenameTable(
                name: "TypeStepTracks",
                newName: "TrackCourses");

            migrationBuilder.RenameTable(
                name: "GroupModules",
                newName: "GroupModule");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Courses",
                newName: "LandingPage");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GroupModule",
                newName: "TempId");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "VideoCourses",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "VideoCourses",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "VideoCourses",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Reaction",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Reaction",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Reaction",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Posts",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Posts",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Posts",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Permissions",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Permissions",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Permissions",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CertificateName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Courses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Configs",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Configs",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Configs",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "BlogTopics",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "BlogTopics",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "BlogTopics",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Blogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Blogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Blogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Banners",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Banners",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Banners",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TempId",
                table: "GroupModule",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrackCourses",
                table: "TrackCourses",
                column: "Id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_GroupModule_TempId",
                table: "GroupModule",
                column: "TempId");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "IsPublished", "Priority", "PublishedAt", "Title" },
                values: new object[] { "/Course/Course-1.png", true, 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kiến Thức Nhập Môn IT" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsPublished", "Priority", "PublishedAt" },
                values: new object[] { true, 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsPublished", "Priority", "PublishedAt" },
                values: new object[] { true, 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsPublished", "Priority", "PublishedAt" },
                values: new object[] { true, 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "00be1ca5-f0bb-4255-8744-fd104297d84e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "cec906cc-a8bb-4197-a27e-4fbd84c139f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "25a4b799-dfb0-4aaf-8628-7f1afd095654");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Status" },
                values: new object[] { "3903462e-b7b7-4c0b-b9ef-fb252b6c6158", "AQAAAAEAACcQAAAAEACseFq4NhuNmXjZr/zidYI7Lru1r/CGrzezahaplak33nc52W354Z0kedU09dhEtg==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Status" },
                values: new object[] { "6709346e-991a-4bee-908e-1336127bc44c", "AQAAAAEAACcQAAAAEAHoaRrnJtOflaXxSEDOkD+u/KXUXc8q06Ub74NPhWvWtdjMmaZp3yscpEBVpYei5w==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Status" },
                values: new object[] { "c6ddd295-df13-4a72-a6b7-2f66ef99a6b2", "AQAAAAEAACcQAAAAELKTtkyGDNqHShZIEpIgX8t8sXHspEFEY2g0SR1HJJNCDMF2Dz4JVgUrq29nwLJjqA==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "678d94ff-c812-43ca-969c-26a5d416fc05", "AQAAAAEAACcQAAAAEEqFzYDRX+pQlAppwMNLXIyCIb1t2vYV4x2Cs9k1IC4fHeaAmARQzhqV0F2jha+QtQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e90a642f-c4e1-4653-9186-1b354f9c7bdd", "AQAAAAEAACcQAAAAEC9Elt0B3rShdUJQGg1emSkunljIHzY4XV1E5/M15aaE2e1yPbJ599AATSSLak2dpA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "144ab96d-c4d8-4ca7-93d5-6fe6db2a7014", "AQAAAAEAACcQAAAAEIoM6MTOWIBykf+nJidbql5EKBMPcF6+xzuh4HCp5fcXo/9+4LfgZqFGUvBEJ2kpCA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24020889-379f-4eb3-9a8b-f7d684cba820", "AQAAAAEAACcQAAAAENj6XLIrDTzO7p3j79ql8vmUnGjiAm83gOj+8POIEwKhsahEeaKBH/CytHfpFl1Mfw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6adce3a3-25fe-4771-97de-65a774ef2dad", "AQAAAAEAACcQAAAAEN4co6fQg5DG/voTsP2QteJp0KegaqGIeZQCjY2alZPmduGQXsl55WX5O86qp/ScKQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d63cdd0a-06a1-4380-9bf1-e294fc9e61c7", "AQAAAAEAACcQAAAAEIkkR3/JXZM2zvvPvRevmbqHfJW649VyYi/x+KSHjIl+wOLCQ5ObQkTOPrhd436lMQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroupModules_GroupModule_GroupModuleId",
                table: "StudentGroupModules",
                column: "GroupModuleId",
                principalTable: "GroupModule",
                principalColumn: "TempId");
        }
    }
}
