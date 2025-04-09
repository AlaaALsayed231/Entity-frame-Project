using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
