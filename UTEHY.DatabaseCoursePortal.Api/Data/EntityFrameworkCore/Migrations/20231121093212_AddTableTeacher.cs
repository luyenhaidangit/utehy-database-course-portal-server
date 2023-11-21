using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f33dc3d9-3846-4df1-9b72-9a7a1de2c7bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "a7d69c12-1e99-4275-95e9-3d4c41b8b592");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "/User/AvatarDefault.png", "6cc7cbff-09a8-4220-bfd4-dc2b2c5dff61", "AQAAAAEAACcQAAAAEA7pNwD4mSFVn4B8tpCrLkFyHaQU5bVdUeWQCJmPxTbz7XgJIcHSIkqqOGF2AEfr7g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "/User/AvatarDefault.png", "c9d6bfdd-254c-43da-b3e3-8bd0c33094ac", "AQAAAAEAACcQAAAAEDiaCEUBlyitbpRlqe9UFKBpvJeFJB5AXJE5FcEuKcdhqFles570QI5awOIX/tYHnw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "/User/AvatarDefault.png", "0cd0b286-cb1d-4266-80a9-da87bf0fa778", "AQAAAAEAACcQAAAAEGTC3o3w+Bkn9YxacqF2IIuJgcAbT4rRVRH3M9ZEEaHXayPJ8kb3N2so3G4/yOoDfg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropColumn(
                name: "AvatarUrl",
                table: "Users");

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
