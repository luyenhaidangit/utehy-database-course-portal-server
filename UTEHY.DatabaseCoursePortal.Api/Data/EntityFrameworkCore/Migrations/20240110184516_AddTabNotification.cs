using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTabNotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotificationGroupModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupModuleId = table.Column<int>(type: "int", nullable: true),
                    NotificationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationGroupModules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f6ffb0a8-1213-44fb-9b48-8381ab360aba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "7841db48-eed5-43e1-a9d2-e46794b4e99d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "6f4897fc-9d0a-42c3-9f5e-d690ae74a048");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1c5480e-ac36-4921-b7dc-7a1de3458b04", "AQAAAAEAACcQAAAAEId/TYYZxcbOFiZ56dzGZ32ZHIyBN6fekj7ozTOgr/OIyLNTkbSeIpaAY/e9uw9cuw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eea96a32-137b-44bd-a055-ac2f4df5bee3", "AQAAAAEAACcQAAAAEA+C/2xU19lPyauncEMARhCrH6Z06YNTFhfg2fqaixrIPEDz+szz80/5HO/GB1HGuw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18354e29-7021-4068-ad2f-15a26c8bff6e", "AQAAAAEAACcQAAAAEMw+k4Js2DTXdjLHW0K2QRFmEyUzTGaxikZ3Fu/lB6pIH4MsdGV1dQtxy2CDvgTdMQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa311d1f-e405-4227-af93-7eb08d2bf1c5", "AQAAAAEAACcQAAAAEPgmrRHo4BQ304MHV8PbiFzpqOmZQIWaLgLM1VPm/Spvrb8/lcICngDkbHKImjIsvQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f250c0d-848b-4cdf-a15d-a565161370a3", "AQAAAAEAACcQAAAAECkAI9S5NDNfxC1tNq3feyhk96N1DIdj4+CTNkpz7oU1AGvbMVFg0FMtNQtjI3aG/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82d5ea41-32f8-4a8c-b294-8ccbd504de9c", "AQAAAAEAACcQAAAAEBrphK7x2k6QwPvJlp2X71KcQ8trPtqbDd/y8E/4hRlVcLpSQkEAWhg8XEB8E3gjDg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f94e9ccf-48f8-48ca-84ea-c1d2e9853d71", "AQAAAAEAACcQAAAAEApYXRk3mfQMBQ7fX7eSj8ZEx5dkW3hiSxWZORnD5KsIBvHzjc3c32aOGy3qmFkM2w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "152ba1b3-518d-42bf-8d85-b0dd7a18b310", "AQAAAAEAACcQAAAAEPEZPcfKEOeKPVcGr3n9SD/0Y4EF1g+l7PKBNezcfKByHF9HKLytdx92/yCgjt2czQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8848b697-41b4-483a-9a0f-956a57f74fc6", "AQAAAAEAACcQAAAAEBubpqP/SAI/dn2OgQebLG8DWVaywA7RYeaNX+eJgAJlcQV08xvKmobtSKaOowar9A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationGroupModules");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3ad3bd2b-6bd4-4a31-a05a-e7bc1262a816");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "2a74c407-873d-44da-ac08-73270c1d1f0b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "559234d8-7d14-4473-9a5d-8267ddd7b870");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "606049ac-6da7-43b4-a163-de548c9a4806", "AQAAAAEAACcQAAAAEGFXS/WV8RbbI5cPeoGV60U4cZ+si3cwZhSrCffRtmVkXcLv6qKybMnANbN4TkkZtA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eaed8c3a-0403-4ab4-a707-6a14b6ee87ea", "AQAAAAEAACcQAAAAEH43y7cUWjayYdnhSg4qj2hvCZ1iU4E7uATOV0lINnWgfmfWLpt4Bwk+M4LDLB5cFw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b47747c3-5a45-4214-912a-c01d9dd0bc45", "AQAAAAEAACcQAAAAEA58VuxcQfgjHfSXbqTNYnWu1NVPpVXU2Bp6miLLnBTVo1JPBSblsVecRX00toFcWA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8510e87-225c-44f5-9f0a-36af612a212b", "AQAAAAEAACcQAAAAEJKumi1+nHsuKnOPSSuOiT4FNS1bEBMtqOEwb18r7/Vjd2kzmkY366myyZzHjCWVsA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d92d5039-5cb3-49ee-8896-a2d9762c0d8b", "AQAAAAEAACcQAAAAEEJf7ATVhed0e+kH1jXnNC/pVq70wHB+LnHlZrdQAvEpcZ3trtDHO+FCRIfMJJPnzQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0a2d11f-bf97-4319-be00-89930ba6c4e2", "AQAAAAEAACcQAAAAEA+fB1u1tozxF/r5OvWu+X9bqZ6nIFlXzlwcs8MdG6EnW6GSwqNwigBn/thLp5cIZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f86ecc9e-36b2-4ee0-9f54-26bef8e239ff", "AQAAAAEAACcQAAAAECUHF8XzFItVm2KYvpmpxwvoAlzdEg5tKnauX39yqHe6qC97Ea/w99TS+dXrY1Oswg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15a19efb-dad9-4b8b-84d0-b4c1609e22e9", "AQAAAAEAACcQAAAAEBeF1OEK1RsO/ksh4NMw1IQEEkYU3wKZv3zRDfSBQOS7W8G45hQ+kXA+d+MHOK4zyw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a2b3d8a-7c5e-45f4-b162-875396a8de9c", "AQAAAAEAACcQAAAAEKk6uzmrXkIMQtg5KBltOg9m2PxMOhGikfrgUr6A/yJinCrzBCLTM31EOrnWgiWh8Q==" });
        }
    }
}
