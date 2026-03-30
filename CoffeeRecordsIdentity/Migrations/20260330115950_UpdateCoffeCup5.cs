using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeRecordsIdentity.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCoffeCup5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "NormalizedName",
                value: "ADMINISTRÁTOR");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0001-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e48f929-ec18-458c-a7a6-f61dc7f82457", "AQAAAAIAAYagAAAAEEJjqvFmMcQEQtsxtDo8Lblj/O++Uv3FHJSc4IQHYueCMeKm61BhWS+h3gHprda14Q==", "301222c3-0a97-44ac-8f1d-2fd5e1612376" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "NormalizedName",
                value: "ADMINISTRATOR");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0001-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7adb0bc3-081b-4655-87f6-7c5b461d2d40", "AQAAAAIAAYagAAAAEEP7iH5cdPVNUxJn75VygiK5+KfgYZXTPl3QxZmTW5ZJHn80/5MkTxFerLMJBzoXcQ==", "0f180002-4009-429e-9efc-80d00fb022df" });
        }
    }
}
