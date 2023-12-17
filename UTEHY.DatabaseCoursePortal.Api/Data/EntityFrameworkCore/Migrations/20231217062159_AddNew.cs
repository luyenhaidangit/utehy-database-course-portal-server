using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c3c7c320-1eab-4d30-a8bb-5d7dd5c3844f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "a3681baa-206e-429e-b60f-302272c2115d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "f7d7ff51-3d1f-446f-aa9a-5ceff759fa26");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9eb035f-881d-4cbd-9002-6aa548dbfb55", "AQAAAAEAACcQAAAAEMlLqF1v1J5ZWTMwbi4EotX3fWEj7m1BNC/EL6NR3h74u6RL2a/iWSGUArT+bRIJ3Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97c47d8e-f321-4f7a-ae9c-ca6b52c15c85", "AQAAAAEAACcQAAAAEMqkSkOYGGVOkfB2UBb5hvjskp+BDUw4REIiEvDci+6zIzDNb9lrcf98S0st3AmkiA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8e55a2e-abc3-4050-a950-d5a005734d77", "AQAAAAEAACcQAAAAEDGBiTdVkH04EHqNe06YyvJhi/H8fCIB+pHFUAJzW83PWqNa/eJhGM/vp2qPfUslPw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1419a26e-686f-464a-9fa0-c797c097f94e", "AQAAAAEAACcQAAAAEJXiG6vGalhhBI/lIyjUz3o3TcgLMFDtBBdtV7lSbrIyDKehKCKi/9pLEKUmKTfUMg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f77b62e9-5c95-4e1f-95e8-861295595f3f", "AQAAAAEAACcQAAAAENF/XsmxQDwckJ9OeB2TbS8kzUA4DKM8tmMUS5CBa5wxdCwvQYESWMllcnJmg7fkFA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12953876-b826-43ae-8f6b-f0958212aecf", "AQAAAAEAACcQAAAAEKr+osfTpUBpk66fOmA6jMwH4AWU1z/BGkNIBoUkawAeeyv1CZUIQCoO9wsCAKVY+w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "270ad09f-0d5e-478e-8461-60a93346618d", "AQAAAAEAACcQAAAAEFzuzFivgAX9gmuhajDRKA4Zsqusk/HPoyTbzyhFzhDhhefeG0XRNIfok3uc510ZNw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1e1b67f-cc27-4808-9355-c8e485a1f510", "AQAAAAEAACcQAAAAEBtmQUutHV3LDkjJ0PkW2Zm2IlFN1/4T7IViqDZzK0PhUNnTJfalJHcQDNOTCiquUw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c75a0cf1-ed9a-4ddb-9c76-8eb851103118", "AQAAAAEAACcQAAAAENYvlgNqQJGwpvVNvGXBX9Y5aPg5SUj1GY2jQe9NlZMAK9aSwOdns8+hpJUztVebMw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionAnswers");

            migrationBuilder.DropTable(
                name: "QuestionTags");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "QuestionCategories");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Questions",
                type: "uniqueidentifier",
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
    }
}
