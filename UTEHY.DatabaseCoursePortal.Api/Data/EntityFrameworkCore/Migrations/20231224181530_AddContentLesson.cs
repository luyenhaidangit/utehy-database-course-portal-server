using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddContentLesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "LessonContents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b96bbddc-7f12-4f35-9fa2-0d03ca705a1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "ebdd80dc-16af-4a8a-88d9-455aed1616d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "beb6c4ba-2e44-4605-aaa6-8fc858f60ee7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a5de9cf-3c4c-4414-919c-f883c2a953bf", "AQAAAAEAACcQAAAAELazrr3HJi7hMEotv9anG0abAZdExEaVOud6AzQd9UP7Ewc2zP8F3I8YLq9pH12hUA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f3b8635-5f6e-4bea-b5f9-7e94cab730de", "AQAAAAEAACcQAAAAEGuRbz1PEVyLOZiT3OHZMpRP8Z4nlhSgby6MhF2bNnW78RsuNNfEYOAVOME7qdD02w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01be1b1d-c8e2-4b85-9882-ad817fd57046", "AQAAAAEAACcQAAAAEGM0DOhoEKBdbJDMTrSR/5yZ0FZv2HyHtam2x1lsY2FUIey8L6dccf4OsZ0rKjlawQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ced679da-1ad2-41b5-a865-66a9c987a488", "AQAAAAEAACcQAAAAEJuheIdfbiYFZ/Rs8tYlpHG7WW6vQ08NfYskYoDR+kq2FWd4Lz1CR44LWyHk8k0NJg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df21c3d4-c305-4e2b-93b8-d30dabfd4e37", "AQAAAAEAACcQAAAAEDNL6maC2wYU8F7V4KBiSagzqoK1FoitWDLdEhJLrxCPbxhC5y60I2mUXQ3FXusASQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e52430ee-bd56-4b96-aa2c-43d0b6961e21", "AQAAAAEAACcQAAAAECOJSCP2XIa/BqoF4c/+FVtWy+ym6UrVsKnGviiTOTOShzzXZvR5jEhzs4GxlWJc0w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92084488-1490-4c05-aba9-a98d9b79528a", "AQAAAAEAACcQAAAAEFtXbOfpCIU6LAxYOG8tSr5+VmML/0bcfl2+ZVcp+voAk4kJCnTZnKdRck/7sZIrXQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1c80a8d-d10e-4e24-905a-0e4bd09a0867", "AQAAAAEAACcQAAAAEOELPtjijSWLBDPVgLXRNCU9fcOXnki0ftLUGoQTe8d+Qx23HArQFjvXpnEhQIyYXQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fe300ee-9247-4348-a53c-8a46f196868d", "AQAAAAEAACcQAAAAEOUTI7GPqdv9GZYdBGF7TwQh+5BWifMpeO1MyDw1DU/ktStPFVNaaVZBekS+ZJDBBQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LessonId",
                table: "LessonContents");

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
    }
}
