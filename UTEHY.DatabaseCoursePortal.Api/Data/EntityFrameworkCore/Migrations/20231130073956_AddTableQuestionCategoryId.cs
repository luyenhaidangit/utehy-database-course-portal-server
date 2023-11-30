using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableQuestionCategoryId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentQuestionCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionCategories", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionCategories");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "295740eb-e5e5-458b-83d6-a029a87531b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "8d561b55-00e1-4150-99e2-93389541af8a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "8a962b89-094e-4237-b239-50e5b5effbaf");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af6483eb-8d57-49d0-a1ad-70875174a031", "AQAAAAEAACcQAAAAELIwk7LLGYGs2x5X1D79laPF3G1h1wtQlw/WQYZsacRuCK/3kxIs6/LrhabfXvQP8A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "491cc615-ff8f-4f0c-bced-a5c40434166f", "AQAAAAEAACcQAAAAEP8MxxA0wFqn3L2NUMTTe5D5KUZOaNMFP8GrCuknPI0QZxr7onKhFvv8ebo0MqC6Pw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4274282c-3eb6-4aa3-a2d7-4d60d171bf84", "AQAAAAEAACcQAAAAEKXIPuxDdt7GsIHlInXTu5hK91KtdsX2ycBsE7r/RJU4WHdfbfw7S1xqD2exFWIuAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9d05dcf-895f-402e-bf21-43eecd9334c5", "AQAAAAEAACcQAAAAEPpOqQo/k6k+Q4h6LxXDQ/lb1yVFHR6fbub99SohnvVk4xvqMPS6xFXfCTvr5gKpdw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f971ad4b-efc7-4a44-8276-3005bcec5c2a", "AQAAAAEAACcQAAAAECyS/nzEJGnJUMC9x4tZEH8T5K0gIhEbdomMRoUkZQBBxMkFdQNEJK7PqcC/LIm9Lw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "602eda1a-01fa-45e4-b122-2ff9f5e5674f", "AQAAAAEAACcQAAAAEKSj5auvUQHHIzDVKi0dkGvGSHGWkFxDtXkNWlsD0LMKCK6n9gUBkFYB8JyTEDtoGw==" });
        }
    }
}
