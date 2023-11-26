using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddColumnCodeTableUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "02cf4571-478d-4306-93eb-f7e20ec625fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "ec279873-ab84-4e7e-9a9a-23db4c91fb2b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "413213db-74c4-4619-9527-a65b27aad978");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "Code", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "User3", "b9b31bdd-7669-4668-93b1-af7c8f291376", "AQAAAAEAACcQAAAAEAamw8SE7LPU4hEVC9Fw7zsh2WWsw/PabLoeEkSA4UCMVPvnLOByzCixUs2EBgqWfQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "Code", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "User1", "217354e0-7696-4c92-a5d1-1177a0c643a4", "AQAAAAEAACcQAAAAEAk8OTlo7ayzs7AGq7MRBfGpEEBuWz8hx9YpelZNKoFT/k9zD2MUI2IwLOTeyDzouw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "Code", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "User2", "d0ec500f-982f-495e-b9bf-889adf0ba967", "AQAAAAEAACcQAAAAEDs4FyJGp4I5PGnJxMD1u7gxP8w+m08s63yQnocWAGk0ZeU6z8fyWFpWIAqAzmZ2Ow==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "Code", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "User5", "ba58c8dc-67da-4773-ae0c-59e6f6289352", "AQAAAAEAACcQAAAAECBg4rsGrKU2MDrBdDerUWj/kASmG1ufOImm/Bybmlto45Qt2XEcbSekPbZn99e4dQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "Code", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "User4", "82a018af-f6a1-4630-8fdf-a3e94006daf9", "AQAAAAEAACcQAAAAEOoQaTLbOqPLcOkjXAttgCT04jblL1my+57hpg1Y8jAb8YvcWDCXOXRARPT1oafnkA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "Code", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "User6", "244c4d67-b90b-46ee-8687-35ad204ecf0b", "AQAAAAEAACcQAAAAEMy3XlXHBly25zBy5GaCyOTs0sYULeaKha6I3PfGYND7b9lyUuSGq1SOlxxnWGT8gQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "998b7ce7-2e6f-40f0-892b-f84cf6fce1d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "d0d0f456-b434-48ca-ac97-bfc666db7e14");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "ef03d57c-78cd-4722-99cc-184039e7ddb7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69e5bdef-a0a7-4e5e-ac0a-7f79fca2a994", "AQAAAAEAACcQAAAAEFHe66R47qOBVjNEadHU9dXCsI3QOeYdc2Jinjyl9zHhqaBomeEm4CiB0AcP93WSPg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a2d59859-de6d-4293-9e16-28fe56790be1", "AQAAAAEAACcQAAAAEPdHE6J4U0YutoTsVIsmPr1xXwIsFeaSKgCwG2k8mU+lbPM+YNDBO7LoK6q3WvMIGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a16b975d-f48a-4c96-9e83-7ea28865f6b5", "AQAAAAEAACcQAAAAENXthXRVOdqMyr1FcoA7/vS8SHsLeWFGDA9MLixeEqJeSMHvHmkHlwJ05PKvIjvN1g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a696c3a-afa1-429b-bf5c-fb3c6a7c5733", "AQAAAAEAACcQAAAAELTuffPNw8dgVzYncC2/1VM14lT/6G3tmQshYnAWs82RUdbB3w4YvbybJcPpjVmk9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b65d06d4-1b74-442b-bbff-56c87b4c651a", "AQAAAAEAACcQAAAAEFrz3YeZOraFy6/Fs5zGmTBe045ny1wrv7Sj+L09ntVt8WR7xacMvxxpzV2UfUcr2A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1b9e785-3664-4973-a974-2c5d50d1a6ef", "AQAAAAEAACcQAAAAEGGJr4c1/AmANwyBmURzGt0I0CckmS5Y8Qmy/0yoFsROCJ9DqyewDbL66WcoNgCamw==" });
        }
    }
}
