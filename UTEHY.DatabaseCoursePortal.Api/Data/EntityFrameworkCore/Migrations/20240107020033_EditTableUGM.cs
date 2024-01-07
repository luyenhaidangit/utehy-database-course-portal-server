using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditTableUGM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserGroupModules");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "UserGroupModules",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8374b3a6-b58d-416f-a576-df50f55b3fd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "a4396203-9cbb-48d7-b44c-3867696a40ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "5e3c399b-4931-43f0-954f-f216e12a8891");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac75bd39-b81b-4403-8138-7e69c723c279", "AQAAAAEAACcQAAAAEOObq4Z2uvpCqQQrnvJFBstpfCgS00wzwIHJ8wQMASb1dgnWig9/wwq0nNHPlLguTg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c5b8cbd-20a8-4ff6-b8c5-1f83e27bac73", "AQAAAAEAACcQAAAAEM3iQvv4a244wHfT7bYMtjtmoTk5p7ggdm8JaaZUCLlY38vpFAalKqscfLuBU3GQfw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e82c6b41-cf7c-4ea6-bf4c-8d0dde611192", "AQAAAAEAACcQAAAAEPLWXYOeIX7+o4GXfrAKiIT2UwzOKLKU3zP3c8w5HJVpxtxxUv6cB+KK4FEv5J3PLA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "acbaef94-48eb-4162-92b6-b212136bab12", "AQAAAAEAACcQAAAAEF6Pp2UJjr8NWszGLOgPsmHGQmeWj0+H6g1t22Rk9fBuC3VGj1Z/nznj8y0TlrJy8A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb80d4b7-ed2b-4830-a599-b2ff371f2551", "AQAAAAEAACcQAAAAEKIKrNp8z1TC5O/lnRX10i2tpzzCa7Q0/2ueeSExEGDNaOZLteMeLlbmisjHqnd0DQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0c3721a-160c-4de5-aac8-90d98cf1127f", "AQAAAAEAACcQAAAAEKa0QCReok7tDEQtz8taxVFBK+ry9AU3kfwehvCIFqfzz0SNk3crRIz9gie3jwvAig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72f8e478-749b-437a-b35c-b984cdbe2ea6", "AQAAAAEAACcQAAAAEJnkiM0mFvRGsb49QiVWCqDo4owd4taVIgd1Ir5SvCOz9KGAYFIuT7V2r1GnUn5csA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82f462b3-392d-44ff-9edd-b4caec6fd561", "AQAAAAEAACcQAAAAEMEIoC2zyJaM2DLtmLKzP8TI97ivTRM/aNifqZmJDZiclLAn/DspuDN6Wy7pZUvL9g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59d3145a-8fe2-417c-9f1d-fbe595f565c2", "AQAAAAEAACcQAAAAEF94XEoj1h+nW14elP/KYK7oYl2PpN0X6TU7tTzO8sSG9cecGthsnkQkT2TeoR/ecA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "UserGroupModules");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "UserGroupModules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "64edc58e-d01b-46eb-9e6e-44afa4f7f755");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "f7f36c58-7a58-4aee-9404-a2a79cc111e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "df870cf7-50d0-4765-9364-aad86c3934e7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5078a4e6-4836-41c6-8841-50c2788cfe44", "AQAAAAEAACcQAAAAEE5nX50qjVfzM7/Drr1XtfldCthqaUwQdeWBgaETyj9pZ/KABmyn4w8M1SrwoLsAzg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb16ba53-9852-4a5e-ad66-a8b40a6200a8", "AQAAAAEAACcQAAAAEJCMUrcUtODURPvASxb2PO2J+/plVT2dcc+IRm9LIBOfS1xJ5kMg6cLsN7xMmwHhDw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14a5d871-da98-4dde-b1f0-87c8c51fbe3d", "AQAAAAEAACcQAAAAEEd2wATEYB2zxvzOFDMhRQpA9qq9ijBFwTv/tbNBJMr1jx7moV5yJoh0gUkqbZ06hg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfc53b9a-63d4-4fc2-a6c1-bdad75925cf1", "AQAAAAEAACcQAAAAEMQ2RWHszedDjch4rxNEhKMEOuVEZESwRaxvcbNXltm5e4F8GnQLQBVucuvyz8oEMg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63352d4b-7c71-461b-a291-21be8fe82456", "AQAAAAEAACcQAAAAEGWlj9WhGIRA7+dk2YEQspAE2w7fl79l3S1fjc7O7djxYJi9uO3P49iTUFRblCwFSw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd8ae3a6-e506-41c3-98e7-32393e5e3a38", "AQAAAAEAACcQAAAAEONmJDZoXNoeBihk8ELncIJ4oJbsOUXRUwILEWDzT3ibNmtDR9a0laEMKYZjAHbx9w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49fb9532-2b5f-4c1d-a8c0-73a0fb74ea87", "AQAAAAEAACcQAAAAEDyXz3YwU6/txan2ODgl+RV0f+DbZAXv9zIoJ8Lp5/VxkoJUfJxh3CUUmUYXZb9hZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9cc1e088-03a9-4ce3-ab88-42662626f19c", "AQAAAAEAACcQAAAAEGB0lwQNKAdapUXN4gMx5QItzJFZZ1E+NuD/McZczS3ft9uFlte2mJLfz1i/4cU7Mg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "311c748d-3a35-4728-813e-3aa473ac23c3", "AQAAAAEAACcQAAAAEGSyu1AEyaP4eNobK2N2gWpaeQcYI27o8MhiNDv/8xFkFTwB/yUnCzBLMB3OJx0yNA==" });
        }
    }
}
