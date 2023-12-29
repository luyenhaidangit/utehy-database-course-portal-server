using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddCourseId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Lessons",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "36fcd44c-b9ef-41d6-a17a-0068fbfb30e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "bd00a220-c8f6-4aa6-8c15-279f4241a6ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "e7b47640-f916-4ce6-a5a2-968da9a30e80");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c59d9e3-ca0d-4910-b4c5-44f54e571cfc", "AQAAAAEAACcQAAAAEDPbDhC4NSWDcHe529jR9etnGsX9VtA2PqjTK5BSDQvOK/tJlqjxoBFd+Q1Iml7Jzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b4c62a6-9ac2-4872-91f0-b9c7d25e8006", "AQAAAAEAACcQAAAAEKuigQufpJjLOyz1oauWE08TUnC92tayYzHT0s0ZcdLoKM9YAWaLcb55mrOSf6jS5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5460e271-8e51-48a9-80b9-3914a344784e", "AQAAAAEAACcQAAAAEPNGze57RJ44cZeHLnNuYA8kkSD27VUQqB2m8JqGXSOIxeYbLc0BBraqsmWR0Mzgrg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a2a2ad77-6b96-48b3-8fea-f50f86d31b03", "AQAAAAEAACcQAAAAEPG6SzkdKURsgT4i0/FHGa8+KoRZCgQ53C5mU9Js1noxRyOTMSqoltHfdlFlQF425A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4a56017-82ba-440f-a45e-5bb4a8f3df12", "AQAAAAEAACcQAAAAEKejUbNL4VapnMbUiJhXUwzmsRuPcbgZ0vRw5QShbly4OF770TPGy7RITSCpkLLLAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c459912d-ad7c-45e1-84d1-81da402a0642", "AQAAAAEAACcQAAAAEBgP8Mf5qgKyqsy5qeqa8Wmo/rohW8K4m47k9Lg+/RLmgH9tS/VzlCn6eS3/NJcgUA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74bac987-51c9-4ad8-9f23-6f3ed3512cb3", "AQAAAAEAACcQAAAAEOBxX+UBg4yE7ZlUwvTJMGDqtR2tZeZzTDCKolTYN4BzIcTcRQZ16abJqnkM1Z6uVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f66c9d0b-db91-48bf-a139-3edcb6afa48f", "AQAAAAEAACcQAAAAEBHodIj9cv99pGt1CKexm1TJY2MeIRLXUuQMyQfL80oZtirJ3DfiTPQiWgqCJ3BZVw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0811ecd1-996d-4756-b2c0-38eee799537d", "AQAAAAEAACcQAAAAEFQeY7hllCc7nqqWNJxRe4Jaq+J4TRG9IfJt6yYpPD27Y71qqterP3onY/exZZYICQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Lessons");

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
    }
}
