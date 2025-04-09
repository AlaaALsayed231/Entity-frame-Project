using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Address1", "Address2", "City", "Country", "CreditLimit", "FirstName", "LastName", "Name", "Phone", "PostalCode", "SalesRepEmployeeNum", "State" },
                values: new object[,]
                {
                    { 1, null, null, null, null, 0, "Jane", "Smith", null, null, 0, 1, null },
                    { 2, null, null, null, null, 0, "Mike", "Johnson", null, null, 0, 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
