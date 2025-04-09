using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ID", "DesclnHTML", "DesclnText", "Image" },
                values: new object[,]
                {
                    { 101, "<b>Electronics</b>", "Electronics", "electronics.jpg" },
                    { 102, "<b>Mobile Devices</b>", "Mobile Devices", "mobile.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Code", "BuyPrice", "MSRP", "Name", "PdtDescription", "ProductlnID", "QlylnStock", "Scale", "Vender" },
                values: new object[,]
                {
                    { 1, 1500m, "2000", "Laptop", "High-performance laptop", 101, 10, 5, "Dell" },
                    { 2, 800m, "1200", "Phone", "Latest smartphone", 102, 25, 3, "Samsung" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
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
        }
    }
}
