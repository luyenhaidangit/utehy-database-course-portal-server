using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditTableBanner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Banners");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d509871c-6151-4dad-abfe-8d15fefc0440");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "9cae13e5-f9b3-4d13-b62d-78402a7e065e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "56a0f80d-2189-425e-a4b0-1b4fb1d4717a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1dc9c3d4-287f-422f-9cac-14bf23f7d9cb", "AQAAAAEAACcQAAAAELaO7+d4S/05NncBxmMGFY3qx07xsycXoVneJx3+4Vokip1p5QU6fAUYE6KWvdRD9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c801dd3-d747-4edd-be0e-5d33ee452126", "AQAAAAEAACcQAAAAEB0jLLhs3/qqnTmtLH5rvL7HvsDvSJx8UuiXsWm07TYO1TN7qWq31fsP2G0fH4uyLw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3131c347-701e-4ded-a7c0-b766d41ca0fa", "AQAAAAEAACcQAAAAEHexpTEGR6AQRgPfoFRR6wnAkBkzmXM06wicBpuTUwq7QiJ+TaUyIjpXA+q9P1K62A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5ef1661-ebed-471c-8dcb-d9aabc99dad1", "AQAAAAEAACcQAAAAEB+72wESlaqBqBc2DN+xAdCu7NooLxP71AT7ycf/JDshY17VyAUJw/BY5UxIeE8Ohg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0bcd2e3-0146-4ecd-9d15-d7968eb70ad1", "AQAAAAEAACcQAAAAELIZS6lE6zLMUp41TsHKsAIvFqz6rbENLDRIaCg+z8Y+DS/hk0QZhmspGytNrdjbDQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99c84b7c-d6fe-4e49-8943-78d15a91c86c", "AQAAAAEAACcQAAAAENWArH8pgo4x5Wv9AhRKmx5ALtf3HADrUPO2wxssSPiIu2ITWkidnYDNEJMedVcRGQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf4b21dc-842a-430f-bb0e-6311a3175d57", "AQAAAAEAACcQAAAAEJIPyi6EB4KU8X+mLuMbRQES/df3kNmzkRzpy/bhqfWXu/VK7L5NHG45E3Ni+TNGPA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "262eaf50-7ef8-4654-8048-c2844d2ea494", "AQAAAAEAACcQAAAAEBoD+nd3UXtkeack64ROcBjc50Yp4Nb4muPLL14kscb9iLJkdZXz+erE9Tje94aW/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15009c39-59c6-4703-83b4-4e007bfb08f0", "AQAAAAEAACcQAAAAEAFcEITznjiROBYbPUGwZ2U+JAH3dZB+4wsbGGTERhIeXUfyOafopFwbxzVEs3qoTA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Banners",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Banners",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "Banners",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Banners",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "32fb6508-86f3-4d20-9022-4491cd9b0edb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "a2e4b453-d73e-4913-b95b-908fafeb5ed7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "e55d8235-09fd-4329-b4cf-91f4ebedc558");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49b844af-df8a-46aa-88c6-973e3d0e7a82", "AQAAAAEAACcQAAAAEH/MYfGe3oDjaVlQ2CqG8Ejg/4t3hofJn0fVBtmbMzxjO3XsaB9FNkkY77xvDU/0MQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c3f1779-a90b-4a73-bd90-6abcd57662ee", "AQAAAAEAACcQAAAAEClaqhW6e5lVAOGvQHJvYfzrTShbPAdofyHaON+SxLodRWTNeKaS+qmyDtDfJ0LNMQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c11732a-d6f3-41d7-8cb1-127bca05e021", "AQAAAAEAACcQAAAAEGL04WMVfsIZdY0LfMadzLPKjSJEgmlS1dotQ7SAfDjXlCqNLgwrXkjt4RAwyMNiRw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8991b994-edf5-4211-b1f2-14fb644c0752", "AQAAAAEAACcQAAAAEEY5QqoJRRGNydxjVZGzFQgRF5ysUoxqHS+MkGhXNA/o6zfZMgLWe4zoWUD5J8XICw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "039930d4-cbda-427d-9363-1702e6c0cf59", "AQAAAAEAACcQAAAAEMvBwuUe0qXWT+0u6zwFJ1DKkt1M/tY36VdmytCf2rx6m8NEdZat/ScoaDHl3SmLRA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0aad2bfd-f954-491d-a0d4-31af0e5efa09", "AQAAAAEAACcQAAAAELlW/o6w8/f8QLDp6DT92DoVZB9c4yVRQHQ9cw4IvEZXZMvqxMwJjz8CYADb/pkMvQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7366c80-e139-4ab0-8f3d-d5b98741a5d8", "AQAAAAEAACcQAAAAELUGAFN0fH7NFpSd4W6fOHbyqr6w1w7LblEWwv7jfg10i0tAqtXpfZ5EAFz/lNAIsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73ceac8a-ab23-49a2-a89f-ffc8c4635075", "AQAAAAEAACcQAAAAEN+42lHRvpOFL7Vkg7nBHDXzfvAN4GKEAYMf4zPXcsC7cMgpm4eITxLauwU2uk84OQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21419c1c-ccda-4d64-b16a-c1056fe3e950", "AQAAAAEAACcQAAAAED0v4EcQJEk5yl2WC/jIDPA2lPB/pWNPbPsmEf0LXtnms8TIosm+dqvI9amikZgnIg==" });
        }
    }
}
