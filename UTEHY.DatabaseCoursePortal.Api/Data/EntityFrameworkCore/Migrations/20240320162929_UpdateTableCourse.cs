using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class UpdateTableCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertificateName",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LandingPage",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "PublishedAt",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TypeVideo",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Courses");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CertificateName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Courses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandingPage",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeVideo",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsPublished", "Priority", "PublishedAt" },
                values: new object[] { true, 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsPublished", "Priority", "PublishedAt" },
                values: new object[] { false, 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsPublished", "Priority", "PublishedAt" },
                values: new object[] { false, 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsPublished", "Priority", "PublishedAt" },
                values: new object[] { false, 1, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "229a3bc9-5bbd-44f2-b621-9ccd76b6f9b9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "36d2d1d5-9f58-40c3-a09a-5a09c90f680b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "83c4b21d-0fb3-430d-a369-b23de05ebfcb");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "461cecb3-5055-461e-9542-3ed5ddddac61", "AQAAAAEAACcQAAAAEH8H0jDBIl8AnZaDLjSA0tCzM3rJ3Q+x019twXcLzg2VzFFJjtn+HmhJJ+D+UZFLpQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67b96714-e135-4b00-ae56-ab1cfeed328c", "AQAAAAEAACcQAAAAEJOMQqERBvLNLNOW6iX/JSsAd0OdG3FBonBkegL5JGe++KrwVkgCXA09eMkOYcI/ZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77de886e-5bbd-41c7-8641-e0e242a78517", "AQAAAAEAACcQAAAAEEOF4gnxkmhKIlkacaXpvK/DyFF8niXCf1VCeohY3r0YXopR+aIwx+8r7GxQzEam8Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27739ff6-8efc-4c4c-9471-69812987dd5e", "AQAAAAEAACcQAAAAEDBj1aMevi8NWSwrtch6Lwv/noX0/s9oset4Mz2cKWtX4rdGN38rzFLyHU22XrIyXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "585cb161-081f-454c-9b63-d1b942d5afe5", "AQAAAAEAACcQAAAAEIgy3n22mr9OUZrf+l3zsgPlsBPvmAaS1HOrYEQnY8fTpePGreq7HQI3T9bKFr2VTQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bec89ec0-43e9-43dc-a96b-01f43f286636", "AQAAAAEAACcQAAAAEKZyrjU2/0WZ9RpHviGygS3wi/kn/PY/6gbXzVeJimiC+I0KrdnocXfs8LQxb2wAaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "535ca74e-48af-46f1-ad85-3e7a8114dc44", "AQAAAAEAACcQAAAAEKsd5FC/T2QxDkrArW1qVvZ2UW5fYMKnfJrIn0/Zi2JlfYz/4Y2ARkRttkYWcvI+Qg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d007c13-c10a-414b-b14a-1de60ee57fb6", "AQAAAAEAACcQAAAAEJkLa9oBCnaJB5/mXw0DTc8Rb2spz9zy4up2t7pvTgD+dzuoQk7bVlFR4Vl+RVpTug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef1b5d89-f749-41cf-aae4-bb981dbffa68", "AQAAAAEAACcQAAAAEPnatnMlBQtAm3Ugi0CXB2i2Klfa3MQpWMOKENU52C//qfqMK6HDDLUT8V/YGfXq1Q==" });
        }
    }
}
