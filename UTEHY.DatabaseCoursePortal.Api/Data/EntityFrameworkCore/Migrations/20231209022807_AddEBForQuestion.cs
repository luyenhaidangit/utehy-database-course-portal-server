using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddEBForQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "d6c8f0c3-c602-48f8-9e99-d405f65f65d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "09b1b7ff-0ed6-4fb1-b2ba-fdeb2832f8e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "0027d578-c2c6-48c0-935e-89126780e7f9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a895fa41-7f1a-4ec7-acec-8d3744cb3835", "AQAAAAEAACcQAAAAEA01fqYRgQaxa/e9ZRKJvATy8k8OywUcDDAua9RMMCJdq7Q811r5u/w9OIUyaJz54w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a5b2c0b-f9cd-46d0-853a-28ebc33732a2", "AQAAAAEAACcQAAAAEPCoGu/z9JVv0n10W4Igw39721OD1CgE5qUo6gHIsExl8LctgqkzA3oT5YYazE3V5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce0f2e02-0991-4847-ad05-64ab017f9d4d", "AQAAAAEAACcQAAAAEAp/KPKlVq1/KLEYLXih66EkemECmr8/pVicvEbGGrZ6g1F7/dKCRlZNoYALki7n+w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5a1c663-0d43-4516-b915-b8b8cad2f312", "AQAAAAEAACcQAAAAEL9YuYi6/fAQidHve7fh49Er1RZLJWV35RYFUDeCbK0LrN2J2KIi/JpywxNYuaFTmg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d816f320-ebbf-48fe-a240-1e979dab4f1d", "AQAAAAEAACcQAAAAEArRfpiN590nV5JWfGYp/IQ9HE3B2jNkV8FCtmGIz0Lx3a5qjC8wb6Pn4T0+7Xaang==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d44a6383-ccdc-4531-a6a5-fa2fe220160d", "AQAAAAEAACcQAAAAELIjP8tYRS0hERthvSrOSTBsgPRYvDTNtEMUMB2mCL6WGAg+wBEVcmSWgrsrj+4QWw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
