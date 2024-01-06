using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Migrations
{
    public partial class AddTableGroupModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "df351847-1499-43d3-bf45-36e650c4658f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "0526cbdd-27b1-4f1b-8639-f3bb07224698");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "823b2523-1232-4fb4-871a-c8245cbc7676");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "086f869d-a83a-4c0a-a8d8-8dfb9767314d", "AQAAAAEAACcQAAAAEALQIdh4EMJQd/lUXNEmhAhSB2ACgS+rB2iV78p8EFtiFVlUS9Nf/CZgEzppn94pgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f9c390d-216d-46fa-8118-fd100a224450", "AQAAAAEAACcQAAAAEPG8FBuJU7kH6dqwk2m4kDsu1OwpoWO3IKR8STXdDtRIUgpulEmVnvgXOTZjE2zejA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e49f3e1d-ef7f-4368-8d53-fd1c324e9caf", "AQAAAAEAACcQAAAAEN/XsneIKRtQqTyGd1Lxj53Oeor5VmcTiUq1wg5dDqzcfTyPPp7DTlHT0PE/8X6JAw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c6a425a8-61b6-4053-832f-6317c1c7bf35", "AQAAAAEAACcQAAAAEB7olZjfjuH2xsN0sd2MoVplAE+irD3XNQ2p0PA2F4KW2r9p74LdYCyaWsL1T2YGjQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "840f7aed-2a21-4771-85fb-46332cf49e8c", "AQAAAAEAACcQAAAAEK8hHt05jz88kHiWf8NvY4Nfwoa9bugrdt5vsoc8H20jWugREuoWAqUXkg38ZbVxKg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "568f1d4a-5cf9-4996-a269-914e76e4911b", "AQAAAAEAACcQAAAAEGOXp5LhmFF7axyoSIl74EH9hRSzRxIjNqdfJOczaG/kOa0yaysxml6IxMA/IJJNIg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff0ca39b-e4f2-4ed6-97f9-e1451e3519f9", "AQAAAAEAACcQAAAAEPcHByfNrFt/iV7l+tZMaD2GB4yPH6XSylIJ+VLdmvTvcqnXW8NTbdYpcDNxZTACww==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b216b0c7-3a59-46eb-bdc2-12ef08454983", "AQAAAAEAACcQAAAAEEoxsJ7M1N9Y5hikgOPyhJnJ2zWES5ecXEqEESfKQvhkznSCrfctrIh4AQLxnkU/Xw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e645467f-317b-4625-9163-0c3cfb81584e", "AQAAAAEAACcQAAAAEAzkLKJtC5d78+74VY5JUxtgpCclahcNE4dTNtLERLIXLK3hNebBBBJSYOlfBbNS9Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "de4e4d4c-4b04-4d9b-985f-a6918e442070");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                column: "ConcurrencyStamp",
                value: "71da8063-17d5-470e-9546-a2ffcdf5f575");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f087a2-48d5-4e09-8a63-8830a7b5b4e3"),
                column: "ConcurrencyStamp",
                value: "1b46b3fa-e1fb-4225-b082-fe617f2753f3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3e854a-843d-4e65-ab88-9d5736c831f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "095220a5-2899-42c8-bee5-98a66ce831bd", "AQAAAAEAACcQAAAAECMywCl1HDMydrhOW5JWZecF39Esxjm3ETSMswAR7xp3w3wNnZCLuEOXZL5cP3PtAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b369f41-b710-4527-8084-3b800e469caa", "AQAAAAEAACcQAAAAEPcCm2TcCztuQeyGfOlIH+jtrOw+eypmpZEbGJxkDTtwMYPZ/r6K5J7FXg/obPJ2JA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4f97a72-6b4a-47d3-ba1b-6fe15e62c192"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34d09d59-813a-4c47-a5e6-8e8dc5fe8a6d", "AQAAAAEAACcQAAAAEHSxKjuh59cMi449YllONyPffWhpUvdihH5+6mVSeGBrsCmb8EH3lD64b13ewLfxOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ed0c72e-11b8-4402-b6a0-9c80f674a7a9", "AQAAAAEAACcQAAAAELGcZ66sVUolnji5ExVTyeIWtM8ZjHTbr/YqpZY5MeFUNKN3D0djEJPqg1OB6PBGXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9c1c567-0528-42d0-9921-04da8e904db3", "AQAAAAEAACcQAAAAEP2CJPy5pIQ2ghol79yodwn+sEe3qiBY61uttVMHs+tst+EAfWmOo5p0XO4UDsSiEA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "651168fe-b5af-4cf6-8dda-ba8e90850156", "AQAAAAEAACcQAAAAEIkf8eY/rmuCPSetixqAYBafvQrYvqCsHG3h13qSDMj9q5McY1GGL1cCNru+eNJGbA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2cca972e-88ab-450e-9ba3-a393cc4dfffd", "AQAAAAEAACcQAAAAEN0qnay/ujMVoKUM+ZBXr+HqO0bh2wQk8Py86ol7NCDdz1aIdPMnf0S9tUMkm5lSaQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b7187ea-c0f4-4747-bd9a-fa9270c5e6db", "AQAAAAEAACcQAAAAEKN2RxtynJ/yQdRSMBOtDp1o/GcM4meihs37jXeD/m/Ni3Y4EmIG/c5FcaNIgTjUyA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e5b63a-53a1-4f88-a399-1f7c7f4b08b2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df813224-db0c-4f2e-bbb2-b82acb6d1cbb", "AQAAAAEAACcQAAAAENiHRYaMyTaQzWq3zCZGDBJs2KJguIIzAVQUHzT/KHJos39r57mSoU2bBeR68vxbLw==" });
        }
    }
}
