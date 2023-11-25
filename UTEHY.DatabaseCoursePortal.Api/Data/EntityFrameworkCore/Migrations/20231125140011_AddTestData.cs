using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0d395d4d-85f3-4229-8e8b-19c9acfc9768");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "ac1cc0bd-7f98-422c-9481-f30a49d934eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "81e2a260-b6fd-4a3c-9623-56a2f9975b8f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5dbaf658-7551-4d5b-ba5c-96b892110f78", "AQAAAAEAACcQAAAAEA+IDM+rOoxtohfK/f2rmJenefrTyi4FIyshiELKfJpRcg0Lkv7K2nXYg1IpT59sGw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "afa5569c-018c-468b-9706-c7303f3a5c85", "AQAAAAEAACcQAAAAEKDO/PA/BFnuJNMfmBLVuN533q4ph2EhcKJHB32lVRrq6nyX016UwljGf0RvjYEslQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8211f2cf-a9d9-404f-9882-8d9ec4ed7a2e", "AQAAAAEAACcQAAAAEGePLxXk+zvv70uckdtKWn9RzGuMJm5qkhb9EWouyzQ+yKOZjk7Qf4ISvNhI2GkaWA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "efd636b6-fdc1-462a-8a3d-679e3ac71746", "AQAAAAEAACcQAAAAECeavf6adzjNcdqt2aTeEk8cZ64bvJiGehN0IWhrKiiFiX0j2wbQ64+QYggSitMLDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "728ecbe4-b7dd-493d-a335-81ccdc43bb05", "AQAAAAEAACcQAAAAEJwbgN+T6pKKfbnIP18GSZFHhuulCa/omgqlXwStSohT4/XCOFKmnAh3OExQbesRDw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a4eda51e-6593-487f-b721-02d994664584", "AQAAAAEAACcQAAAAEJGKWOV+9DsdVBtQhXnMS+TNRPhVczb/NqCvxgxWd+GsjnoF8gsQALIgeZtUmzjsAw==" });
        }
    }
}
