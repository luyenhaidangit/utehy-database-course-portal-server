using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddFeedbacktoNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Feedback",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "fed642d8-8c47-4d55-9881-6801b625c059");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "f0e60ab8-8487-4d79-9edc-86009b9192aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "f96feca8-f4c1-40e2-85d9-4d6305baa5ad");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b1bc975-9dac-4207-862e-5c236aebb49b", "AQAAAAEAACcQAAAAEHftpuGXgxVGfmLYKs7+OdmVTgrHwi5AG7hio+VzCT30ClYMHO3s9WfT6eCM9qevLQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "167283a5-3acc-44fc-b046-2189a95f1446", "AQAAAAEAACcQAAAAEFuoVwuyl+KtSsPsiadSLwgfNOvrZ1BvQMfCl9knUJxMty/ACPNhyxh4Dy1j8NaGfA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea226673-01aa-4625-9de3-a050fb2abf0c", "AQAAAAEAACcQAAAAEAyXMn24zmiJY4reB4aE6kgtoV0lHt74UKx6IARfdcjVembwEcHEipZF0fJhffnuww==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4e93dd7-9e31-4956-87e7-a374aadf5a28", "AQAAAAEAACcQAAAAEJWU1GBqDeJltJKmqjgdAOQkGC1RWv+Yo1fMmB66sSUkQQLLxCQzvT/mbYI+UFj4/w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04a8b0f7-cdc8-496a-9350-3a02a2eced9e", "AQAAAAEAACcQAAAAENsTeaMKrL3Q/GFdcMKjBhnFfVpPvLVzfpg/wNZO93KgklQDnFUgHi95oxvLt0Ng5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "509c90c3-c03d-49c8-b12d-552ca9800fda", "AQAAAAEAACcQAAAAEFgSB+uJfWXY2s1yfe04FZZOiSiUoR61I2wls0mKCgeQ2KTKMuUI6zi52gfXDkA37w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de132add-8065-4d91-a198-18883e08c48f", "AQAAAAEAACcQAAAAEF89jM9iU0dB87Gkrh0uMMJFxDzdIELWvBPZbzC39rG7pz9DSTAhUrd/EjLwUjAlKw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5559569b-a57e-4945-aa3e-f38e9d9bb0f4", "AQAAAAEAACcQAAAAEO4nR86pnCaPcgygqpXfQbpljKcQ3L2rRDmTkcSrm6ps53M7oMzpdrtsk2zhJD9uAg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77103b6c-d885-4548-bfb8-1a2d5353e11a", "AQAAAAEAACcQAAAAEDclCn8+sv/p1zfuD5+GCAN4XpwILlYIReF/u8FokdAAdHsQ3LBMqwFquXKrrVpDGg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Feedback",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b26aa7eb-da59-4f2d-a44d-7ebfbfd5fa54");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "771b09b9-2d40-475f-8fb1-6ba4e70b038a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "d6072625-3284-4c2c-8937-1fca5fff6e25");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cedb4c8c-5db1-440f-aa02-86b853f2fc1f", "AQAAAAEAACcQAAAAED8A/d0pPDmWDio4MCl6ZR5THjXqslzMbczqWlrZRqXOVgE2LbgZT7Qp8rCVEDnwsA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14b8c147-18be-4410-817c-9d5085c6af84", "AQAAAAEAACcQAAAAEPNZmGQRHnZWQrfkwzNmeOn4G8140Qb5Z05x+kWvBtHAhU98Za5YEF2LXcPx0O7YGQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd1b7096-4b40-4e42-95bf-b38e240c7c5c", "AQAAAAEAACcQAAAAEFXO0G2U7GxWs5GWvrGFIIDRtkbwpAQGFlwcIy+WBmsycqhPe0WDpwoxX5AW24bIIg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68c4852c-5365-46de-8e52-e04fe79bcbd2", "AQAAAAEAACcQAAAAEOxzgZ1t3yQDkKYrjWGghtEf4AAYRi78e6+GEsnB9snVcu1cGIYX+2YJwDTkqoEQ/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfdeeb40-0139-4d0c-aee0-b7b2ceed61ee", "AQAAAAEAACcQAAAAEEC+A+UCeJIbR+Zt9Y5zMxUdvoEyMZo14+7P5SW2WNcYUEyP1nAgogTNij+sThr3xg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9404a3cd-6fcc-4061-a4d8-1f55757fda54", "AQAAAAEAACcQAAAAECBaUfcV2FY7r2Cd0o1B2UvRGtxo6X9NBba77SUmCJfLbwMLb582mS604TiNhR/1RQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8da9bc33-640c-4161-aace-0172cb63d44c", "AQAAAAEAACcQAAAAEOgpzevAR5pxGZGd3etpDoVXL/2fKIJYJQbW6mKY2jTDMgD+p8AengN+abEcFaeN1g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04da116b-5147-45cb-b4eb-4cfdf21db3a3", "AQAAAAEAACcQAAAAEPkLeIOrcNoerSxC5GvX+Z4gEE1CQJ6msVXJGlKkPsDqE2MpxBuFHc7Tit4PUPuYdA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "721693e2-0098-428e-9190-eab5348c7525", "AQAAAAEAACcQAAAAEBWrbU1LU+sjokdFwwrWtttwdEg4kXMjVyZdy/eDQjx4PGGz7bKRNDE+8/R4NA5J+Q==" });
        }
    }
}
