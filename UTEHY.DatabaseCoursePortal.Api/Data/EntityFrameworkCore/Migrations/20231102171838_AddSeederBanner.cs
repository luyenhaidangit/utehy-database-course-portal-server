using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddSeederBanner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "Alt", "CreatedAt", "CreatedBy", "CtaTitle", "DeletedAt", "DeletedBy", "Description", "Expired", "Image", "IsBlank", "LinkTo", "Place", "Priority", "Properties", "Title", "Type", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Banner-1", null, null, "Học thử miễn phí", null, null, "Thực hành dự án với Figma, hàng trăm bài tập và thử thách, hướng dẫn 100% bởi Sơn Đặng, tặng kèm Flashcards, v.v.", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Banner/Banner-1.png", true, "https://fullstack.edu.vn/landing/htmlcss/", "Home", 1, "{\"props\":{\"style\":{\"--cta-hover-color\":\"#6828fa\",\"background\":\"linear-gradient(to right, #6828fa, #ffbaa4)\"}}", "Học HTML CSS cho người mới", "SlideShow", null, null },
                    { 2, "Banner-2", null, null, "Đăng ký ngay", null, null, "Khóa học ReactJS từ cơ bản tới nâng cao. Kết quả của khóa học này là bạn có thể làm hầu hết các dự án thường gặp với ReactJS.", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Banner/Banner-2.png", true, "https://fullstack.edu.vn/courses/reactjs?ref=banner", "Home", 2, "{\"props\":{\"style\":{\"--cta-hover-color\":\"#6828fa\",\"background\":\"linear-gradient(to right, #6828fa, #ffbaa4)\"}}", "Học ReactJS Miễn Phí!", "SlideShow", null, null },
                    { 3, "Banner-3", null, null, "Xem thành quả", null, null, "Để đạt được kết quả tốt trong mọi việc ta cần xác định mục tiêu rõ ràng cho việc đó. Học lập trình cũng không là ngoại lệ.", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Banner/Banner-3.png", true, "https://fullstack.edu.vn/blog/tong-hop-cac-san-pham-cua-hoc-vien-tai-f8.html", "Home", 3, "{\"props\":{\"style\":{\"--cta-hover-color\":\"#7612ff\",\"background\":\"linear-gradient(to right, #7612ff, #05b2ff)\"}}", "Thành Quả của Học Viên", "SlideShow", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "44c01f79-fabc-4c19-9ffe-c669660b36f3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d79118fb-e490-442f-926c-ea72c0661c74", "AQAAAAEAACcQAAAAEHwM57aBuT16O1g1BoD6us15qE/E/ZKsqrAc4qSUYZtS/EOKOTZk6ZgXWN8LtcDeKw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "39391931-41ca-47d3-8073-3ec761df2b3c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "22095f24-19f3-4173-a53e-96b0a8d349a8", "AQAAAAEAACcQAAAAEKal07InLp3QldisuxxdVreW3d+Gg+TejP4UE1qDWL5eO6yuIpMxUumSefrQO9p5FA==" });
        }
    }
}
