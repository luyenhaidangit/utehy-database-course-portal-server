using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddEntityBaseForTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Teachers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Teachers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Teachers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "49a40972-f072-47d0-8597-524d1fcfba98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "7e29a0f4-d764-4b1d-a8cc-9ce390621f45");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "bb2c91f6-6fdf-4c17-9d82-a1d5ec097fa6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32f6f110-bdaa-4b21-99c4-b9d54a40ce5b", "AQAAAAEAACcQAAAAEPWA2IT9querBb9Q3uIFOrabdyWV4CvUoXcjcXppDRwZHId/CsLi7PHtYWMSeJjAEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3ce8f39-c3fc-4b2b-881d-54410d4dd9bc", "AQAAAAEAACcQAAAAEDCQRYu+Z3mzPLl/TeBzLcV1Bxq6v9XYDquU5qTFpvHnLxJmSzS9anDYFJh2g4a8lA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9982fae-181a-41e1-9d58-ccdb8fadaf01", "AQAAAAEAACcQAAAAEKp8ZwMzU2CphNzc1A8UAP7Xv3AlzV1ZPxbYP6xrPY6D+dxThVp7dV5Pv19eFS4N4Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2063ce55-5793-4c6b-a317-7132d13e6b29", "AQAAAAEAACcQAAAAECWVqCxwHBbqrcYiZ3HQ2ZrvjjC8QoxA2qn871Yalt9JjvmwyIEoVWWVcGVX1f4sSw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b19828c-9ff7-4bf1-8ddd-6da854ada522", "AQAAAAEAACcQAAAAEBv9ljUkOrMznwBHSacaD5UZNYBVopqMxsAN5WgMgkX5kZAwi40YzW7siXkiDuvMZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4aba6801-e196-45ee-941f-d981f521470b", "AQAAAAEAACcQAAAAEAwrRw9IJRCY+D8DaE4pd06r6ePlvwsM5jgI5S3UJ0nFr9BWTwmHRTwpj44L2bmhIw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Teachers");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "18aa6b06-eeb0-4c72-b167-fb146f41c372");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "94e2cc59-4deb-4596-9cd6-adcbbb5530b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "2342427e-9bc7-4e54-9c51-53964e145c40");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4199a771-ea36-47fe-b2bd-771bc3b18bf0", "AQAAAAEAACcQAAAAEORxdm95yZf7QV/sThdOoU3QhrPFNPqZ3VcoBjecz1uxuyF6JmopTWptfCIxoWaEPg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7736955-a1cb-4b12-b954-073813630a13", "AQAAAAEAACcQAAAAED4hZ6r37qIRUshCNJO9YpZuuvrWQsXgl0Mns1uyfAzNJtrSSYgmw5s+26Y8I0HQAw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d89081a7-20bd-42bd-b18c-b24a306e1565", "AQAAAAEAACcQAAAAEJQIEpZ6CCFbwmPRAJDBWolXgvRSPQQ6xlbFAPfJ0kqvsCY7IJLgLQ1weySU6yzbMA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10f3a653-449b-4fab-85e2-ebe56c2b9a51", "AQAAAAEAACcQAAAAEPe0W/FqeeOEOhdFCC1pY1Z0uS2h1mZcFIOoVeNXWqePvWhr26MSZ0+Mx9Y2Mdo8yg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ca147a1-f0f0-41ab-859f-7c832c0ee7ed", "AQAAAAEAACcQAAAAEI/4dXsF0xbbQiOcsEHFK9JugN56edX82Gc+WY2s7Cl1WHfbDEPRo+mE5GvER4jzHQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06b95854-e554-4091-97e0-bb2206a51938", "AQAAAAEAACcQAAAAEH2EEuHmPGmQsbb0HXZZiyJIXmNN8VQgM46qRQwIpTcxp3LE/F1/Guyo2Zvzi/N/7w==" });
        }
    }
}
