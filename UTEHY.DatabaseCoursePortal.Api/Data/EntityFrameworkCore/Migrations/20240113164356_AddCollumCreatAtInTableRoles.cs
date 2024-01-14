using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddCollumCreatAtInTableRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "27b68125-5da3-4f48-847c-248a3940cdfc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "7385dc71-9e33-4b78-abd3-0b066b1e71c4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "e7164a90-eed6-4dae-893f-1a06fef3a218");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd807023-34e0-44fd-9c2d-7c22b5355fe9", "AQAAAAEAACcQAAAAEJL88WtyeG9vtHxzncVY8OlQoc1bRjcreKiDYcYpQ3MPq9wMwWIPb9ZVDzd9q7ITZQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81ad98e6-94d8-4b31-9256-518bbb207ce0", "AQAAAAEAACcQAAAAEJZiQSu/gXq4aqwXh9BmY/QHRkubQnHpUs1qsyKC8DbsvJm0AHCe+2k7OwDDULpWlA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9afd5110-64f1-4588-9fec-f8d72e035952", "AQAAAAEAACcQAAAAEGkGT+tw2jjAMXoyOyBSephvdNhyHilNGGLdALScYbATZCB0LdJK5MKqaz9uTukdCw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "073eb1ed-6fe5-4438-9347-3418172b1781", "AQAAAAEAACcQAAAAEH9f+It/WS9rZ0X3Cgq9bgxqW1wKgBSt2z2ZGeoqu3ihxvGtpmIQTNPjsbcqIiYfUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40090770-3a64-43a6-94fd-0b7fc1d6a90a", "AQAAAAEAACcQAAAAEHjsaf21rIZTY0JM7HO2iBtCwZu1virTOoux0AHkSHf0B2MrXt3hKplXpN6E2oDqQQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "811fc611-038f-4ffc-9571-9fbe2d493eb4", "AQAAAAEAACcQAAAAEDXDoOSPnGO0DhI0s70kT8KkXjOyBg1sfVvpTnmNw2RnP+eWEBN1JF5lsvj59CA1Og==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5166ceec-bc56-40a6-bb91-a4e22ce0c129", "AQAAAAEAACcQAAAAEPo3tHOI9kgH4rxnReRZNrhgKTMqumy/FELVRR1gZzqgWY5HdboSGaeT2jvKup3XGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f3a8cbc-d94c-4133-b63e-84eeeca7e671", "AQAAAAEAACcQAAAAEOJPqSyTGjYC2g9whAxKg782qV9Wf5/nvde57LZGkOkAq6Omis4sNp9BhtHSGh+fOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "827e8882-a907-4d78-8a6c-f69d9aff5621", "AQAAAAEAACcQAAAAECq9hP0JJjcOUbGXR0GKquV2iorFVgWOiaB5lCHwfuco28NnCa038AbSbmkDp0rp2g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Roles");

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
