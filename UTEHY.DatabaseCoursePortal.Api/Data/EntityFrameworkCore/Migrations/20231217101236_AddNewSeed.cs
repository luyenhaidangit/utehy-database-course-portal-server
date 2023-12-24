using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddNewSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDefault",
                value: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDefault",
                value: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDefault",
                value: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b29695df-68e1-4549-a158-3187d06a336d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "bcb0bce3-8e8c-4e70-abfa-9f93ac8bd8a2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "7bd02079-e26f-40f9-9e97-72d6d2d5723f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32f3353a-1c18-4162-b918-d4ec460e03ca", "AQAAAAEAACcQAAAAEE9iJh75KTlzQq/NEhelYz8UfOCDBcwPyFGoa7cdPFlqAMHvjrZpz5tIVWh8k0Rj6w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9fbf718-8e82-456e-8bcb-f1684e8e3488", "AQAAAAEAACcQAAAAELhXoMl1vKD3X+Tz5k4ZFO8C4HtUI1QlcH/21Dzh7LNvmbdPXK0LX83yW6x9coWlAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f8e3241-17b6-423e-b057-83557eeaaaba", "AQAAAAEAACcQAAAAEIDZWY1o9DZVQRpLiKP9iBO85OQIbdFKcomlFIRz/zBZSnIsYH3rYdQpx9Ag72S8jw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e7132d6-6443-4014-913f-bab9c931a451", "AQAAAAEAACcQAAAAEPv2zT1/Yvrft41K52wcmjqrSGxHgva75mFZCc8EAESy4ykXYeBJR1kPZeiikCTLZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "203b8bef-70d3-4fa7-8707-e53cf297a921", "AQAAAAEAACcQAAAAEFPCU+jgvqz6JhCC4vXp3/nqNzXHah+zCgPQibkjBixAQHDRue9TvVzCh0qYT1auyg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "568b1f81-30ee-493b-88db-b400dc4bc28f", "AQAAAAEAACcQAAAAEETgaTHNJpT8wcbCok2W51AwtOujKlYnGAPgrWYi30yYRzHqOnQMmQWrvkU6FzXquA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e5e7c158-66de-4e67-9469-2ad15c142fc5", "AQAAAAEAACcQAAAAEKVbIaYIkiCJ5StSQwAaoM0vlUqD4MAWRfZVVZ0Ph+eDWUnrdeVOUnJO+EeXqdFpcg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ebc637ac-d631-473c-8718-acc2e76ad3ed", "AQAAAAEAACcQAAAAEH7pyl+8l7aChb7jicJZgktXQBmFVLOqBF83SC1yRs+wY4JZx5vIZvA7bsbxwBQBHA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9176d728-7542-47af-b004-b1cde017d535", "AQAAAAEAACcQAAAAECwweSusBOu6YmdGgKBE2IN+bjSfuPl1PgT+980Q8+cCW+GjrfVe55axcvj26xzulw==" });
        }
    }
}
