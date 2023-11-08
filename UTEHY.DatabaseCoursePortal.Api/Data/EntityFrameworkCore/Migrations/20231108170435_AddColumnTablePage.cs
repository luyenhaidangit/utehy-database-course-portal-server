using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddColumnTablePage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Pages",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Configs",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Key", "UpdatedAt", "UpdatedBy", "Value" },
                values: new object[] { 3, null, null, null, null, "Số lượng trang tính năng hiển thị tối đa tại trang chủ", "MaxPageFeatureHome", null, null, "10" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Priority",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Priority",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Priority",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0c949fc2-b383-437b-a50d-342245609134");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "461fe063-230e-40b3-ae68-f123aa61d45a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4bf352dd-3cec-443a-8c99-cbb4f191f847", "AQAAAAEAACcQAAAAEN1e/y19HNOfr0PLMqPjJ0S81dRzZKNBhhRAphyoHWy4tsi3m/ak4+8X04iFg6sXqw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6cdc134a-9f68-470e-8ca5-b545f77280f8", "AQAAAAEAACcQAAAAEApBP2Pf6VFH0egwQt0yPJ7yfIk4hSEtcKfEckKzD9UtGPQmFNgJABxB8zrG8GjneQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a626788b-2544-418c-8bf5-573ed8e9a825", "AQAAAAEAACcQAAAAECjkek1f7GmberpyqDCn3hD4xpE6Oh6TZ1UuwMOSm78BknM4elVdMJUxdk9Zwudi6Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Pages");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e425fda6-bee9-4c73-9df4-2668fad80900");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "504d5af5-4284-4d8a-aef6-84045502db69");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff0ea682-fa77-4a0f-84b4-8f2588b68373", "AQAAAAEAACcQAAAAEKuGK3jrQfczN8u4Cla8XPFT51akrupSKCmA8637sLg/UUuk/U8ABlYfQQ+ss97wXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5367d4d5-1926-4b09-ba20-d4af876d887f", "AQAAAAEAACcQAAAAEFsVnuKCOMM8a5tkgEgu7X6HauLPFh6ClxiYmL0DglFdTQ6qCwkFYkcSTroMXaSV9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9597a247-d281-4aa5-83f6-e5f71796f76a", "AQAAAAEAACcQAAAAELm0idjx3rlM2gsdiqnUHfWv/tr7g4nQqGlDK9ztUwMET4mfO5VNHiVgmjKw6RzAAw==" });
        }
    }
}
