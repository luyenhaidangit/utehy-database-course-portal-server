using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditTablePost_AddCollumIsApprove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Posts",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "884da17d-ddf0-4db5-8f35-0c1bf91aad93");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "63ea2035-46a9-433c-b1a2-33d356c144fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "10ff1254-f591-4456-ba14-19c5542c4e00");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f0e383f-52fb-4957-a028-53350ab9231d", "AQAAAAEAACcQAAAAEKTzEzgiCXcssyUMNuT0CvKXhZRUKJq35G5xvzvcP7rI6DryBMqgBUAtk8q59b38uw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1897c0d-5b8e-42de-8127-5bf8c88f39b6", "AQAAAAEAACcQAAAAECE+9qN4MJ+Qa29q0lKDbXDd1hLASGTV0rsQB9rPTkEcXwmbkkiUuGsdAh56GmbIuw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa633270-7bf7-4060-b0b4-7dd70867fa7a", "AQAAAAEAACcQAAAAEB90A76Vd6QZ+LT3/8XxD0A6Z2NKAv4uddKumiegYgq/w1cKapim7A7nI9M/8A60HA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1046d7ea-8dc5-4f4b-a9cf-f2d2d4f29834", "AQAAAAEAACcQAAAAEPtQJBUDNTyZ4dr50J4j/cxSYM5BOHLhwCDcMeWTeWdbSzIgmQJjuU8a2F/fMq05fQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed514bcf-b5ab-4cbd-8c19-793e58fab1c5", "AQAAAAEAACcQAAAAEC26a+6jRnXQjKtOW8FE9NsYPD1lRsvsFfinmA6bpRDXfw2PgWUTSeqC6+8x8q0whg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd1d9984-5631-4c17-bf48-67b975cf8ccc", "AQAAAAEAACcQAAAAEDZNzsu6QE2Bh20GGDwgSKxW1hy6JtrftbaIx9FYLLL6eDnbi8ThnyE1LRCDxTPo9w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a11567a0-2759-4ec4-8544-bc26df025084", "AQAAAAEAACcQAAAAEMdoKb7F90CmFFeuOg+8zQpoG7869bNLMjKO2QoFLCO5E1dAqmR+sUawIYdafKrJNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "112d898e-b266-4017-8c01-e366db73f9fb", "AQAAAAEAACcQAAAAEN6V3E3iYb9ss5Z4jQhqKP6Z+Cy+AMYniRC55ab8htpzkUUT85Nq6vAvKaAen6dfzQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f55b402-0c88-458c-8818-dc9ac8dd7903", "AQAAAAEAACcQAAAAEDBTfVwhdrr/ZcvSJ87rQdajTr4Hdyp80BuyKQGsptKVEm7trCLlwskj+IsjbNrhOw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3108b7bf-674a-4154-91f6-634d380d6649");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "8498d0de-b037-420e-a4bb-daba4a648705");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "aecea373-53da-41bf-af6b-8afcec92e262");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc5cfa7b-dcbf-442c-91c3-fd84defecf54", "AQAAAAEAACcQAAAAEMgB39oeO+memZid6qusQ4DW0OI/Bq6b7NFwqzXidD5KxmVJPMJL4Q9fl32OwUPhHg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "903f7bc0-537d-4dd5-9925-b47890c1eb57", "AQAAAAEAACcQAAAAEEUO9+eUB5H5f2n2yNfCuVssDur7AyyqptMjYx81Wb2b+mW3ryFk10n4eb9p9l2iAw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "782f311c-baa9-4980-8fbc-a99b8148fa49", "AQAAAAEAACcQAAAAEBcfXsAacjPdl2t7lcuL15L2d1pvGNJl6ZbZ6w6NUzLsH8F4VF1UFEJGA4hgan9YYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dcbef5b6-106d-4751-a437-e525d7873190", "AQAAAAEAACcQAAAAEMvS3oy5pipgYhRLm6g79zxntahuQ1t6iZN/FeySvgVwN/UWP5SmwJR+jwOHeK57qw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97057386-5259-4a8a-acb6-e70dd47e7b6b", "AQAAAAEAACcQAAAAEJK2RPI6t59XEmFVoCX4zE20c4p0KG7vhe6e0riG4K+956P5RUk0kxt7DkkLA412+g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf1d1f62-94f2-4f3c-83e3-362decbb1086", "AQAAAAEAACcQAAAAECBNGpr/l0W4Oio4itDPDtReAv2j57G1HvGjucgak/ca6XI8A57hY6mL6VY+tfBs0A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be09b89c-13bb-4a43-a029-b16b3724645a", "AQAAAAEAACcQAAAAEOZuqLqn/0fvq2LjeKgUCnd9evAgw8JzGXNqfZkdH7cBuYk98MvAlEXY1ynvX23xXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2334eb43-0ed0-4ee4-80a5-dc73ca069e59", "AQAAAAEAACcQAAAAEFFEsrzogUDLDD/9oum8UOD515YMVK5zw89ozh5e1jB7WUMmQo4Ww44gq8Ap6X13kw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6d7b164-db67-4448-9800-f73de2ad60d8", "AQAAAAEAACcQAAAAEOcS9a8nFr4P+SkM0K0GvlpA6Xx2n2tF+9+chvXSu0VKot7QpEnxpF8OUOSpGLOulA==" });
        }
    }
}
