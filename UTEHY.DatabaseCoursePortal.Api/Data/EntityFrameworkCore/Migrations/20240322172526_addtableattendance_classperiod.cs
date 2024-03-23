using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class addtableattendance_classperiod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lessons",
                table: "Schedules");

            migrationBuilder.AddColumn<string>(
                name: "ClassPeriods",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendance_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendance_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassPeriod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfPeriod = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassPeriod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassPeriod_Attendance_AttendanceId",
                        column: x => x.AttendanceId,
                        principalTable: "Attendance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c3698f26-f6de-43d0-804a-f9a31e641b48");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "ca5352f5-3827-4c18-8b3e-eb921ad0cf15");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "98a207b6-cfca-4358-9fbe-526fc3fcd170");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0f47dfd-1173-4832-a009-8e799f44ff3f", "AQAAAAEAACcQAAAAELDhB0H263ExOEHZRwnOgBC7TlPqPGHG5cv7pc5LK6X6kmaPu3mCZnhsvtJGE/wapg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df3ee484-cbca-4a35-9f06-f55d1454dfdd", "AQAAAAEAACcQAAAAEFEfRrypTKFDObb2WK3bmHHU0uPrjcSMLbJGcII6NiOQoisbq/8ncY5G7L5tydfpww==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "90c01d13-3845-4f92-b1cf-e131dfefb50b", "AQAAAAEAACcQAAAAEBFp1Hggpn1mtBAnftWFiAguHMzX08je3gu4kcMdweGDKCSdiGeq5QMALLdWXGE3sg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba2b3214-6e7c-418c-83de-d2b5e2270c8c", "AQAAAAEAACcQAAAAEJy976SKDZEENRVwkKsJ/sptS0B8x8MU3grziotFdD4oO+s7tF/m8YBzoihTJ5EvNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87921e80-edfa-4d2d-a96d-5db89584a3fe", "AQAAAAEAACcQAAAAEAIp1EqSG+EC3Ppx8rN4zlZs+Gr9aAAn2/t8qxD4bCX7oSYCGGesr0jgZRU1Q7v+2w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "851913fb-e67c-483f-8148-be44c884cff2", "AQAAAAEAACcQAAAAEFiyl1JGGnfKFFhWYDOgbjQiG34b1FPUMqbRrtG8UkScKxL4LumfeMziLK2y24xjZg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb191470-5370-48db-846b-9a7301fa0434", "AQAAAAEAACcQAAAAEB8NimECZp4VWZGGz80zRJtanYhJ6PUysNC4wyhe7Mb5bi/k0fslRH4Rmfi+S590CA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cce4782a-4119-4cac-beca-e4be18354ed1", "AQAAAAEAACcQAAAAEHcUed4XdHSiPPM2S931XFt4necs0N7uRz6sYGcI0ZqXD8UZIe1S+DKMi/iwxRAt9w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3663d83a-fd75-42d5-8dfa-5f9b1e397a66", "AQAAAAEAACcQAAAAEOD7bnUvTt1bfyr00fRvb7FpdBUU9VPxzbf0JUHrIgYUK0/2b6UaU0vrADTg79A5pQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_ScheduleId",
                table: "Attendance",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_StudentId",
                table: "Attendance",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassPeriod_AttendanceId",
                table: "ClassPeriod",
                column: "AttendanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassPeriod");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropColumn(
                name: "ClassPeriods",
                table: "Schedules");

            migrationBuilder.AddColumn<string>(
                name: "Lessons",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "bc4ce3c9-b9f2-4432-b8e2-b2593e3ef451");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "a3c9d0ba-0b7f-4495-a80c-682d8b9e6c30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "d5120a5c-14d3-45ed-9fd0-ffd2ad910e5c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9bae3f7e-2418-4ea9-9cb2-5a93e916ed69", "AQAAAAEAACcQAAAAEGdIIlbXZC1N7BxUyF6TLRIuDVdnQeCKLt8+HttcDJYXq+WOKamIUUMPL2llnNRVzQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9614575-5315-4a1b-b35e-6766270d90f5", "AQAAAAEAACcQAAAAEIiJZA7F89cyMnJk6UCz9agWKFA5SmUH1PaqnjWVJOcn9z/RiLHDJrng8pxsaGhUKw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a4cd79a4-089f-4330-8f74-417f4e2f8c68", "AQAAAAEAACcQAAAAEA7CHuzFJKwnrGYHTbmTVqmJnNpOtzotv+HbyqWru0Ku4z1BLvQhqrVLmPQe2ZhrQg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "169a3d4e-3f55-442c-914b-389d27c69d19", "AQAAAAEAACcQAAAAEE95sd2dMhjvAC1ffNtWDkP6lMWr4RWotgJHlgN+54uM6cyBlWBXzPCgWunioF4xOg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23c2f003-a8bb-4def-982e-9949a41ca7aa", "AQAAAAEAACcQAAAAEMyeKRf2rkehj5M3j34pcA70zj8xM1EcMTiBO9zahkG9xoQJbf0OLaN8V5XII0K2iQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "adcb5372-d4a8-4e52-b37f-81db4a9f1dd4", "AQAAAAEAACcQAAAAEAlHcANLIcfp/8H9t/T5g4O2vs/crm2BVtHeA7LBtlJiWLNRHTSlcl7ke5w87fxd4w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41c97f66-a94e-43b5-956a-262ee3702e43", "AQAAAAEAACcQAAAAEDc8LIxxKgBOo4FxM4oq6gGpneaZHz9tesfrIhYBY3+GJh58D6S92B6l9hZ0pYG4eA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5989bfa7-fb85-4e74-8a4f-3928c6d81b8b", "AQAAAAEAACcQAAAAEDzEvqBlLuPOURTt3isiOp7jguA0d3qpAovo6eEQo/849Mog6ocZw4T+TgSOgkVz7A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02000a0e-747b-4295-b0f2-b76a25e98e8d", "AQAAAAEAACcQAAAAENQksgSfCAIUO9CS4XIDq2pNMBUTAqUkCkVePgNATr9fi1wIxGKK0RXT+DNGLzc+Wg==" });
        }
    }
}
