using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditTableNotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e5f6241e-8385-44cf-a9fb-c6e385703c05");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "f2430128-3434-4372-808a-6f268d640d93");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "59566754-b188-4644-986e-c6569d15110d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "730ec2b2-7fb4-483b-8dbe-dfdbb7885e78", "AQAAAAEAACcQAAAAELZZ1Crzmq5L0VWz3s4pe0foQmtSzpJDmAOBtOieEDkGpWYmyaPAZ2ri6bzkvq3O9g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57a43da8-0578-42a7-afe6-7388dfef8265", "AQAAAAEAACcQAAAAEMAxHH/d6Sgb3qJZe0UYf9Zw7462CLvEz1NwCVuTZa3wPMDJ6Ihubsyfh5Ssyhk8tw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4db2597f-b2e9-4237-9dfd-91c831943bdb", "AQAAAAEAACcQAAAAEOweVDCo6jsyLjU7/aEKAaRlaPgCIMJPZZJpzIQySyhrbMcfytENVixYHao0enxQfQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "446adbd1-0d9c-436a-b95e-948b8704ec1d", "AQAAAAEAACcQAAAAEG83QVjbRran1wToUchq6dsstB/iAXT4nPp/xqaRAyC53Mxw5S3oRznybGa/+IseYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ea8e8a4-ae92-4d2c-84f2-90ff3e3dc7fe", "AQAAAAEAACcQAAAAEP3AeVOhU9trRbmDMwNfeRg/qJ4w47UkLI5DFjSrK+Z4I/dfZfFnAbTx/p4np+gX5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2955520-c1be-446d-be50-b26d7aa92dd3", "AQAAAAEAACcQAAAAEOYeOFAOzPwHJiXTlwmojPwzVzs2vVcN0TeXwpSh0I94ClcKHWQsP+ZJNbx2gOUeYw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdac9cfe-d72a-470b-b164-47455301b9eb", "AQAAAAEAACcQAAAAEP+P4Y0CKfpo4leu4QH3FSYpgvda0LiGYZ1DxFBFLQqgtGEHaIX0f7Tbj39mDBF1lA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "512a221a-64cb-4aae-8ecf-63e45eb3677b", "AQAAAAEAACcQAAAAEKKRXnpnQ1pzdtumBITcVuy5ja7r4EKDOYmraKDaKh9G1G4+F44p5QhStiBxx+TWZQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5de1eca4-96ae-4b09-b4e5-5f5a6250be2e", "AQAAAAEAACcQAAAAEAhyvLS53wT1WE8kNpeqULKNtDrvlTw4B/JqnYT0G/O408NzQ32NpdWdLu/pwGLEyg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SectionId",
                table: "Questions",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationGroupModules_GroupModuleId",
                table: "NotificationGroupModules",
                column: "GroupModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationGroupModules_GroupModules_GroupModuleId",
                table: "NotificationGroupModules",
                column: "GroupModuleId",
                principalTable: "GroupModules",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Sections_SectionId",
                table: "Questions",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationGroupModules_GroupModules_GroupModuleId",
                table: "NotificationGroupModules");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Sections_SectionId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_SectionId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_NotificationGroupModules_GroupModuleId",
                table: "NotificationGroupModules");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Permissions",
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
                value: "49fdadf6-4159-47e8-a39e-0437e085e35c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "14169643-8e1f-48a8-a4da-6d95bf4bff0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "fd1a70c7-7d39-42f5-8b3a-1f141fc48149");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28de65ea-3a84-4577-8fa7-8917c4556ae9", "AQAAAAEAACcQAAAAEGofCaMEycrmyXO0TNgGyfqol8tgXIWVrq+oZlEEJ7HCJ37+RovBSR6GJlLDtMvtyA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "081fe78a-2f55-4655-953c-7a28f3a72089", "AQAAAAEAACcQAAAAEEEWOO83sKJn8/93niL1sSTyx4uWIrJCkhegJHFrtajRgbikgZnbcMYHMRPYf3hxEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69d4329b-4c1f-40f3-8b94-20f2de09159e", "AQAAAAEAACcQAAAAEDCT3xpSs8lxFgdUPilWXW0PvGhe+xyYzHawH/21SFeHQDZqeCC8PJHnKO/r5mAwtg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86839680-a1a5-4505-af55-6556a951116c", "AQAAAAEAACcQAAAAEIAoJc95vkPuShMIqcXILAW6nMznbyO+iFw8QyUX1BZmZVxNCvsi5o2Si1/HOUqQjg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cad50b0e-8853-4ab2-a9f8-43ec81170b7b", "AQAAAAEAACcQAAAAEEYsyMqydE81ZEt8rsuQDvQQld+Lxv2RE6eLrA6W8rrPZIShL9esMEVomJaQxQRDiQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e42b790-0d54-4fc1-8391-9d60c8352837", "AQAAAAEAACcQAAAAEMvbKCfqF74q6LBuS+tnVIFOOCLtp4CZJXCaRNeEaykiLETqqBj0IWG8LPf5wu1E0w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "50b5e77f-593b-4fdf-86ad-06dc2dc953c5", "AQAAAAEAACcQAAAAEJEHmbJ8i8aUWCpvnB10upXfemZXz3CNOOUFsZVSD0joE9JWLmuWnufks3M83OWmgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d3da4c6-bfe2-40fd-9e27-c80638804142", "AQAAAAEAACcQAAAAEJOkf8fg0zT7MLYx8oZLslOio61oId09TpUAgIYot2o4ACdC5fOkXQNDQEOx0tfcDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e3d6af5-0eb1-4934-abb9-c0375296c083", "AQAAAAEAACcQAAAAELO11lQOh/inCWJPrthdqlRRBLKGGGMLRqLNHKIQ2X5Z4plAM3LC191K20MIpkh+QA==" });
        }
    }
}
