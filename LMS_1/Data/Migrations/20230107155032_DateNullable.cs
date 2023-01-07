using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_1.Data.Migrations
{
    public partial class DateNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateJoined",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "35d136b4-ca81-4f38-b8c5-35eb3626654e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "b51536e2-2ba6-45ca-8f0b-853042667d27");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51b226ed-5c1e-499e-b59d-3af5bc149b4f", null, null, "AQAAAAEAACcQAAAAEEq3YBW2Kp2lt+oS6MP2t+DHhcvObCvoB+Q+UwHweZVO78YCQLyWN0MPE8Kyj7Bp4Q==", "d8f2dcb9-b938-40e3-a1f3-25e4e7658827" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4d5b755-644b-4242-a76c-687d7eec53ff", null, null, "AQAAAAEAACcQAAAAEOkTh/XjqTYQuO+VybdC3TKMJmkw49L2n6m7Q5MYA2l+EdG74Yfru4AwsWMJGGSYLA==", "e5f86833-d787-48ed-8985-1519fdb17d4e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateJoined",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd5f7486-49bb-4999-b282-939775b55392", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAECDtwgGsUNB68fqRqpXifJSW4c58hCQpX8iGnexwre9CsHHvjOCXYF1XpCTNtY0LiQ==", "6b7af727-c71b-4711-a0e9-6c419ddf4b88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9c46e4c-1f11-4b34-999d-63dc7f056fd2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEDFNiBI4HqLjllyPueQrhAOcTr1WcTi1vzHWce+PgYEMM91CV0iS9NbdZwpcpt+0xw==", "c18faab7-3f72-4ee2-8deb-6aa62a434ccc" });
        }
    }
}
