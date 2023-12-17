using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTestNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "36883312-8f38-40a3-9a1a-eb1b82253e25");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "6004a14b-0ff2-424b-a25f-b36af26713a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "981bc812-bebf-4a18-8632-4bec76515bb6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2f1f1bf-7d1d-4adf-92b3-adf9ccacdc83", "AQAAAAEAACcQAAAAELYAZLe2EUbrCqZfuu9HdYmbdTcy9q9Asc7pRK8SRE7tIs/ssErphbKTUH2+MmZ1Yg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ce83ad7-c876-4556-9888-5646dafff50b", "AQAAAAEAACcQAAAAEOMhRUJpUFxUUwRYAKgbq7Jdz7g1KCSgaO/ZzycmiBkcnLegt7EJXS28wrCH+hFLnA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f629469d-5d3c-4dbb-9c66-71fe47440939", "AQAAAAEAACcQAAAAEEl7qZiDANr66u3Q0isc2gFhvpC0zRg6VrIGS8afhI79w+YC/8h9F7tAAdXUR7pdwQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a832e85f-a02c-4ff9-8040-dd2870028389", "AQAAAAEAACcQAAAAEK+BOOKmuWhapwdEUYdrGpc6ccp/7yQei+1ZnysHoNaCtjSf8djooEdAzQ68kcNNAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b056ca6-87a6-4399-bcec-886ac251fa66", "AQAAAAEAACcQAAAAEE8RQoZWn04oObc7R8CyBSNxODZ601K9Fq9W0RIXhynmZaWzAxGlqijTJPCu30G+9Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b851d453-2258-4771-b233-97a2b29699cd", "AQAAAAEAACcQAAAAEHYJkBW0whM89c2bGhNROndEcNSQu38meRAh9B3VVRnx0BXJ/kVIXq+vlhjaXG9rzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92664b34-0b92-42f4-8dd6-478e204c405c", "AQAAAAEAACcQAAAAEKfy+gLss+a9lyu7OlzdZEkWzXLqMovr+nd7H1EUk4Jpq1zw9NCaOr8h17TidyE5WQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91ff84f9-7423-47c1-a6a0-07c4ced57753", "AQAAAAEAACcQAAAAEAgCoo4TXHocN2XrKzF26SUugXlMd8LiAJvXJGU1XawVl4vilsq6eJnOHWkZAE060Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29ca2a61-8d60-44e6-961b-35f262b8d89a", "AQAAAAEAACcQAAAAEFtE2t8YFJUnwYlgPbDvmI3fOQvO2Xh1phOZnIs7jiEqjacQwVmG9JQFBbBgHhLEJg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
