using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditCourseTable1217 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeVideo",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2f39b9c4-7d34-4880-85ac-3ec2ad2265e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "ad7727e7-33ca-492b-95e4-0708e451f35f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "a30d22d0-b454-4880-a019-7a8ad01bd4de");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e19fe1ab-2e81-4652-9cb0-61dff4205ef4", "AQAAAAEAACcQAAAAEJT6iCUlNS67YRMfDD5TS1V+2hnem7Y6oMXtdN+8ik50D2CWh6uHjNBfL5JTsIMDVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e850c54-42c5-43fc-9397-e01391eec510", "AQAAAAEAACcQAAAAEOFi3e+X3fsM6UljfrCGmEy27/yUhRY/e+U961kCg/J0rPoX8pAMykmQNy5ADSw74Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f81b8e98-79f3-401d-8582-a7701521a920", "AQAAAAEAACcQAAAAEHsqSwezIkW2X3FmxVbxfbtDYsFH9k9qJukARvP0cD7InamMT1d7OPbt+X5x0zMwzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7774d578-51f9-45e3-9b19-934323c22dd4", "AQAAAAEAACcQAAAAEDa2qZpUBMFnrw2Vy0SDvyT8wyXvPC+6LYxurtWrMRgaaL+OoKNgoYwq27zKft6q3g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4bb62e9-d400-4bf6-a7e4-ff388dfd84eb", "AQAAAAEAACcQAAAAEMs0XQ4pY4eVn+HJXo28FK/e5A1U0duXyPBHYqrhUwWANqd7OAwo5zMl+VsYgbjCSg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6343bf5f-005b-4862-979a-25c42aaae827", "AQAAAAEAACcQAAAAEAi02uSWuwrBnYNZ+VGYK8pjWe21FbOPPyBfpyf0Ik2jHFKE+mpMe9TQFmiKXiHhZg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04912d2e-b812-4a40-b252-a043bfa9e9b7", "AQAAAAEAACcQAAAAEM20EN6Cl9e+NVdqOJiWxKNI3xMxIW4Qo91u2dlWakNkyrDgLfWNO9SjKSOF5fronQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5471e51d-13f2-4bf1-aad1-9defeeb9aaf2", "AQAAAAEAACcQAAAAECVOjCEFyjhn1/LNwIbYysa7Ia8GowHGg98xpq7bLxFqBH/bcRNOhw3qwcqOSf3CBg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c0909e3-367f-4fe6-8e7b-c6c4cefd4d51", "AQAAAAEAACcQAAAAEJ6b26MSKi7tga4V/+W9pDVFnnzlxu2ID+g1aremXNQ9IP3g0y2ckXI5fB9stUKicw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TypeVideo",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7138daa7-261d-41eb-9a97-f167429dfc5b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "1f54555e-08cd-4098-8fd9-50faad7b401a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "0d7fb99b-9c96-4771-95eb-938d1309b1f4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5da241a-2c54-44b6-a93c-f0346d023744", "AQAAAAEAACcQAAAAEFBl3HJmTeAnMKGrq27KwXtRJ7k2VIIDne36HpbBWWSgI/fKSWESDQzMRSuSW5St2g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5e55111-9fcb-4e87-ba8e-f52b18fd65a1", "AQAAAAEAACcQAAAAEH9gXObOy4xaE0veyRaSJZMkNoTz2nbUmdNp6qUPZaL2iekZADsmFVlq3NBCtn3Krw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2df0c677-7509-47ae-88e2-382aac1a8e78", "AQAAAAEAACcQAAAAEO/AH1bxQDqQFH3qAxFSpMQpAdFk3dZ1cc4uyn/+QYxkzM7IdCH3OqaJDIAPe0Rjlg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "878a0a14-4b87-49b8-9d88-921d328a6c1a", "AQAAAAEAACcQAAAAENI72kS9SshyWgg7Y2f3YY9WG0jqgFle3goJnc25kYKE/DbTozoM67+FuwQaH+kFqg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b38e47c6-436f-439d-8319-41ecdc6e1881", "AQAAAAEAACcQAAAAEA94YHUotykKgyjtZ40E8fkdn2LqODE2Lu+etN4BJcWql8ISTEad+hJb3YVbMsVGRw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f46b8bc8-dec0-40d9-a3e1-8ecc006ee720", "AQAAAAEAACcQAAAAEOMaSACsBvkRCpqQqXh3DR4HP+80v4SkLxb6KHcgP47oZBWcMtTcwCSkWx7IRH49rA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55dbbe5e-4c0f-484b-b853-90687ca7feea", "AQAAAAEAACcQAAAAEKYUg7swm0b8sVm/Cvj7xnWsN+Q8StJHwew7zPmBPAjE2gYwJkUcuEmpqiDRoxp9kA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f935004-de64-4ccb-a83c-943c31f91b7c", "AQAAAAEAACcQAAAAEFMHNsuICTo0oFC6tydTGDdTndXBtgtpgPiX7bLxPyGlzE4LVG3MA1sFcrZ/6QjSNQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fc74138b-49dd-458b-b6bc-6dd32e2eb312", "AQAAAAEAACcQAAAAENNLFN9MiBgn4QddQjMkYCb6ZUXfiJgtGWpPryg2bD+8g7v5EqqOJqn8vC29gBq02g==" });
        }
    }
}
