using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9c01cabf-a58c-4832-bcfa-a87f8bf94a0b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "4a73f04e-bf5e-431c-8793-a81711fc6391");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "144a26ea-9b75-4ef6-a362-5d0c5bdd78bd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10f679f2-e135-4854-8c66-ce0dfea5f079", "AQAAAAEAACcQAAAAELxxAP77K/GJpQg06JbptcO0VGPaxeIkszYnLwLBm8ICrIwj/LfACNRv3HxuoUy6Mw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66d33749-b1c7-48ee-a4db-6e8a77566adc", "AQAAAAEAACcQAAAAEPG9wbqdhZpyEOr15d1rB7cqds9Eg+8CORLqCD1VXc3U5xC3hzAxAsykB+V79rU68w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b11e5a63-3154-407d-88cd-6e12f7afb2ea", "AQAAAAEAACcQAAAAEEhYlBDlHeFi9VfvI402ob0/y601eRfNqoUltlVZxyatIXuii1cXaVu2E5fC2+wkOw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb0cb000-d647-4ee2-b143-02dd7e3b451b", "AQAAAAEAACcQAAAAEAvWXUWjgFbzfxtJZxFt7h/Ux10hFdOiXwf/Y7RXoK9VIMMc24fviDROVMcmzJQ27A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ca88793-7908-4517-9e83-32be0adb8ad0", "AQAAAAEAACcQAAAAEI7N3ysDkZD4sGK8Geax8d3bbFowfyHcdIKURk2zujRiIrI2lvT3HKfJsFYb2uzL4w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "05f05725-ae89-4c2d-8dbd-9ba6ac65b879", "AQAAAAEAACcQAAAAEOBbMsTTncqJgXXp99arFr+NoTNCPfmNetKkUGiDLyNE7R8gS2ozjdK2L3hXj67BRg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionCategoryId",
                table: "Questions",
                column: "QuestionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuestionCategories_QuestionCategoryId",
                table: "Questions",
                column: "QuestionCategoryId",
                principalTable: "QuestionCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuestionCategories_QuestionCategoryId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionCategoryId",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "cdf7c9b8-667c-4dcf-8875-c38026b1cf0a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "0a30bc14-14ea-403b-97bf-92ae497b1c36");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "109ac8a6-88dd-4780-bff9-3392472a8761");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba9c2ad3-c99a-433f-8174-e3079f75d3cd", "AQAAAAEAACcQAAAAEM640JsAZ+k04U7exvi97OM0iqZCqI164BifjgDD4h61vpLWdlIFXg0c3lloxM1UPQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67c7d3e5-d80f-453a-91b4-904b99e31fee", "AQAAAAEAACcQAAAAEDjBBlS4M7EyHw/sKNVX+woHYiYJ7JaYRXfwSJrWZW1Ly5sros/TTteDKRtY0rgzmA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea76c250-aa51-45ba-90bd-d533a2cfb45b", "AQAAAAEAACcQAAAAEAZIc3H4cC5ejemdJh5/FOBoC+nvwkZC5rbHH48IMWH8AXqXCyp24QlTLhzSuF/k4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7964bc3-4592-4e6d-b2a7-fc3356a77bd2", "AQAAAAEAACcQAAAAENKF6R/q29M1CrklLmdmWH4JQxdIkhUKVXkrIsRAsMFL1fuq/swnSvJFsd9Nv1Vl9w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2bce57a3-e60a-4d1d-be9e-cd3394343223", "AQAAAAEAACcQAAAAEAIOmBMOtZwEV6osO4SOaAhWUHt46DvhI5OJUISGts1vWHUxRFNeYT4gGcdFFUgF4Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38cb81a8-ea85-4e60-8df1-752d71a95f5f", "AQAAAAEAACcQAAAAEEAdJEiQr00AfNOuxAtvYHZzfvWjh4dAfG2rRQ6TduE1HrGnfmv7xI2gsZcEEnwA8Q==" });
        }
    }
}
