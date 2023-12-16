using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddColumnQuestionCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "QuestionCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "42efae49-461b-4160-924c-081829d46f5c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "9f09f74a-1c66-408e-8c51-6826b605df53");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "27036bc6-8997-4d22-a1c5-9902987a4b18");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "212ecd85-57db-497f-a98b-bdb9304d35a8", "AQAAAAEAACcQAAAAEAK6D5JyxYDkm1RNbFwM/SZsr9xFAH/tX2m74eX8vFugHssDIwaOH6k6/Yupev1cag==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1bc679dd-3f34-4b40-a489-0fbc8f08974b", "AQAAAAEAACcQAAAAEKzlFJEMhFTy+TC21MDSbfFqO7zx5oqPzMcUMpeU4IHaPOwzIK4CvbxPZFXb2VSGpw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34237137-7a75-491d-b3e9-1aaef8ddc883", "AQAAAAEAACcQAAAAEPWFft56xViQS700hFNcQojlu1W7/PViw3J3gcGY43tPKB1xKAxhIT5zSW+tob+Yaw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "548fcdf1-6bd1-4aef-b1ad-b92466e91404", "AQAAAAEAACcQAAAAEPKE1mh76t1nb5Gq1uk+Yfx40W2WOSvhd5HKkBx+uxNa3VPWXZuDAARsEDjcjkF+FA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19f0f73a-7f24-4db8-8cfa-a9c88d54275d", "AQAAAAEAACcQAAAAED0aObUfpvxIrqgjD5MyJ9fTfrq1kk3P1/lOvb31bDf24hLeXyr33hEmFfD5ZwAxEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "404bd7f5-21ab-49c2-ac88-e861d79cb0e2", "AQAAAAEAACcQAAAAEBHPWJ2MSa5JejsNiXeC78LIpUL9+s7S81ciEs4QOtAt5GaVwuS0r2rYwCdAhCu7Dg==" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTags_QuestionId",
                table: "QuestionTags",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTags_TagId",
                table: "QuestionTags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionTags_Questions_QuestionId",
                table: "QuestionTags",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionTags_Tags_TagId",
                table: "QuestionTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionTags_Questions_QuestionId",
                table: "QuestionTags");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionTags_Tags_TagId",
                table: "QuestionTags");

            migrationBuilder.DropIndex(
                name: "IX_QuestionTags_QuestionId",
                table: "QuestionTags");

            migrationBuilder.DropIndex(
                name: "IX_QuestionTags_TagId",
                table: "QuestionTags");

            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "QuestionCategories");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d6c8f0c3-c602-48f8-9e99-d405f65f65d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "09b1b7ff-0ed6-4fb1-b2ba-fdeb2832f8e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "0027d578-c2c6-48c0-935e-89126780e7f9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a895fa41-7f1a-4ec7-acec-8d3744cb3835", "AQAAAAEAACcQAAAAEA01fqYRgQaxa/e9ZRKJvATy8k8OywUcDDAua9RMMCJdq7Q811r5u/w9OIUyaJz54w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a5b2c0b-f9cd-46d0-853a-28ebc33732a2", "AQAAAAEAACcQAAAAEPCoGu/z9JVv0n10W4Igw39721OD1CgE5qUo6gHIsExl8LctgqkzA3oT5YYazE3V5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce0f2e02-0991-4847-ad05-64ab017f9d4d", "AQAAAAEAACcQAAAAEAp/KPKlVq1/KLEYLXih66EkemECmr8/pVicvEbGGrZ6g1F7/dKCRlZNoYALki7n+w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5a1c663-0d43-4516-b915-b8b8cad2f312", "AQAAAAEAACcQAAAAEL9YuYi6/fAQidHve7fh49Er1RZLJWV35RYFUDeCbK0LrN2J2KIi/JpywxNYuaFTmg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d816f320-ebbf-48fe-a240-1e979dab4f1d", "AQAAAAEAACcQAAAAEArRfpiN590nV5JWfGYp/IQ9HE3B2jNkV8FCtmGIz0Lx3a5qjC8wb6Pn4T0+7Xaang==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d44a6383-ccdc-4531-a6a5-fa2fe220160d", "AQAAAAEAACcQAAAAELIjP8tYRS0hERthvSrOSTBsgPRYvDTNtEMUMB2mCL6WGAg+wBEVcmSWgrsrj+4QWw==" });
        }
    }
}
