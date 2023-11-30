using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddEnititybaseForCategoryQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "QuestionCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "QuestionCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "QuestionCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "QuestionCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "QuestionCategories",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "QuestionCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "QuestionCategories");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "QuestionCategories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "QuestionCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "QuestionCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "QuestionCategories");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6056825f-e3d0-45cb-8913-4e806f3ce33f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "95e3b792-861a-4e1b-bef1-43fe555c82bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "78683f0f-cd95-42b9-aea6-3c26ea9bdd9b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "419f5c28-7bf4-4153-8064-70ae95c32f61", "AQAAAAEAACcQAAAAEPssXFyS+rHhm6LDkmD4V0+JrWiX3b+KBvdHIlCTmKXXtSjlBSSamerS0TLsGyuZHA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78cb2dbf-c262-4192-a5f0-fbfd1d60ff43", "AQAAAAEAACcQAAAAEMPapJC+AKXpsb64pTJKvVXgngDa3uo8EhcSpZiF0X8ZLqb08AnXbXizRWBa5uo1xw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b84c1e1d-b9ed-4c50-ac81-3abfb5dbb460", "AQAAAAEAACcQAAAAEG70GqKauUA41dS5GfPjGaCkM8ILkp0msl/Es+0JxBJc5JAOwmqfZcIZLjjb5h1KCw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b34bd804-4677-427b-95a8-1c8fea8b7464", "AQAAAAEAACcQAAAAEBjE24pR53GHMpVsDJ9OIQ014sxDWqDJGimUH5EhA1rnLVErPpZRc5XfNUM9WuwL+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d741ddb8-5b84-47ff-8117-921a318aadfa", "AQAAAAEAACcQAAAAEEe2FIvmf/Gpdlmxf1jscriccPzTrAmVz8mChNedznm292rLHVeXeFP7QvI0nFIPPg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86999bfd-0abe-42b3-8805-33ab05244456", "AQAAAAEAACcQAAAAEN/nk9UDFr+pstM+SssVfZhTE5HWMWV1r5yiQYC7X8Ifcpa44r2DTNSk1CxqCvYyYA==" });
        }
    }
}
