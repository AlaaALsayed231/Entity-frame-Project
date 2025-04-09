using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "ProductLines",
                columns: new[] { "ID", "DesclnHTML", "DesclnText", "Image" },
                values: new object[,]
                {
                    { 101, "<b>Electronics</b>", "Electronics", "electronics.jpg" },
                    { 102, "<b>Mobile Devices</b>", "Mobile Devices", "mobile.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Email", "Extention", "FirstName", "JobTitle", "LastName", "OfficeCode", "reportTo" },
                values: new object[] { 1, "alice@example.com", null, "Alice", "CEO", "Smith", 1, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Code", "BuyPrice", "MSRP", "Name", "PdtDescription", "ProductlnID", "QlylnStock", "Scale", "Vender" },
                values: new object[,]
                {
                    { 1, 1500m, "2000", "Laptop", "High-performance laptop", 101, 10, 5, "Dell" },
                    { 2, 800m, "1200", "Phone", "Latest smartphone", 102, 25, 3, "Samsung" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Email", "Extention", "FirstName", "JobTitle", "LastName", "OfficeCode", "reportTo" },
                values: new object[,]
                {
                    { 2, "bob@example.com", null, "Bob", "Manager", "Johnson", 1, 1 },
                    { 3, "charlie@example.com", null, "Charlie", "Engineer", "Brown", 2, 2 }
                });
        }
    }
}
