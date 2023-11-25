using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class UpdateCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackCourses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "VideoCourses");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "127baa33-b555-497d-b0d6-71c1f160b3de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "d8c6755d-a94c-4c29-85de-dd04df66a75f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c83348c0-2511-4caa-9bb9-47761df4f318", "AQAAAAEAACcQAAAAEI8HJbak6FjE1w1uhQ+81zVVCcesFvyqpaLwxttIEE3mp7xjFxou8v0oogASrn9kgA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff7dbffa-44db-4955-8441-d57f3cf5f875", "AQAAAAEAACcQAAAAEHcfnc62XxlfZIOkp6VWVWEr2chzDO0P0c/crONGkyNh/wEXVzZHfxTuxGHuyGJS5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "660e2513-bbb4-4b81-94ca-8b9022aaceed", "AQAAAAEAACcQAAAAEMsOO5KdtxFHky3pX/BwsF+5NjFOtJtoY+KC32eNhewk7o9lRYLrzs6U/0gr+heFCw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "VideoCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TrackCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Progress = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackCourses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "118654f8-2468-4169-840e-0e99e699a062");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "406705e7-7ea5-4742-b996-660c68d51f3b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e41ef43-c21f-413b-9109-85aa0e1d7763", "AQAAAAEAACcQAAAAEMsKA3WGGfdhIA4z0m69ZRB1jfI0seD2C7V9Pdsof4rRruLuiS3P/yxNLorc9Kvcug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77f1f55d-9d1c-4cd1-b1fe-ef32aea6264e", "AQAAAAEAACcQAAAAEDcDSdmcHUBLQiw6sqoMngtwC0ai3IH7IRV3UDwyCBtqd+CQyPEdpVE/vVHwh6y+Eg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9661fd3-75b8-49d5-bd7b-f028b5c102a2", "AQAAAAEAACcQAAAAEPRTAHKYAOixrsb3mFYRWzSfwIi2i/cqkSyttQSSvj1EDrKgMadC7dCOnRK32niMKQ==" });
        }
    }
}
