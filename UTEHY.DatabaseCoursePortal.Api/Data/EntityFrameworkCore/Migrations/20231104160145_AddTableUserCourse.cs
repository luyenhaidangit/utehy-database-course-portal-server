using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableUserCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "UserCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Progress = table.Column<int>(type: "int", nullable: true),
                    TimeSpent = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCourses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "23cdbf3e-bdf4-434d-83fe-b4f411c82cb6");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"), "d893a05c-732d-494f-90e4-f75f24c8e3b3", "Student Role", "student", "student" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), "UserRole" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8da9496f-c992-4819-aebc-81a3588a981a", "AQAAAAEAACcQAAAAELObSnmw77PScsmAMQ9z9piWBV0LVRW595RYiu+2oOOYtjWp7swyfWNCYNxOEfZAbw==" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"), 0, "34100b2f-7795-4097-b247-c7f617f255a9", "nguyenvanthang@gmail.com", true, false, null, "Nguyễn Văn Thắng", "nguyenvanthang@gmail.com", "nguyenvanthang", "AQAAAAEAACcQAAAAEAINnoViyD2VjBzF5aPf9DkupQEU080kOfQc+NGovIKRKiwWYl73CQluq6VpS4Ou3w==", null, false, "", false, "nguyenvanthang" },
                    { new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"), 0, "9f97fd0c-3067-417b-af78-b49abbc3aceb", "caovandan@gmail.com", true, false, null, "Cao Văn Dân", "caovandan@gmail.com", "caovandan", "AQAAAAEAACcQAAAAEMX13Ht7yi6DcMoSIpJeWmpUolRhyoAZS2ZVx5pV8PnB4hl/BB5Dm4g6JxKQYl3QRw==", null, false, "", false, "caovandan" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"), new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"), "UserRole" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"), new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"), "UserRole" });

            migrationBuilder.CreateIndex(
                name: "IX_UserCourses_CourseId",
                table: "UserCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCourses_UserId",
                table: "UserCourses",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCourses");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"), new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"), new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"));

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "UserRoles");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "de8e093e-67b6-4801-8d80-3be96a21b513");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74992807-4b39-4abb-ab1a-20b74db9fa6c", "AQAAAAEAACcQAAAAEOZ3prmwamc7/0aahxlZNRTxav2CJecMQsp6siC7HzkgccXGR8iAob4nMWE1IOagWQ==" });
        }
    }
}
