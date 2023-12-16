using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditTableBannerE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "3108b7bf-674a-4154-91f6-634d380d6649");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "8498d0de-b037-420e-a4bb-daba4a648705");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "aecea373-53da-41bf-af6b-8afcec92e262");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc5cfa7b-dcbf-442c-91c3-fd84defecf54", "AQAAAAEAACcQAAAAEMgB39oeO+memZid6qusQ4DW0OI/Bq6b7NFwqzXidD5KxmVJPMJL4Q9fl32OwUPhHg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "903f7bc0-537d-4dd5-9925-b47890c1eb57", "AQAAAAEAACcQAAAAEEUO9+eUB5H5f2n2yNfCuVssDur7AyyqptMjYx81Wb2b+mW3ryFk10n4eb9p9l2iAw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "782f311c-baa9-4980-8fbc-a99b8148fa49", "AQAAAAEAACcQAAAAEBcfXsAacjPdl2t7lcuL15L2d1pvGNJl6ZbZ6w6NUzLsH8F4VF1UFEJGA4hgan9YYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dcbef5b6-106d-4751-a437-e525d7873190", "AQAAAAEAACcQAAAAEMvS3oy5pipgYhRLm6g79zxntahuQ1t6iZN/FeySvgVwN/UWP5SmwJR+jwOHeK57qw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97057386-5259-4a8a-acb6-e70dd47e7b6b", "AQAAAAEAACcQAAAAEJK2RPI6t59XEmFVoCX4zE20c4p0KG7vhe6e0riG4K+956P5RUk0kxt7DkkLA412+g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf1d1f62-94f2-4f3c-83e3-362decbb1086", "AQAAAAEAACcQAAAAECBNGpr/l0W4Oio4itDPDtReAv2j57G1HvGjucgak/ca6XI8A57hY6mL6VY+tfBs0A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be09b89c-13bb-4a43-a029-b16b3724645a", "AQAAAAEAACcQAAAAEOZuqLqn/0fvq2LjeKgUCnd9evAgw8JzGXNqfZkdH7cBuYk98MvAlEXY1ynvX23xXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2334eb43-0ed0-4ee4-80a5-dc73ca069e59", "AQAAAAEAACcQAAAAEFFEsrzogUDLDD/9oum8UOD515YMVK5zw89ozh5e1jB7WUMmQo4Ww44gq8Ap6X13kw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6d7b164-db67-4448-9800-f73de2ad60d8", "AQAAAAEAACcQAAAAEOcS9a8nFr4P+SkM0K0GvlpA6Xx2n2tF+9+chvXSu0VKot7QpEnxpF8OUOSpGLOulA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
