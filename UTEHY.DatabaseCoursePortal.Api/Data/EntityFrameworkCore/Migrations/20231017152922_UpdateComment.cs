using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class UpdateComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Comment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoCourseId",
                table: "Comment",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "64c9dbb5-221b-4e9f-9f5d-96b2e1988d57");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0b13b96-4bfc-4c78-ae12-60f4813b487f", "AQAAAAEAACcQAAAAENJBvr5Wky4VcZKwERNtUt4ArhewEt5Pjevnr65U/V39qsE9ooo12tgE5IWBD2qgmA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "VideoCourseId",
                table: "Comment");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "64d56388-f527-4b8b-9586-2fdb394ea344");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28fd2d15-82a3-4bb1-a122-545c1293ae7a", "AQAAAAEAACcQAAAAEGs6/TVq2l/og1xY/l1kFH+Ol0bDfhgqs4tUAYvVMVpAcCk1//5QksIFumk8H2EX1g==" });
        }
    }
}
