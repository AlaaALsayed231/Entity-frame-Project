using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ID", "DesclnHTML", "DesclnText", "Image" },
                values: new object[,]
                {
                    { 1, "<b>Electronics</b>", "Electronics", "electronics.jpg" },
                    { 2, "<b>Mobile Devices</b>", "Mobile Devices", "mobile.jpg" },
                    { 3, "<b>Food Products</b>", "Food", "food.jpg" },
                    { 4, "<b>Home Appliances</b>", "Appliances", "appliances.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
