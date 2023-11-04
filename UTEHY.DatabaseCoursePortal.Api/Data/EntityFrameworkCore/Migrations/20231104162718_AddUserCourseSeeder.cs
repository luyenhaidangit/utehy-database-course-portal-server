using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddUserCourseSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "86530f8a-5c0a-4616-bc36-af0b82c18f2c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "6287126d-f4ef-4a4a-b4fc-765776362616");

            migrationBuilder.InsertData(
                table: "UserCourses",
                columns: new[] { "Id", "CourseId", "Progress", "RegistrationDate", "Status", "TimeSpent", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 50, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 50, new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192") },
                    { 2, 1, 50, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 50, new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2") },
                    { 3, 2, 50, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 50, new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4d14d27-e701-4413-969d-7eae2bf17b99", "AQAAAAEAACcQAAAAEGTYG6T3dIbv4u0tDLOTvhjbzRZduD26AH/jpbX+Hj3aayq9RgEhbYxuVz2rbJBJKQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "987fb868-741a-4367-94b0-4e82226efa75", "AQAAAAEAACcQAAAAEH6bkGUnZrmN5VvEoIEax38A0IbMrI1O/kY4i0AjX+2s9hOeoMKvTu6l3lurKdlG0w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9dff6d9-a1e5-462c-b7d3-90c8265399e3", "AQAAAAEAACcQAAAAEN4wxh8NHjdmmhN0TqIyLn4SM2hohOTlTLjZPBSKzq4XopuNDcl0U45zAuc8FxV8fQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d3dcc885-d271-4c13-a71d-fdbe2fea9890");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "b0f9be9e-bd98-452f-b17c-766621d21db8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c36d6804-b3b4-496f-b8e2-00c085d78e0d", "AQAAAAEAACcQAAAAEAoz+vrW/QH8IVoELCabnFEhJ8TUpYOxgSpGGzE1JDKh32QWrhSXpuePSLLFIUpJiw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e188d53e-7ae0-4d52-9ec0-3a2f1b46bb7b", "AQAAAAEAACcQAAAAECETpK66+UR62m2ksfrfkEmCkfk8++8vkOOB82jZrCMXO5tq9ZR9KNXgcDlkvy+iYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a8bdcaf-9095-485d-bc04-c94d459090c7", "AQAAAAEAACcQAAAAEI0WyZ1PnRHN4xifXIj8aR9rldkV4w2kD7u+gPOVgPbbyTrCWo4wylcIe5CtGbTwuQ==" });
        }
    }
}
