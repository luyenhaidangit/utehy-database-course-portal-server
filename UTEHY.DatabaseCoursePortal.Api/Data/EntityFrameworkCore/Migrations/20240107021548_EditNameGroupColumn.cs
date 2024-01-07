using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditNameGroupColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "StudentGroupModules");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e4254d11-389d-478e-ae75-8192780a8d12");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "5dc070f0-e6a7-4026-ad7f-4c6484d8818b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "080c6bd1-9e27-4dc3-aa0b-bbb8afdbe545");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0912e0df-8834-46c9-b063-24de528e0692", "AQAAAAEAACcQAAAAEDeYcbPVZz7TZa4xqpjJuydH7t2UjqJgvGei/FZuYHR1W8HrWg6XMaLTtB4pHHb96g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aeb49b03-a216-40df-acc6-d879f0eb634f", "AQAAAAEAACcQAAAAEJ8KHx3w97xiP7gkv6L3t3PzOvr1OZwHEKa6ypsHqb+Mg2bgUIibkjOflwUnGz9UaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a2a00864-814d-487e-b9cc-0435be6fb19e", "AQAAAAEAACcQAAAAEE6X+6b9SXCkZQcpFqbokWZtyWxSBdSLdLFWah0XN8R6rFk/URAURmWf+2+j1fgafg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a741aa45-e18c-495e-850a-63d54e1781de", "AQAAAAEAACcQAAAAEPWRzlRisHFZxLYy+dgTVg0COQwbKaE1khVO2npSI8bKSxmN8ZO6SU1Rh35k7Sl09g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0eab852e-e040-4407-b982-e6493b8e9c5e", "AQAAAAEAACcQAAAAEJN6knEqgVDxe/QBsbB1/UpOKAaCzj3bXe1KWEbyRiwdGwM5mw5Th9+CtC7a/g+6xw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b0e15537-1a2d-4462-8ee5-87ca1e6285be", "AQAAAAEAACcQAAAAEJEAs3fAoapIU/qs2k4hF8sBaVMLthe8rRufiwQ7VUF2nBTYtHUaPKM6FN9j5lHaUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67d6e05a-7779-40d4-9884-a6066bec9e31", "AQAAAAEAACcQAAAAEJrBvvPrhIyVpKh3JKBwZ90OEBpyCKZzNRYnHgk8XeISyf5uCsjmEurY8jeS84+BpA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d39c2faf-0890-4840-84d9-50b458a90eda", "AQAAAAEAACcQAAAAEMlrSqKgEhN1J+rrbt6bsU0q7oXmqWztlU8bjoXyfsHkjEeWz5gaj0BYb1RtEZwi2w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8697a42c-d9b7-49d0-a149-07abb70b966e", "AQAAAAEAACcQAAAAEIyC0ReQNiC4jaFSQB4mI9iOxaQwfV4krw5LazDaUoqAbeBUiZutp9ZHYLw52oqwqQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "StudentGroupModules",
                type: "int",
                nullable: true);

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
        }
    }
}
