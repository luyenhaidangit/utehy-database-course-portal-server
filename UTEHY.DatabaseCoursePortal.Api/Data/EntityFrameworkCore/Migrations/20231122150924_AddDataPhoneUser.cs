using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddDataPhoneUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "51dce66d-8c38-4350-8935-4436bfbefd97");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "f1659393-f471-45a1-a3de-1a07cc5b7251");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "4aedd46d-e177-4fa6-b5bc-dec254079b32");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c494b51-b4a0-4d8e-a6e9-c1a579128abd", "AQAAAAEAACcQAAAAEL3ejylS9M9q7cDey/mg3kF1g6CxbVieA1NWg7iImzejb3xj/IrJvx8oPoPLcDg0/A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6f74a9d-8923-4255-b0bf-a3860e3c81ee", "AQAAAAEAACcQAAAAEPDEQBbwnQmO1L3EXG2tWFlJfr2pNtRuwVcuEemUxpf1R4OjaYNrCgP3ydzvr8hY5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28bf5d6a-aaaa-4457-a181-3e869ed41cae", "AQAAAAEAACcQAAAAEPvju7v9soKuKjg5G8Kt3xn2tY4F0FT2lVfje9U6vrZJgNdhcTf6JN1zeBn6iEnXDg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f322619-dc50-4492-b76b-d564a4945551", "AQAAAAEAACcQAAAAEKtdOGOPnNZpsBKzYPzLH1lctck/+idJDPO+Q3nm+MDIx/y4W6ZfMbASzonuy89cyA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f0734d5-c8ba-487c-b8b0-2190f39194e9", "AQAAAAEAACcQAAAAEPoij97pWSjAGmCsWzUQiGaDgagiNVe//HwLO9C/Ote2PHpvssTfHY0lll3WwXkq7Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "1144d16a-876c-4845-98cb-ff2a01bbdb04", "AQAAAAEAACcQAAAAED/eAD5uPlVV9fNsuIfazZ33Kp5kdLm45c48UT5QD/rsymhk9GDGMiMAx3/33LHQ4g==", "+84922002360" });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Users_UserId",
                table: "Teachers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Users_UserId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "a3b263f2-9607-4eed-8e0c-deb674a9ce34", "AQAAAAEAACcQAAAAEEJPWsM3t/mKVeTGhUbuF+7bwiwyxacIzDwidXb2k+SK/ekYQthNbCgkf3oF/NPLhw==", null });
        }
    }
}
