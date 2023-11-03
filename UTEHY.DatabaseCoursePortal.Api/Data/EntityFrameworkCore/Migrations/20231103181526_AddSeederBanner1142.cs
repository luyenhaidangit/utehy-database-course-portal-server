using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddSeederBanner1142 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Properties",
                value: "{\"props\":{\"style\":{\"--cta-hover-color\":\"#2877FA\",\"background\":\"linear-gradient(to right, #2877FA, #6717CD)\"}}}");

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Properties",
                value: "{\"props\":{\"style\":{\"--cta-hover-color\":\"#7612ff\",\"background\":\"linear-gradient(to right, #7612ff, #05b2ff)\"}}}");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d25a55db-9eae-4b9a-aa81-1a97f5107e20");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6992f370-c874-45b1-a05c-f655b7986f28", "AQAAAAEAACcQAAAAEAniHlPqcAzdFikr+UgLg53ROZU62rDUfooDMxBkV7wfJos/75/Ty5Ahb6+26ptjLg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Properties",
                value: "{\"props\":{\"style\":{\"--cta-hover-color\":\"#6828fa\",\"background\":\"linear-gradient(to right, #6828fa, #ffbaa4)\"}}}");

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Properties",
                value: "{\"props\":{\"style\":{\"--cta-hover-color\":\"#6828fa\",\"background\":\"linear-gradient(to right, #6828fa, #ffbaa4)\"}}}");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "717aaaa4-438b-474b-91d5-1db1ee8e91a5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "47f42fec-4f51-480e-8390-a7e024ef63c9", "AQAAAAEAACcQAAAAEGZmeJb8uJRNiqQzw4urMDQQuiKHMbdkEITnJxllEXykV71aNdmYm2Owjb3R3QkWug==" });
        }
    }
}
