using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddSeederConfig11101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Configs",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Key", "UpdatedAt", "UpdatedBy", "Value" },
                values: new object[] { 4, null, null, null, null, "Số lượng bài viết hiển thị tối đa tại trang chủ", "MaxPostHome", null, null, "10" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c41f54a3-099e-4fbf-a5e5-336743a6673b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "f13258d5-a349-48df-90f7-1f76cdabf053");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d072ac1-726c-439c-aebc-e8e09936202c", "AQAAAAEAACcQAAAAEMdVz3it29UnoL8uBsaVuXqHhlZilK9AErSTNqD8oaDeNdj0TH/Gf7GhyJHyLB0odw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae6e2c9f-788a-4d66-b01f-79598be1ed1b", "AQAAAAEAACcQAAAAEO37vLJkSC4QbNiRfz5BpzzryiWBx9RNwxB+XIHxpqmKGJKNmWbiwMoBNnSYMWrOLQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d22ac1d-e91f-4bad-b7bd-95249f764fe0", "AQAAAAEAACcQAAAAEBW+u+Ao+u0uGGr5mk6VFB8Zs1gKU6nyDPBmygXG/hcobc8Cw3MiYwVancN1SUg4aQ==" });
        }
    }
}
