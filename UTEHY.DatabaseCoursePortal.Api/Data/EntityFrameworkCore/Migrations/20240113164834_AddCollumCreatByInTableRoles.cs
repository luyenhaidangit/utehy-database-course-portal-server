using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddCollumCreatByInTableRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "cd874f4a-ad57-43fe-9d36-d81cb148a5e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "b2b952d8-abfb-48f9-baa2-98cae4ace435");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "0195116e-5bb3-40b5-816f-e378aa601e60");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e3163aa-0bd0-4d35-9043-4b80a84f6196", "AQAAAAEAACcQAAAAEHy1Jbz2riYfoep0YoOaULQFWeDb3cRAS1ag7zTgvgiZVIrdnOheZOLkrh/AcRlHSw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32969f49-118e-4e89-a0e6-d81034adf976", "AQAAAAEAACcQAAAAEAY6pk/mNdpJP8hkwJYzZtTiL5CnbBV0s6fp3hchUEiQYO+IKJ79z3R5lQw1/0M3EA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f2dd6b3-c563-4142-8a0e-a557a02ae004", "AQAAAAEAACcQAAAAEJkgm4FAb06aqoibqTJjiwYZ94b3eihbZlHzO6wi/Jgjgnp+ZdEDfZn/nuGWUX/JuQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e865a24c-0618-4ea3-9ce7-368b3911c16f", "AQAAAAEAACcQAAAAEFjyBkUDGKS2XGCGA2nGNj4a3cxceWMgMqBppjqFUT0Ucl1pwqHTEaNdRnm4YiTZbQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e51b944-6645-4dee-801c-83f6dbe49d04", "AQAAAAEAACcQAAAAELpFJeqJ9Ds6x8wTo86TeHwfI2TBwMVeanRsd3FtcsZhXcIto4AVigIDONA90lNf8w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fc53f5c5-6fa3-4233-8587-0204869a10d4", "AQAAAAEAACcQAAAAEANO8sn2AGiJ7+61lAnTv2BDeNhoJHIiQFXZ7Px4XC1QL91mB0i7Yk+K/i/lJTc2eg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8367cfb-510a-4c8c-ba9f-7ea647c45a7d", "AQAAAAEAACcQAAAAELotmYsK9PREgcw4Lkog2q3FIwgY5UO33QrL5OhRXcCYSWZ+FOB34lR/cSbSH479wg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f628578-5cea-49ba-8216-6e9afadc083e", "AQAAAAEAACcQAAAAEH4ki2NxJL4cGPvXWw9nauL9WIAwEssEGqpbUwqfBfDtnbJfWqUIAdnPI/MDNT3niQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03998380-7b61-4081-877a-cbc32c26f325", "AQAAAAEAACcQAAAAEHbl8V8HYlPI7Cg/Xgb7i8vAA2JQBl6esWdmRoN/9SSulxFsmyQrqV2dI0Zyj2TXpg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Roles");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "27b68125-5da3-4f48-847c-248a3940cdfc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "7385dc71-9e33-4b78-abd3-0b066b1e71c4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "e7164a90-eed6-4dae-893f-1a06fef3a218");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd807023-34e0-44fd-9c2d-7c22b5355fe9", "AQAAAAEAACcQAAAAEJL88WtyeG9vtHxzncVY8OlQoc1bRjcreKiDYcYpQ3MPq9wMwWIPb9ZVDzd9q7ITZQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81ad98e6-94d8-4b31-9256-518bbb207ce0", "AQAAAAEAACcQAAAAEJZiQSu/gXq4aqwXh9BmY/QHRkubQnHpUs1qsyKC8DbsvJm0AHCe+2k7OwDDULpWlA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9afd5110-64f1-4588-9fec-f8d72e035952", "AQAAAAEAACcQAAAAEGkGT+tw2jjAMXoyOyBSephvdNhyHilNGGLdALScYbATZCB0LdJK5MKqaz9uTukdCw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "073eb1ed-6fe5-4438-9347-3418172b1781", "AQAAAAEAACcQAAAAEH9f+It/WS9rZ0X3Cgq9bgxqW1wKgBSt2z2ZGeoqu3ihxvGtpmIQTNPjsbcqIiYfUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40090770-3a64-43a6-94fd-0b7fc1d6a90a", "AQAAAAEAACcQAAAAEHjsaf21rIZTY0JM7HO2iBtCwZu1virTOoux0AHkSHf0B2MrXt3hKplXpN6E2oDqQQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "811fc611-038f-4ffc-9571-9fbe2d493eb4", "AQAAAAEAACcQAAAAEDXDoOSPnGO0DhI0s70kT8KkXjOyBg1sfVvpTnmNw2RnP+eWEBN1JF5lsvj59CA1Og==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5166ceec-bc56-40a6-bb91-a4e22ce0c129", "AQAAAAEAACcQAAAAEPo3tHOI9kgH4rxnReRZNrhgKTMqumy/FELVRR1gZzqgWY5HdboSGaeT2jvKup3XGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f3a8cbc-d94c-4133-b63e-84eeeca7e671", "AQAAAAEAACcQAAAAEOJPqSyTGjYC2g9whAxKg782qV9Wf5/nvde57LZGkOkAq6Omis4sNp9BhtHSGh+fOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "827e8882-a907-4d78-8a6c-f69d9aff5621", "AQAAAAEAACcQAAAAECq9hP0JJjcOUbGXR0GKquV2iorFVgWOiaB5lCHwfuco28NnCa038AbSbmkDp0rp2g==" });
        }
    }
}
