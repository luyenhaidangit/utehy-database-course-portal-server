using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddSeederPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Image", "IsPublished", "Priority", "Title", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "", null, null, null, null, "Authentication và Authorization là một phần quan trọng trong việc phát triển phần mềm, giúp chúng ta xác thực và phân quyền...", "/Post/Post-1.png", true, 0, "Authentication & Authorization trong ReactJS", null, null, new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192") },
                    { 2, "", null, null, null, null, "Chào bạn! Nếu bạn đã là học viên khóa Pro của F8, chắc hẳn bạn đã biết tới \"Dev Mode\" - giúp thực hành code song song khi xem...", "/Post/Post-2.png", true, 0, "Hướng dẫn chi tiết cách sử dụng Dev Mode trong khóa Pro", null, null, new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192") },
                    { 3, "", null, null, null, null, "Hello ae mọi người nhé, mọi người (đặc biệt là lập trình viên Software) chắc hẳn đã nghe tới Powershell, nhưng bù lại cái màn hình...", "/Post/Post-3.png", true, 0, "Cách chỉnh theme Oh-my-posh cho Powershell", null, null, new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192") },
                    { 4, "", null, null, null, null, "Ở bài viết này, chúng ta cùng nhau tìm hiểu về các vấn đề liên quan đến Performance ở phía FE. Không dài dòng nữa,...", "/Post/Post-4.png", true, 0, "Sự khác biệt giữa var, let và const trong JavaScript", null, null, new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c41f54a3-099e-4fbf-a5e5-336743a6673b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "f13258d5-a349-48df-90f7-1f76cdabf053");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d072ac1-726c-439c-aebc-e8e09936202c", "AQAAAAEAACcQAAAAEMdVz3it29UnoL8uBsaVuXqHhlZilK9AErSTNqD8oaDeNdj0TH/Gf7GhyJHyLB0odw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae6e2c9f-788a-4d66-b01f-79598be1ed1b", "AQAAAAEAACcQAAAAEO37vLJkSC4QbNiRfz5BpzzryiWBx9RNwxB+XIHxpqmKGJKNmWbiwMoBNnSYMWrOLQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d22ac1d-e91f-4bad-b7bd-95249f764fe0", "AQAAAAEAACcQAAAAEBW+u+Ao+u0uGGr5mk6VFB8Zs1gKU6nyDPBmygXG/hcobc8Cw3MiYwVancN1SUg4aQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0c949fc2-b383-437b-a50d-342245609134");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "461fe063-230e-40b3-ae68-f123aa61d45a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4bf352dd-3cec-443a-8c99-cbb4f191f847", "AQAAAAEAACcQAAAAEN1e/y19HNOfr0PLMqPjJ0S81dRzZKNBhhRAphyoHWy4tsi3m/ak4+8X04iFg6sXqw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6cdc134a-9f68-470e-8ca5-b545f77280f8", "AQAAAAEAACcQAAAAEApBP2Pf6VFH0egwQt0yPJ7yfIk4hSEtcKfEckKzD9UtGPQmFNgJABxB8zrG8GjneQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a626788b-2544-418c-8bf5-573ed8e9a825", "AQAAAAEAACcQAAAAECjkek1f7GmberpyqDCn3hD4xpE6Oh6TZ1UuwMOSm78BknM4elVdMJUxdk9Zwudi6Q==" });
        }
    }
}
