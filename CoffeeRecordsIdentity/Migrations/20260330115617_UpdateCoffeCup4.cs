using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeRecordsIdentity.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCoffeCup4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", null, "Administrátor", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-0000-0000-0001-000000000001", 0, "7adb0bc3-081b-4655-87f6-7c5b461d2d40", "admin@x.test", true, false, null, "", "ADMIN@X.TEST", "ADMIN@X.TEST", "AQAAAAIAAYagAAAAEEP7iH5cdPVNUxJn75VygiK5+KfgYZXTPl3QxZmTW5ZJHn80/5MkTxFerLMJBzoXcQ==", null, false, "0f180002-4009-429e-9efc-80d00fb022df", false, "admin@x.test" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0001-000000000001" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0001-000000000001" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0001-000000000001");
        }
    }
}
