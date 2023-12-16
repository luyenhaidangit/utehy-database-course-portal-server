using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditTablePosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "ParentCommentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "26342609-f110-4838-afc7-ea17184cad69");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "66dc27ce-07fe-49af-a6b2-46a4068d03f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "67e27667-5029-4da1-8d3b-7b756a2c7493");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c49204d-2076-4e11-8dc2-57b99d0b9978", "AQAAAAEAACcQAAAAEBdvFwG8T+XRxsGy/cDSrUNLwOTEbNFMUTaB10c/fCE3zcJuJY/7iHInyuQWdy0cxw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "737ea57a-de21-4bc9-ae2a-77e77d83c0c6", "AQAAAAEAACcQAAAAEM02fzRKeZA0XbPpMDNMgsZmdfMe1gDRrrr47qtlooHcv+6jSzkwCCLd72K2s9U9Wg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86922129-d408-485b-b9bd-b34105929c4e", "AQAAAAEAACcQAAAAEJx6hwUAFqkdJncBh2gLTIPpCA/GNySU3a/OMlX/6TbUP/QSr59Fv0bBRB3hzMNykA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78db1117-e49c-434b-8412-ab28fb87662d", "AQAAAAEAACcQAAAAEOyvt4Oy7T2l7sC7R3DHmcnnHZbT+sRUgbzcS4ahVXmgQzjHA8+BpKpbKEjLMW9Srw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09805a7b-ec9c-46d7-b201-0b34418c28fd", "AQAAAAEAACcQAAAAEE1oXAwdjfsRBMJfBawFAe60PJNuR7Y9wtz1Dox+zs4jxzi4bYI1ZHn2Eyz5dRKVGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f59bb1e2-1a15-45c2-9754-62d4a73f8eea", "AQAAAAEAACcQAAAAEHFi1i5rupDS++fPJ8mlaWliviH+kZ74Qqw7IMQxuAiK5fgnGROTYNAa242R1985vg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6020a02-0360-4c35-988c-d17229c63531", "AQAAAAEAACcQAAAAEKAFJLhKcegUlVFn7ddNNLZ1YUuWZvjjgvKnnsq+lcDmCZsOtUGgJYVtI01DOMEzmQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e849567-1d84-429f-bd93-53a005ed7cec", "AQAAAAEAACcQAAAAEJVTlFCoS3i6otPjeS/HqVpTP4pBKJzw8+0KjCkkSfKz9bD39Q05RPkqfquv+fQIug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f15fdc9-803f-4335-9354-7711b919d9b4", "AQAAAAEAACcQAAAAELWVLX6yHsEpZNls+PrTC0Rog9Syi1FmazCTxMreCOoJnm5WbJ86pt+TfJdptxe41Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "ParentCommentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "eb2ed1fa-b1fa-4b16-a1d5-d71607857629");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "03c6a470-f65e-4d66-917b-efae75190284");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "6e2431c3-2680-4d35-88f3-e90f0dd41393");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "65e2d313-7122-4fb4-ac96-b15845b5dd6b", "AQAAAAEAACcQAAAAEGBhY/pwKQ1ov2FYOFtv86XLdqIAiq2aQ7hnabtYPEcXC9WGBZnMzGsY78DY1+5XKw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1f5015e-424a-4ff1-a34f-8a95db82d60a", "AQAAAAEAACcQAAAAEL4KeliY1MoOLN+h7Zq9enZpn4aiPH08DYVkudpKvAxDuPRpkPnHwJpwI6lVsVcJ/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e09fe86f-b536-4e22-b8de-608e2f2cf217", "AQAAAAEAACcQAAAAEO1kaVJ1eIp+XaJr1Kwe18wc8SSY8DQdDauLGEBGXs1SlwLhO7iq1F+dh8Su+OUaXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69c4b3c3-3227-40d5-9ab9-078b925db145", "AQAAAAEAACcQAAAAEBg3yf8z9EqMw3ub7XJOQ78YuERCVOiu0SSUpq7JM4HqlpHi4c1rESQ1J47Cr0Gxvw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e76994c8-ecb8-47b2-8bf1-cb1079d763fd", "AQAAAAEAACcQAAAAEOUaqxGnB3EwI7GFetVg5ZL2wI1gg1YqW1RDLKoVIlFpcb+K57vZmVpMSGnopW0QTw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02f98f67-59f2-4d8e-a578-4887350ccab1", "AQAAAAEAACcQAAAAEBIiCJaTuiym8AoCX5aKEi4EfqD9bKxWyw2DoSuHTf5HCQ/zofGi47YlsEyOTKzdlw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2eadf0e-4649-4f41-9af2-a5ddfe4b438e", "AQAAAAEAACcQAAAAEOeMFsF9uICFhWZ5Kwz8PHOrlRcXS8M3Z0ZQymB7EqotfOHNgBHarwxV4oIzu/NnoQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b34ee9ce-ca76-4f29-a78b-2d54b0079d7d", "AQAAAAEAACcQAAAAEDQjCz3gynjHc6TLD8p4qEjgOaU3z5/JjqudlYCeeP6Va21EEN7tlg+i53Qk7ZHRTw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0b1a6cd-d7b0-4fb8-8726-43beb8d17d89", "AQAAAAEAACcQAAAAEGk20PrquQK3/F6K2hk3/WoOyq+VJ8P1NG7y4U5aDJA9CFNLc0K0VELU80OOtblMog==" });
        }
    }
}
