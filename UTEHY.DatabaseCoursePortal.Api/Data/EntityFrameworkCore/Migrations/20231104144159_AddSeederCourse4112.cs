using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddSeederCourse4112 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Kiến Thức Nhập Môn I");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c4a8082c-2d34-4d2b-a922-b96dbb89c8d3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8bc999ef-8be8-4764-914c-7c1a917cf390", "AQAAAAEAACcQAAAAEIEDv+fMpA5VeSb6/gX0NtLzkcXNrv6oMzOx6KdYIDFwhOhMAceKCkj13zyYF0p93Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Kiến Thức Nhập Môn IT");

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
    }
}
