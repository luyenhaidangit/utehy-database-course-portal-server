using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableExamGroupModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamGroupModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupModuleId = table.Column<int>(type: "int", nullable: true),
                    ExamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamGroupModules", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7baa5316-f44c-48a1-b9de-981a74abcb26");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "390262b5-0ef6-44fb-b213-9d6a78746a24");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "05213826-0eb2-4eaf-bbbc-7da56044ad0d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8a60a63-c50a-4892-8c20-27da83cb6d85", "AQAAAAEAACcQAAAAEHTEtDsqEdIpKFhXFf3U1B0fWbkGsLykpyUf91vGFXVzTePH7ijTgL2XE0cQw4Oomw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "321ea7de-2ea3-4396-ad65-c207bc608f02", "AQAAAAEAACcQAAAAEAeYeadzHqyooZPAMKSdhSrqhSGk8w3SJvpqsFwSS4Ka3ascUYA5s6bz064/1Lw1Eg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d112592d-c53a-4210-9358-4747f5be9607", "AQAAAAEAACcQAAAAEFCt3pLNWCWt1utepjhERORszFlhavN5N/AA4FVSq7QA0GbvmYJEp5vTrv12GAJDsA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19043ca5-cbd8-4f29-a5b8-1eae674cd2c0", "AQAAAAEAACcQAAAAEDOwd8OpXH9yH0CVeJsv+ofPJZ3tJ7ZovPU0bgPuWChttrU5Ut8s0MQrbXA3HDmwvw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df9881c7-e629-43ce-9f25-37100b3956b9", "AQAAAAEAACcQAAAAENQCmINLbeYypVkFmMRcF6stjCXfNpz8kxSOh6su5O6Fc1gvJbbIvf9qE6he0MbdlA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "814bf66e-047d-465f-9df2-5a2c4806ecfd", "AQAAAAEAACcQAAAAEJBFeqqhqxP/UOYqupu2JJewLHq04TSNgRJC3z5BCUJNWQH8TFEXy736tMK7PCQ5Bg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ab69815-fe5e-46a8-ae22-b00f3d3d5942", "AQAAAAEAACcQAAAAEHKxKj61pXLgVrw488Q4Hyj2d8q4VdAxz5Bqu8KkHbggrQukcTAA80rf6VFp4xjEZQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8aba99b-2dda-4e5f-a660-64cd35894951", "AQAAAAEAACcQAAAAEOftFfprnXHubaXHQ2nxcb/er1EmfyzmMu8exRgpPMzq2u+ie1jLqsMFGF/1HU+lmw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc25516e-23d6-4863-9e86-7002564b2cc8", "AQAAAAEAACcQAAAAEAwRbYpwOZ/Cpnh492vXv8qYCpmGSThJ4ljzBvgAewVlHPaH9uY64AgXnZkj9vPBxw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamGroupModules");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f35a41db-388a-4105-a4df-fa0829c97a56");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "a833a98b-925f-481a-bd2f-25dac44974be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "9b9711fc-5e07-4ca9-97d0-a5f27b0e7ffe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6a5b4aa-3c3b-4daf-ab0d-ae23844febbd", "AQAAAAEAACcQAAAAEBnIDchRLCNi2/PvFSSCyxVo1MsyaK8WvWQ3jvw0GHcV+FTAYmM9oiXUNyouj/4ssQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a179b7f-a743-4bb2-a23f-0a6528eed93b", "AQAAAAEAACcQAAAAEDNln/Amc+v/bV+6RSxbZJ5tOUSQHcBYYUkdjesliw/DvYGqU+KJ0HVuXJj2OB3cvA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb053644-944a-4d35-9484-cebf63a1aa3f", "AQAAAAEAACcQAAAAEB5FoXSBSQV+K0T7cetxXHlQ4PmD+m2oTggprBqVonSFwNCq61LDNEUrdUaA407L1g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0566ec88-ff67-4840-bf6b-26315df28bf7", "AQAAAAEAACcQAAAAEHqLukIuUVVH+WsZ1/TCMMTrfgqO0hsY6M+s9F4ZAQr7POFzmv4EoAE7XRG+n2rmrg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4b44d7e-5731-412a-996f-33d30088f291", "AQAAAAEAACcQAAAAEFQGIw7EcVeaYHrWFfIyfeC2fiHdQ5hxgPYB7x5HuAKufO+TazIrf9zplOBbmlkOBg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3143909f-d932-4e3a-8228-0056434f63d5", "AQAAAAEAACcQAAAAEIv8KkG3KdNm1d6lapzqFSVHAZeNUKY4cJuoiPQS6hV0FHDLiNnhoKs8voIiKb/rQQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b4dfaad-79f5-4a4d-bcb7-661ff6df4433", "AQAAAAEAACcQAAAAEFFDPKKw7x0CvcBafMlheRZrS5B8FGaxnRp3nEsWwePwIltz5IZkyA35+ZLkU9O8Ig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4df9dc6f-ac9c-4875-bf45-dea464bf551a", "AQAAAAEAACcQAAAAEDWlYksulRUqI4UtB9gXzc1tP0qDelL1AuAYlGHnj1qRtGvJI6jQ/xKBrjWezBws+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa841cc9-48ce-4271-95dc-bc9ff5f764ae", "AQAAAAEAACcQAAAAEPXzfc7BVCVithrCFe8WxEBfpkjrWvDQM3YkIlfBWPzayhEtTCsTfJDMVm1QyxVz6A==" });
        }
    }
}
