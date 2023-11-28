using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddSortDeleteUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "fbda67e9-8fdf-4ca3-8b63-26001cebe802");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "a2558b21-0232-4f17-9278-003c841eef03");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "9709e2ad-1666-4303-b9b5-22e0314e14e2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dbfe2dec-d7b7-4b5f-ad73-fe2f230121d3", "AQAAAAEAACcQAAAAEKWpijOLvs/UD3YRM8sksb6phhhEKMJjCIFkTjX7FBDeCJhhhU3kKykoCvi+PRhyOw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7bcf2389-d17e-49c7-824a-bb6030926ebf", "AQAAAAEAACcQAAAAEKb8OoUzKGRdRqpTfalb0cJowa41OjaX9DOuE2RrTTMbaeD4SeoWCcKnBns6FRw2pg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f61508a-fa62-4ea9-80ef-b68a1c210302", "AQAAAAEAACcQAAAAEK335oGeOmdE8JKnzXmO9w32pTJLmjlpKjKMdDYx1mnHRNm8MtuNwOSi61D3mp5odw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33bb830a-1553-4e0c-9909-e3633a252052", "AQAAAAEAACcQAAAAEDhHx45vgiGaBEFJEuNyo11BI6BwUu/6lk3Bfy5Ali+svHk2LGDgaKAew9L2jvK39g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7119e3f4-8d36-4e62-8985-6a7df3de354f", "AQAAAAEAACcQAAAAEOeGZjV56L4/Ao2uy+pIFOPmWYJ0yrlwXsyy23S5Lod7ZcZtma9qRXirsHwbvZvTAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c70890ea-e9ac-4271-81e8-fe35c1c2e3ed", "AQAAAAEAACcQAAAAEFvvfReoedks+yeVvpB0iHPJEbYzcyNUcQRSypW1GeQEDtQCOuLtN6kV1Nh1/I/j+Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Users");

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
    }
}
