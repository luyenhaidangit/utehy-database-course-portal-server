using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddSeederStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "StudentId", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "10121910", null, null, new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6") },
                    { 2, null, null, null, null, "10121911", null, null, new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1") },
                    { 3, null, null, null, null, "10121912", null, null, new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1") }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9c01cabf-a58c-4832-bcfa-a87f8bf94a0b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "4a73f04e-bf5e-431c-8793-a81711fc6391");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "144a26ea-9b75-4ef6-a362-5d0c5bdd78bd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10f679f2-e135-4854-8c66-ce0dfea5f079", "AQAAAAEAACcQAAAAELxxAP77K/GJpQg06JbptcO0VGPaxeIkszYnLwLBm8ICrIwj/LfACNRv3HxuoUy6Mw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66d33749-b1c7-48ee-a4db-6e8a77566adc", "AQAAAAEAACcQAAAAEPG9wbqdhZpyEOr15d1rB7cqds9Eg+8CORLqCD1VXc3U5xC3hzAxAsykB+V79rU68w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b11e5a63-3154-407d-88cd-6e12f7afb2ea", "AQAAAAEAACcQAAAAEEhYlBDlHeFi9VfvI402ob0/y601eRfNqoUltlVZxyatIXuii1cXaVu2E5fC2+wkOw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb0cb000-d647-4ee2-b143-02dd7e3b451b", "AQAAAAEAACcQAAAAEAvWXUWjgFbzfxtJZxFt7h/Ux10hFdOiXwf/Y7RXoK9VIMMc24fviDROVMcmzJQ27A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ca88793-7908-4517-9e83-32be0adb8ad0", "AQAAAAEAACcQAAAAEI7N3ysDkZD4sGK8Geax8d3bbFowfyHcdIKURk2zujRiIrI2lvT3HKfJsFYb2uzL4w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "05f05725-ae89-4c2d-8dbd-9ba6ac65b879", "AQAAAAEAACcQAAAAEOBbMsTTncqJgXXp99arFr+NoTNCPfmNetKkUGiDLyNE7R8gS2ozjdK2L3hXj67BRg==" });
        }
    }
}
