using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddNewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d3dcc885-d271-4c13-a71d-fdbe2fea9890");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "b0f9be9e-bd98-452f-b17c-766621d21db8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c36d6804-b3b4-496f-b8e2-00c085d78e0d", "AQAAAAEAACcQAAAAEAoz+vrW/QH8IVoELCabnFEhJ8TUpYOxgSpGGzE1JDKh32QWrhSXpuePSLLFIUpJiw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e188d53e-7ae0-4d52-9ec0-3a2f1b46bb7b", "AQAAAAEAACcQAAAAECETpK66+UR62m2ksfrfkEmCkfk8++8vkOOB82jZrCMXO5tq9ZR9KNXgcDlkvy+iYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a8bdcaf-9095-485d-bc04-c94d459090c7", "AQAAAAEAACcQAAAAEI0WyZ1PnRHN4xifXIj8aR9rldkV4w2kD7u+gPOVgPbbyTrCWo4wylcIe5CtGbTwuQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "889d4f1b-9e8c-49cd-928e-994a2beac154");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "d536e430-03ae-4d40-95b1-bc19433e886b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f2e8a55-36f1-466c-a48f-4bcc8a3f119b", "AQAAAAEAACcQAAAAEBcGS7W661MDGDIruXjMIAIbXUd3AL9Qa63RKmqM4BdQBNZCzNDOaiQB1hpAKifMVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ae54b7d-36bf-4177-bb26-372e7f6013e6", "AQAAAAEAACcQAAAAEJzqJOtxLZFIT47LqJ8YslT6nfxWCWDwHc4JGUl4w/MX8Z0al8clgZZEeTGClwwwLg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b75e476b-f343-4f45-8adb-3560a293dd23", "AQAAAAEAACcQAAAAEJRNQC6OKdV4or1ZUEwydy4C3xRmcStNnv0HtUe1gWqllSHpsQNIbP7DQ739v+KKdw==" });
        }
    }
}
