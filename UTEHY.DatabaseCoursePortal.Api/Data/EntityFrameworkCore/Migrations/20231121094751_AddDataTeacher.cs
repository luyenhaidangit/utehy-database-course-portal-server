using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddDataTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0e94e363-5116-4cc1-9110-cacd98440d74");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "522d01ed-df77-402d-9429-321ba5aff65f");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), "094786c3-843e-4a20-af69-391b476d8542", "Teacher Role", "teacher", "teacher" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Status" },
                values: new object[] { "0f0d9f52-515c-4cd4-85a1-45fcb7946029", "AQAAAAEAACcQAAAAEP+CUiv7DLa8C6AqnMpNuazi9lv3UxhqTu+btjQTryorVnI/dvMIfJWG6GQH1aRznQ==", true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Status" },
                values: new object[] { "f67822a5-d1d7-4529-88c9-19b0def3209f", "AQAAAAEAACcQAAAAECNyIRwn780PHK7oGWnSlfRqJBB7dx40uOffMNml6WPDy4X4zlp2vGEYP8CfsGcSEA==", true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Status" },
                values: new object[] { "931eb538-86e4-482c-a672-9dc9aa18933d", "AQAAAAEAACcQAAAAEJUzVg8eGeOFQRkP+AtFLuLW0m/ApunMSQ4F12d1VP+2cHLRxd98aNzUblussJEzxw==", true });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AvatarUrl", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"), 0, "/User/AvatarDefault.png", "a9de2361-a18b-40d7-8cb3-2f516b202fb3", "daoxuanduc@gmail.com", true, false, null, "Đào Xuân Đức", "daoxuanduc@gmail.com", "daoxuanduc", "AQAAAAEAACcQAAAAECmSo2enq8hAUWd5U8bDJ/nyYv2tSaSzPpR6cwGemRLpuJdkpbvW8CfdMqJFT2vT5w==", null, false, "", true, false, "daoxuanduc" },
                    { new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"), 0, "/User/AvatarDefault.png", "d163e620-adf9-48f7-ab36-dc03941ec6f0", "phamxuantuyen@gmail.com", true, false, null, "Phạm Xuân Tuyển", "phamxuantuyen@gmail.com", "phamxuantuyen", "AQAAAAEAACcQAAAAEOWxA7ITWxbxlnab9nCrGW/Q2wRDOIXf0PAv2L6ug86D1npFcVzQ0LI1S5AM5DGbcg==", null, false, "", true, false, "phamxuantuyen" },
                    { new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"), 0, "/User/AvatarDefault.png", "d7dccf97-6df1-4d56-ae74-23daa734b2bb", "hoanggiabao@gmail.com", true, false, null, "Hoàng Gia Bảo", "hoanggiabao@gmail.com", "hoanggiabao", "AQAAAAEAACcQAAAAEH+F1KF6uEpXfwoEL7JoAS/fsLfZGfm9RG7oE5avCKm+qoVWRRz1efgeTI/OqlTN3Q==", null, false, "", true, false, "hoanggiabao" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"), "UserRole" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"), "UserRole" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"), "UserRole" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6cc7cbff-09a8-4220-bfd4-dc2b2c5dff61", "AQAAAAEAACcQAAAAEA7pNwD4mSFVn4B8tpCrLkFyHaQU5bVdUeWQCJmPxTbz7XgJIcHSIkqqOGF2AEfr7g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9d6bfdd-254c-43da-b3e3-8bd0c33094ac", "AQAAAAEAACcQAAAAEDiaCEUBlyitbpRlqe9UFKBpvJeFJB5AXJE5FcEuKcdhqFles570QI5awOIX/tYHnw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0cd0b286-cb1d-4266-80a9-da87bf0fa778", "AQAAAAEAACcQAAAAEGTC3o3w+Bkn9YxacqF2IIuJgcAbT4rRVRH3M9ZEEaHXayPJ8kb3N2so3G4/yOoDfg==" });
        }
    }
}
