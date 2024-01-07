using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddEBToGroupModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupModules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "GroupModules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "GroupModules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "GroupModules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "GroupModules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "GroupModules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b9f08664-d828-45f6-9abd-5fb0ea284ebe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "2413c3fa-b5c1-40e8-bb5a-d2e9fd70c90f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "19ce2bdc-c1c4-440d-8aea-b0cc282bb39b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "931181d0-3027-4245-9b32-629b900ebe57", "AQAAAAEAACcQAAAAEAQCYP3Ls38oNFABke9zfmAuoEbW7CVDxmB0PKwmQrqNFWnppOlW4LGRMzqXP0z5hQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85f82a3a-b41a-4c97-89f8-155ccd3f3594", "AQAAAAEAACcQAAAAEN1P6hGFL0Jnd0IozbgldcRwRLrCVqTWRCKh3CirPzsXYSgPxZ3OgPdyIKkNmMmsSg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e7ad3ec-9d69-4de8-a7eb-ee71e9281981", "AQAAAAEAACcQAAAAEPX7PrxYArlXf+woy2JkXpDBEJD5Ym/HOoTOcfor71OR/HulM+QxxZhTw3J+g3CVNw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "60ebc340-84d5-4a34-bc26-ab9407a746a2", "AQAAAAEAACcQAAAAENreU4s+B4QL4GN0FBHUcG00RXLU36Zep7YRO0ZL0a0C3q8uMZmH447L2ZhGGEtLVQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f93a90d-6ba0-416f-9fd4-6c5adc295e1e", "AQAAAAEAACcQAAAAEBgtWwErvm3FaMZHgdlh2NU+wdqUOCMTdx3JeEp7paTl6NCjtF1f67FGbNbsoFYd8g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f161d584-8923-43ff-bbc3-afd32de01c98", "AQAAAAEAACcQAAAAELymf/hKGVWe1EX+ADo7qmuUNbnK5OVYEJsWftTdnCuyhOfzbgV0HzJWQuuZeyFlfA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9414ee0-29f3-4cf1-8690-7eb3a4742b9b", "AQAAAAEAACcQAAAAENlZi+U5Km/0S5GuYCnoDmj2NhvOOU6Uzx2VYHt1fFrHhIu0hrpU54eg+TXH4v7Tpg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e7786f9-8342-4901-8492-7f7ea9eb772b", "AQAAAAEAACcQAAAAEF+zqbxcbPe5AD5fTUOJkV0ZCPfwg5yQ+8zh9snYoOxH+9fqNy+A3DdxxmP7A1H3Kg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7e6967a-6474-4e21-b70b-17218e22655a", "AQAAAAEAACcQAAAAEPo6jS/iKxE1Bncf9uAZSsD5eFCXbiNw3PCjUhYBv9+DQu+fCPXdnTkrf+aTggBvDw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "GroupModules");

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
    }
}
