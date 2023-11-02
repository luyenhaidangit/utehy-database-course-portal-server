using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditSeederConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Số lượng khoá học hiển thị tối đa tại trang chủ");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "39391931-41ca-47d3-8073-3ec761df2b3c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "22095f24-19f3-4173-a53e-96b0a8d349a8", "AQAAAAEAACcQAAAAEKal07InLp3QldisuxxdVreW3d+Gg+TejP4UE1qDWL5eO6yuIpMxUumSefrQO9p5FA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0b130421-082d-4ac1-916e-591e2414ae95");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9652aa32-0083-4d09-8e05-e61aa138ee63", "AQAAAAEAACcQAAAAEM7gO4HVWA5LIzoPf9dmhkzax1R2/60p0PvxuMf667RLaOC4cMzgp+BUL8inN59TWQ==" });
        }
    }
}
