using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditTableExam18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duration",
                table: "Exams",
                type: "time",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Exams",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAllowChangeTab",
                table: "Exams",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMixQuestion",
                table: "Exams",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMixQuestionAnswer",
                table: "Exams",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSeeScore",
                table: "Exams",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsShowContent",
                table: "Exams",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberQuestionDifficult",
                table: "Exams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberQuestionEasy",
                table: "Exams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberQuestionModerate",
                table: "Exams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Exams",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Exams",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Exams",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f35a41db-388a-4105-a4df-fa0829c97a56");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "a833a98b-925f-481a-bd2f-25dac44974be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "9b9711fc-5e07-4ca9-97d0-a5f27b0e7ffe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6a5b4aa-3c3b-4daf-ab0d-ae23844febbd", "AQAAAAEAACcQAAAAEBnIDchRLCNi2/PvFSSCyxVo1MsyaK8WvWQ3jvw0GHcV+FTAYmM9oiXUNyouj/4ssQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a179b7f-a743-4bb2-a23f-0a6528eed93b", "AQAAAAEAACcQAAAAEDNln/Amc+v/bV+6RSxbZJ5tOUSQHcBYYUkdjesliw/DvYGqU+KJ0HVuXJj2OB3cvA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb053644-944a-4d35-9484-cebf63a1aa3f", "AQAAAAEAACcQAAAAEB5FoXSBSQV+K0T7cetxXHlQ4PmD+m2oTggprBqVonSFwNCq61LDNEUrdUaA407L1g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0566ec88-ff67-4840-bf6b-26315df28bf7", "AQAAAAEAACcQAAAAEHqLukIuUVVH+WsZ1/TCMMTrfgqO0hsY6M+s9F4ZAQr7POFzmv4EoAE7XRG+n2rmrg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4b44d7e-5731-412a-996f-33d30088f291", "AQAAAAEAACcQAAAAEFQGIw7EcVeaYHrWFfIyfeC2fiHdQ5hxgPYB7x5HuAKufO+TazIrf9zplOBbmlkOBg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3143909f-d932-4e3a-8228-0056434f63d5", "AQAAAAEAACcQAAAAEIv8KkG3KdNm1d6lapzqFSVHAZeNUKY4cJuoiPQS6hV0FHDLiNnhoKs8voIiKb/rQQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b4dfaad-79f5-4a4d-bcb7-661ff6df4433", "AQAAAAEAACcQAAAAEFFDPKKw7x0CvcBafMlheRZrS5B8FGaxnRp3nEsWwePwIltz5IZkyA35+ZLkU9O8Ig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4df9dc6f-ac9c-4875-bf45-dea464bf551a", "AQAAAAEAACcQAAAAEDWlYksulRUqI4UtB9gXzc1tP0qDelL1AuAYlGHnj1qRtGvJI6jQ/xKBrjWezBws+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa841cc9-48ce-4271-95dc-bc9ff5f764ae", "AQAAAAEAACcQAAAAEPXzfc7BVCVithrCFe8WxEBfpkjrWvDQM3YkIlfBWPzayhEtTCsTfJDMVm1QyxVz6A==" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentGroupModules_StudentId",
                table: "StudentGroupModules",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupModules_TeacherId",
                table: "GroupModules",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupModules_Teachers_TeacherId",
                table: "GroupModules",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroupModules_Students_StudentId",
                table: "StudentGroupModules",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupModules_Teachers_TeacherId",
                table: "GroupModules");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroupModules_Students_StudentId",
                table: "StudentGroupModules");

            migrationBuilder.DropIndex(
                name: "IX_StudentGroupModules_StudentId",
                table: "StudentGroupModules");

            migrationBuilder.DropIndex(
                name: "IX_GroupModules_TeacherId",
                table: "GroupModules");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "IsAllowChangeTab",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "IsMixQuestion",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "IsMixQuestionAnswer",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "IsSeeScore",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "IsShowContent",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "NumberQuestionDifficult",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "NumberQuestionEasy",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "NumberQuestionModerate",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Exams");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e4254d11-389d-478e-ae75-8192780a8d12");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "5dc070f0-e6a7-4026-ad7f-4c6484d8818b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "080c6bd1-9e27-4dc3-aa0b-bbb8afdbe545");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0912e0df-8834-46c9-b063-24de528e0692", "AQAAAAEAACcQAAAAEDeYcbPVZz7TZa4xqpjJuydH7t2UjqJgvGei/FZuYHR1W8HrWg6XMaLTtB4pHHb96g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aeb49b03-a216-40df-acc6-d879f0eb634f", "AQAAAAEAACcQAAAAEJ8KHx3w97xiP7gkv6L3t3PzOvr1OZwHEKa6ypsHqb+Mg2bgUIibkjOflwUnGz9UaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a2a00864-814d-487e-b9cc-0435be6fb19e", "AQAAAAEAACcQAAAAEE6X+6b9SXCkZQcpFqbokWZtyWxSBdSLdLFWah0XN8R6rFk/URAURmWf+2+j1fgafg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a741aa45-e18c-495e-850a-63d54e1781de", "AQAAAAEAACcQAAAAEPWRzlRisHFZxLYy+dgTVg0COQwbKaE1khVO2npSI8bKSxmN8ZO6SU1Rh35k7Sl09g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0eab852e-e040-4407-b982-e6493b8e9c5e", "AQAAAAEAACcQAAAAEJN6knEqgVDxe/QBsbB1/UpOKAaCzj3bXe1KWEbyRiwdGwM5mw5Th9+CtC7a/g+6xw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b0e15537-1a2d-4462-8ee5-87ca1e6285be", "AQAAAAEAACcQAAAAEJEAs3fAoapIU/qs2k4hF8sBaVMLthe8rRufiwQ7VUF2nBTYtHUaPKM6FN9j5lHaUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67d6e05a-7779-40d4-9884-a6066bec9e31", "AQAAAAEAACcQAAAAEJrBvvPrhIyVpKh3JKBwZ90OEBpyCKZzNRYnHgk8XeISyf5uCsjmEurY8jeS84+BpA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d39c2faf-0890-4840-84d9-50b458a90eda", "AQAAAAEAACcQAAAAEMlrSqKgEhN1J+rrbt6bsU0q7oXmqWztlU8bjoXyfsHkjEeWz5gaj0BYb1RtEZwi2w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8697a42c-d9b7-49d0-a149-07abb70b966e", "AQAAAAEAACcQAAAAEIyC0ReQNiC4jaFSQB4mI9iOxaQwfV4krw5LazDaUoqAbeBUiZutp9ZHYLw52oqwqQ==" });
        }
    }
}
