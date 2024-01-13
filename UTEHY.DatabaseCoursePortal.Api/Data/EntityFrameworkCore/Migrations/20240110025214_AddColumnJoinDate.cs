using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddColumnJoinDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "JoinDate",
                table: "StudentGroupModules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "50fb4372-9964-4b9d-8b66-ff4a895bd105");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "3d47e095-0ae3-4c80-aab6-7a1ee184fdf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "8b16cc0e-6cf7-4e53-bffa-54ebcab810c7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cb9dfc1-09a9-4d22-9a2b-3dd4bbbc5018", "AQAAAAEAACcQAAAAEBCSlPWFxJDlmUEIj5r4XhzuBiMshTLGq6eHGZ1TegSrwDe4pBeCqCnUt1lyCiRggw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "acd1c14b-6ff9-46eb-bbd7-71b589c5dd5a", "AQAAAAEAACcQAAAAEN+ov66v9548rFctz/fkOxjde57y48Avpwd4JEzHGnVjFW8/G9dewbj5lo20sGCHcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42d5d7df-7e68-4eca-bb92-b6352b652748", "AQAAAAEAACcQAAAAEIc1uWIxzBZBawGvTUuOaQ9sx5UndyYz2RQz0e9HEU4IACtMhWNmcr17c/L713FZ3Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "593a5a4e-2136-480b-a55c-4e7a6014170c", "AQAAAAEAACcQAAAAEPwiWPSeZNoKNKddtWGJopWatoR4hQVxpJlHWviD2/fO0jcl6A1UABOSE8tojcTubw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16a6bc91-891b-4a1f-a581-b1d600ec3878", "AQAAAAEAACcQAAAAEH8ffHGFx2N92mjYqZdEG9roXMRiaD23COi35l8WnYjGZSfXOcYEnNowbIPIUpRTUw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e1eb60b-56c3-4014-9c42-d8e5498daf58", "AQAAAAEAACcQAAAAEMSIm7WgEd52l4QHydWtBTp9VmWmUOSSb7ujLNgyovmvg9BuTNseIjgZ1L5Dogc+Eg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce1c9952-c9be-472f-b8b9-d84b4fa1b7de", "AQAAAAEAACcQAAAAEA8UGRY02hD9yJC424CNvwVUffAAAat7sjpwGKE8ez6DRXkMUAJwJaUlHxJLbk7EJQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3678325-fac3-48a2-b139-300d33748606", "AQAAAAEAACcQAAAAENtL2h63VBmjkf2vNT6CqLaM7vJ3CYYAyTqdfLBtkeeBbB5W2QUnT/omrK95rMGemQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fc56099-d864-494e-93fd-d08f2f4316e3", "AQAAAAEAACcQAAAAEFDRAxhsx+EWJ0OlPZ1XGSpGJsxda6Uy9jZThHdaonFq2khLIndCvIjVNnxHLnMe/g==" });

            migrationBuilder.CreateIndex(
                name: "IX_ExamResults_ExamId",
                table: "ExamResults",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamGroupModules_ExamId",
                table: "ExamGroupModules",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamGroupModules_GroupModuleId",
                table: "ExamGroupModules",
                column: "GroupModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamGroupModules_Exams_ExamId",
                table: "ExamGroupModules",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamGroupModules_GroupModules_GroupModuleId",
                table: "ExamGroupModules",
                column: "GroupModuleId",
                principalTable: "GroupModules",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamResults_Exams_ExamId",
                table: "ExamResults",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamGroupModules_Exams_ExamId",
                table: "ExamGroupModules");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamGroupModules_GroupModules_GroupModuleId",
                table: "ExamGroupModules");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamResults_Exams_ExamId",
                table: "ExamResults");

            migrationBuilder.DropIndex(
                name: "IX_ExamResults_ExamId",
                table: "ExamResults");

            migrationBuilder.DropIndex(
                name: "IX_ExamGroupModules_ExamId",
                table: "ExamGroupModules");

            migrationBuilder.DropIndex(
                name: "IX_ExamGroupModules_GroupModuleId",
                table: "ExamGroupModules");

            migrationBuilder.DropColumn(
                name: "JoinDate",
                table: "StudentGroupModules");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "5d60f7d6-7721-4799-98b9-12671e53c867");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "727e9d29-c022-4cf0-b085-708d25bc5446");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "89430877-cdb0-46e6-8680-c7a80850f649");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7dd8d67f-f320-45aa-97a6-dca1856bbe3b", "AQAAAAEAACcQAAAAEMXKgr9wSQN2Ag+oR8jV2g3YYVd+8ZHYNR42Da4Qg6+E3nGx9JJGtUsb9kjO7jye1Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e878257-c9bd-401a-921a-d63bc62554c1", "AQAAAAEAACcQAAAAEBzzcJTv7Mx2KVpU8T7LwJjw7LoIyBSorcTqw3gsIBEFVNhB++MFjCF3/Sk33XtVGQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2acd5a0a-0742-4b3d-8575-0f603a39490f", "AQAAAAEAACcQAAAAEJbQ50BEdpeuggnGVU3z9AtdcJ82duvFHW28Sw6pLjvpMamk6wwqLX3WpAv1TbY93A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "329fc1b2-620c-4037-9c0e-cd1de3c007b8", "AQAAAAEAACcQAAAAEB9g/8HkyjVl4encypq/BZOsiz3E4JM/UaEJ/cGHl/ktdH0C1QscOINsaWr0qrfJTA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42894b02-efc9-4d14-bf8e-abfbec9c6eca", "AQAAAAEAACcQAAAAEBTCzyJljO2RoiFf5poMu80zWoS22ybDaXnR256+Xzf/XkqBElWVjkbrOSKOXQUtWQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "681105fb-d470-45cf-a6c6-b70947a5f19e", "AQAAAAEAACcQAAAAEMVdpkpt2xVBOlTxSlFHlFXja8j2zJ6Vo2RQ7WXSUqfXBSnVfU1b0faCjjRwEzvI4A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae1a90fa-2fb6-4d11-b355-afe303c40e8c", "AQAAAAEAACcQAAAAENJslT0qY24nGtci5OkeBl9rjUAavh+7NUeA+/pSoIkOBy0GsCB2u7k9rgQhwpyx9Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cf310f4-d544-4f97-878e-383b3c917fc9", "AQAAAAEAACcQAAAAEOlWavYjKNI8rJjcnPvNaBUKVWwnlUx7tPk0wjUy8TdCVIEQ+9Jt5c5eyD3wFuiUVA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02ad7bb6-dca7-4b01-a79e-f9d1e4e859ad", "AQAAAAEAACcQAAAAECKwBNubG5RgfD4E+niwNVxGtAljS+LGJUQNiJaoYSQfoSdGuIE3rpngdtwOmp6Eog==" });
        }
    }
}
