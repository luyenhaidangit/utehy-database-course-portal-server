using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class UpdateTableQuiz_AssignmentCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuizCourseId",
                table: "StepTracks");

            migrationBuilder.AddColumn<int>(
                name: "AssignmentCourseId",
                table: "QuizCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f8ddb297-f813-4565-81b7-123bd6e7dc21");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "c403d67e-e379-4653-be1e-14cf38aa0a23");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd986468-bde3-45fc-ac6c-ebcb836a6fd8", "AQAAAAEAACcQAAAAEFfZ/sD3js+Sh1Dn0N9x6XhqLhS6O1tVQ3IWLmpcJtzWU46UwbFgQcjzSQOrgV9y3g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c3b2887-53c0-407e-96f5-e07afe209e26", "AQAAAAEAACcQAAAAEIKd3bz7TW4r4QQVcn11SWpPzqNocoSiELIODYXl8GDq5A+2c0CeWWgN6GP7sT2BSg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "93d8799b-0eb0-4e5b-8c24-59c6399395d6", "AQAAAAEAACcQAAAAEDg8zEioTxQTxtJs0NY6p5O4sJPcDVVMeJxYsY2kMUXU1cSHqq0J3yyZbOzAW3CZ/g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignmentCourseId",
                table: "QuizCourses");

            migrationBuilder.AddColumn<int>(
                name: "QuizCourseId",
                table: "StepTracks",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a6dec083-3c6a-404c-8dbd-57e78d892ebc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "3878e7fe-3e1e-401f-9704-72137d8c264b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "134e8e40-ffc2-4415-8f36-a04cee1ba75f", "AQAAAAEAACcQAAAAEPz4fWwJoOKNFgHg5+WGqmfCB1uUpKs5ZO9yQcbwlm9XpAfqUEIDvv7EbfAcNNha2A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d4dfa74-9138-484e-9627-c718efe450c6", "AQAAAAEAACcQAAAAEBE1qJqJ805sxAeo7RtX95iGvxF2i9pi/yPGCRcywyrGJ7YBa2ro+Lnf+SdpEGpNbw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c6b5550-17be-42e1-a662-3d6a0074a65f", "AQAAAAEAACcQAAAAEMYfZNPmhPJEsz7ncU7uQVPkH9wTczRNehCB2o9886oqU7gdJ3klXGf3xr9OUaSkjg==" });
        }
    }
}
