using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddNewTableExamReulst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DurationTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    NumberCorrectAnswers = table.Column<int>(type: "int", nullable: true),
                    NumberChangeTab = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamResults", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "5d60f7d6-7721-4799-98b9-12671e53c867");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "727e9d29-c022-4cf0-b085-708d25bc5446");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "89430877-cdb0-46e6-8680-c7a80850f649");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7dd8d67f-f320-45aa-97a6-dca1856bbe3b", "AQAAAAEAACcQAAAAEMXKgr9wSQN2Ag+oR8jV2g3YYVd+8ZHYNR42Da4Qg6+E3nGx9JJGtUsb9kjO7jye1Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e878257-c9bd-401a-921a-d63bc62554c1", "AQAAAAEAACcQAAAAEBzzcJTv7Mx2KVpU8T7LwJjw7LoIyBSorcTqw3gsIBEFVNhB++MFjCF3/Sk33XtVGQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2acd5a0a-0742-4b3d-8575-0f603a39490f", "AQAAAAEAACcQAAAAEJbQ50BEdpeuggnGVU3z9AtdcJ82duvFHW28Sw6pLjvpMamk6wwqLX3WpAv1TbY93A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "329fc1b2-620c-4037-9c0e-cd1de3c007b8", "AQAAAAEAACcQAAAAEB9g/8HkyjVl4encypq/BZOsiz3E4JM/UaEJ/cGHl/ktdH0C1QscOINsaWr0qrfJTA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42894b02-efc9-4d14-bf8e-abfbec9c6eca", "AQAAAAEAACcQAAAAEBTCzyJljO2RoiFf5poMu80zWoS22ybDaXnR256+Xzf/XkqBElWVjkbrOSKOXQUtWQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "681105fb-d470-45cf-a6c6-b70947a5f19e", "AQAAAAEAACcQAAAAEMVdpkpt2xVBOlTxSlFHlFXja8j2zJ6Vo2RQ7WXSUqfXBSnVfU1b0faCjjRwEzvI4A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae1a90fa-2fb6-4d11-b355-afe303c40e8c", "AQAAAAEAACcQAAAAENJslT0qY24nGtci5OkeBl9rjUAavh+7NUeA+/pSoIkOBy0GsCB2u7k9rgQhwpyx9Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cf310f4-d544-4f97-878e-383b3c917fc9", "AQAAAAEAACcQAAAAEOlWavYjKNI8rJjcnPvNaBUKVWwnlUx7tPk0wjUy8TdCVIEQ+9Jt5c5eyD3wFuiUVA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02ad7bb6-dca7-4b01-a79e-f9d1e4e859ad", "AQAAAAEAACcQAAAAECKwBNubG5RgfD4E+niwNVxGtAljS+LGJUQNiJaoYSQfoSdGuIE3rpngdtwOmp6Eog==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamResults");

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
    }
}
