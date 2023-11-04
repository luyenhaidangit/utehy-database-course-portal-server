using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "23cdbf3e-bdf4-434d-83fe-b4f411c82cb6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "d893a05c-732d-494f-90e4-f75f24c8e3b3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34100b2f-7795-4097-b247-c7f617f255a9", "AQAAAAEAACcQAAAAEAINnoViyD2VjBzF5aPf9DkupQEU080kOfQc+NGovIKRKiwWYl73CQluq6VpS4Ou3w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8da9496f-c992-4819-aebc-81a3588a981a", "AQAAAAEAACcQAAAAELObSnmw77PScsmAMQ9z9piWBV0LVRW595RYiu+2oOOYtjWp7swyfWNCYNxOEfZAbw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f97fd0c-3067-417b-af78-b49abbc3aceb", "AQAAAAEAACcQAAAAEMX13Ht7yi6DcMoSIpJeWmpUolRhyoAZS2ZVx5pV8PnB4hl/BB5Dm4g6JxKQYl3QRw==" });
        }
    }
}
