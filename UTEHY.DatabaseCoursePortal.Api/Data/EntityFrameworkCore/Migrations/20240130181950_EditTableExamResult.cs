using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditTableExamResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "229a3bc9-5bbd-44f2-b621-9ccd76b6f9b9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "36d2d1d5-9f58-40c3-a09a-5a09c90f680b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "83c4b21d-0fb3-430d-a369-b23de05ebfcb");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "461cecb3-5055-461e-9542-3ed5ddddac61", "AQAAAAEAACcQAAAAEH8H0jDBIl8AnZaDLjSA0tCzM3rJ3Q+x019twXcLzg2VzFFJjtn+HmhJJ+D+UZFLpQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67b96714-e135-4b00-ae56-ab1cfeed328c", "AQAAAAEAACcQAAAAEJOMQqERBvLNLNOW6iX/JSsAd0OdG3FBonBkegL5JGe++KrwVkgCXA09eMkOYcI/ZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77de886e-5bbd-41c7-8641-e0e242a78517", "AQAAAAEAACcQAAAAEEOF4gnxkmhKIlkacaXpvK/DyFF8niXCf1VCeohY3r0YXopR+aIwx+8r7GxQzEam8Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27739ff6-8efc-4c4c-9471-69812987dd5e", "AQAAAAEAACcQAAAAEDBj1aMevi8NWSwrtch6Lwv/noX0/s9oset4Mz2cKWtX4rdGN38rzFLyHU22XrIyXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "585cb161-081f-454c-9b63-d1b942d5afe5", "AQAAAAEAACcQAAAAEIgy3n22mr9OUZrf+l3zsgPlsBPvmAaS1HOrYEQnY8fTpePGreq7HQI3T9bKFr2VTQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bec89ec0-43e9-43dc-a96b-01f43f286636", "AQAAAAEAACcQAAAAEKZyrjU2/0WZ9RpHviGygS3wi/kn/PY/6gbXzVeJimiC+I0KrdnocXfs8LQxb2wAaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "535ca74e-48af-46f1-ad85-3e7a8114dc44", "AQAAAAEAACcQAAAAEKsd5FC/T2QxDkrArW1qVvZ2UW5fYMKnfJrIn0/Zi2JlfYz/4Y2ARkRttkYWcvI+Qg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d007c13-c10a-414b-b14a-1de60ee57fb6", "AQAAAAEAACcQAAAAEJkLa9oBCnaJB5/mXw0DTc8Rb2spz9zy4up2t7pvTgD+dzuoQk7bVlFR4Vl+RVpTug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef1b5d89-f749-41cf-aae4-bb981dbffa68", "AQAAAAEAACcQAAAAEPnatnMlBQtAm3Ugi0CXB2i2Klfa3MQpWMOKENU52C//qfqMK6HDDLUT8V/YGfXq1Q==" });

            migrationBuilder.CreateIndex(
                name: "IX_ExamResults_StudentId",
                table: "ExamResults",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamResults_Students_StudentId",
                table: "ExamResults",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamResults_Students_StudentId",
                table: "ExamResults");

            migrationBuilder.DropIndex(
                name: "IX_ExamResults_StudentId",
                table: "ExamResults");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9eafd85c-95e0-42ae-80d3-db3dd1ecdc9c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "822c4e08-550b-46ec-8238-f02c872f9a95");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "2dc80c35-fc95-4dc6-ac66-77e3e9888393");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19d12051-a55d-4166-8331-816b8be7937a", "AQAAAAEAACcQAAAAEPgEH1NoQRi0YSsmUj3sA8muhqp6hD4bkVoFkULuylvX2ZH4W2Vn/exAFFlfXrNbRA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95462819-504b-4603-92ee-e2213b73c0e3", "AQAAAAEAACcQAAAAEFCXJmoLbR0yax3L2j1fZnJBC2REMPljlpCqvQVImquCsYWvUDGzd6WK2Xr/HOtMtg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84303415-3054-4f1a-97ea-9498a19d343c", "AQAAAAEAACcQAAAAEEA9pRVnBJxNTSevQgPk1gcc3ldKb4s1B1Ti723ad0TbM62rASxDGPeU9NyBdPjKtw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1fb97873-cbc9-4dd8-8385-78d95ae43f74", "AQAAAAEAACcQAAAAEFsTW6RAd5UcvVgj9A4xcoSNarHnsd630LkYX2t0vV4xf1//jPDSJGQ7EVQ+2yK3lA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef3cabe9-5733-4ec9-9987-3b1c992b09d4", "AQAAAAEAACcQAAAAEPalYBUFY1GQk3RhIBsN2wXw+l3V1OAVkOLI/sooIixOfcjsrEpleu6r/nltlFae9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "049e447c-db87-46d9-953e-0001fc2783d5", "AQAAAAEAACcQAAAAEGvRt48jCFgC6ArnO+DBdRDyyp9M8Joy3PGpu/5Si2McjAQqRdh4+FptU0omRPnjsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e88063a0-4252-4de5-a19f-b8633dd32202", "AQAAAAEAACcQAAAAEAFQhP4N6IrkRCqzS7R2MYZATOIsI9lRsRDzo9lDDn9z8z0mhfYy9nPxrPvgqTnyTw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96f4d2c4-0305-4f71-a9c9-74910c77dd8d", "AQAAAAEAACcQAAAAEMFeKlNZ2glLMfWjFJGTDiw3jtINZ3YmS0Udk0PwN0YGVVE1G8muGsKtZTpI3KazhQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "833100a2-6dfe-4ea9-9f4f-c2e902324a5f", "AQAAAAEAACcQAAAAEKzkgOZ6UuA/NaA3DgenWAx2BZWyTPbgZzuslrsfzpY7S8Fa515PoUDsuFtM8Sqlbw==" });
        }
    }
}
