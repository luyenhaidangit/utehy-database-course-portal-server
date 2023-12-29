using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddLessonContentCurrentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "UserRoles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessonContentCurrentId",
                table: "UserCourses",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId1",
                table: "UserRoles",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_LessonContents_LessonId",
                table: "LessonContents",
                column: "LessonId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonContents_Lessons_LessonId",
                table: "LessonContents",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId1",
                table: "UserRoles",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonContents_Lessons_LessonId",
                table: "LessonContents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId1",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId1",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_LessonContents_LessonId",
                table: "LessonContents");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "LessonContentCurrentId",
                table: "UserCourses");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "95064f14-6e7d-43d5-974a-f669048173a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "f2ecc5c6-a4f2-4baf-ac25-48820ba360fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "86f01939-029c-4c30-826e-e4d3b292cae3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84e357ab-5063-464a-af71-20e68a49db7c", "AQAAAAEAACcQAAAAEOIWRt5XIspB/c4QGVdi9gO3+cPZPKTg/Kh4PSNZ/a/wJybpx6+zOzwA/GdiJmOz0w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b2caa14-309e-4040-a185-ca91d46d4db6", "AQAAAAEAACcQAAAAEEmB1R81MQYE3+hzP4+gVB+9bCkUl0AYZXw6GR4orSeiMlWG6iqxW5lQu4JCavztFw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3fc93f7-34e6-42f5-b237-5542527f664e", "AQAAAAEAACcQAAAAEArgVOcQ4+j19VJ+eufLsvzZZnEY0mpJXvw+aOHsyB/Lwd9zVTgp8EIrSE7QsPCQAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6440d300-e445-4c0d-9f40-b9b8a51e4c85", "AQAAAAEAACcQAAAAECQQpmb+G47HSu2CVnWL/MXBKgMz00RRnyyoOFipwGdHvpoxONY2SO0IabPaYrXefw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7debf9fc-6e22-4cc7-9a77-9a39b79cddf1", "AQAAAAEAACcQAAAAEA+N/Cq8Z5LV4oVa+WcCQDZqi3KDztJ506QITPxxRrJ9IpMBO7uI8SNKeQaTHm68zg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de65e824-e14f-4512-97dd-45c86dffec61", "AQAAAAEAACcQAAAAEENCUIBmUZAmaARG59oHqj4kggEKUCVWPMs1Hf5l89DDqsUKgOtgeBWmmu3QpXW3PQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15a64be9-eea9-48b9-988b-f1852d13fd99", "AQAAAAEAACcQAAAAEGDMKB93yWPQeiOiaT76Bxn3hclcojvZNsr9AmKFRTmES9czfjWCPRALV79AZeSuvQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58e8c489-1567-4b33-80eb-b5a8c554ebc6", "AQAAAAEAACcQAAAAEC4LqvPXkSwqkaNDpP7kwDADdHrImiAn58VmogkaWdIguhrx8mF/dg/sNJft6L6ntw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c54ff148-a9fe-4874-b3f2-8fd5536af4ac", "AQAAAAEAACcQAAAAEMBfgatSuA/WIl2m1UrAo1IGxdWrj+WhV1xXeHWmZCOCtTf2kpZ9qeWDVvNCvnfRGA==" });
        }
    }
}
