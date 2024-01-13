using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "04d72aa9-3dbd-41b8-a865-7ddca55aeed3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "c4012274-5fe6-4745-bbde-0e88124b8882");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "bccf6ae5-8d00-4186-832c-0fb8f3dfa319");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9ad8192-953b-42d4-a49f-0a297a6228c4", "AQAAAAEAACcQAAAAEOvbzuMBtSwCcZbv801vGY4eLF7zoo2UThsrbpbSi3Ll22zlkbJn2TCAIbWlNv1h2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25389d0c-e981-4e6a-889c-38c0c0926fee", "AQAAAAEAACcQAAAAEAAml1GRX4JnTRpuKIYu3pFRDKWu8QvwyGu3yWP0ZhPcVNK1C80vO+InighXIViVSA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12a0952b-8276-4776-8204-9af5ddf94cd9", "AQAAAAEAACcQAAAAELlbvqBiG7BINkvv+t0KxjKVENSp+f80plsX5fs//8q9Dpg1/4qyOkbLQWsZ+9lP/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6b1accc-bd0c-444e-b6d3-f1d2d4fda7ba", "AQAAAAEAACcQAAAAEM+3Um3e5E82x5/EhLYCWCeyvcCBK1je/QxLzFXSFCn+3frisFnuuL4qeJG5QtswJQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd6a9bf8-7b3a-4fd7-accb-f67132260a6e", "AQAAAAEAACcQAAAAEDzkCIB/j8TBuTdwdDVcnt5FuiYLcjVXkNdPdzY2mcQbpNMUZwWRf6mLFLNjLECBOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c91809c2-47bd-4f79-909f-8cc1c009b86e", "AQAAAAEAACcQAAAAEIlAnOoLjSKqydd2t62F6qz9gTbxbfaKksQUhMPMBJ8HG6wGkHREqDfXu/LP0Qb3YQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57729b0c-dfe6-4732-bcfb-1dd5ffe8614a", "AQAAAAEAACcQAAAAENirA8V7+z7UrQWgy6wAYgnEVSlt0DB/LFY7/sePW/lEoVpsgzi7SPm7jdUsf4fHJw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26b5711b-7c99-4513-8bb2-4310ac7a4f8e", "AQAAAAEAACcQAAAAEMeEukrpqGGtXC3X8yPFzvAXbyTcvVCPh8yiEO5FidxVWZ4GAkVpZz11APGEAhZ6XQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13e656c8-1eae-4e68-b8e3-ef80bd0e2b5e", "AQAAAAEAACcQAAAAECg/DyZ4xfJnf5AqlxBoyRrE3Gk5KZmr7xlVIWYq/8Hz7R1URZAILLG68aPNK4uA2A==" });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationGroupModules_NotificationId",
                table: "NotificationGroupModules",
                column: "NotificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationGroupModules_Notifications_NotificationId",
                table: "NotificationGroupModules",
                column: "NotificationId",
                principalTable: "Notifications",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationGroupModules_Notifications_NotificationId",
                table: "NotificationGroupModules");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_NotificationGroupModules_NotificationId",
                table: "NotificationGroupModules");

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
    }
}
