using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class ReUpdateSGM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserGroupModules");

            migrationBuilder.CreateTable(
                name: "StudentGroupModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    GroupModuleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGroupModules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentGroupModules_GroupModules_GroupModuleId",
                        column: x => x.GroupModuleId,
                        principalTable: "GroupModules",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "031f82e4-4136-43fe-afc2-c4efd5c54031");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "dcdcc24f-870d-4683-845f-21f069ef5f79");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "43ae8504-3fc2-4239-8784-1a5e3d2af129");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9f7f7c6-2fe7-4a02-8acc-32ff339e77eb", "AQAAAAEAACcQAAAAEB6UvPL84gC912TA18plTrROYFU5AlIOoJjP/jIaLDgomDQj4gaW0+2EXvrsN51GNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9fc9051-dc5d-48b5-a875-c82a02cea87f", "AQAAAAEAACcQAAAAEC2wvuaAdPOnwDk+CTw/4VDN4C/cLBudeL07J2hMGP4iJmi3KT3SEqEG05UO32Zmcw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44f3d1af-36d6-4378-a508-89fb4ab8985f", "AQAAAAEAACcQAAAAEHB24vLJBmgALuv87G5iFbr43j7gN9GqQWtpOGbQAuARpLXFIFaTya8aZ3zzhDJMqg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4423b193-8199-4153-8ab2-9aa75dd33e41", "AQAAAAEAACcQAAAAEFbmHQ6acQFUZgRVIbMSAcM2JBJl6MM4nVus2duL4OXgsUq8BVCfJQA1CAfa0LYdNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df9592d1-9833-4dee-9a0e-f50bcc30c7fc", "AQAAAAEAACcQAAAAEEeM2u3x5a69vLDz5G2+UVeRol+ny5xlBsBX/+dTUhBCSGnJt+vzXp+SLqCNhYGrlA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b78101de-3bd1-428a-8f74-e90b0ea4c7f6", "AQAAAAEAACcQAAAAEHHqNDNHUxHpg73NFInw4O1KanleKHGZftLJO5AV6g/qNpNVt8nQ5duUGtyV4cJoFQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17cdf8c7-b454-4957-8251-5e34003c524f", "AQAAAAEAACcQAAAAEIs5UIol3csCa38rbCBWrJb5zauKRE4rUQ5YQD2G5qi4GCy5M7LuUjyTnMWws2ENVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "035c135e-1e52-4925-9def-12b9e05a04b8", "AQAAAAEAACcQAAAAEHslm8EfZi0S0/C+y6VZ9pxQmPDViQTT3oxVFZtbruJZSHAzGiisNo3+pYw2jdSy8Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8749c78d-8e7d-4c46-a49e-3a49987fb05e", "AQAAAAEAACcQAAAAEHeELHmXDjFXYxQ+y7N5XmgTFT3uo5lkHovzqBjdHftEVaQNjl2bbODlk29gFlxObA==" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentGroupModules_GroupModuleId",
                table: "StudentGroupModules",
                column: "GroupModuleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentGroupModules");

            migrationBuilder.CreateTable(
                name: "UserGroupModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    GroupModuleId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroupModules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGroupModules_GroupModules_GroupModuleId",
                        column: x => x.GroupModuleId,
                        principalTable: "GroupModules",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8374b3a6-b58d-416f-a576-df50f55b3fd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "a4396203-9cbb-48d7-b44c-3867696a40ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "5e3c399b-4931-43f0-954f-f216e12a8891");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac75bd39-b81b-4403-8138-7e69c723c279", "AQAAAAEAACcQAAAAEOObq4Z2uvpCqQQrnvJFBstpfCgS00wzwIHJ8wQMASb1dgnWig9/wwq0nNHPlLguTg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c5b8cbd-20a8-4ff6-b8c5-1f83e27bac73", "AQAAAAEAACcQAAAAEM3iQvv4a244wHfT7bYMtjtmoTk5p7ggdm8JaaZUCLlY38vpFAalKqscfLuBU3GQfw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e82c6b41-cf7c-4ea6-bf4c-8d0dde611192", "AQAAAAEAACcQAAAAEPLWXYOeIX7+o4GXfrAKiIT2UwzOKLKU3zP3c8w5HJVpxtxxUv6cB+KK4FEv5J3PLA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "acbaef94-48eb-4162-92b6-b212136bab12", "AQAAAAEAACcQAAAAEF6Pp2UJjr8NWszGLOgPsmHGQmeWj0+H6g1t22Rk9fBuC3VGj1Z/nznj8y0TlrJy8A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb80d4b7-ed2b-4830-a599-b2ff371f2551", "AQAAAAEAACcQAAAAEKIKrNp8z1TC5O/lnRX10i2tpzzCa7Q0/2ueeSExEGDNaOZLteMeLlbmisjHqnd0DQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0c3721a-160c-4de5-aac8-90d98cf1127f", "AQAAAAEAACcQAAAAEKa0QCReok7tDEQtz8taxVFBK+ry9AU3kfwehvCIFqfzz0SNk3crRIz9gie3jwvAig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72f8e478-749b-437a-b35c-b984cdbe2ea6", "AQAAAAEAACcQAAAAEJnkiM0mFvRGsb49QiVWCqDo4owd4taVIgd1Ir5SvCOz9KGAYFIuT7V2r1GnUn5csA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82f462b3-392d-44ff-9edd-b4caec6fd561", "AQAAAAEAACcQAAAAEMEIoC2zyJaM2DLtmLKzP8TI97ivTRM/aNifqZmJDZiclLAn/DspuDN6Wy7pZUvL9g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59d3145a-8fe2-417c-9f1d-fbe595f565c2", "AQAAAAEAACcQAAAAEF94XEoj1h+nW14elP/KYK7oYl2PpN0X6TU7tTzO8sSG9cecGthsnkQkT2TeoR/ecA==" });

            migrationBuilder.CreateIndex(
                name: "IX_UserGroupModules_GroupModuleId",
                table: "UserGroupModules",
                column: "GroupModuleId");
        }
    }
}
