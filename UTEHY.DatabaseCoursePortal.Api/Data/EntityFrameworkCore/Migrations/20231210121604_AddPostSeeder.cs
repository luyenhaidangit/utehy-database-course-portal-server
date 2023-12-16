using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddPostSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BlogId", "CommentsCount", "Content", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsAnswered", "IsApproved", "IsReacted", "IsRemoved", "IsVoted", "ParentCommentId", "PostId", "TypeCommentable", "UpdatedAt", "UpdatedBy", "UserId", "VideoCourseId", "VotersCount" },
                values: new object[,]
                {
                    { 1, 1, 1, "Học đi nào SGP", null, null, null, null, true, true, true, false, false, null, 1, "", null, null, null, 1, 1 },
                    { 2, 1, 1, "Học đi nào VGM", null, null, null, null, true, true, true, false, false, 1, 1, "", null, null, null, 1, 1 },
                    { 3, 1, 1, "Học đi nào GGL", null, null, null, null, true, true, true, false, false, 1, 1, "", null, null, null, 1, 1 },
                    { 4, 1, 1, "Học đi nào FL", null, null, null, null, true, true, true, false, false, null, 1, "", null, null, null, 1, 1 },
                    { 5, 1, 1, "Học đi nào TLN", null, null, null, null, true, true, true, false, false, 2, 1, "", null, null, null, 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "eb2ed1fa-b1fa-4b16-a1d5-d71607857629");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "03c6a470-f65e-4d66-917b-efae75190284");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "6e2431c3-2680-4d35-88f3-e90f0dd41393");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "65e2d313-7122-4fb4-ac96-b15845b5dd6b", "AQAAAAEAACcQAAAAEGBhY/pwKQ1ov2FYOFtv86XLdqIAiq2aQ7hnabtYPEcXC9WGBZnMzGsY78DY1+5XKw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1f5015e-424a-4ff1-a34f-8a95db82d60a", "AQAAAAEAACcQAAAAEL4KeliY1MoOLN+h7Zq9enZpn4aiPH08DYVkudpKvAxDuPRpkPnHwJpwI6lVsVcJ/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e09fe86f-b536-4e22-b8de-608e2f2cf217", "AQAAAAEAACcQAAAAEO1kaVJ1eIp+XaJr1Kwe18wc8SSY8DQdDauLGEBGXs1SlwLhO7iq1F+dh8Su+OUaXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69c4b3c3-3227-40d5-9ab9-078b925db145", "AQAAAAEAACcQAAAAEBg3yf8z9EqMw3ub7XJOQ78YuERCVOiu0SSUpq7JM4HqlpHi4c1rESQ1J47Cr0Gxvw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e76994c8-ecb8-47b2-8bf1-cb1079d763fd", "AQAAAAEAACcQAAAAEOUaqxGnB3EwI7GFetVg5ZL2wI1gg1YqW1RDLKoVIlFpcb+K57vZmVpMSGnopW0QTw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02f98f67-59f2-4d8e-a578-4887350ccab1", "AQAAAAEAACcQAAAAEBIiCJaTuiym8AoCX5aKEi4EfqD9bKxWyw2DoSuHTf5HCQ/zofGi47YlsEyOTKzdlw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2eadf0e-4649-4f41-9af2-a5ddfe4b438e", "AQAAAAEAACcQAAAAEOeMFsF9uICFhWZ5Kwz8PHOrlRcXS8M3Z0ZQymB7EqotfOHNgBHarwxV4oIzu/NnoQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b34ee9ce-ca76-4f29-a78b-2d54b0079d7d", "AQAAAAEAACcQAAAAEDQjCz3gynjHc6TLD8p4qEjgOaU3z5/JjqudlYCeeP6Va21EEN7tlg+i53Qk7ZHRTw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0b1a6cd-d7b0-4fb8-8726-43beb8d17d89", "AQAAAAEAACcQAAAAEGk20PrquQK3/F6K2hk3/WoOyq+VJ8P1NG7y4U5aDJA9CFNLc0K0VELU80OOtblMog==" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostId",
                table: "Comments");

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

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4e4fe9c7-2d6a-42d4-9cdc-4307323cf103");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "06143861-c0b4-4588-b3c4-6f530f142dea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "97a09586-98e1-47c6-bccd-1c49e76b3f3c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16e16403-d518-4ea3-8292-7f33b0b5b11e", "AQAAAAEAACcQAAAAEAgwrdFM/FolmMsfkgDjA7ztFvjqNR2NC25EP60Rd6S/KDf1/BTkcX/q6a3jvq8P0g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41c55880-7f9c-4d6b-a8d2-e65d21fe66e3", "AQAAAAEAACcQAAAAEDmAK7BRcSySeL8UE9hrU2R7d8BH7K1KbnYqym/T18DFi7uvGdNguthXFg74Ga98bA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9be5f47-0e68-4fd0-933c-44b164febcf5", "AQAAAAEAACcQAAAAEGui9tYNg4kk/IwJcvvydYJjKiqVzoiC+Fn0v1/bzvOg9WPGiSvZ23NE4sdhO9THtA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e86e294-96f9-4dde-bc02-b2e53013c96e", "AQAAAAEAACcQAAAAENpf72iaWLWV67OQNHjPXaKHi5eSTCebUJwPYK63NvmaS/m+ddVYAW3xO52FDQv3mw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3240e60a-f57c-44a0-9b35-4dbec77eee89", "AQAAAAEAACcQAAAAEMP+SvGb79NYPfZHJrqC1hfGbiSrv1py6EcSSnURL1s7U9GxxC1o2qCBlDyp4cb8SA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4963ccdf-5eca-4f5f-8157-3d8f54bcc421", "AQAAAAEAACcQAAAAEI7vJNKH23ssyaG7N5jcDywfv7KX2cfbtRnwXkosO/6InLFcoCj6BVn33IhRJ94evg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e837b73a-1d55-4b23-b15d-e65ab9a9d3c7", "AQAAAAEAACcQAAAAEMVBBXOmaVDBO4hPwpkhOrremtNUcJYrqAhgZ93i/DiWjxLDm73pRX64IV+O8t1O+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc2e067e-5144-4913-944a-f31c6a5b797a", "AQAAAAEAACcQAAAAEAzuG+5DXjGqWpFMD+BFYy0nFMI8AS4W/rlYNWsOiUYHHuAlKCO+GKnNlbubDTmnYw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f33cfa16-1aef-421b-9a4a-62e58d50e6c0", "AQAAAAEAACcQAAAAEALpzO2RGtyldLSrnWAudUHvjp221hm/JBvYOSaMYkZ7t7zu/Ywf43HB8EBko5TlzA==" });
        }
    }
}
