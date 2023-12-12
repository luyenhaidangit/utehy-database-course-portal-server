using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddDefaultCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuestionCategories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDefault", "Name", "ParentQuestionCategoryId", "Priority", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, null, null, null, null, "Thư mục loại câu hỏi mặc định", true, "Mặc đinh", null, 0, null, null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f56e1e02-8e5f-4888-ac7e-b7c0f50dc5f3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "ac902031-3463-4772-ab5d-33b00a133dd2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "3bcb6348-bb3e-4dbc-9d01-17dfe7703da2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "954cd773-4e6b-4631-9201-645e728cd0f8", "AQAAAAEAACcQAAAAEPwSfYTwSTczvGKkdOv+9e24El1jmXxD4948e/qbMT05R2qRMBIMXm9ByG7sqwQhTg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ceb34497-57a7-42be-a64f-fdd76a3db906", "AQAAAAEAACcQAAAAEPkhGMWcnTw49ToPsM2wNgOYciXh8i1UaW3Tvmq0VfYPyFufAW5aiZPTOpZb145t5Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7847adad-c8f0-4440-a750-816aee7a1578", "AQAAAAEAACcQAAAAEKhw/bEeeuYPJS8YJ51rr8E6k3QRh2TvRqgBknvx4h3Rlugz/sbcScH6gQH+bAiNug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7481140d-98c1-44f1-b543-2d034e1ed205", "AQAAAAEAACcQAAAAEPnn8p8YbqILdgvDRiZmVTVvdwAtGUI6ytk26pL0TovslLbDVTBoYItm04zRp+jlAg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6160f1a7-d4a0-4d47-bf53-77e435e486fc", "AQAAAAEAACcQAAAAEL1DmVU5k1vzUdMLt1GOWeDHAKxj7MRQOXJPQTLz0xU6XD2S803W/oZXBbvkzG2M7Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51192065-5b26-488c-a71e-8701ad92b9b6", "AQAAAAEAACcQAAAAEBhNeq3oMoo+rd6P4O+G5I3ZNkub60b28dBeqywiWfVkFRkjzKW+GHnAFGxWlC0ndg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "Id",
                keyValue: 1);

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
        }
    }
}
