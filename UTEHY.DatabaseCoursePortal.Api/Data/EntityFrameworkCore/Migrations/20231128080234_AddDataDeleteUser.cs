using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddDataDeleteUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
