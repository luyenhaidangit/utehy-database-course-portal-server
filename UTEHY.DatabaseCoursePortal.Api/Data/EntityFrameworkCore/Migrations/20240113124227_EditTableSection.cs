using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditTableSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Sections",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Sections");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "04d72aa9-3dbd-41b8-a865-7ddca55aeed3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "c4012274-5fe6-4745-bbde-0e88124b8882");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "bccf6ae5-8d00-4186-832c-0fb8f3dfa319");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9ad8192-953b-42d4-a49f-0a297a6228c4", "AQAAAAEAACcQAAAAEOvbzuMBtSwCcZbv801vGY4eLF7zoo2UThsrbpbSi3Ll22zlkbJn2TCAIbWlNv1h2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25389d0c-e981-4e6a-889c-38c0c0926fee", "AQAAAAEAACcQAAAAEAAml1GRX4JnTRpuKIYu3pFRDKWu8QvwyGu3yWP0ZhPcVNK1C80vO+InighXIViVSA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12a0952b-8276-4776-8204-9af5ddf94cd9", "AQAAAAEAACcQAAAAELlbvqBiG7BINkvv+t0KxjKVENSp+f80plsX5fs//8q9Dpg1/4qyOkbLQWsZ+9lP/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6b1accc-bd0c-444e-b6d3-f1d2d4fda7ba", "AQAAAAEAACcQAAAAEM+3Um3e5E82x5/EhLYCWCeyvcCBK1je/QxLzFXSFCn+3frisFnuuL4qeJG5QtswJQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd6a9bf8-7b3a-4fd7-accb-f67132260a6e", "AQAAAAEAACcQAAAAEDzkCIB/j8TBuTdwdDVcnt5FuiYLcjVXkNdPdzY2mcQbpNMUZwWRf6mLFLNjLECBOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c91809c2-47bd-4f79-909f-8cc1c009b86e", "AQAAAAEAACcQAAAAEIlAnOoLjSKqydd2t62F6qz9gTbxbfaKksQUhMPMBJ8HG6wGkHREqDfXu/LP0Qb3YQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57729b0c-dfe6-4732-bcfb-1dd5ffe8614a", "AQAAAAEAACcQAAAAENirA8V7+z7UrQWgy6wAYgnEVSlt0DB/LFY7/sePW/lEoVpsgzi7SPm7jdUsf4fHJw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26b5711b-7c99-4513-8bb2-4310ac7a4f8e", "AQAAAAEAACcQAAAAEMeEukrpqGGtXC3X8yPFzvAXbyTcvVCPh8yiEO5FidxVWZ4GAkVpZz11APGEAhZ6XQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13e656c8-1eae-4e68-b8e3-ef80bd0e2b5e", "AQAAAAEAACcQAAAAECg/DyZ4xfJnf5AqlxBoyRrE3Gk5KZmr7xlVIWYq/8Hz7R1URZAILLG68aPNK4uA2A==" });
        }
    }
}
