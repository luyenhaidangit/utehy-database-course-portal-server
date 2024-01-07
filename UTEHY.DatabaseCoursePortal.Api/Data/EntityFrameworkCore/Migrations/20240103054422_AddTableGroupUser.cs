using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableGroupUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "fed642d8-8c47-4d55-9881-6801b625c059");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "f0e60ab8-8487-4d79-9edc-86009b9192aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "f96feca8-f4c1-40e2-85d9-4d6305baa5ad");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b1bc975-9dac-4207-862e-5c236aebb49b", "AQAAAAEAACcQAAAAEHftpuGXgxVGfmLYKs7+OdmVTgrHwi5AG7hio+VzCT30ClYMHO3s9WfT6eCM9qevLQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "167283a5-3acc-44fc-b046-2189a95f1446", "AQAAAAEAACcQAAAAEFuoVwuyl+KtSsPsiadSLwgfNOvrZ1BvQMfCl9knUJxMty/ACPNhyxh4Dy1j8NaGfA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea226673-01aa-4625-9de3-a050fb2abf0c", "AQAAAAEAACcQAAAAEAyXMn24zmiJY4reB4aE6kgtoV0lHt74UKx6IARfdcjVembwEcHEipZF0fJhffnuww==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4e93dd7-9e31-4956-87e7-a374aadf5a28", "AQAAAAEAACcQAAAAEJWU1GBqDeJltJKmqjgdAOQkGC1RWv+Yo1fMmB66sSUkQQLLxCQzvT/mbYI+UFj4/w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04a8b0f7-cdc8-496a-9350-3a02a2eced9e", "AQAAAAEAACcQAAAAENsTeaMKrL3Q/GFdcMKjBhnFfVpPvLVzfpg/wNZO93KgklQDnFUgHi95oxvLt0Ng5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "509c90c3-c03d-49c8-b12d-552ca9800fda", "AQAAAAEAACcQAAAAEFgSB+uJfWXY2s1yfe04FZZOiSiUoR61I2wls0mKCgeQ2KTKMuUI6zi52gfXDkA37w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de132add-8065-4d91-a198-18883e08c48f", "AQAAAAEAACcQAAAAEF89jM9iU0dB87Gkrh0uMMJFxDzdIELWvBPZbzC39rG7pz9DSTAhUrd/EjLwUjAlKw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5559569b-a57e-4945-aa3e-f38e9d9bb0f4", "AQAAAAEAACcQAAAAEO4nR86pnCaPcgygqpXfQbpljKcQ3L2rRDmTkcSrm6ps53M7oMzpdrtsk2zhJD9uAg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77103b6c-d885-4548-bfb8-1a2d5353e11a", "AQAAAAEAACcQAAAAEDclCn8+sv/p1zfuD5+GCAN4XpwILlYIReF/u8FokdAAdHsQ3LBMqwFquXKrrVpDGg==" });
        }
    }
}
