using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class UpdateCourse1218 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TypeVideo",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f96832c4-bbec-43f7-948f-63605d9e852e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "80f18498-80fc-4e11-bf3f-61327b439a67");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "bd520427-04e5-4dc2-9db0-c8e38a9367d5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fe531bf-3f16-404e-91b2-8ed29ceb3d08", "AQAAAAEAACcQAAAAEMBAYzzlJEnMiDan2LDv5qxn66vJMI44egVPCrrje7ESvgnJkBOfvjv5rz0lTilFDw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f424ad6-2719-4753-aeb7-1f3a26e95083", "AQAAAAEAACcQAAAAEBRW81QjRPrl9w3v0yj4vJLjI0QVrE3Mi9es50r+cdOoSz86SNGFUxKNVFvgUikQSQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c5f3102-4ec4-4ac6-a057-dfb44ebe5dd0", "AQAAAAEAACcQAAAAEKTOawh/iqsgm1E+IN0nwP7ogKPIBGtKNGDwFz5v4COUXHzj/7wRSNNS30ldTmHg+g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bde5ddb6-977a-44f0-becb-94ea28240ad3", "AQAAAAEAACcQAAAAEN7cwddQqgYDcfA6NyZ7JpiWrGI2C3lPMHjDp/ijIecjU82ijKU3sCvhXVm0K5LL1Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "952d9b12-6546-4738-b1f4-85fe366a0d9c", "AQAAAAEAACcQAAAAEE+SfrL8kmCe1KdFUh2DtkmKwBS8DWYQihusxsqiErloBKmE/f3l0WoFcvs9lWlofQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a04ab776-1b44-4bbd-95d0-891ef2784039", "AQAAAAEAACcQAAAAEOSBUGDo1kuSE83U5rQP48nFqX2aR2VDNb1Cz9wzLL+nZ168XwYo3O+rnBJdur/R5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64fb214a-3858-43e5-99fc-d02fefe50786", "AQAAAAEAACcQAAAAEPz6t+0AA+AcEHaxbE4iIBnmbyaPAgG6FKRTTc6dWdtzkA3a0UnSaErCVb0APjkGZg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fb645f3-2b8c-49b4-a0d4-8a34948cc102", "AQAAAAEAACcQAAAAEMxoE/03IBTQ5eq/YHHDfaHkGQ4Wv8yDDWR3OpPvZlarUtqyvUyf2rl++/Ijt/H+Uw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf6546d4-539e-4c78-963b-21310512d740", "AQAAAAEAACcQAAAAEEVnvm43fdB1Qq6iDCsWMK+KtX8m4/pXguO41F67jJIaZ2OtI9bNBN31xYcidpU+lA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TypeVideo",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2f39b9c4-7d34-4880-85ac-3ec2ad2265e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "ad7727e7-33ca-492b-95e4-0708e451f35f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "a30d22d0-b454-4880-a019-7a8ad01bd4de");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e19fe1ab-2e81-4652-9cb0-61dff4205ef4", "AQAAAAEAACcQAAAAEJT6iCUlNS67YRMfDD5TS1V+2hnem7Y6oMXtdN+8ik50D2CWh6uHjNBfL5JTsIMDVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e850c54-42c5-43fc-9397-e01391eec510", "AQAAAAEAACcQAAAAEOFi3e+X3fsM6UljfrCGmEy27/yUhRY/e+U961kCg/J0rPoX8pAMykmQNy5ADSw74Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f81b8e98-79f3-401d-8582-a7701521a920", "AQAAAAEAACcQAAAAEHsqSwezIkW2X3FmxVbxfbtDYsFH9k9qJukARvP0cD7InamMT1d7OPbt+X5x0zMwzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7774d578-51f9-45e3-9b19-934323c22dd4", "AQAAAAEAACcQAAAAEDa2qZpUBMFnrw2Vy0SDvyT8wyXvPC+6LYxurtWrMRgaaL+OoKNgoYwq27zKft6q3g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4bb62e9-d400-4bf6-a7e4-ff388dfd84eb", "AQAAAAEAACcQAAAAEMs0XQ4pY4eVn+HJXo28FK/e5A1U0duXyPBHYqrhUwWANqd7OAwo5zMl+VsYgbjCSg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6343bf5f-005b-4862-979a-25c42aaae827", "AQAAAAEAACcQAAAAEAi02uSWuwrBnYNZ+VGYK8pjWe21FbOPPyBfpyf0Ik2jHFKE+mpMe9TQFmiKXiHhZg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04912d2e-b812-4a40-b252-a043bfa9e9b7", "AQAAAAEAACcQAAAAEM20EN6Cl9e+NVdqOJiWxKNI3xMxIW4Qo91u2dlWakNkyrDgLfWNO9SjKSOF5fronQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5471e51d-13f2-4bf1-aad1-9defeeb9aaf2", "AQAAAAEAACcQAAAAECVOjCEFyjhn1/LNwIbYysa7Ia8GowHGg98xpq7bLxFqBH/bcRNOhw3qwcqOSf3CBg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c0909e3-367f-4fe6-8e7b-c6c4cefd4d51", "AQAAAAEAACcQAAAAEJ6b26MSKi7tga4V/+W9pDVFnnzlxu2ID+g1aremXNQ9IP3g0y2ckXI5fB9stUKicw==" });
        }
    }
}
