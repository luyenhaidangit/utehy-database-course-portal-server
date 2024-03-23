using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupModuleId = table.Column<int>(type: "int", nullable: false),
                    Lessons = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSchool = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeachedId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_GroupModules_GroupModuleId",
                        column: x => x.GroupModuleId,
                        principalTable: "GroupModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "bc4ce3c9-b9f2-4432-b8e2-b2593e3ef451");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "a3c9d0ba-0b7f-4495-a80c-682d8b9e6c30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "d5120a5c-14d3-45ed-9fd0-ffd2ad910e5c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9bae3f7e-2418-4ea9-9cb2-5a93e916ed69", "AQAAAAEAACcQAAAAEGdIIlbXZC1N7BxUyF6TLRIuDVdnQeCKLt8+HttcDJYXq+WOKamIUUMPL2llnNRVzQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9614575-5315-4a1b-b35e-6766270d90f5", "AQAAAAEAACcQAAAAEIiJZA7F89cyMnJk6UCz9agWKFA5SmUH1PaqnjWVJOcn9z/RiLHDJrng8pxsaGhUKw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a4cd79a4-089f-4330-8f74-417f4e2f8c68", "AQAAAAEAACcQAAAAEA7CHuzFJKwnrGYHTbmTVqmJnNpOtzotv+HbyqWru0Ku4z1BLvQhqrVLmPQe2ZhrQg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "169a3d4e-3f55-442c-914b-389d27c69d19", "AQAAAAEAACcQAAAAEE95sd2dMhjvAC1ffNtWDkP6lMWr4RWotgJHlgN+54uM6cyBlWBXzPCgWunioF4xOg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23c2f003-a8bb-4def-982e-9949a41ca7aa", "AQAAAAEAACcQAAAAEMyeKRf2rkehj5M3j34pcA70zj8xM1EcMTiBO9zahkG9xoQJbf0OLaN8V5XII0K2iQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "adcb5372-d4a8-4e52-b37f-81db4a9f1dd4", "AQAAAAEAACcQAAAAEAlHcANLIcfp/8H9t/T5g4O2vs/crm2BVtHeA7LBtlJiWLNRHTSlcl7ke5w87fxd4w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41c97f66-a94e-43b5-956a-262ee3702e43", "AQAAAAEAACcQAAAAEDc8LIxxKgBOo4FxM4oq6gGpneaZHz9tesfrIhYBY3+GJh58D6S92B6l9hZ0pYG4eA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5989bfa7-fb85-4e74-8a4f-3928c6d81b8b", "AQAAAAEAACcQAAAAEDzEvqBlLuPOURTt3isiOp7jguA0d3qpAovo6eEQo/849Mog6ocZw4T+TgSOgkVz7A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02000a0e-747b-4295-b0f2-b76a25e98e8d", "AQAAAAEAACcQAAAAENQksgSfCAIUO9CS4XIDq2pNMBUTAqUkCkVePgNATr9fi1wIxGKK0RXT+DNGLzc+Wg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_GroupModuleId",
                table: "Schedules",
                column: "GroupModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TeacherId",
                table: "Schedules",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");

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
