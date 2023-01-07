using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_1.Data.Migrations
{
    public partial class fixUserTableColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "Lastname");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "10cbbe6b-9c92-466f-bef0-5d2b62fb544e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "10218c33-bc69-477c-820c-70171bc22406");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd5f7486-49bb-4999-b282-939775b55392", "AQAAAAEAACcQAAAAECDtwgGsUNB68fqRqpXifJSW4c58hCQpX8iGnexwre9CsHHvjOCXYF1XpCTNtY0LiQ==", "6b7af727-c71b-4711-a0e9-6c419ddf4b88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9c46e4c-1f11-4b34-999d-63dc7f056fd2", "AQAAAAEAACcQAAAAEDFNiBI4HqLjllyPueQrhAOcTr1WcTi1vzHWce+PgYEMM91CV0iS9NbdZwpcpt+0xw==", "c18faab7-3f72-4ee2-8deb-6aa62a434ccc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "758b1c91-a056-4c32-b557-7a8be651c5a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "38095553-3b67-498b-b7f9-4f5b3aca81a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a1fe6c4-01e9-417e-ab3c-9f537cfbf42c", "AQAAAAEAACcQAAAAEDYRfrg+Nsg8RQBJDyrSlH0qlraqVWrzw/GYqrZ91vPCmkdW57QTPHCQJ1L4uqAfbw==", "9c665cbb-2d95-4019-ae98-444f47f7b65c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edc0197c-ce80-4e5b-b233-ba5b669f51e4", "AQAAAAEAACcQAAAAEAwKcweZeeuimzgke/qWhHdAH59Zim55RBEIE6l9B55UwvMnN0OQ6ZY90pCfv4HfKg==", "e3a79311-c6a4-445c-90a7-bd71525480d5" });
        }
    }
}
