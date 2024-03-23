using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddCourseField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Sections",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d2894c92-f0e1-4505-932d-ad25168d28fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "1371d481-58b7-4219-a066-428992452909");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "30e01013-8a48-408c-ae64-c50bfca3ad68");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f65171ad-3689-456b-bef2-9bafa8fd5dd8", "AQAAAAEAACcQAAAAEJl7Z7UQ/azi0UXJ01n7BgFA63nkOLIuE9eEr70ijPdMMMPmGO+ehXi3LvvEcmO1uQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a4ff1ab-4536-4d55-9dbf-6ccf4f26ce36", "AQAAAAEAACcQAAAAEChXMY9LKn+8aROiLATrn4KicYh1F9aoXlmPyY+gw4qIf+7EFAFiV4ii75b/s7KpGw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96188278-dee9-4450-83bc-6eb3628a82f2", "AQAAAAEAACcQAAAAEGRMGXK9JHWHNCc8zhckgZwRuOs27RCfsZpaGxh+azPWYc956lxmt9PN55HVVD4p/A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07c439fd-482b-44f5-bc88-9dc15e70c029", "AQAAAAEAACcQAAAAEBu/O93ovWpg8x28i/51S6cdQdjNKXcjoRAGJJfVwx/Efxc0CkyygclTVSJtBA7l3Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c124384-de03-4888-bc1d-63b90c54a2d2", "AQAAAAEAACcQAAAAEPovzrNYBaE7cijGp1Rz1umnO+rhocFEeNpDhS55W/RcAIYlSuAtbSsazG0qSBnYfw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d89e7d1b-3a3a-4466-a278-de979ac6a72f", "AQAAAAEAACcQAAAAEEvq2F3AHnxAg2KiZkatr0ZyI7vnGTrfJvXG9CHGLHZii7BVimi90RHJTiBiTmenDw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15d172a1-6e49-4d37-9e8e-ca1f076ace11", "AQAAAAEAACcQAAAAECNHlR4Hu4LdA/+Mz303kSiY66vZZAdVlFWjpcPmg5IW+NluuMUJS+/jo35pDb7fLA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "289933e2-b18c-4e73-a28c-174401e230e7", "AQAAAAEAACcQAAAAEJonuk6elMNOscV+SyvvKXEtBvEehPU/K4SgV43gBrDOe6RCs1LKtkaBN9dEHOMJTQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee29aa53-844b-4db6-9572-1f7a32cf183d", "AQAAAAEAACcQAAAAEIKxexvnYVEvhrBgjie+pZOiLB5kQR4iGsr7+PQ/kToCHj1YJArd3JY07P72UTiKjA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CourseId",
                table: "Sections",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Courses_CourseId",
                table: "Sections",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Courses_CourseId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_CourseId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Sections");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "00be1ca5-f0bb-4255-8744-fd104297d84e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "cec906cc-a8bb-4197-a27e-4fbd84c139f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "25a4b799-dfb0-4aaf-8628-7f1afd095654");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3903462e-b7b7-4c0b-b9ef-fb252b6c6158", "AQAAAAEAACcQAAAAEACseFq4NhuNmXjZr/zidYI7Lru1r/CGrzezahaplak33nc52W354Z0kedU09dhEtg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6709346e-991a-4bee-908e-1336127bc44c", "AQAAAAEAACcQAAAAEAHoaRrnJtOflaXxSEDOkD+u/KXUXc8q06Ub74NPhWvWtdjMmaZp3yscpEBVpYei5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c6ddd295-df13-4a72-a6b7-2f66ef99a6b2", "AQAAAAEAACcQAAAAELKTtkyGDNqHShZIEpIgX8t8sXHspEFEY2g0SR1HJJNCDMF2Dz4JVgUrq29nwLJjqA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "678d94ff-c812-43ca-969c-26a5d416fc05", "AQAAAAEAACcQAAAAEEqFzYDRX+pQlAppwMNLXIyCIb1t2vYV4x2Cs9k1IC4fHeaAmARQzhqV0F2jha+QtQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e90a642f-c4e1-4653-9186-1b354f9c7bdd", "AQAAAAEAACcQAAAAEC9Elt0B3rShdUJQGg1emSkunljIHzY4XV1E5/M15aaE2e1yPbJ599AATSSLak2dpA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "144ab96d-c4d8-4ca7-93d5-6fe6db2a7014", "AQAAAAEAACcQAAAAEIoM6MTOWIBykf+nJidbql5EKBMPcF6+xzuh4HCp5fcXo/9+4LfgZqFGUvBEJ2kpCA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24020889-379f-4eb3-9a8b-f7d684cba820", "AQAAAAEAACcQAAAAENj6XLIrDTzO7p3j79ql8vmUnGjiAm83gOj+8POIEwKhsahEeaKBH/CytHfpFl1Mfw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6adce3a3-25fe-4771-97de-65a774ef2dad", "AQAAAAEAACcQAAAAEN4co6fQg5DG/voTsP2QteJp0KegaqGIeZQCjY2alZPmduGQXsl55WX5O86qp/ScKQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d63cdd0a-06a1-4380-9bf1-e294fc9e61c7", "AQAAAAEAACcQAAAAEIkkR3/JXZM2zvvPvRevmbqHfJW649VyYi/x+KSHjIl+wOLCQ5ObQkTOPrhd436lMQ==" });
        }
    }
}
