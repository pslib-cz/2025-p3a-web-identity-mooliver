using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeRecordsIdentity.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCoffeCup6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0001-000000000001",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2a78405b-8c05-4330-9d55-c2cab286e412", "admin@test.com", "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEN5rtFVSxhicgb/tcVUOwxY3u2+Dle7WRAke4wKE4NnQu+F58eJVs8gFgHnPuiSmvA==", "47dfa760-5848-4899-9121-cb08c2afc8cc", "admin@test.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Administrátor", "ADMINISTRÁTOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0001-000000000001",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4e48f929-ec18-458c-a7a6-f61dc7f82457", "admin@x.test", "ADMIN@X.TEST", "ADMIN@X.TEST", "AQAAAAIAAYagAAAAEEJjqvFmMcQEQtsxtDo8Lblj/O++Uv3FHJSc4IQHYueCMeKm61BhWS+h3gHprda14Q==", "301222c3-0a97-44ac-8f1d-2fd5e1612376", "admin@x.test" });
        }
    }
}
