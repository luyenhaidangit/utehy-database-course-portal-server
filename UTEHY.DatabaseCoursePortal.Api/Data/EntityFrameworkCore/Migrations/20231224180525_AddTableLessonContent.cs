using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableLessonContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LessonContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoType = table.Column<int>(type: "int", nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonContents", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "999cea2e-1e72-440d-a49b-08b877f1fc87");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "9f38fcee-299c-4661-9ccb-55cfe875073b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "72e70527-f7d1-48ed-af12-a3cdf537a129");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "114ca3c1-7278-4a28-b877-b4ae10809443", "AQAAAAEAACcQAAAAENgRaQNOMrCvTiQTgxGJqLvMIrIqUs51RKEIiSuyYZDdCJ0TdTUzk4cFmOAw3m+2og==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b84e8d4d-e35d-4acc-bd33-e980a2ec031c", "AQAAAAEAACcQAAAAEEqc6ZSvprJ7l7Z7ZJU340X52nGpszchohSc1rCQ7DFjzKGyISTG8tFRSEfjq3XrMA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6aded2b3-ea6d-4bd3-a3ca-f2b662ec0693", "AQAAAAEAACcQAAAAEHisKKRjsBmOhfRx7298kFIOdCAiFoJ9f5+0yARLg04oY3NsJvOBb3UJYK/qfm18oQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b0778a1-88de-484d-a2c6-f2b81d58957f", "AQAAAAEAACcQAAAAELRySQ2AH1UdJclVeQFgjZfmq4g5dN6ZCT2fzflIF9/e4V5l5Rs++BLT/wrOTJaMvg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2965ce39-beb0-4403-aebc-323ada2110f0", "AQAAAAEAACcQAAAAEBS2OKYuoBVVHjtz768b3aIO3la7tgNLK1ok5zJCqm28DBPHzeXXo1SfVp6la48WLQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85718156-8fa6-4021-96b2-36898b298a95", "AQAAAAEAACcQAAAAEAuAXk026heEO8I6cRIlgXbVcIl+7f7R8B0lht6ma/iyNtBFsSG3nXV1EULRJKJYKA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e2c6394-5f5b-4ece-83b7-5719bf57e7db", "AQAAAAEAACcQAAAAEH8Z6Ywb5nDpgg8GTqND8Mebmr6DNRCWK0ofLDggumyfT4+EkscS3lQxb6h/tvMNBQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "202f7921-8df2-4c7c-a5e4-627f9fc6e2ef", "AQAAAAEAACcQAAAAEDMnpfjCUvUWEqx4K5YYJG3PB6VTMw61GYJB6vIfK+1BU/Ifo1KifixT16qDjK9dkQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de185a1e-ba48-423a-8390-b7b44764d51a", "AQAAAAEAACcQAAAAEDVGl0/CjaoiFgV28oJF/HfgwLKj9cTbyv1SQ6od2hdFYOtBUPfKce1cirHckdkoiQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonContents");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "62c3f4c6-1672-47a3-a442-7bb04152bd36");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "be30b5d0-e370-42f1-a43c-515d91f56098");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "0e99ae91-1c9c-4c48-a880-c98bb3b5788a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8475183-366d-415e-9020-eb5e5158b0e8", "AQAAAAEAACcQAAAAEEXIEIic6wfD+JXxheS8pp7M1I5wwacQ3r5z3AzUKHO55Uhcc20SGQ04k8tvu+5DjQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "39dff109-c53f-43f7-a4d7-a3c313d0e3a4", "AQAAAAEAACcQAAAAEPgc3XAqzsBt1+4kUGzV2VYK9VufyqYlXMcs4o/xX8ka7IE44znjLxDsODwcdMLbIA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eadf1df4-a6db-4f2a-bf08-bbb00f9d31ac", "AQAAAAEAACcQAAAAEKMTVe6elrYW/3WhlQPVWaN6ZGAW7dBkN6PX37eRTfNBBmRtyvWRsnKmD/7w3U7X1Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58644f6d-66a4-48d8-93f9-0f348e1ec5e4", "AQAAAAEAACcQAAAAEJRTPfQ5gbvH7FlxwONykySvE7Dz9OGKX/KNNL8OoO0ibj0tmxmBnuNlCRStcwCLXQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cccf2150-64a6-4c60-9e04-f0413b7c5f0e", "AQAAAAEAACcQAAAAEEUvg5Z+TeEjZXwU8SFQ9iXCDNalyUaaJXdp7yZ3Es2NwSxvHlDTn+y7y1+8dCxYoA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "468ed235-b256-4a57-b130-a6e68a8171ae", "AQAAAAEAACcQAAAAEJf1d2wi0UBUbuA7Ac/Lh3sL0USfSA0KlLBv4qGmv0ycmLVGpw/oCkYVVuYv1M4O/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b348226-70cb-49a4-8fdb-6cec23b18ab6", "AQAAAAEAACcQAAAAEHnY15wAKgu+qy7WFFjaoZ73iUrJvodSO6BmMUUT6yn3U6lXpcJWqZGgodfgD43SBQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7aca79c-3174-4194-9e4c-be400c887e79", "AQAAAAEAACcQAAAAEJXRpcR7yiK/SXf9WGXEvYzrZv+69GBcjtz4sjRTBIoF9fZVAyGGu/CMAWzFk2P8Dw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e754396c-be26-48f3-a9cb-3559ca64f38f", "AQAAAAEAACcQAAAAEP7jlrHwr6k/G5tmDkvFUXQj+FykkwxgSXtTIkyun+LytKhnUGIEbUwnOQOwKBDgpw==" });
        }
    }
}
