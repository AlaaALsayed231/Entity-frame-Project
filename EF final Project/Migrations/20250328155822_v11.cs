using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Code", "Address1", "Address2", "City", "Country", "Phone", "PostalCode", "State", "Territory" },
                values: new object[,]
                {
                    { 1, "123 Main St", null, "New York", "USA", "123456", 10001, null, null },
                    { 2, "456 Queen St", null, "London", "UK", "789101", 20002, null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Email", "Extention", "FirstName", "JobTitle", "LastName", "OfficeCode", "reportTo" },
                values: new object[,]
                {
                    { 1, "alice@example.com", null, "Alice", "CEO", "Smith", 1, null },
                    { 2, "bob@example.com", null, "Bob", "Manager", "Johnson", 1, 1 },
                    { 3, "charlie@example.com", null, "Charlie", "Engineer", "Brown", 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 1);
        }
    }
}
