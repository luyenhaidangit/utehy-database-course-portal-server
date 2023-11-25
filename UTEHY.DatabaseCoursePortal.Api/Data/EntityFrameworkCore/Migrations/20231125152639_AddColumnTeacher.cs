using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddColumnTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeacherId",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "998b7ce7-2e6f-40f0-892b-f84cf6fce1d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "d0d0f456-b434-48ca-ac97-bfc666db7e14");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "ef03d57c-78cd-4722-99cc-184039e7ddb7");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TeacherId",
                value: "12520001");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "TeacherId",
                value: "12520002");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "TeacherId",
                value: "12520003");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69e5bdef-a0a7-4e5e-ac0a-7f79fca2a994", "AQAAAAEAACcQAAAAEFHe66R47qOBVjNEadHU9dXCsI3QOeYdc2Jinjyl9zHhqaBomeEm4CiB0AcP93WSPg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a2d59859-de6d-4293-9e16-28fe56790be1", "AQAAAAEAACcQAAAAEPdHE6J4U0YutoTsVIsmPr1xXwIsFeaSKgCwG2k8mU+lbPM+YNDBO7LoK6q3WvMIGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a16b975d-f48a-4c96-9e83-7ea28865f6b5", "AQAAAAEAACcQAAAAENXthXRVOdqMyr1FcoA7/vS8SHsLeWFGDA9MLixeEqJeSMHvHmkHlwJ05PKvIjvN1g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a696c3a-afa1-429b-bf5c-fb3c6a7c5733", "AQAAAAEAACcQAAAAELTuffPNw8dgVzYncC2/1VM14lT/6G3tmQshYnAWs82RUdbB3w4YvbybJcPpjVmk9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b65d06d4-1b74-442b-bbff-56c87b4c651a", "AQAAAAEAACcQAAAAEFrz3YeZOraFy6/Fs5zGmTBe045ny1wrv7Sj+L09ntVt8WR7xacMvxxpzV2UfUcr2A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1b9e785-3664-4973-a974-2c5d50d1a6ef", "AQAAAAEAACcQAAAAEGGJr4c1/AmANwyBmURzGt0I0CckmS5Y8Qmy/0yoFsROCJ9DqyewDbL66WcoNgCamw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Teachers");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "27245067-7e6f-42e6-9303-131d467d7ad6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "435723f9-77b0-406a-94bc-3152a777a72a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "6d17c8e1-f8b5-4b9a-b3b2-cfea33633cd3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2838d5fc-b021-44a6-b2b8-dd9122e77068", "AQAAAAEAACcQAAAAEDFBWJ0i1q8xQC4TuV8CjTez5inHxQKsQA5IVcAUax3m5l3hZj/zUb6zuVYfBb4ugw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9c49fed-b8a9-45a8-9c94-bd9a54c568ce", "AQAAAAEAACcQAAAAEDO3Wshg8ewSE5BCiyjnfwr8GJoGS8wltbJucZ0eAuW+/vwZL91Asx1xe0lS90/i8A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71e8e5c0-5a53-4840-80a0-3dd51cfb24b5", "AQAAAAEAACcQAAAAEC07Ksx/KxofTYGACj0Ocf7syxMiD/ip+Grq+2zfz1lZK+umofB2Qgz/cpaGsG3kHw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "275fd7e4-092c-46ea-b85a-5872e15d9f50", "AQAAAAEAACcQAAAAEBOblQdjYsCYDqKQQG3jI/CZYt2D7mIwxDXtL5V3OCtTlOHzS9BZFOuOAwxFsEf/oQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b68741c-d732-4192-bbb7-1e35416a0260", "AQAAAAEAACcQAAAAEKqbenw2IugP49If0Q4ll/N398O7vxHObNt5AggBPFr4zf5s9BM5hOnk/PrGr8mjsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "086bd84a-592f-4346-8286-e29a614d0b1b", "AQAAAAEAACcQAAAAEAma3/MbtRQFy55t/lqL6l11Xl44kLJECfE8kpnBUhSegI1idl3ZYsPfp6GYCBhuMA==" });
        }
    }
}
