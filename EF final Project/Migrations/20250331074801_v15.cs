using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Code", "Address1", "Address2", "City", "Country", "Phone", "PostalCode", "State", "Territory" },
                values: new object[,]
                {
                    { 1, "123 Main St", null, "New York", "USA", "123456", 10001, "NY", "North East" },
                    { 2, "456 Queen St", null, "London", "UK", "789101", 20002, null, "North East" },
                    { 3, "789 Sunset Blvd", null, "Los Angeles", "USA", "987654", 90001, "CA", "West Coast" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 3);
        }
    }
}
