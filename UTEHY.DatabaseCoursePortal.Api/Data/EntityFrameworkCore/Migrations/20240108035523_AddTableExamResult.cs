using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableExamResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "dd6c4bdb-00d3-4093-986c-01a3e05352fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "d9888793-e2b7-4454-be36-83384c36c1e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "13dfb412-bc97-4a26-b4ae-d35726cae976");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "05aa8fce-2902-4b78-96ef-9762a7e0cb7b", "AQAAAAEAACcQAAAAEH4YzShElCvD5QJV4tfGLD0Y8bGA9LRpwJuYpgk807sCOMD9EBDyBzMDPnnZJz4MYQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d66d3fb-51ed-4e50-bc4d-ec222334e8a0", "AQAAAAEAACcQAAAAEKphfWF04e7KWfWJrIVBsMMvchjSAoxbNq2SeMmMWHqNq1lIXrM1gGr30rHUqd9sJg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25c5ca5a-ac5e-4793-805e-a327f7f4a498", "AQAAAAEAACcQAAAAEFoFynYzFxuomjuxzU7W9cz1vXPgbuK8Yh5hSAOEk+n4HGK/OldaGX3eT56GpL88Dg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2dac6337-4083-4d01-be4c-5c8111c91c2a", "AQAAAAEAACcQAAAAEArQTj1FEAAjqzDrndD72PUGII1VnqeEsBDNtOYhRD63kxdu9bw4mTQPKiQ4RkG2cw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e15f8eef-8600-406b-b742-985be87abfe8", "AQAAAAEAACcQAAAAEE35Z2SWmS+V/Y4Yc3JHg86X9rJlNBUcnuJVc6pfuHzLIuYbTspX48ScBRjf8tKEcw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66a28f28-1e1e-4274-9e27-9d4daa6f9181", "AQAAAAEAACcQAAAAEMExUjg/gEbhg8iNgWfU1Dncx9Pc2N+zhkwkBzj8WeFctkj9jfYcN2UmgstTiD/UJg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17b4c52e-799a-445d-9907-da84fcadf436", "AQAAAAEAACcQAAAAEMoFBXc6khJPfVPFVAj+ohmro63HfJprfjd1Z0YCKn0neSW7rlpONBVkjmIfVGLSPQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4449758-f8ee-462a-9197-b2e13dfb9324", "AQAAAAEAACcQAAAAEMzaaamtasBvYG9rY/e92XWWVysiWJrUpBaZGbXIaLNpA29lgCuLSjAdBPRCLYHkNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1d0e8b1-21dd-42b3-bc2d-90fe09fdb765", "AQAAAAEAACcQAAAAEDf0GqTFgraSCxii2kO3uSmkES4PfbEKpOX0Lcfrbn3geHmxMy1Zgscp+Z3G4xJ9dA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7baa5316-f44c-48a1-b9de-981a74abcb26");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "390262b5-0ef6-44fb-b213-9d6a78746a24");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "05213826-0eb2-4eaf-bbbc-7da56044ad0d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8a60a63-c50a-4892-8c20-27da83cb6d85", "AQAAAAEAACcQAAAAEHTEtDsqEdIpKFhXFf3U1B0fWbkGsLykpyUf91vGFXVzTePH7ijTgL2XE0cQw4Oomw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "321ea7de-2ea3-4396-ad65-c207bc608f02", "AQAAAAEAACcQAAAAEAeYeadzHqyooZPAMKSdhSrqhSGk8w3SJvpqsFwSS4Ka3ascUYA5s6bz064/1Lw1Eg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d112592d-c53a-4210-9358-4747f5be9607", "AQAAAAEAACcQAAAAEFCt3pLNWCWt1utepjhERORszFlhavN5N/AA4FVSq7QA0GbvmYJEp5vTrv12GAJDsA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19043ca5-cbd8-4f29-a5b8-1eae674cd2c0", "AQAAAAEAACcQAAAAEDOwd8OpXH9yH0CVeJsv+ofPJZ3tJ7ZovPU0bgPuWChttrU5Ut8s0MQrbXA3HDmwvw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df9881c7-e629-43ce-9f25-37100b3956b9", "AQAAAAEAACcQAAAAENQCmINLbeYypVkFmMRcF6stjCXfNpz8kxSOh6su5O6Fc1gvJbbIvf9qE6he0MbdlA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "814bf66e-047d-465f-9df2-5a2c4806ecfd", "AQAAAAEAACcQAAAAEJBFeqqhqxP/UOYqupu2JJewLHq04TSNgRJC3z5BCUJNWQH8TFEXy736tMK7PCQ5Bg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ab69815-fe5e-46a8-ae22-b00f3d3d5942", "AQAAAAEAACcQAAAAEHKxKj61pXLgVrw488Q4Hyj2d8q4VdAxz5Bqu8KkHbggrQukcTAA80rf6VFp4xjEZQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8aba99b-2dda-4e5f-a660-64cd35894951", "AQAAAAEAACcQAAAAEOftFfprnXHubaXHQ2nxcb/er1EmfyzmMu8exRgpPMzq2u+ie1jLqsMFGF/1HU+lmw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc25516e-23d6-4863-9e86-7002564b2cc8", "AQAAAAEAACcQAAAAEAwRbYpwOZ/Cpnh492vXv8qYCpmGSThJ4ljzBvgAewVlHPaH9uY64AgXnZkj9vPBxw==" });
        }
    }
}
