using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class UpdateSeederCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Title" },
                values: new object[] { "/Course/Default.jpg", "Cơ sở dữ liệu" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsPublished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsPublished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsPublished",
                value: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Title" },
                values: new object[] { "/Course/Course-1.png", "Kiến Thức Nhập Môn IT" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsPublished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsPublished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsPublished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1f9d853f-73a0-49e0-aacf-901bb9119183");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "3971988b-3bfc-4d30-b128-b6f19a2506e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "910cdb2d-41ca-4af7-b7dc-4cf164a46ceb");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb85817f-37d4-4314-8a0d-265887ddcfb8", "AQAAAAEAACcQAAAAEAzxouiU45BGkx6cdUbrpiBEDAtwZD0beaPObldDUXVRkaJ7LNIWnaMp189T8QmoUA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "625c9e48-38ff-4fe6-af47-2d452531798c", "AQAAAAEAACcQAAAAEL9p0G+J9iRiJmeiQEwgZ/ggc0vayFqa8MwxKyV+7i+SlGJj0aizkY/G7ptsdo8G6g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "387afe0b-3c3c-42e9-9d33-9aac38268ff5", "AQAAAAEAACcQAAAAEAu7vAYImkLBIKAW/vVWsUzZbIizQVh8+qdNaLBEb16PNDefU/SJFdnbjlFqwi04NA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be4b40bf-c001-4381-8bfb-ec662bf3a874", "AQAAAAEAACcQAAAAEPAaNhRewBAYBxNctf/zPTvgUDAhKt0jSkkcRAV+QmfXUp/EYP4d3HUGPQsACdK16g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "acf84e7d-3562-4903-8b1c-64b11e9f4d83", "AQAAAAEAACcQAAAAEOEqsZgzG378DvAHTIrFeMkcnZU+hwJox4TyNZaGLN3fSw/UQrmYmfahCFH08gdptA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "48b182dc-79ad-4cd9-a1fe-c2b1c17b3126", "AQAAAAEAACcQAAAAEKWaKIGL5Fd9Eqjdz59XQfyEP3DRF42FP50xvvKG5NSJxasejuSjPE5smMeS2jCB5Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc5fd5aa-f54d-4349-8c64-651d8c094e81", "AQAAAAEAACcQAAAAEHRSVVnP6W5C+yA/mqGyxTNmLrHUCqlEbr5ry5ap8woNG8p2UVqxENDkjh4Y+5tXWw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69db8e60-cce4-49c4-88bc-655febe26c5d", "AQAAAAEAACcQAAAAEOc+G7uLOIyNbyhGbzD3A6Oqv5b16atqsuLOXoFOGQtj4iYtzj1DL7m+uAGHaAx9XQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4830f04d-6a3a-4238-bffa-05cd391fc0f4", "AQAAAAEAACcQAAAAEJT8HwCJ6hetauAWujLKPtP5xVb5PXxqkzoAYBKs4LKTie/0IKmi6sqeFhm/EZ5VHw==" });
        }
    }
}
