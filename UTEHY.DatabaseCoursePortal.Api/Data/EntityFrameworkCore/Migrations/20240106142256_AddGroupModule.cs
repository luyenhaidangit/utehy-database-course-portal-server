using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddGroupModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvitationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryTimeInvitation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Semester = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupModules", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "32465781-d905-403a-8c3b-0f3b244e1c66");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "b851f027-eb2e-461f-93fc-bb1db357d753");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "e847c5f7-efe7-4b98-9e34-231cca5b5504");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24cc3083-4299-40ae-915e-8a43de47dbfc", "AQAAAAEAACcQAAAAEE5hsYyDEF+r/WZy8pfIsbA0nBaVzkgL50lVZ28WeWqAySb0rbpO2UK03ND5SQkG9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25a6d107-6710-420c-b469-efbe69f34f00", "AQAAAAEAACcQAAAAEDYQxBtgH4ZILWQs2HiafHzY2oQQv9wa8b8FY33uHVkIOu1Dfs8Cz5fXbmVMVyB/wQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a902478-9b30-40bf-aa5e-84751d8f8ac6", "AQAAAAEAACcQAAAAEFOy4QKT9aNs25boaVLviOPIXGv+UXaew9OM0L5GKtIzHOcZh4qIrwD8okQTcny/VQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54d78ce3-ea89-4d12-8752-c40759a07d01", "AQAAAAEAACcQAAAAEH+jHIZjlhoDYReHHSF0WKt6xzwIqyYNSILtI5qQLEdcKEYJNOK2gVPpwQlYXZ9xpg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7a5e7a9-f3df-4ee7-b761-2a6beda40f57", "AQAAAAEAACcQAAAAEOELogEQ8NsD9F1tZ0hjlkk42JgdVGU2zmmYAU5+nZlE5xFJsxMshxAFo1YhTSah3g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2db78d22-b720-48df-ace4-ff92647b0a4f", "AQAAAAEAACcQAAAAELmq+wq/irC0+Im9WesLc/i0/Ym4HzPhUAnDIJllNEU4AgXTGKqNJ78sbxaB+4Q8jA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54cd18b7-4004-44dd-86b8-a8f221a36c43", "AQAAAAEAACcQAAAAEB1eiwoqhhxo3fLef24J5ZuQRlr2h+oOMLqldoVVEc3oplJpJm6C1rBL+OGhsoxPog==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e242ad3-f487-4d37-a2ab-996ea273d27b", "AQAAAAEAACcQAAAAEIbhj0sTe5K7aMjB1WBqYZf89H7jGQn0BbNKBFGfAcB1hCjSzqcoSVZwg0fAf+uWFg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bffa17c6-694d-49d0-8828-8227a14a4ee2", "AQAAAAEAACcQAAAAEJYqIfPiar4YFZfGrr+mktrMJwoVw+FRxMTHz3gD9dX3IYNgSIa5wnuqQxjvhGNMrQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupModules");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "df351847-1499-43d3-bf45-36e650c4658f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "0526cbdd-27b1-4f1b-8639-f3bb07224698");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "823b2523-1232-4fb4-871a-c8245cbc7676");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "086f869d-a83a-4c0a-a8d8-8dfb9767314d", "AQAAAAEAACcQAAAAEALQIdh4EMJQd/lUXNEmhAhSB2ACgS+rB2iV78p8EFtiFVlUS9Nf/CZgEzppn94pgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f9c390d-216d-46fa-8118-fd100a224450", "AQAAAAEAACcQAAAAEPG8FBuJU7kH6dqwk2m4kDsu1OwpoWO3IKR8STXdDtRIUgpulEmVnvgXOTZjE2zejA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e49f3e1d-ef7f-4368-8d53-fd1c324e9caf", "AQAAAAEAACcQAAAAEN/XsneIKRtQqTyGd1Lxj53Oeor5VmcTiUq1wg5dDqzcfTyPPp7DTlHT0PE/8X6JAw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c6a425a8-61b6-4053-832f-6317c1c7bf35", "AQAAAAEAACcQAAAAEB7olZjfjuH2xsN0sd2MoVplAE+irD3XNQ2p0PA2F4KW2r9p74LdYCyaWsL1T2YGjQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "840f7aed-2a21-4771-85fb-46332cf49e8c", "AQAAAAEAACcQAAAAEK8hHt05jz88kHiWf8NvY4Nfwoa9bugrdt5vsoc8H20jWugREuoWAqUXkg38ZbVxKg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "568f1d4a-5cf9-4996-a269-914e76e4911b", "AQAAAAEAACcQAAAAEGOXp5LhmFF7axyoSIl74EH9hRSzRxIjNqdfJOczaG/kOa0yaysxml6IxMA/IJJNIg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff0ca39b-e4f2-4ed6-97f9-e1451e3519f9", "AQAAAAEAACcQAAAAEPcHByfNrFt/iV7l+tZMaD2GB4yPH6XSylIJ+VLdmvTvcqnXW8NTbdYpcDNxZTACww==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b216b0c7-3a59-46eb-bdc2-12ef08454983", "AQAAAAEAACcQAAAAEEoxsJ7M1N9Y5hikgOPyhJnJ2zWES5ecXEqEESfKQvhkznSCrfctrIh4AQLxnkU/Xw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e645467f-317b-4625-9163-0c3cfb81584e", "AQAAAAEAACcQAAAAEAzkLKJtC5d78+74VY5JUxtgpCclahcNE4dTNtLERLIXLK3hNebBBBJSYOlfBbNS9Q==" });
        }
    }
}
