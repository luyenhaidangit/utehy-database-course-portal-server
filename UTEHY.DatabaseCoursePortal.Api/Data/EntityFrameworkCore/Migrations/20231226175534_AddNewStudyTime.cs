using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddNewStudyTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "EstimatedStudyTime",
                table: "LessonContents",
                type: "time",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "95064f14-6e7d-43d5-974a-f669048173a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "f2ecc5c6-a4f2-4baf-ac25-48820ba360fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "86f01939-029c-4c30-826e-e4d3b292cae3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84e357ab-5063-464a-af71-20e68a49db7c", "AQAAAAEAACcQAAAAEOIWRt5XIspB/c4QGVdi9gO3+cPZPKTg/Kh4PSNZ/a/wJybpx6+zOzwA/GdiJmOz0w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b2caa14-309e-4040-a185-ca91d46d4db6", "AQAAAAEAACcQAAAAEEmB1R81MQYE3+hzP4+gVB+9bCkUl0AYZXw6GR4orSeiMlWG6iqxW5lQu4JCavztFw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3fc93f7-34e6-42f5-b237-5542527f664e", "AQAAAAEAACcQAAAAEArgVOcQ4+j19VJ+eufLsvzZZnEY0mpJXvw+aOHsyB/Lwd9zVTgp8EIrSE7QsPCQAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6440d300-e445-4c0d-9f40-b9b8a51e4c85", "AQAAAAEAACcQAAAAECQQpmb+G47HSu2CVnWL/MXBKgMz00RRnyyoOFipwGdHvpoxONY2SO0IabPaYrXefw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7debf9fc-6e22-4cc7-9a77-9a39b79cddf1", "AQAAAAEAACcQAAAAEA+N/Cq8Z5LV4oVa+WcCQDZqi3KDztJ506QITPxxRrJ9IpMBO7uI8SNKeQaTHm68zg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de65e824-e14f-4512-97dd-45c86dffec61", "AQAAAAEAACcQAAAAEENCUIBmUZAmaARG59oHqj4kggEKUCVWPMs1Hf5l89DDqsUKgOtgeBWmmu3QpXW3PQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15a64be9-eea9-48b9-988b-f1852d13fd99", "AQAAAAEAACcQAAAAEGDMKB93yWPQeiOiaT76Bxn3hclcojvZNsr9AmKFRTmES9czfjWCPRALV79AZeSuvQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58e8c489-1567-4b33-80eb-b5a8c554ebc6", "AQAAAAEAACcQAAAAEC4LqvPXkSwqkaNDpP7kwDADdHrImiAn58VmogkaWdIguhrx8mF/dg/sNJft6L6ntw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c54ff148-a9fe-4874-b3f2-8fd5536af4ac", "AQAAAAEAACcQAAAAEMBfgatSuA/WIl2m1UrAo1IGxdWrj+WhV1xXeHWmZCOCtTf2kpZ9qeWDVvNCvnfRGA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "EstimatedStudyTime",
                table: "LessonContents");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "36fcd44c-b9ef-41d6-a17a-0068fbfb30e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "bd00a220-c8f6-4aa6-8c15-279f4241a6ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "e7b47640-f916-4ce6-a5a2-968da9a30e80");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c59d9e3-ca0d-4910-b4c5-44f54e571cfc", "AQAAAAEAACcQAAAAEDPbDhC4NSWDcHe529jR9etnGsX9VtA2PqjTK5BSDQvOK/tJlqjxoBFd+Q1Iml7Jzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b4c62a6-9ac2-4872-91f0-b9c7d25e8006", "AQAAAAEAACcQAAAAEKuigQufpJjLOyz1oauWE08TUnC92tayYzHT0s0ZcdLoKM9YAWaLcb55mrOSf6jS5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5460e271-8e51-48a9-80b9-3914a344784e", "AQAAAAEAACcQAAAAEPNGze57RJ44cZeHLnNuYA8kkSD27VUQqB2m8JqGXSOIxeYbLc0BBraqsmWR0Mzgrg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a2a2ad77-6b96-48b3-8fea-f50f86d31b03", "AQAAAAEAACcQAAAAEPG6SzkdKURsgT4i0/FHGa8+KoRZCgQ53C5mU9Js1noxRyOTMSqoltHfdlFlQF425A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4a56017-82ba-440f-a45e-5bb4a8f3df12", "AQAAAAEAACcQAAAAEKejUbNL4VapnMbUiJhXUwzmsRuPcbgZ0vRw5QShbly4OF770TPGy7RITSCpkLLLAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c459912d-ad7c-45e1-84d1-81da402a0642", "AQAAAAEAACcQAAAAEBgP8Mf5qgKyqsy5qeqa8Wmo/rohW8K4m47k9Lg+/RLmgH9tS/VzlCn6eS3/NJcgUA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74bac987-51c9-4ad8-9f23-6f3ed3512cb3", "AQAAAAEAACcQAAAAEOBxX+UBg4yE7ZlUwvTJMGDqtR2tZeZzTDCKolTYN4BzIcTcRQZ16abJqnkM1Z6uVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f66c9d0b-db91-48bf-a139-3edcb6afa48f", "AQAAAAEAACcQAAAAEBHodIj9cv99pGt1CKexm1TJY2MeIRLXUuQMyQfL80oZtirJ3DfiTPQiWgqCJ3BZVw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0811ecd1-996d-4756-b2c0-38eee799537d", "AQAAAAEAACcQAAAAEFQeY7hllCc7nqqWNJxRe4Jaq+J4TRG9IfJt6yYpPD27Y71qqterP3onY/exZZYICQ==" });
        }
    }
}
