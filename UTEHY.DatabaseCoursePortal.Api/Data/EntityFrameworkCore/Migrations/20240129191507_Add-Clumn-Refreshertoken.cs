using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddClumnRefreshertoken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "Users",
                type: "datetime2",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e5f6241e-8385-44cf-a9fb-c6e385703c05");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "f2430128-3434-4372-808a-6f268d640d93");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "59566754-b188-4644-986e-c6569d15110d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "730ec2b2-7fb4-483b-8dbe-dfdbb7885e78", "AQAAAAEAACcQAAAAELZZ1Crzmq5L0VWz3s4pe0foQmtSzpJDmAOBtOieEDkGpWYmyaPAZ2ri6bzkvq3O9g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57a43da8-0578-42a7-afe6-7388dfef8265", "AQAAAAEAACcQAAAAEMAxHH/d6Sgb3qJZe0UYf9Zw7462CLvEz1NwCVuTZa3wPMDJ6Ihubsyfh5Ssyhk8tw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4db2597f-b2e9-4237-9dfd-91c831943bdb", "AQAAAAEAACcQAAAAEOweVDCo6jsyLjU7/aEKAaRlaPgCIMJPZZJpzIQySyhrbMcfytENVixYHao0enxQfQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "446adbd1-0d9c-436a-b95e-948b8704ec1d", "AQAAAAEAACcQAAAAEG83QVjbRran1wToUchq6dsstB/iAXT4nPp/xqaRAyC53Mxw5S3oRznybGa/+IseYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ea8e8a4-ae92-4d2c-84f2-90ff3e3dc7fe", "AQAAAAEAACcQAAAAEP3AeVOhU9trRbmDMwNfeRg/qJ4w47UkLI5DFjSrK+Z4I/dfZfFnAbTx/p4np+gX5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2955520-c1be-446d-be50-b26d7aa92dd3", "AQAAAAEAACcQAAAAEOYeOFAOzPwHJiXTlwmojPwzVzs2vVcN0TeXwpSh0I94ClcKHWQsP+ZJNbx2gOUeYw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdac9cfe-d72a-470b-b164-47455301b9eb", "AQAAAAEAACcQAAAAEP+P4Y0CKfpo4leu4QH3FSYpgvda0LiGYZ1DxFBFLQqgtGEHaIX0f7Tbj39mDBF1lA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "512a221a-64cb-4aae-8ecf-63e45eb3677b", "AQAAAAEAACcQAAAAEKKRXnpnQ1pzdtumBITcVuy5ja7r4EKDOYmraKDaKh9G1G4+F44p5QhStiBxx+TWZQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5de1eca4-96ae-4b09-b4e5-5f5a6250be2e", "AQAAAAEAACcQAAAAEAhyvLS53wT1WE8kNpeqULKNtDrvlTw4B/JqnYT0G/O408NzQ32NpdWdLu/pwGLEyg==" });
        }
    }
}
