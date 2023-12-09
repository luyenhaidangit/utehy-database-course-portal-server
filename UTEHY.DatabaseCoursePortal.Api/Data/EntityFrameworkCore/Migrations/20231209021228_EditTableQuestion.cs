using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditTableQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2b181ec4-a552-4660-9d1a-bd2b5c744f98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "eb7a188d-c042-4a4a-a315-b8ea2fda30cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "9724c8c6-2252-4b88-b77c-ad13d40744dd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e0ca753-3a20-4ba4-afb9-f2e243f63c80", "AQAAAAEAACcQAAAAED+tX2QixsiJyGhkxvtlfXgewZNYPCUWqWKbFGzbalaiS1CQcmSQV6CelMntcRC/Tw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2f4f953-8858-4128-83b0-bce38b12382b", "AQAAAAEAACcQAAAAEJgiQHquehG9eDGDjYJEOTu34jHtw5uSTHL/xsL+frHuQLFRU59gNrMAkIqo3JccLQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f9c8921-564b-42e7-a047-cc2121e32ad6", "AQAAAAEAACcQAAAAECvUp/m8XAdVi/qeVxqGTf+4I2mooFyrS2bpY+kmam7E6woM6CCQLsFK4i2Wj1tNHQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8538d190-94d6-41ff-96b2-10caa109c464", "AQAAAAEAACcQAAAAEMlPPV3dfb7Dp2MTbX91qQ/k+mEXihSa8cS/YjxlEBbX5rYtVtCV5ZnhtoZ61XcDTQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5676516e-b831-415d-921a-3383b6697cc1", "AQAAAAEAACcQAAAAEFHhZ/Ixqv4g70VcvGhe4lG2rKdazMyCL6PcRps12cgfoeRcqTIIKMWf8JE36ScOTQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3dd38656-fc99-47ae-aa40-6410b67dfc86", "AQAAAAEAACcQAAAAEFg8bb6QJ7qxJDR/SBShHN821pVk7OfTElpiJnuR1ZKDuusUy6TsVUEwVE9gg/PAYg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
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
