using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class ChangeColumnQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9eae9654-618c-458c-a285-dd717eff309b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "2a462b85-8373-4db9-94d1-35aee8b49087");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "1934ecdb-3d0a-4f24-b755-5b952f60bdbb");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d8a3fb7-31e9-4001-b24f-154d8ea09ff8", "AQAAAAEAACcQAAAAEDsZMXzlmwKdNjENnnn7Cqw0DeZIGKAnvzsfQkLmr69dWv7eV0Ot/kS+74af5HeS+Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b20c3ee-8006-4163-8f10-d8784addbce6", "AQAAAAEAACcQAAAAEIr5pAPwuVkgUZXBu2r9ZJqAZThdswqGFR5JXOcxQUKy9Ii3Tcf9JC3AxkUQrqxRSQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "94826d1c-34f8-45d8-af60-356d09999cad", "AQAAAAEAACcQAAAAEElGSSYnWudSMc1yIu8X2fQfUwJKbtAhTn6bZ0A9ryNkSmyjTJBIlXVuwFlBGuMNGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "969fb751-f919-4bad-ad62-f022ae749392", "AQAAAAEAACcQAAAAEPVY0/W6YhtIIu4b4Zi33d3tQapMVDGxI2rr2p/1/uQo6buoJ5I2I6Ltl61JWKz31Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f37d0a72-d29d-4933-99eb-bf662d823158", "AQAAAAEAACcQAAAAEBWp7NsKiCW2Cc6IRyH+rTPTJZm50ihTWbkCgog/UKt2oucMurNjoI5/41XDPITPJw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78c5d1c3-e1e1-41c1-ac02-67a67e9a095d", "AQAAAAEAACcQAAAAENJDMqL/UfU/N3pl9kqi8W2aEOMtwihnKPEQ8+C0kowvRpeTGayLKKw1P2ASIXhlVA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0a86a753-91ef-4765-8a09-0130efb76f44");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "b368156f-903f-4a24-af3c-d97af5630eb8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "f7c4566a-e6e4-46cf-851f-04ba1aee00fe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e55c1674-59a7-4c00-9929-ec11c3f0afd9", "AQAAAAEAACcQAAAAEP2rdlLMAE7MFmtjp2PJhvPzhQYMmTVG9fw2uTl3RtcZeKYasZ6jecXeC1HLVXbUDQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "023f0f72-00fd-47a7-a3c2-d48001dbdc4d", "AQAAAAEAACcQAAAAEBprK1zvYqM37/jguXFWvGZLIRSfSj9wfE4t9Kc3t99NjgDkEe02GSd4aXq/gUkegg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67e5ac7a-bc75-497a-939b-5c7e1f60509d", "AQAAAAEAACcQAAAAEOJrbniY0pGgcMny6O8JJzhEtfSoSArQ1NXY3Jt3g3nKV7TesxqIUCa/KWG/43E33g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38cb533f-2030-45ec-9cc0-efb2d9dacd5c", "AQAAAAEAACcQAAAAELSBUUPrWWWcOU+oeguBATuDYzgc4AKtiFbLXufbE2fvnyFlYmc17MvMwtOgAtGisw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ab3182f-d992-4afb-a2e4-49abc8e9b168", "AQAAAAEAACcQAAAAEF2zG/xaL6Rhn84tMBd8wNPqS37wefw6FnmwzJgogb+Y/IQESF34To4/d7S+1MvvFg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10d26a7e-9abb-4f78-8fde-0687b9c16b15", "AQAAAAEAACcQAAAAEA+VoA/Z0VLc0IqobPPoojTcLtFxVa40+OumGGJZvtSxIzQ0ZavQ0LlM0mTmn1xRvA==" });
        }
    }
}
