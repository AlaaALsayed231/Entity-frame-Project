using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Address1", "City", "Country", "CreditLimit", "Phone", "PostalCode", "State" },
                values: new object[] { "456 Oak St", "Los Angeles", "USA", 5000, "987-654-3210", 90001, "CA" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Address1", "City", "Country", "CreditLimit", "Phone", "PostalCode", "State" },
                values: new object[] { "789 Maple Ave", "Chicago", "USA", 7000, "555-123-4567", 60601, "IL" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Address1", "City", "Country", "CreditLimit", "Phone", "PostalCode", "State" },
                values: new object[] { null, null, null, 0, null, 0, null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Address1", "City", "Country", "CreditLimit", "Phone", "PostalCode", "State" },
                values: new object[] { null, null, null, 0, null, 0, null });
        }
    }
}
