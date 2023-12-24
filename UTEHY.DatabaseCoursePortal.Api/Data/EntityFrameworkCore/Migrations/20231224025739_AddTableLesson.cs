using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableLesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f96832c4-bbec-43f7-948f-63605d9e852e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "80f18498-80fc-4e11-bf3f-61327b439a67");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "bd520427-04e5-4dc2-9db0-c8e38a9367d5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fe531bf-3f16-404e-91b2-8ed29ceb3d08", "AQAAAAEAACcQAAAAEMBAYzzlJEnMiDan2LDv5qxn66vJMI44egVPCrrje7ESvgnJkBOfvjv5rz0lTilFDw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f424ad6-2719-4753-aeb7-1f3a26e95083", "AQAAAAEAACcQAAAAEBRW81QjRPrl9w3v0yj4vJLjI0QVrE3Mi9es50r+cdOoSz86SNGFUxKNVFvgUikQSQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c5f3102-4ec4-4ac6-a057-dfb44ebe5dd0", "AQAAAAEAACcQAAAAEKTOawh/iqsgm1E+IN0nwP7ogKPIBGtKNGDwFz5v4COUXHzj/7wRSNNS30ldTmHg+g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bde5ddb6-977a-44f0-becb-94ea28240ad3", "AQAAAAEAACcQAAAAEN7cwddQqgYDcfA6NyZ7JpiWrGI2C3lPMHjDp/ijIecjU82ijKU3sCvhXVm0K5LL1Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "952d9b12-6546-4738-b1f4-85fe366a0d9c", "AQAAAAEAACcQAAAAEE+SfrL8kmCe1KdFUh2DtkmKwBS8DWYQihusxsqiErloBKmE/f3l0WoFcvs9lWlofQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a04ab776-1b44-4bbd-95d0-891ef2784039", "AQAAAAEAACcQAAAAEOSBUGDo1kuSE83U5rQP48nFqX2aR2VDNb1Cz9wzLL+nZ168XwYo3O+rnBJdur/R5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64fb214a-3858-43e5-99fc-d02fefe50786", "AQAAAAEAACcQAAAAEPz6t+0AA+AcEHaxbE4iIBnmbyaPAgG6FKRTTc6dWdtzkA3a0UnSaErCVb0APjkGZg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fb645f3-2b8c-49b4-a0d4-8a34948cc102", "AQAAAAEAACcQAAAAEMxoE/03IBTQ5eq/YHHDfaHkGQ4Wv8yDDWR3OpPvZlarUtqyvUyf2rl++/Ijt/H+Uw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf6546d4-539e-4c78-963b-21310512d740", "AQAAAAEAACcQAAAAEEVnvm43fdB1Qq6iDCsWMK+KtX8m4/pXguO41F67jJIaZ2OtI9bNBN31xYcidpU+lA==" });
        }
    }
}
