using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddSeederData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4e4fe9c7-2d6a-42d4-9cdc-4307323cf103");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "06143861-c0b4-4588-b3c4-6f530f142dea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "97a09586-98e1-47c6-bccd-1c49e76b3f3c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16e16403-d518-4ea3-8292-7f33b0b5b11e", "AQAAAAEAACcQAAAAEAgwrdFM/FolmMsfkgDjA7ztFvjqNR2NC25EP60Rd6S/KDf1/BTkcX/q6a3jvq8P0g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41c55880-7f9c-4d6b-a8d2-e65d21fe66e3", "AQAAAAEAACcQAAAAEDmAK7BRcSySeL8UE9hrU2R7d8BH7K1KbnYqym/T18DFi7uvGdNguthXFg74Ga98bA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9be5f47-0e68-4fd0-933c-44b164febcf5", "AQAAAAEAACcQAAAAEGui9tYNg4kk/IwJcvvydYJjKiqVzoiC+Fn0v1/bzvOg9WPGiSvZ23NE4sdhO9THtA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e86e294-96f9-4dde-bc02-b2e53013c96e", "AQAAAAEAACcQAAAAENpf72iaWLWV67OQNHjPXaKHi5eSTCebUJwPYK63NvmaS/m+ddVYAW3xO52FDQv3mw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4963ccdf-5eca-4f5f-8157-3d8f54bcc421", "AQAAAAEAACcQAAAAEI7vJNKH23ssyaG7N5jcDywfv7KX2cfbtRnwXkosO/6InLFcoCj6BVn33IhRJ94evg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc2e067e-5144-4913-944a-f31c6a5b797a", "AQAAAAEAACcQAAAAEAzuG+5DXjGqWpFMD+BFYy0nFMI8AS4W/rlYNWsOiUYHHuAlKCO+GKnNlbubDTmnYw==" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AvatarUrl", "ConcurrencyStamp", "DeletedAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"), 0, "/User/AvatarDefault.png", "3240e60a-f57c-44a0-9b35-4dbec77eee89", null, "phamthanhlong@gmail.com", true, false, null, "Phạm Thanh Long", "phamthanhlong@gmail.com", "phamthanhlong", "AQAAAAEAACcQAAAAEMP+SvGb79NYPfZHJrqC1hfGbiSrv1py6EcSSnURL1s7U9GxxC1o2qCBlDyp4cb8SA==", "+84922002222", false, "", true, false, "phamthanhlong" },
                    { new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"), 0, "/User/AvatarDefault.png", "e837b73a-1d55-4b23-b15d-e65ab9a9d3c7", null, "buixuanhoang@gmail.com", true, false, null, "Bùi Xuân Hoàng", "buixuanhoang@gmail.com", "buixuanhoang", "AQAAAAEAACcQAAAAEMVBBXOmaVDBO4hPwpkhOrremtNUcJYrqAhgZ93i/DiWjxLDm73pRX64IV+O8t1O+A==", "+84922002111", false, "", true, false, "buixuanhoang" },
                    { new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"), 0, "/User/AvatarDefault.png", "f33cfa16-1aef-421b-9a4a-62e58d50e6c0", null, "nguyendinhhung@gmail.com", true, false, null, "Nguyễn Đình Hùng", "nguyendinhhung@gmail.com", "nguyendinhhung", "AQAAAAEAACcQAAAAEALpzO2RGtyldLSrnWAudUHvjp221hm/JBvYOSaMYkZ7t7zu/Ywf43HB8EBko5TlzA==", "+84922002333", false, "", true, false, "nguyendinhhung" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "90d4a00c-952c-4453-8329-542d758d0dfb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "26b89274-32a5-4e23-8e25-f483b9677ef1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "c94cf842-f45c-4590-b44a-0da3f53043a7");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0a78081-1078-4e4a-834d-8e7236207fa3", "AQAAAAEAACcQAAAAECeemAty41hy7/WElLnacRgGwGTp4vE13Y8KRviEK6jHoyAAkrLpkIyw6GMdu3g9DA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e6e1590-eee8-466d-b4bc-8dd177ace850", "AQAAAAEAACcQAAAAEPb+h7kyLIUAYeHQRJHxuq75ZR/yo8R0FJNJWS2TufzDLgn7tLMErOn85R4S3ImncA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc6bfb7e-f563-4f99-9c43-6220291a9939", "AQAAAAEAACcQAAAAEMzAEvi+BQXgY5X7I5evquHVkbgfCvl9vUgmAEL2BCSnBucKkfkcpk5ERyzRVlcw4Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7941667-819e-4555-a32e-26428a517789", "AQAAAAEAACcQAAAAED3uSOwR7mkS6xkAycX4mTePpVzvLsLFVb7bJ1uxh2/PqDmJIZ8d2fIRtoeauep/Qw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db4deed5-86a7-4357-96c8-83a565d217b2", "AQAAAAEAACcQAAAAEIK7K4snDbm+T+0sP2Zhjiln2AguoD+c7zOwV/iNhQz8xate+qfWNCZo0Qeis/SIgg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc5e19e9-d408-4cb4-8f0e-9835ec5b1f72", "AQAAAAEAACcQAAAAEODezpjoy/6saMrV6WU7wn6KTuoWJpnd2195wwDbAYqWGQycnX1uEK+SbbF1yuaM8Q==" });
        }
    }
}
