using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddColumnToTableUser10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sex",
                table: "Users",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "50fb4372-9964-4b9d-8b66-ff4a895bd105");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "3d47e095-0ae3-4c80-aab6-7a1ee184fdf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "8b16cc0e-6cf7-4e53-bffa-54ebcab810c7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cb9dfc1-09a9-4d22-9a2b-3dd4bbbc5018", "AQAAAAEAACcQAAAAEBCSlPWFxJDlmUEIj5r4XhzuBiMshTLGq6eHGZ1TegSrwDe4pBeCqCnUt1lyCiRggw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "acd1c14b-6ff9-46eb-bbd7-71b589c5dd5a", "AQAAAAEAACcQAAAAEN+ov66v9548rFctz/fkOxjde57y48Avpwd4JEzHGnVjFW8/G9dewbj5lo20sGCHcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42d5d7df-7e68-4eca-bb92-b6352b652748", "AQAAAAEAACcQAAAAEIc1uWIxzBZBawGvTUuOaQ9sx5UndyYz2RQz0e9HEU4IACtMhWNmcr17c/L713FZ3Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "593a5a4e-2136-480b-a55c-4e7a6014170c", "AQAAAAEAACcQAAAAEPwiWPSeZNoKNKddtWGJopWatoR4hQVxpJlHWviD2/fO0jcl6A1UABOSE8tojcTubw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16a6bc91-891b-4a1f-a581-b1d600ec3878", "AQAAAAEAACcQAAAAEH8ffHGFx2N92mjYqZdEG9roXMRiaD23COi35l8WnYjGZSfXOcYEnNowbIPIUpRTUw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e1eb60b-56c3-4014-9c42-d8e5498daf58", "AQAAAAEAACcQAAAAEMSIm7WgEd52l4QHydWtBTp9VmWmUOSSb7ujLNgyovmvg9BuTNseIjgZ1L5Dogc+Eg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce1c9952-c9be-472f-b8b9-d84b4fa1b7de", "AQAAAAEAACcQAAAAEA8UGRY02hD9yJC424CNvwVUffAAAat7sjpwGKE8ez6DRXkMUAJwJaUlHxJLbk7EJQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3678325-fac3-48a2-b139-300d33748606", "AQAAAAEAACcQAAAAENtL2h63VBmjkf2vNT6CqLaM7vJ3CYYAyTqdfLBtkeeBbB5W2QUnT/omrK95rMGemQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fc56099-d864-494e-93fd-d08f2f4316e3", "AQAAAAEAACcQAAAAEFDRAxhsx+EWJ0OlPZ1XGSpGJsxda6Uy9jZThHdaonFq2khLIndCvIjVNnxHLnMe/g==" });
        }
    }
}
