using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddSectionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4ec7356d-e804-42bb-8974-942718c0d43d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "090a0385-7767-41c5-83e9-e60e4f1c0411");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "8fe4035f-9f4a-4db9-af17-dc8c7011836a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40ef2ed5-dbc7-42c1-8c7a-2f59cf78dab6", "AQAAAAEAACcQAAAAELehknk2SVvOjfFxHkApGqsoUDJkjDo7D2Y16dGeuBTR3ZL+mZK9igNw27DbnsQASw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9eec1044-2b00-441e-b102-87880a3ae07e", "AQAAAAEAACcQAAAAEDPMz8lxX42g5nM89j31g2fpoRngWb6zsorMq6/DibXSLAoWwhwQv8u/i+eDG0bfSQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3506185-1127-46d9-a74a-096c843f6aa9", "AQAAAAEAACcQAAAAELbIExtBztZWrE8pvrQarChKZ/jA00q5g/CeF5PKMG+LIXhBH9HCNXoGEgmz/ue3jg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41f39288-4aa5-47ba-8dc2-cb5c2016a75f", "AQAAAAEAACcQAAAAEBNfVKLfPjv0PefA3JL6blhLfWmjZAa68GIP6whjWkF1UrUIi+kZYLGPcSLCh7aZ6Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ed8984c-4faa-4ab1-9af7-5db7bc147b68", "AQAAAAEAACcQAAAAEIxKEBPT86l3J4g3nZoo/igOgktxK2xzIt3YafavTa/Vo//OkaNkhSuEKnFA3d56YA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a822e738-36d6-4b46-a200-c646a20ddf55", "AQAAAAEAACcQAAAAEJRaerPITSlY1mcYJnspn+CDe6E/UkNU/Ls/AW6kQuALixfkvZPNPQoDpiKnVipJbQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9466a5bd-1209-4b3e-9961-4f0dfc7011b9", "AQAAAAEAACcQAAAAEB9D2EwKC3sgokjmC0+pMu+i+B3R6Q3jaCE4V06uwLHR7utrNJFU8ta5JjOelOjERA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8022d955-a719-4774-a9c9-b2cfe2efc175", "AQAAAAEAACcQAAAAECBZLkH8Ug92K0wSuaks4EXVqzArlXhzqQ/8QmxhIFhBW/mybpc0FfAHrhg1eS6XSw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c87503f7-b4eb-4b9d-978d-ff0c96ddeabe", "AQAAAAEAACcQAAAAEHHOWFN1C2a96J1VQDfmtvvcyfSgBbVoiyHruvlFDm+Kd/j0fhNaNCZoR67D4zNhTg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "Questions");

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
