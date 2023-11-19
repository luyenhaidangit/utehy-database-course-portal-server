using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class UpdateDataTableConfig1119 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Configs",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Key", "UpdatedAt", "UpdatedBy", "Value" },
                values: new object[,]
                {
                    { 5, null, null, null, null, "Id kênh youtube hệ thống", "IdChannelYoutube", null, null, "UCVy9p7eBCMmHVEITk4yPZjg" },
                    { 6, null, null, null, null, "Số lượng video youtube hiển thị tối đa tại trang chủ", "MaxVideoYoutubeHome", null, null, "10" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "118654f8-2468-4169-840e-0e99e699a062");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "406705e7-7ea5-4742-b996-660c68d51f3b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e41ef43-c21f-413b-9109-85aa0e1d7763", "AQAAAAEAACcQAAAAEMsKA3WGGfdhIA4z0m69ZRB1jfI0seD2C7V9Pdsof4rRruLuiS3P/yxNLorc9Kvcug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77f1f55d-9d1c-4cd1-b1fe-ef32aea6264e", "AQAAAAEAACcQAAAAEDcDSdmcHUBLQiw6sqoMngtwC0ai3IH7IRV3UDwyCBtqd+CQyPEdpVE/vVHwh6y+Eg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9661fd3-75b8-49d5-bd7b-f028b5c102a2", "AQAAAAEAACcQAAAAEPRTAHKYAOixrsb3mFYRWzSfwIi2i/cqkSyttQSSvj1EDrKgMadC7dCOnRK32niMKQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a3e86bdc-050c-4925-a893-14db274b3fe4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "3d2fcfcc-009b-4b37-9406-15893a58a041");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b4b44db-2db7-4653-94f7-7627acba6ada", "AQAAAAEAACcQAAAAEPZzArgildp29Kiqmv5Tm59Z/f1G7coSZTkVEv40+ER/Dl3G6zQGiIO4RFhsyjGF/g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a53e72b7-100a-40b0-88d5-02d8be085b25", "AQAAAAEAACcQAAAAENwGVx3mRcifmHmdkzKiJS81gsY/8Yc9en54l09IAQNvjrjcsOokRYeMvgQ6A7eAxg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20f16b3f-92d1-47ce-be74-82a3198015f3", "AQAAAAEAACcQAAAAEPZsuQ7nXDhHKXQNvNpyK5zSc4TSXJCETKIF8sFfH7Ew7+Yb/AXeE6MWagj6hLpkQw==" });
        }
    }
}
