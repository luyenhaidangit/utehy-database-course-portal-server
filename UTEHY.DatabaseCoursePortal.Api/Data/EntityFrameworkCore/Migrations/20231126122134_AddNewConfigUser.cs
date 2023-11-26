using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddNewConfigUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Configs",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Key", "UpdatedAt", "UpdatedBy", "Value" },
                values: new object[] { 7, null, null, null, null, "Số người dùng đã tạo", "UserCreationCount", null, null, "0" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "18aa6b06-eeb0-4c72-b167-fb146f41c372");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "94e2cc59-4deb-4596-9cd6-adcbbb5530b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "2342427e-9bc7-4e54-9c51-53964e145c40");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4199a771-ea36-47fe-b2bd-771bc3b18bf0", "AQAAAAEAACcQAAAAEORxdm95yZf7QV/sThdOoU3QhrPFNPqZ3VcoBjecz1uxuyF6JmopTWptfCIxoWaEPg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7736955-a1cb-4b12-b954-073813630a13", "AQAAAAEAACcQAAAAED4hZ6r37qIRUshCNJO9YpZuuvrWQsXgl0Mns1uyfAzNJtrSSYgmw5s+26Y8I0HQAw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d89081a7-20bd-42bd-b18c-b24a306e1565", "AQAAAAEAACcQAAAAEJQIEpZ6CCFbwmPRAJDBWolXgvRSPQQ6xlbFAPfJ0kqvsCY7IJLgLQ1weySU6yzbMA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10f3a653-449b-4fab-85e2-ebe56c2b9a51", "AQAAAAEAACcQAAAAEPe0W/FqeeOEOhdFCC1pY1Z0uS2h1mZcFIOoVeNXWqePvWhr26MSZ0+Mx9Y2Mdo8yg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ca147a1-f0f0-41ab-859f-7c832c0ee7ed", "AQAAAAEAACcQAAAAEI/4dXsF0xbbQiOcsEHFK9JugN56edX82Gc+WY2s7Cl1WHfbDEPRo+mE5GvER4jzHQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06b95854-e554-4091-97e0-bb2206a51938", "AQAAAAEAACcQAAAAEH2EEuHmPGmQsbb0HXZZiyJIXmNN8VQgM46qRQwIpTcxp3LE/F1/Guyo2Zvzi/N/7w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 7);

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
    }
}
