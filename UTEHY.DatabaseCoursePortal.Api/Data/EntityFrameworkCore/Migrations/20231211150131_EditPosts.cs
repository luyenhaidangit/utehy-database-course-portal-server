using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2b61add4-5e96-4486-8185-6b56f8b07a76");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "e1a44057-f091-4d76-b8e7-0d3621422fa5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "f7aca278-7fcc-409a-94e2-d5a46f39b44e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40c25a95-f7ad-4eb3-9ac6-96ad6dfcb89c", "AQAAAAEAACcQAAAAEHT4SPFr05DxMP2HeoJGx/Dl5T72DlpjRCISHgVXFyRKNZ/CJeHekJMjIC7vepXuZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b1c7327-c25c-4d65-89da-d2d19e861174", "AQAAAAEAACcQAAAAEIxu9aZHOAl/3Tv+1ApFeOWT3KZLdmoY/jXicwCkcGwOvuBkSe5IqoNHCfYC3aQeow==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36bf2a0a-3568-48d2-b60c-a42873433d8e", "AQAAAAEAACcQAAAAEGTPy1H7cXN1vCjVUk0TS4vQNYLvX81ybsae83d0Mlhq9l75pKXSQuErnOV4iYr/xA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad3b8744-1bdf-4716-852e-2b5e583208f1", "AQAAAAEAACcQAAAAELwP81rtnz50X+ajJXDBetw9MYSBiafpsOsJSPeeQLbQ5jA46BEPwx4ykf+K53sskg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01630fb2-37df-4b1a-8b6f-f2f03a100f9d", "AQAAAAEAACcQAAAAEEzDl+doZl4D9TCLPvtnwWrlUZbBtQAS6EdpGUdh0qWgo6SPoi835v4BIeCdc3H3+w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72adc3a1-2e93-4687-8bb1-a018911201a1", "AQAAAAEAACcQAAAAEH4JchERVxonBWS5E4KXU9Uxl1PnfQfmWyC6xIjzy6z55VOzGeGuNYRwAYuUA89M1A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61998ef4-c88a-4515-9995-b5ab3e9d87e0", "AQAAAAEAACcQAAAAEE87epYLZEz94Fc/VqeAM/IINHsyYHsFRGQCSRc9m2X7211c2jK59SzWltwGOet0yg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dbb365ef-ecda-4758-80ef-ded98a04bc7f", "AQAAAAEAACcQAAAAEKpsmK8UWRTF5Ywx7QDdVecEOgT+9lzqrD/pdmuxaoPSuKlbAR5FKLbT9PKCZft9Dg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6347ee1d-b814-4a9a-8d11-ff3490bf4b48", "AQAAAAEAACcQAAAAEKmLJI9tfT9fFHJSliMLmwQ8LCFzwr0GNs3+fPo5RVxZ13yl46kFRiDzyeWsAkTsag==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Posts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: true);

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
    }
}
