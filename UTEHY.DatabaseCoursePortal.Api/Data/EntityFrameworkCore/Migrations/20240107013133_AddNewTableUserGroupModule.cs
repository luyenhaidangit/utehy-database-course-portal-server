using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddNewTableUserGroupModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserGroupModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    GroupModuleId = table.Column<int>(type: "int", nullable: true)
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
                value: "64edc58e-d01b-46eb-9e6e-44afa4f7f755");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "f7f36c58-7a58-4aee-9404-a2a79cc111e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "df870cf7-50d0-4765-9364-aad86c3934e7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5078a4e6-4836-41c6-8841-50c2788cfe44", "AQAAAAEAACcQAAAAEE5nX50qjVfzM7/Drr1XtfldCthqaUwQdeWBgaETyj9pZ/KABmyn4w8M1SrwoLsAzg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb16ba53-9852-4a5e-ad66-a8b40a6200a8", "AQAAAAEAACcQAAAAEJCMUrcUtODURPvASxb2PO2J+/plVT2dcc+IRm9LIBOfS1xJ5kMg6cLsN7xMmwHhDw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14a5d871-da98-4dde-b1f0-87c8c51fbe3d", "AQAAAAEAACcQAAAAEEd2wATEYB2zxvzOFDMhRQpA9qq9ijBFwTv/tbNBJMr1jx7moV5yJoh0gUkqbZ06hg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfc53b9a-63d4-4fc2-a6c1-bdad75925cf1", "AQAAAAEAACcQAAAAEMQ2RWHszedDjch4rxNEhKMEOuVEZESwRaxvcbNXltm5e4F8GnQLQBVucuvyz8oEMg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63352d4b-7c71-461b-a291-21be8fe82456", "AQAAAAEAACcQAAAAEGWlj9WhGIRA7+dk2YEQspAE2w7fl79l3S1fjc7O7djxYJi9uO3P49iTUFRblCwFSw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd8ae3a6-e506-41c3-98e7-32393e5e3a38", "AQAAAAEAACcQAAAAEONmJDZoXNoeBihk8ELncIJ4oJbsOUXRUwILEWDzT3ibNmtDR9a0laEMKYZjAHbx9w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49fb9532-2b5f-4c1d-a8c0-73a0fb74ea87", "AQAAAAEAACcQAAAAEDyXz3YwU6/txan2ODgl+RV0f+DbZAXv9zIoJ8Lp5/VxkoJUfJxh3CUUmUYXZb9hZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9cc1e088-03a9-4ce3-ab88-42662626f19c", "AQAAAAEAACcQAAAAEGB0lwQNKAdapUXN4gMx5QItzJFZZ1E+NuD/McZczS3ft9uFlte2mJLfz1i/4cU7Mg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "311c748d-3a35-4728-813e-3aa473ac23c3", "AQAAAAEAACcQAAAAEGSyu1AEyaP4eNobK2N2gWpaeQcYI27o8MhiNDv/8xFkFTwB/yUnCzBLMB3OJx0yNA==" });

            migrationBuilder.CreateIndex(
                name: "IX_UserGroupModules_GroupModuleId",
                table: "UserGroupModules",
                column: "GroupModuleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserGroupModules");

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
    }
}
