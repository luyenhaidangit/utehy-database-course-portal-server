using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTablePages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Content", "Description", "Image", "Status", "Title", "Type", "Url" },
                values: new object[,]
                {
                    { 1, null, "Công cụ sơ đồ ER để trực quan hóa cách các thực thể hệ thống như người hoặc đối tượng liên quan với nhau.", "/Page/Page-1.png", true, "Vẽ sơ đồ ER", "Feature", null },
                    { 2, null, "Tổng hợp câu hỏi trắc nghiệm CSDL có đáp án đầy đủ nhằm giúp các bạn dễ dàng ôn tập lại toàn bộ các kiến thức.", "/Page/Page-2.png", true, "Bộ câu hỏi trắc nghiệm về CSDL", "Feature", null },
                    { 3, null, "Trình biên dịch SQL trực tuyến ngay trên nền tảng web, không cần phải cài đặt trên máy tính cá nhân.", "/Page/Page-3.png", true, "Thực thi SQL", "Feature", null },
                    { 4, null, "Nơi người dùng có thể tương tác, chia sẻ kiến thức, và giải quyết thắc mắc về CSDL.", "/Page/Page-4.png", true, "Thảo luận và diễn dàn", "Feature", null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e425fda6-bee9-4c73-9df4-2668fad80900");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "504d5af5-4284-4d8a-aef6-84045502db69");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff0ea682-fa77-4a0f-84b4-8f2588b68373", "AQAAAAEAACcQAAAAEKuGK3jrQfczN8u4Cla8XPFT51akrupSKCmA8637sLg/UUuk/U8ABlYfQQ+ss97wXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5367d4d5-1926-4b09-ba20-d4af876d887f", "AQAAAAEAACcQAAAAEFsVnuKCOMM8a5tkgEgu7X6HauLPFh6ClxiYmL0DglFdTQ6qCwkFYkcSTroMXaSV9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9597a247-d281-4aa5-83f6-e5f71796f76a", "AQAAAAEAACcQAAAAELm0idjx3rlM2gsdiqnUHfWv/tr7g4nQqGlDK9ztUwMET4mfO5VNHiVgmjKw6RzAAw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "86530f8a-5c0a-4616-bc36-af0b82c18f2c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "6287126d-f4ef-4a4a-b4fc-765776362616");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4d14d27-e701-4413-969d-7eae2bf17b99", "AQAAAAEAACcQAAAAEGTYG6T3dIbv4u0tDLOTvhjbzRZduD26AH/jpbX+Hj3aayq9RgEhbYxuVz2rbJBJKQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "987fb868-741a-4367-94b0-4e82226efa75", "AQAAAAEAACcQAAAAEH6bkGUnZrmN5VvEoIEax38A0IbMrI1O/kY4i0AjX+2s9hOeoMKvTu6l3lurKdlG0w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9dff6d9-a1e5-462c-b7d3-90c8265399e3", "AQAAAAEAACcQAAAAEN4wxh8NHjdmmhN0TqIyLn4SM2hohOTlTLjZPBSKzq4XopuNDcl0U45zAuc8FxV8fQ==" });
        }
    }
}
