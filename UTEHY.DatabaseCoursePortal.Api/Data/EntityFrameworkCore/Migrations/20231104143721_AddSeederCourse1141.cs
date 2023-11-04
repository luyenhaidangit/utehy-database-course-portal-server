using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddSeederCourse1141 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ImageUrl", "IsPublished", "Priority", "PublishedAt", "Title" },
                values: new object[] { "/Course/Course-2.png", true, 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HTML CSS từ Zero đến Hero" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "IsPublished", "Priority", "PublishedAt", "Title" },
                values: new object[] { "/Course/Course-3.png", true, 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Responsive Với Grid System" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "IsPublished", "Priority", "PublishedAt", "Title" },
                values: new object[] { "/Course/Course-4.png", true, 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lập Trình JavaScript Cơ Bản" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1218364b-5191-4c25-aef2-2f6aa9fac085");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "894edabe-fda0-4a16-8246-940aea51bfca", "AQAAAAEAACcQAAAAECCk98wCOzZ0HLXYPQoY2klQt/SzjS5FoH61HtJh62bXOG/vWpb1AUIYFFRvyKQy6Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "IsPublished", "Priority", "PublishedAt", "Title" },
                values: new object[] { "/Course/Course.png", null, null, null, "SQL căn bản" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "IsPublished", "Priority", "PublishedAt", "Title" },
                values: new object[] { "/Course/Course.png", null, null, null, "SQL Advanced Queries" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "IsPublished", "Priority", "PublishedAt", "Title" },
                values: new object[] { "/Course/Course.png", null, null, null, "Bảo mật Cơ sở dữ liệu" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "IsPublished", "Priority", "PublishedAt", "Title" },
                values: new object[] { "/Course/Course.png", null, null, null, "Thiết kế Cơ sở dữ liệu" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "24ab3726-cec0-461d-a53f-594acfb63dfc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0ed9102-0d7e-400b-8e6d-fd54b991ca49", "AQAAAAEAACcQAAAAEEaZrJsxZZn7BPIfzShLXveOq3FTm3TNoSUNk/i0tZOS8sNqpMlFR6ngkBfk0wjISQ==" });
        }
    }
}
