using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddSeederTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "862b8012-cf25-40f9-a1b4-b0ae47113db5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "8bd70227-91e8-430a-baae-49d1249d52c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "3ef42022-1aea-44c0-8be3-9ae60dd3f1a9");

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6") },
                    { 2, new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1") },
                    { 3, new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a9f67b5-d994-4f8c-9b2c-3d4a0e8ec505", "AQAAAAEAACcQAAAAENuLS72eAb3P792XQQpgpqSZ0Z7y+VkaeD2dvaxP7ccpjkd0uzwBSh24d15eGFieew==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7bb90c45-e647-436f-8745-7f4562cd4425", "AQAAAAEAACcQAAAAEKGsDlI7GYZTlMUKFQOn1GlVkyLZ6PYlHQJlcytlDMO7Sty8cwFy/3nyz/0gut5wsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c93d6537-6935-4e00-9cdd-3370fe82485f", "AQAAAAEAACcQAAAAEC31Qf8MfTrKUznFuclh1O4s7WHeEd1E+g7nvWwDy1OyBLYQnAEWLn9MfWm2DUY1TA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2bf50c21-f21b-4860-9cd1-b018a0d613c1", "AQAAAAEAACcQAAAAEE8mkjc5xTLqIIhi8sflE4XvNj+6YnNPd1T1IzwVTCgS3ntEQqWimLKSC3ZbCfalgw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbc50708-3cf8-4c2f-a714-655492d54eb5", "AQAAAAEAACcQAAAAEPxHBvTxMclLLxIbOFKCp3FaJ3iOQV9JPcpGpXDXYSdAeLzQeQsF0XhHB3TO7gb3Sw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3b263f2-9607-4eed-8e0c-deb674a9ce34", "AQAAAAEAACcQAAAAEEJPWsM3t/mKVeTGhUbuF+7bwiwyxacIzDwidXb2k+SK/ekYQthNbCgkf3oF/NPLhw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0e94e363-5116-4cc1-9110-cacd98440d74");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "094786c3-843e-4a20-af69-391b476d8542");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "522d01ed-df77-402d-9429-321ba5aff65f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f0d9f52-515c-4cd4-85a1-45fcb7946029", "AQAAAAEAACcQAAAAEP+CUiv7DLa8C6AqnMpNuazi9lv3UxhqTu+btjQTryorVnI/dvMIfJWG6GQH1aRznQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f67822a5-d1d7-4529-88c9-19b0def3209f", "AQAAAAEAACcQAAAAECNyIRwn780PHK7oGWnSlfRqJBB7dx40uOffMNml6WPDy4X4zlp2vGEYP8CfsGcSEA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "931eb538-86e4-482c-a672-9dc9aa18933d", "AQAAAAEAACcQAAAAEJUzVg8eGeOFQRkP+AtFLuLW0m/ApunMSQ4F12d1VP+2cHLRxd98aNzUblussJEzxw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9de2361-a18b-40d7-8cb3-2f516b202fb3", "AQAAAAEAACcQAAAAECmSo2enq8hAUWd5U8bDJ/nyYv2tSaSzPpR6cwGemRLpuJdkpbvW8CfdMqJFT2vT5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d163e620-adf9-48f7-ab36-dc03941ec6f0", "AQAAAAEAACcQAAAAEOWxA7ITWxbxlnab9nCrGW/Q2wRDOIXf0PAv2L6ug86D1npFcVzQ0LI1S5AM5DGbcg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7dccf97-6df1-4d56-ae74-23daa734b2bb", "AQAAAAEAACcQAAAAEH+F1KF6uEpXfwoEL7JoAS/fsLfZGfm9RG7oE5avCKm+qoVWRRz1efgeTI/OqlTN3Q==" });
        }
    }
}
