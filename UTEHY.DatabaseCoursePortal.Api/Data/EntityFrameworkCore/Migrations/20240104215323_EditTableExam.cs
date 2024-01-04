using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditTableExam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ExamId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "de4e4d4c-4b04-4d9b-985f-a6918e442070");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "71da8063-17d5-470e-9546-a2ffcdf5f575");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "1b46b3fa-e1fb-4225-b082-fe617f2753f3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "095220a5-2899-42c8-bee5-98a66ce831bd", "AQAAAAEAACcQAAAAECMywCl1HDMydrhOW5JWZecF39Esxjm3ETSMswAR7xp3w3wNnZCLuEOXZL5cP3PtAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b369f41-b710-4527-8084-3b800e469caa", "AQAAAAEAACcQAAAAEPcCm2TcCztuQeyGfOlIH+jtrOw+eypmpZEbGJxkDTtwMYPZ/r6K5J7FXg/obPJ2JA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34d09d59-813a-4c47-a5e6-8e8dc5fe8a6d", "AQAAAAEAACcQAAAAEHSxKjuh59cMi449YllONyPffWhpUvdihH5+6mVSeGBrsCmb8EH3lD64b13ewLfxOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ed0c72e-11b8-4402-b6a0-9c80f674a7a9", "AQAAAAEAACcQAAAAELGcZ66sVUolnji5ExVTyeIWtM8ZjHTbr/YqpZY5MeFUNKN3D0djEJPqg1OB6PBGXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9c1c567-0528-42d0-9921-04da8e904db3", "AQAAAAEAACcQAAAAEP2CJPy5pIQ2ghol79yodwn+sEe3qiBY61uttVMHs+tst+EAfWmOo5p0XO4UDsSiEA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "651168fe-b5af-4cf6-8dda-ba8e90850156", "AQAAAAEAACcQAAAAEIkf8eY/rmuCPSetixqAYBafvQrYvqCsHG3h13qSDMj9q5McY1GGL1cCNru+eNJGbA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2cca972e-88ab-450e-9ba3-a393cc4dfffd", "AQAAAAEAACcQAAAAEN0qnay/ujMVoKUM+ZBXr+HqO0bh2wQk8Py86ol7NCDdz1aIdPMnf0S9tUMkm5lSaQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b7187ea-c0f4-4747-bd9a-fa9270c5e6db", "AQAAAAEAACcQAAAAEKN2RxtynJ/yQdRSMBOtDp1o/GcM4meihs37jXeD/m/Ni3Y4EmIG/c5FcaNIgTjUyA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df813224-db0c-4f2e-bbb2-b82acb6d1cbb", "AQAAAAEAACcQAAAAENiHRYaMyTaQzWq3zCZGDBJs2KJguIIzAVQUHzT/KHJos39r57mSoU2bBeR68vxbLw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e4c1ec20-5b97-4136-b59b-ddc1b4fa0b0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "a4ae02ea-c8e2-4d2d-a11e-9a5c507f663d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "8594ce98-cec0-4c9a-af5b-4f1a5e650c77");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b939f7ce-13e1-4666-9f4a-1e185771621e", "AQAAAAEAACcQAAAAEJ0oytbO/yL1KMk/qVRv4eMAucqEleYM0JZYdftsQhJZ44ARMoqShZTk0lOCLUcD/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1636eb6-0c60-49cf-9f63-ed9d5e17f760", "AQAAAAEAACcQAAAAEOKXKUMjQybBk0HKzKApnqRa8w6W4NbgpqDc7AsR/4cGLkSmhFW859zhuQDLorNwUw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9a5bc6c-a7ef-48f3-8f15-08f8f0d47393", "AQAAAAEAACcQAAAAEEygBCjAWN3SR66WEq45SrxSrvpjyXfBFCin1Ktieq08mAqbJUoOAk58QleeFYb+mw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "694a902a-048a-4388-9cb6-ad535108d43a", "AQAAAAEAACcQAAAAEOt3sZ/QsErW8uK/iE+B3OzICCatCdY+PByvGMANnOkud00JaBW2TcNm5+IqZl2sxg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4a97812-3df3-48c3-acbd-3877f8f607ff", "AQAAAAEAACcQAAAAEKv0VaGB13cf21afUHwKxXodlLzocbnunTzqIvzOjQu+AVVNYjByZiuOc9C1CAvEyw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55894c17-ed25-4885-8818-dc643e14f646", "AQAAAAEAACcQAAAAEF87fviTjMhstt+7uDjA1dRQiY0XLopZmVkXZR19WaInpSO19QhjMEcIexEOizCReA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba77e62b-471b-4b28-8db5-54b11b2755e1", "AQAAAAEAACcQAAAAEI/U0aYuLnjyvtxQNH1julXT3nLosMixwwefnzHg/CnJI6W7GZfgUKG6qXhb/XdGTg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f604eee5-9f1f-47a0-ad6d-bb0a6d0782d6", "AQAAAAEAACcQAAAAEJwLt5ZfaqzqJT7F7U+LZDHcofJCNKgUU2eAY2uuF3rFdBSBJlY4PpoDTBdQe5+VIA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e069bdc-3a1a-40d5-af37-d24fe99c3185", "AQAAAAEAACcQAAAAEHSAAMT6S51fPhwT+g7Y91vfXlNE/qXrl83zWUQ8c4MN1UGqyfnfxkPP3+vN99y/iA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamId",
                table: "Questions",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");
        }
    }
}
