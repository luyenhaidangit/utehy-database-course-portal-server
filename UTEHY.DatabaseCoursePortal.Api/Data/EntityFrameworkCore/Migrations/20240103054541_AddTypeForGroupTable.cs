using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTypeForGroupTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "eedf9f83-b4f7-4daa-be18-6b47dd114732");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "8cb4f90b-3132-43ae-ac4d-807b170a3aea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "c145287b-5cc6-4563-a1df-285a226f9ccd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ff597fa-d3ca-4097-a19a-e21250f4cc27", "AQAAAAEAACcQAAAAEKzKd5ETQq4+qwoDPq3fbaDNOpbDUi5V0Esia7/oa4pG+Ar7fOBq7VfXwSzw8k9Trg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "424cf2c9-fb8c-4f0f-8060-bfac9f6d395b", "AQAAAAEAACcQAAAAEPCN1lkrCzV+vmJUfgnlirRN2CwfbuOMEaoen82decBRHY9OTReOLRAManBG/XYj9w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2986b92c-aced-4188-89bf-a65a8bffa3b2", "AQAAAAEAACcQAAAAENoa5ckE3HlB8wY5x446WHRGm/4ipwkZC0TKt3rluAKHgk9Vi90kOJk+hjBWczGDAg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b642a35-54fc-4e6a-89c9-9723f1ff9409", "AQAAAAEAACcQAAAAEMVFcS3P9bV44yxNuzv+WC80Hz/3vvhhops4bE7Xg37kLDMpjCwOb7L6MvqtRrYYfA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87e07751-bfee-4e02-a7ab-7af83ac4852d", "AQAAAAEAACcQAAAAENkEDDAnXWtuuJ9mXCROhsFdN+OTwryAZdUtTSyUuFt7Xfb+N+C8Ctp2sbf14BeZnw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "abf1c64e-5177-4192-92e3-d046ddafd486", "AQAAAAEAACcQAAAAEL5kMOPzRelp/0GujBufzY6dnczgCwj4iOnVF+tM5k2IIHuDbgZQDsNE/RUQf97adQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "795c12f2-419c-4b36-9abe-adbce8bc52be", "AQAAAAEAACcQAAAAEKQhbnW9JTtN0WXYt9QBZBeNdcYb1r+ufQ+JBDBXQclBoMXFu+VE0pqtlrWFM7gd+Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b684e8b9-1579-4cf3-adf1-e09103c5f467", "AQAAAAEAACcQAAAAEJpOqreT0lEBLg1mjxV97TjvbmG/FGCAPqTQpjEjqAhUOKX+A42hVT9obLuQe022nA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe4997ea-62f2-47d5-ac32-ae585a51509e", "AQAAAAEAACcQAAAAECHbigk0cy6nq04/Jl95rPMY807LNFjvF2tLq+1ihhMlD+orJR0HMDuJ0f8nvWm4hQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Groups");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7629f137-b72b-47d2-a719-b2480db276ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "4a4001d4-32ad-4c07-be04-15c995433028");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "e13b11e7-0181-4580-a811-0e0971b6cf0f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d87c9f2c-9cbf-4eda-ad25-443fda9fe5b6", "AQAAAAEAACcQAAAAEDw3C5jTipLObNDCqw8FLKdiNPykbZfyBKzgzEPx48mKN30+uoM8F66sOs1Sp++tuA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ba85ae3-e9e2-40b2-b7f1-41797a4af11e", "AQAAAAEAACcQAAAAEJEUfAF8ckcUFEOx47MKNXgO56hkdsRd7uFjehpwfsW30ZZ+0Oeys8CKTw/OlCNbRQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f48edd0e-d370-4f84-b56c-1d5c5ff5cf50", "AQAAAAEAACcQAAAAEEzHqkMhQKXpSGmMDdyL2knnpfC+12zXp+APMoliXnh6a0wnSZqt5qnPizC+IrqPZQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca15d2cf-055b-4d4b-8f63-123f19b0783c", "AQAAAAEAACcQAAAAECFJw6FHGAw9F7pv4Fo0hL4VFJBYHhWrZpeY4tKMgWBMKynFL9n4rgxbS56XckXAWA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19295831-e9e0-4771-9e72-9b8dda46c441", "AQAAAAEAACcQAAAAEJ9PGdMsG1irYwHS2pBbqzipWdKDA5JT69LecC0NWqhNCeieVCl7ST5g4zOAF7aKDg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd2b5772-5aab-4ef9-97ab-37beabf067e4", "AQAAAAEAACcQAAAAEHKCUI5Ps0boULeavg0uwcAuoeLELJxMdCpLMHUQKj70dSqHhWaKZdZEkYJWw8XgKw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f912c10-ae05-4c2b-8824-39f74de05f46", "AQAAAAEAACcQAAAAED/Btr8q/SD5Ne5PJXJy0tfNMGVFlbEOQdyjBtV331p5s1IqAsSzCxlP3FUTt6gmtg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8595bb9c-670f-49f9-8bb8-d1f39edf08b7", "AQAAAAEAACcQAAAAENnlRTnzqPEJ1D36vy60I3wK4nlY6mpp+wnYa6q1f/U7dOL5c8EGqayR3GSPch64OQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c1bc5d8-f161-4f36-9248-530a28641642", "AQAAAAEAACcQAAAAEKt18jH6cTqZ7n3SzqVnmvFqdoGvpqrz/8ufyr8rpeizoeZXbD7obYfnVcYpigc5VA==" });
        }
    }
}
