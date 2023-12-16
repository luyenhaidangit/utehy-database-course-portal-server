using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class DeleteColumnUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0a86a753-91ef-4765-8a09-0130efb76f44");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "b368156f-903f-4a24-af3c-d97af5630eb8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "f7c4566a-e6e4-46cf-851f-04ba1aee00fe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e55c1674-59a7-4c00-9929-ec11c3f0afd9", "AQAAAAEAACcQAAAAEP2rdlLMAE7MFmtjp2PJhvPzhQYMmTVG9fw2uTl3RtcZeKYasZ6jecXeC1HLVXbUDQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "023f0f72-00fd-47a7-a3c2-d48001dbdc4d", "AQAAAAEAACcQAAAAEBprK1zvYqM37/jguXFWvGZLIRSfSj9wfE4t9Kc3t99NjgDkEe02GSd4aXq/gUkegg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67e5ac7a-bc75-497a-939b-5c7e1f60509d", "AQAAAAEAACcQAAAAEOJrbniY0pGgcMny6O8JJzhEtfSoSArQ1NXY3Jt3g3nKV7TesxqIUCa/KWG/43E33g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38cb533f-2030-45ec-9cc0-efb2d9dacd5c", "AQAAAAEAACcQAAAAELSBUUPrWWWcOU+oeguBATuDYzgc4AKtiFbLXufbE2fvnyFlYmc17MvMwtOgAtGisw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ab3182f-d992-4afb-a2e4-49abc8e9b168", "AQAAAAEAACcQAAAAEF2zG/xaL6Rhn84tMBd8wNPqS37wefw6FnmwzJgogb+Y/IQESF34To4/d7S+1MvvFg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10d26a7e-9abb-4f78-8fde-0687b9c16b15", "AQAAAAEAACcQAAAAEA+VoA/Z0VLc0IqobPPoojTcLtFxVa40+OumGGJZvtSxIzQ0ZavQ0LlM0mTmn1xRvA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ac29b56b-085f-489b-a17b-fe46e759676a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "86825233-cc73-44db-8ea0-a6dd1d8f793e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "2a12f497-db58-4f6d-8f6b-bb43988171db");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe0b0379-a788-4508-832f-765ce36ebd24", "AQAAAAEAACcQAAAAEINczS3tq4/tuLfUQbHguklpxmUljknws09r0kRylVhAm79kYcSdye+r600sRtYX2A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36922259-a2d9-4bd7-96c8-d401418141df", "AQAAAAEAACcQAAAAEI4PDgk/piWFHXdIcyInuWPXtbSrSUQNzZ6DFk4v59zikBeRBeZ/rgp//CPeSXXV+g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c899137c-31be-4548-a6dd-36e5c5152171", "AQAAAAEAACcQAAAAEIJc3CGlv9iJYPImNZewSk2+db5k9S/MiCH/0NvLBLEgYmBQs9ny8Pi1rDq4xcuGnw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df92f4fd-15b8-4e88-870b-436348a2f264", "AQAAAAEAACcQAAAAEJWnG/uhtXAmNfhsvy/RElzwbGtrdI/7fbvWMsvhwiAqmZY9RfEW7q+fP391E7DwUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43c1e8f9-cdad-4cab-8ed8-7ae91fd92ddf", "AQAAAAEAACcQAAAAEH87AJ4HNEJh73LWqgSd6tlZ/0YU4l410f2xmPzqTp2XkhNL2il2yvFUSypN2FSFxA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2741dfb0-a414-4257-8d84-25dd65c9dab7", "AQAAAAEAACcQAAAAEOo7ekTZ9HF8G9RGgmMbpYeySdb/l/3Hb5I2lkh91lPKmLYoTOK+WZnKlQQQa0nwgA==" });
        }
    }
}
