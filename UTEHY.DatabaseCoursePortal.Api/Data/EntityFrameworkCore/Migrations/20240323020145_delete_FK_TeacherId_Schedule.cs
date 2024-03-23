using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class delete_FK_TeacherId_Schedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Teachers_TeacherId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "TeachedId",
                table: "Schedules");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Schedules",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "025e3d22-56a8-44d5-a9f1-2eab14276059");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "e244aaea-bef2-4519-b105-e0e822b8e993");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "04e97e38-0f63-4e6b-be99-8bf3836d0250");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a6eaa63-acf0-4052-998d-dab89d63524c", "AQAAAAEAACcQAAAAEAQdnA2hg453queMSshceLjbXYqpL9KMMYfydyf8addQ4JUEuBIl0Ni8M5YEDdTXUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b9c2c09-c150-478d-ba4f-e7716c55c9f7", "AQAAAAEAACcQAAAAEB4RuMxdUkBbnM7lmAO/5rcgtyQOy/Tx7YREcJQwSD//HdB3AAP/7b5oNI8NCjhyEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40c7fd6a-cb40-4e1e-a758-226d0402f6ce", "AQAAAAEAACcQAAAAEIHNlC3OXAS5g6XmmuRTCa8eEsRlgjCqWfqzFprGKtnP2MY5WZPn20xrVarFA4UcTQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea311259-d86f-49ee-84bb-4db52d3a7226", "AQAAAAEAACcQAAAAEHSlOyEttTVWp27J2bxfqz5IxaSXSAgu+KB6oo+T4cTF2W+nPfaw+idc36wO33pYGA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16555827-ba0d-4c5f-b942-51ab401ac5eb", "AQAAAAEAACcQAAAAECxPOIEo4cLaPEDaE1yFRn/Tc8K2I33P7sXMYowKxegKOC7kz+j8o4aGQ4c3JfRt3A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1d03870-39d2-4adc-94ac-6846f13166b0", "AQAAAAEAACcQAAAAEHGD5aQYT9W0R7sN3giqVspgaElRA8PGmHpC7dejIEJukw1/9G6cGBk7bX6gXB5dbA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21cfeae1-fba1-43f8-a283-d11c00b2088a", "AQAAAAEAACcQAAAAEJBLsJwMxXP3hWde9dJAcqXTsRUoykToXCn62+K9XKoMnAzIQx4b6KvaHaQSyLjXig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa32b431-aafe-4a9c-b27d-7ca876057e93", "AQAAAAEAACcQAAAAEFWKflynwKj/p9tK/n5S01Vjtwmg69dyTaLwAVsAC3pwAEA8qwz/QdCaxuHAuuLidg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad35429e-707f-49d2-a70f-2239ba51c55a", "AQAAAAEAACcQAAAAED2Hu10Jf8QxVS3xZ03J/hA0h2Ym8ID98qCUmYOB14Ah9nyY+pgf6lhcJbSpjpjo7A==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Teachers_TeacherId",
                table: "Schedules",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Teachers_TeacherId",
                table: "Schedules");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeachedId",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c3698f26-f6de-43d0-804a-f9a31e641b48");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "ca5352f5-3827-4c18-8b3e-eb921ad0cf15");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "98a207b6-cfca-4358-9fbe-526fc3fcd170");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0f47dfd-1173-4832-a009-8e799f44ff3f", "AQAAAAEAACcQAAAAELDhB0H263ExOEHZRwnOgBC7TlPqPGHG5cv7pc5LK6X6kmaPu3mCZnhsvtJGE/wapg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df3ee484-cbca-4a35-9f06-f55d1454dfdd", "AQAAAAEAACcQAAAAEFEfRrypTKFDObb2WK3bmHHU0uPrjcSMLbJGcII6NiOQoisbq/8ncY5G7L5tydfpww==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "90c01d13-3845-4f92-b1cf-e131dfefb50b", "AQAAAAEAACcQAAAAEBFp1Hggpn1mtBAnftWFiAguHMzX08je3gu4kcMdweGDKCSdiGeq5QMALLdWXGE3sg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba2b3214-6e7c-418c-83de-d2b5e2270c8c", "AQAAAAEAACcQAAAAEJy976SKDZEENRVwkKsJ/sptS0B8x8MU3grziotFdD4oO+s7tF/m8YBzoihTJ5EvNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87921e80-edfa-4d2d-a96d-5db89584a3fe", "AQAAAAEAACcQAAAAEAIp1EqSG+EC3Ppx8rN4zlZs+Gr9aAAn2/t8qxD4bCX7oSYCGGesr0jgZRU1Q7v+2w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "851913fb-e67c-483f-8148-be44c884cff2", "AQAAAAEAACcQAAAAEFiyl1JGGnfKFFhWYDOgbjQiG34b1FPUMqbRrtG8UkScKxL4LumfeMziLK2y24xjZg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb191470-5370-48db-846b-9a7301fa0434", "AQAAAAEAACcQAAAAEB8NimECZp4VWZGGz80zRJtanYhJ6PUysNC4wyhe7Mb5bi/k0fslRH4Rmfi+S590CA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cce4782a-4119-4cac-beca-e4be18354ed1", "AQAAAAEAACcQAAAAEHcUed4XdHSiPPM2S931XFt4necs0N7uRz6sYGcI0ZqXD8UZIe1S+DKMi/iwxRAt9w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3663d83a-fd75-42d5-8dfa-5f9b1e397a66", "AQAAAAEAACcQAAAAEOD7bnUvTt1bfyr00fRvb7FpdBUU9VPxzbf0JUHrIgYUK0/2b6UaU0vrADTg79A5pQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Teachers_TeacherId",
                table: "Schedules",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
