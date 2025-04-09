using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Code", "BuyPrice", "MSRP", "Name", "PdtDescription", "ProductlnID", "QlylnStock", "Scale", "Vender" },
                values: new object[,]
                {
                    { 1, 1.50m, "2.00", "Apple", "Organic red apples", 3, 200, 1, "FreshFarms" },
                    { 2, 2.50m, "3.50", "Bread", "Whole wheat bread loaf", 3, 150, 1, "BakersBest" },
                    { 3, 3.00m, "4.00", "Milk", "1L fresh milk", 3, 100, 1, "DairyFarm" },
                    { 4, 1500m, "2000", "Laptop", "High-performance laptop", 1, 10, 5, "Dell" },
                    { 5, 800m, "1200", "Phone", "Latest smartphone", 2, 25, 3, "Samsung" }
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
                table: "Products",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 5);
        }
    }
}
