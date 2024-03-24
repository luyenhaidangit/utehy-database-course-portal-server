using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class Retest243 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Configs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"), new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"), new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "Alt", "CreatedAt", "CreatedBy", "CtaTitle", "DeletedAt", "DeletedBy", "Description", "Expired", "Image", "IsBlank", "LinkTo", "Place", "Priority", "Properties", "Title", "Type", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Banner-1", null, null, "Học thử miễn phí", null, null, "Thực hành dự án với Figma, hàng trăm bài tập và thử thách, hướng dẫn 100% bởi Sơn Đặng, tặng kèm Flashcards, v.v.", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Banner/Banner-1.png", true, "https://fullstack.edu.vn/landing/htmlcss/", "Home", 1, "{\"props\":{\"style\":{\"--cta-hover-color\":\"#6828fa\",\"background\":\"linear-gradient(to right, #6828fa, #ffbaa4)\"}}}", "Học HTML CSS cho người mới", "SlideShow", null, null },
                    { 2, "Banner-2", null, null, "Đăng ký ngay", null, null, "Khóa học ReactJS từ cơ bản tới nâng cao. Kết quả của khóa học này là bạn có thể làm hầu hết các dự án thường gặp với ReactJS.", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Banner/Banner-2.png", true, "https://fullstack.edu.vn/courses/reactjs?ref=banner", "Home", 2, "{\"props\":{\"style\":{\"--cta-hover-color\":\"#2877FA\",\"background\":\"linear-gradient(to right, #2877FA, #6717CD)\"}}}", "Học ReactJS Miễn Phí!", "SlideShow", null, null },
                    { 3, "Banner-3", null, null, "Xem thành quả", null, null, "Để đạt được kết quả tốt trong mọi việc ta cần xác định mục tiêu rõ ràng cho việc đó. Học lập trình cũng không là ngoại lệ.", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Banner/Banner-3.png", true, "https://fullstack.edu.vn/blog/tong-hop-cac-san-pham-cua-hoc-vien-tai-f8.html", "Home", 3, "{\"props\":{\"style\":{\"--cta-hover-color\":\"#7612ff\",\"background\":\"linear-gradient(to right, #7612ff, #05b2ff)\"}}}", "Thành Quả của Học Viên", "SlideShow", null, null }
                });

            migrationBuilder.InsertData(
                table: "Configs",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Key", "UpdatedAt", "UpdatedBy", "Value" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "Số lượng khoá học hiển thị tối đa tại trang chủ", "MaxCourseHome", null, null, "20" },
                    { 2, null, null, null, null, "Số lượng banner hiển thị tối đa tại trang chủ", "MaxBannerHome", null, null, "10" },
                    { 3, null, null, null, null, "Số lượng trang tính năng hiển thị tối đa tại trang chủ", "MaxPageFeatureHome", null, null, "10" },
                    { 4, null, null, null, null, "Số lượng bài viết hiển thị tối đa tại trang chủ", "MaxPostHome", null, null, "10" },
                    { 5, null, null, null, null, "Id kênh youtube hệ thống", "IdChannelYoutube", null, null, "UCVy9p7eBCMmHVEITk4yPZjg" },
                    { 6, null, null, null, null, "Số lượng video youtube hiển thị tối đa tại trang chủ", "MaxVideoYoutubeHome", null, null, "10" },
                    { 7, null, null, null, null, "Số người dùng đã tạo", "UserCreationCount", null, null, "0" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "ImageUrl", "IsDefault", "ShortDescription", "Slug", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, "/Course/Default.jpg", true, null, null, "Cơ sở dữ liệu", null, null },
                    { 2, null, null, null, null, null, null, "/Course/Course-2.png", false, null, null, "HTML CSS từ Zero đến Hero", null, null },
                    { 3, null, null, null, null, null, null, "/Course/Course-3.png", true, null, null, "Responsive Với Grid System", null, null },
                    { 4, null, null, null, null, null, null, "/Course/Course-4.png", true, null, null, "Lập Trình JavaScript Cơ Bản", null, null }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Content", "Description", "Image", "Priority", "Status", "Title", "Type", "Url" },
                values: new object[,]
                {
                    { 1, null, "Công cụ sơ đồ ER để trực quan hóa cách các thực thể hệ thống như người hoặc đối tượng liên quan với nhau.", "/Page/Page-1.png", 4, true, "Vẽ sơ đồ ER", "Feature", null },
                    { 2, null, "Tổng hợp câu hỏi trắc nghiệm CSDL có đáp án đầy đủ nhằm giúp các bạn dễ dàng ôn tập lại toàn bộ các kiến thức.", "/Page/Page-2.png", 3, true, "Bộ câu hỏi trắc nghiệm về CSDL", "Feature", null },
                    { 3, null, "Trình biên dịch SQL trực tuyến ngay trên nền tảng web, không cần phải cài đặt trên máy tính cá nhân.", "/Page/Page-3.png", 2, true, "Thực thi SQL", "Feature", null },
                    { 4, null, "Nơi người dùng có thể tương tác, chia sẻ kiến thức, và giải quyết thắc mắc về CSDL.", "/Page/Page-4.png", 1, true, "Thảo luận và diễn dàn", "Feature", null }
                });

            migrationBuilder.InsertData(
                table: "QuestionCategories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDefault", "Name", "ParentQuestionCategoryId", "Priority", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, null, null, null, null, "Thư mục loại câu hỏi mặc định", true, "Mặc định", null, 0, null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Name", "NormalizedName", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "d16c4090-e276-43a0-bf3e-e90761efdd9d", null, null, null, null, "Admin Role", "admin", "admin", null, null },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), "080c90fc-65a9-496b-bdde-ac685fe6aeea", null, null, null, null, "Teacher Role", "teacher", "teacher", null, null },
                    { new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"), "05eb319b-99af-40f5-969c-6d2b8ab2ee89", null, null, null, null, "Student Role", "student", "student", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarUrl", "BirthDay", "ConcurrencyStamp", "DeletedAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Sex", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"), 0, null, "/User/AvatarDefault.png", null, "6b6ccbc1-d1f0-4cc7-9d7f-f3f9a6540bb5", null, "nguyenvanthang@gmail.com", true, false, null, "Nguyễn Văn Thắng", "nguyenvanthang@gmail.com", "nguyenvanthang", "AQAAAAEAACcQAAAAEAr9lc0DLFL1guU/TpLav6JSCUAykRNlKP9VBvywhcXwW9psKBDLPWwnhlNJfjvp7Q==", null, false, null, null, "", null, true, false, "nguyenvanthang" },
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, null, "/User/AvatarDefault.png", null, "31f60781-da8e-4718-8f1e-0a5a1ea9decc", null, "luyenhaidangit@gmail.com", true, false, null, "Luyện Hải Đăng", "luyenhaidangit@gmail.com", "admin", "AQAAAAEAACcQAAAAECNz5Q4cUB6/TCx6hGuolt+IJDxgsHwivG+HyOAGYhX5raFk3HKBO1PLgOYIrM4kaw==", null, false, null, null, "", null, true, false, "admin" },
                    { new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"), 0, null, "/User/AvatarDefault.png", null, "029f6412-15d3-46b7-832e-a9950618accf", null, "caovandan@gmail.com", true, false, null, "Cao Văn Dân", "caovandan@gmail.com", "caovandan", "AQAAAAEAACcQAAAAELcFZkzMVls+zgzzrDZetHT+4CKinM6wi9zAIcEGJokeU5Sw4CWCWBNYvgPgX7eYDA==", null, false, null, null, "", null, true, false, "caovandan" },
                    { new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"), 0, null, "/User/AvatarDefault.png", null, "bd41cb68-49f6-4850-92e7-b93565f58e96", null, "daoxuanduc@gmail.com", true, false, null, "Đào Xuân Đức", "daoxuanduc@gmail.com", "daoxuanduc", "AQAAAAEAACcQAAAAEHxAOyXYc+mjgp6yQc8gp7LhHqB95E38CzGfSg1DYsrif33CN5oJm/0qoM2dYoONBQ==", null, false, null, null, "", null, true, false, "daoxuanduc" },
                    { new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"), 0, null, "/User/AvatarDefault.png", null, "b05ddadb-fcb1-4a00-908c-c1cc6a41a739", null, "phamthanhlong@gmail.com", true, false, null, "Phạm Thanh Long", "phamthanhlong@gmail.com", "phamthanhlong", "AQAAAAEAACcQAAAAEF0XDGxcgu3Bj43m7q8jKCNWjVU9L7EruANMkZPfbbrvNj1STUO7P2y7oKoB8icYjQ==", "+84922002222", false, null, null, "", null, true, false, "phamthanhlong" },
                    { new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"), 0, null, "/User/AvatarDefault.png", null, "ffe062f1-2baa-4d37-b86a-44cc1e9146ab", null, "phamxuantuyen@gmail.com", true, false, null, "Phạm Xuân Tuyển", "phamxuantuyen@gmail.com", "phamxuantuyen", "AQAAAAEAACcQAAAAEA82IZf9pjOtzN0kRnJwom/qt9UurGCNos6OQJc8g3yMpUV3Rk7UZpnngURs39kXyw==", null, false, null, null, "", null, true, false, "phamxuantuyen" },
                    { new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"), 0, null, "/User/AvatarDefault.png", null, "ce24b8c6-4f25-436f-813f-9ba800a48f11", null, "buixuanhoang@gmail.com", true, false, null, "Bùi Xuân Hoàng", "buixuanhoang@gmail.com", "buixuanhoang", "AQAAAAEAACcQAAAAENTQCjvMQtUeCqTQZu4PNTtkdYnrE0GV4vfVNf78558Z5w3BRLZ1Wg0NZpaEZP9j2g==", "+84922002111", false, null, null, "", null, true, false, "buixuanhoang" },
                    { new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"), 0, null, "/User/AvatarDefault.png", null, "9fac2f8f-d8d9-4577-a356-21f6a5606f45", null, "hoanggiabao@gmail.com", true, false, null, "Hoàng Gia Bảo", "hoanggiabao@gmail.com", "hoanggiabao", "AQAAAAEAACcQAAAAEGaLKIKY29nd3HD+M5lS1k6arzpNv38QU5lqdLDZ3mkCgd3NCXInuwmhLmpVC7f1QA==", "+84922002360", false, null, null, "", null, true, false, "hoanggiabao" },
                    { new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"), 0, null, "/User/AvatarDefault.png", null, "1c4757fe-ebbe-4b9d-85d5-ce8cde45f354", null, "nguyendinhhung@gmail.com", true, false, null, "Nguyễn Đình Hùng", "nguyendinhhung@gmail.com", "nguyendinhhung", "AQAAAAEAACcQAAAAEPFyhy+m2mLr0V6mXZiYfB7lt229Hlqh2HfM6wK5Y2RsMl7zv5DScKSk+CpD4bdKew==", "+84922002333", false, null, null, "", null, true, false, "nguyendinhhung" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Image", "IsApproved", "IsPublished", "Priority", "Title", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "", null, null, null, null, "Authentication và Authorization là một phần quan trọng trong việc phát triển phần mềm, giúp chúng ta xác thực và phân quyền...", "/Post/Post-1.png", null, true, 0, "Authentication & Authorization trong ReactJS", null, null, new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192") },
                    { 2, "", null, null, null, null, "Chào bạn! Nếu bạn đã là học viên khóa Pro của F8, chắc hẳn bạn đã biết tới \"Dev Mode\" - giúp thực hành code song song khi xem...", "/Post/Post-2.png", null, true, 0, "Hướng dẫn chi tiết cách sử dụng Dev Mode trong khóa Pro", null, null, new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192") },
                    { 3, "", null, null, null, null, "Hello ae mọi người nhé, mọi người (đặc biệt là lập trình viên Software) chắc hẳn đã nghe tới Powershell, nhưng bù lại cái màn hình...", "/Post/Post-3.png", null, true, 0, "Cách chỉnh theme Oh-my-posh cho Powershell", null, null, new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192") },
                    { 4, "", null, null, null, null, "Ở bài viết này, chúng ta cùng nhau tìm hiểu về các vấn đề liên quan đến Performance ở phía FE. Không dài dòng nữa,...", "/Post/Post-4.png", null, true, 0, "Sự khác biệt giữa var, let và const trong JavaScript", null, null, new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "StudentId", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "10121910", null, null, new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7") },
                    { 2, null, null, null, null, "10121911", null, null, new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2") },
                    { 3, null, null, null, null, "10121912", null, null, new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "TeacherId", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "12520001", null, null, new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6") },
                    { 2, null, null, null, null, "12520002", null, null, new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1") },
                    { 3, null, null, null, null, "12520003", null, null, new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1") }
                });

            migrationBuilder.InsertData(
                table: "UserCourses",
                columns: new[] { "Id", "CourseId", "LessonContentCurrentId", "Progress", "RegistrationDate", "Status", "TimeSpent", "UserId" },
                values: new object[,]
                {
                    { 1, 1, null, 50, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 50, new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192") },
                    { 2, 1, null, 50, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 50, new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2") },
                    { 3, 2, null, 50, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 50, new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator", "UserId1" },
                values: new object[,]
                {
                    { new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"), new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"), "UserRole", null },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), "UserRole", null },
                    { new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"), new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"), "UserRole", null },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"), "UserRole", null },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"), "UserRole", null },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"), new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"), "UserRole", null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BlogId", "CommentsCount", "Content", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsAnswered", "IsApproved", "IsReacted", "IsRemoved", "IsVoted", "ParentCommentId", "PostId", "TypeCommentable", "UpdatedAt", "UpdatedBy", "UserId", "VideoCourseId", "VotersCount" },
                values: new object[,]
                {
                    { 1, 1, 1, "Học đi nào SGP", null, null, null, null, true, true, true, false, false, null, 1, "", null, null, null, 1, 1 },
                    { 2, 1, 1, "Học đi nào VGM", null, null, null, null, true, true, true, false, false, 1, 1, "", null, null, null, 1, 1 },
                    { 3, 1, 1, "Học đi nào GGL", null, null, null, null, true, true, true, false, false, 1, 2, "", null, null, null, 1, 1 },
                    { 4, 1, 1, "Học đi nào FL", null, null, null, null, true, true, true, false, false, null, 3, "", null, null, null, 1, 1 },
                    { 5, 1, 1, "Học đi nào TLN", null, null, null, null, true, true, true, false, false, 1, 1, "", null, null, null, 1, 1 }
                });
        }
    }
}
