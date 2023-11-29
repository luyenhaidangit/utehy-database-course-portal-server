using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableQUestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QuestionCategoryId = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "295740eb-e5e5-458b-83d6-a029a87531b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "8d561b55-00e1-4150-99e2-93389541af8a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "8a962b89-094e-4237-b239-50e5b5effbaf");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af6483eb-8d57-49d0-a1ad-70875174a031", "AQAAAAEAACcQAAAAELIwk7LLGYGs2x5X1D79laPF3G1h1wtQlw/WQYZsacRuCK/3kxIs6/LrhabfXvQP8A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "491cc615-ff8f-4f0c-bced-a5c40434166f", "AQAAAAEAACcQAAAAEP8MxxA0wFqn3L2NUMTTe5D5KUZOaNMFP8GrCuknPI0QZxr7onKhFvv8ebo0MqC6Pw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4274282c-3eb6-4aa3-a2d7-4d60d171bf84", "AQAAAAEAACcQAAAAEKXIPuxDdt7GsIHlInXTu5hK91KtdsX2ycBsE7r/RJU4WHdfbfw7S1xqD2exFWIuAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9d05dcf-895f-402e-bf21-43eecd9334c5", "AQAAAAEAACcQAAAAEPpOqQo/k6k+Q4h6LxXDQ/lb1yVFHR6fbub99SohnvVk4xvqMPS6xFXfCTvr5gKpdw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f971ad4b-efc7-4a44-8276-3005bcec5c2a", "AQAAAAEAACcQAAAAECyS/nzEJGnJUMC9x4tZEH8T5K0gIhEbdomMRoUkZQBBxMkFdQNEJK7PqcC/LIm9Lw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "602eda1a-01fa-45e4-b122-2ff9f5e5674f", "AQAAAAEAACcQAAAAEKSj5auvUQHHIzDVKi0dkGvGSHGWkFxDtXkNWlsD0LMKCK6n9gUBkFYB8JyTEDtoGw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f145a968-2119-4b9d-a649-e2c376da3bc4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "94f85809-dc4c-4d64-ab48-5ab41e513635");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "3ed451b8-bb20-405b-87c6-db4aa91782ec");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d68c600-3474-415f-8e24-2b7ee76cf9e0", "AQAAAAEAACcQAAAAEB8Z2YncZ7tPQjF604QCnvCK94SlLaYVd1kzBr4Qzm4VbmL7BnxGBUPkEhAUkg5ppA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d88764a1-aee5-42a7-86f6-353ad5cc8397", "AQAAAAEAACcQAAAAEFjCqvd7zaPW/oldhMwI+fKIP1rhIHyO5uVHSrdGRhpPRgfbFpNGBfs1w/B/i47FxQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3bf066db-e7fc-4ba2-962a-d4fa8572f80f", "AQAAAAEAACcQAAAAEFKXbzUIZKoOTOO+7w1NVo3kiwa04lDs0vIPz+ApNDVbs9j8/fkETLl4ujJAdh37EA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa2052e8-c025-46fa-8649-90d795fa8baa", "AQAAAAEAACcQAAAAEDQ5nu14Y1nUmJhq8WhFE1mzZHdshC8ChHoNo+DGZNHsOUTtfz92zirfIXRW2t8inQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16393c98-6ab7-48ae-9614-d6a6fe5bc63d", "AQAAAAEAACcQAAAAEHEytNfstagSwXCNqpssURHWMNCh4A6Iadw3pSQdWeFmU3qHLH06gFBRWtKr6vAFJw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61ab4635-cbbd-4870-ad8b-516ae50cbde4", "AQAAAAEAACcQAAAAEGsAe5Gy/LAHYw8GsUDqzJWz+0vbAEXQnx7c5MofWKSjJyaqdtGUEiJF7VbsLAGcHA==" });
        }
    }
}
