using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddColumnPriotrityFortablCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "QuestionCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ad4071e3-d937-48ae-839a-1f09482cc164");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "7a768b66-42fd-43ce-8e40-e9214465fe49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "98e3b514-b6c9-4283-a3aa-9c2b344fa114");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8c21aff-d8ee-4acd-8ba4-78e2eda059f1", "AQAAAAEAACcQAAAAEIrt2jU2KcTBuezcGgtoUVxeYiSJB1YKLQ5PhVGS7+FFda4XK4i/qLpsWtlZ7+G44Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49f33fca-799a-41c4-a5ea-92b559ea4567", "AQAAAAEAACcQAAAAEGi/qp/HGPp9/v7BLgWXk6fAgkJ0h7ioHgFAwPn+RhZzVqiZbyGU2b0CiPSRys8uJg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a20d1e44-8b8b-49f2-a128-7b497a708b63", "AQAAAAEAACcQAAAAEEvwukZNCHPcHkkt0G+RNL9Wldn+sU//bZo+ReuUFOI7XHtwgJ676L2OuknTPey6Wg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1fa690fd-efef-427e-ac09-a85bfb2c091a", "AQAAAAEAACcQAAAAEIqnJs13Oge7fV1qyBlAalPqkW347Y8K1Cbycad0hpjlLoujnxLW5xnV5YubfqVT5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "001ad8c0-aa33-4757-bdba-9cb18b957b8b", "AQAAAAEAACcQAAAAECbfaW+t0a0LHhWRwQe6HhA3j69gMFuxt6V7n78hZjX2jmiBGUFP3xHu31ZiEw4muw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fe6ce07-5fa8-4ebd-8b74-06912c753b13", "AQAAAAEAACcQAAAAEP33jV5fLH5RqAPdsv8XPJ6XZqkeBy8EZtycehO9VrIJo6cFln/fIDZ9VsRgMKPEVw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "QuestionCategories");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6e7bed5d-edd0-4c16-abc6-97b82b539b01");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "7d5ea143-b10e-468e-a158-bdeab14a53e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "20be78df-d84f-4abd-8193-1c8dc335eab4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0f0bfc9-9d32-4be7-a028-aea0593f0d1f", "AQAAAAEAACcQAAAAEEEKG7+HSo97Jv2+oY6p6d0FbJzCVITxKAMmVyKkub1iGsiZCuAVLqy58qMMaEX5WA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09b7778e-d54f-46e8-8c56-ba5d1f917804", "AQAAAAEAACcQAAAAEHtmo0IYmDU1vnMk0b7NkfelSVXEIkhIYUyt9aXz79ZLg0GOm2kqYPoYvg2nos5q2w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27fbf5ac-ffd8-4e43-8e8c-22e1de1276a1", "AQAAAAEAACcQAAAAEJJGhPBLDLLfBsmzGOkXaesUjuhIIi+I2I7rkATPeUheveSUT3+wqXEaBdzvFYLROA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9479c00d-655e-423e-8493-0985798a251e", "AQAAAAEAACcQAAAAEKkrc45d/4umET3Isp9MWLrooJkp+5cXDoPd/TEw6lyk42LIUbvUWIGZ3YbTNf7X5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b14b8cb3-06e6-47da-9667-4065f84aea8a", "AQAAAAEAACcQAAAAEORAEMC7iqoNR0xcnulfyTqCDqGFQURuBAIUlKKzFVR8APaJ/LnK88qTE4tioIMomQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c04fd91f-0773-4379-a482-b62d1a3e3419", "AQAAAAEAACcQAAAAEFdbGXiFR4D2jtQjW0se+jCLLo7EloJj+G216xN4cs6jRiy2DNXe3HxFl4LejnF/5Q==" });
        }
    }
}
