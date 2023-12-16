using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class EditlPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "32fb6508-86f3-4d20-9022-4491cd9b0edb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "a2e4b453-d73e-4913-b95b-908fafeb5ed7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "e55d8235-09fd-4329-b4cf-91f4ebedc558");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49b844af-df8a-46aa-88c6-973e3d0e7a82", "AQAAAAEAACcQAAAAEH/MYfGe3oDjaVlQ2CqG8Ejg/4t3hofJn0fVBtmbMzxjO3XsaB9FNkkY77xvDU/0MQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c3f1779-a90b-4a73-bd90-6abcd57662ee", "AQAAAAEAACcQAAAAEClaqhW6e5lVAOGvQHJvYfzrTShbPAdofyHaON+SxLodRWTNeKaS+qmyDtDfJ0LNMQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c11732a-d6f3-41d7-8cb1-127bca05e021", "AQAAAAEAACcQAAAAEGL04WMVfsIZdY0LfMadzLPKjSJEgmlS1dotQ7SAfDjXlCqNLgwrXkjt4RAwyMNiRw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8991b994-edf5-4211-b1f2-14fb644c0752", "AQAAAAEAACcQAAAAEEY5QqoJRRGNydxjVZGzFQgRF5ysUoxqHS+MkGhXNA/o6zfZMgLWe4zoWUD5J8XICw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "039930d4-cbda-427d-9363-1702e6c0cf59", "AQAAAAEAACcQAAAAEMvBwuUe0qXWT+0u6zwFJ1DKkt1M/tY36VdmytCf2rx6m8NEdZat/ScoaDHl3SmLRA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0aad2bfd-f954-491d-a0d4-31af0e5efa09", "AQAAAAEAACcQAAAAELlW/o6w8/f8QLDp6DT92DoVZB9c4yVRQHQ9cw4IvEZXZMvqxMwJjz8CYADb/pkMvQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7366c80-e139-4ab0-8f3d-d5b98741a5d8", "AQAAAAEAACcQAAAAELUGAFN0fH7NFpSd4W6fOHbyqr6w1w7LblEWwv7jfg10i0tAqtXpfZ5EAFz/lNAIsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73ceac8a-ab23-49a2-a89f-ffc8c4635075", "AQAAAAEAACcQAAAAEN+42lHRvpOFL7Vkg7nBHDXzfvAN4GKEAYMf4zPXcsC7cMgpm4eITxLauwU2uk84OQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21419c1c-ccda-4d64-b16a-c1056fe3e950", "AQAAAAEAACcQAAAAED0v4EcQJEk5yl2WC/jIDPA2lPB/pWNPbPsmEf0LXtnms8TIosm+dqvI9amikZgnIg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
