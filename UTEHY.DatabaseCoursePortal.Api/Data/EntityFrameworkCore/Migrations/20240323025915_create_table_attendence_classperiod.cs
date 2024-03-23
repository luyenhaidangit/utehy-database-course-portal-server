using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class create_table_attendence_classperiod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Schedules_ScheduleId",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Students_StudentId",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassPeriod_Attendance_AttendanceId",
                table: "ClassPeriod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassPeriod",
                table: "ClassPeriod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance");

            migrationBuilder.RenameTable(
                name: "ClassPeriod",
                newName: "ClassPeriods");

            migrationBuilder.RenameTable(
                name: "Attendance",
                newName: "Attendances");

            migrationBuilder.RenameIndex(
                name: "IX_ClassPeriod_AttendanceId",
                table: "ClassPeriods",
                newName: "IX_ClassPeriods_AttendanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendance_StudentId",
                table: "Attendances",
                newName: "IX_Attendances_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendance_ScheduleId",
                table: "Attendances",
                newName: "IX_Attendances_ScheduleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassPeriods",
                table: "ClassPeriods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "10cccaaf-8f66-4e1a-ae16-8110b7d71e42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "dcc6f327-ecde-4da8-a649-cd8d98ddf70d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "ff788343-4ee6-40da-b79e-bf50f0b5f8b4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9829653-9c7c-463e-bab3-72e4ab7f4b1c", "AQAAAAEAACcQAAAAEFYM6rAJEqHHs8cW1xCe6AS8XwQtGn4R0F/CuD9q9Dk6uG/HtEci//rxhgr9JXdQ4w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b8d1e7b-ab96-472a-a025-243bf94bcc78", "AQAAAAEAACcQAAAAEJ+r6QwmpKsRREcz8e8xvSkl3FboosGO0/HEOAWEdzTan/aaGmWNz2Xfnqk4TN+fLw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46f5fa78-bb68-49fc-beca-7f4b29dd8bc0", "AQAAAAEAACcQAAAAEFPAae7hY3UWraxOSRDihIXkNlfionfP9NuVH4FUsZGW0UjlWRcUc/HLZk6CMcvyyg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3821defd-3061-49e0-8207-e76b237fcf30", "AQAAAAEAACcQAAAAEKbjXaYsKqy8yIVR/BYpzk586QTZ/vr5+Zckm76m6Zo0DKFod3+GxSr8+8Hp73ToWw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2cad068d-c2df-4737-9838-83128b1cded3", "AQAAAAEAACcQAAAAEDRa/pi1ZZpok28+HQVSyakNI+OULFSNZoiKU127snLLYDzmb/C2ce4qNwu69hvsqQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe81f865-2f24-4c00-b0cb-0ef7e74d2824", "AQAAAAEAACcQAAAAEFqVF2dnIejUDxueFSX9Mj/J7Ik6FhMqnlB70c98o73n5OJBbQpvwo9FFDAZH/uvZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb54860a-bfef-447a-91c1-e3e171c134c5", "AQAAAAEAACcQAAAAEBl6GSKGuhA8UbNtk8PhIazaUuzg1JqUpg5+o/sLrjAAywatTOtqMs1eQHszpgqe2g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "afa1bad8-6758-48b9-bf62-5c99be61d818", "AQAAAAEAACcQAAAAEEsQbi+v2bUfRjNS6Ti0c4YCRFqOPmER1uAy2LnhmwsABiW7OysPloRz4JISCxexLg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af8b662c-a34c-4e1e-8a95-0dfe8e52ae75", "AQAAAAEAACcQAAAAEOhGdLNDySS57o7rgiLOHhGBalh2IUis6VJ+aMuzHRlNCbRYOmP+eYco6jYn2out7A==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Schedules_ScheduleId",
                table: "Attendances",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassPeriods_Attendances_AttendanceId",
                table: "ClassPeriods",
                column: "AttendanceId",
                principalTable: "Attendances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Schedules_ScheduleId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassPeriods_Attendances_AttendanceId",
                table: "ClassPeriods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassPeriods",
                table: "ClassPeriods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances");

            migrationBuilder.RenameTable(
                name: "ClassPeriods",
                newName: "ClassPeriod");

            migrationBuilder.RenameTable(
                name: "Attendances",
                newName: "Attendance");

            migrationBuilder.RenameIndex(
                name: "IX_ClassPeriods_AttendanceId",
                table: "ClassPeriod",
                newName: "IX_ClassPeriod_AttendanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendance",
                newName: "IX_Attendance_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_ScheduleId",
                table: "Attendance",
                newName: "IX_Attendance_ScheduleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassPeriod",
                table: "ClassPeriod",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "025e3d22-56a8-44d5-a9f1-2eab14276059");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "e244aaea-bef2-4519-b105-e0e822b8e993");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "04e97e38-0f63-4e6b-be99-8bf3836d0250");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a6eaa63-acf0-4052-998d-dab89d63524c", "AQAAAAEAACcQAAAAEAQdnA2hg453queMSshceLjbXYqpL9KMMYfydyf8addQ4JUEuBIl0Ni8M5YEDdTXUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b9c2c09-c150-478d-ba4f-e7716c55c9f7", "AQAAAAEAACcQAAAAEB4RuMxdUkBbnM7lmAO/5rcgtyQOy/Tx7YREcJQwSD//HdB3AAP/7b5oNI8NCjhyEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40c7fd6a-cb40-4e1e-a758-226d0402f6ce", "AQAAAAEAACcQAAAAEIHNlC3OXAS5g6XmmuRTCa8eEsRlgjCqWfqzFprGKtnP2MY5WZPn20xrVarFA4UcTQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea311259-d86f-49ee-84bb-4db52d3a7226", "AQAAAAEAACcQAAAAEHSlOyEttTVWp27J2bxfqz5IxaSXSAgu+KB6oo+T4cTF2W+nPfaw+idc36wO33pYGA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16555827-ba0d-4c5f-b942-51ab401ac5eb", "AQAAAAEAACcQAAAAECxPOIEo4cLaPEDaE1yFRn/Tc8K2I33P7sXMYowKxegKOC7kz+j8o4aGQ4c3JfRt3A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1d03870-39d2-4adc-94ac-6846f13166b0", "AQAAAAEAACcQAAAAEHGD5aQYT9W0R7sN3giqVspgaElRA8PGmHpC7dejIEJukw1/9G6cGBk7bX6gXB5dbA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21cfeae1-fba1-43f8-a283-d11c00b2088a", "AQAAAAEAACcQAAAAEJBLsJwMxXP3hWde9dJAcqXTsRUoykToXCn62+K9XKoMnAzIQx4b6KvaHaQSyLjXig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa32b431-aafe-4a9c-b27d-7ca876057e93", "AQAAAAEAACcQAAAAEFWKflynwKj/p9tK/n5S01Vjtwmg69dyTaLwAVsAC3pwAEA8qwz/QdCaxuHAuuLidg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad35429e-707f-49d2-a70f-2239ba51c55a", "AQAAAAEAACcQAAAAED2Hu10Jf8QxVS3xZ03J/hA0h2Ym8ID98qCUmYOB14Ah9nyY+pgf6lhcJbSpjpjo7A==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Schedules_ScheduleId",
                table: "Attendance",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Students_StudentId",
                table: "Attendance",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassPeriod_Attendance_AttendanceId",
                table: "ClassPeriod",
                column: "AttendanceId",
                principalTable: "Attendance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
