using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "Comments", "CustomerID", "OrderDate", "ReqiredDate", "ShippedDate", "Status" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, null, 2, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "ID", "OrderID", "PriceEach", "ProductCode", "Qty" },
                values: new object[,]
                {
                    { 1, 1, 599, 1, 2 },
                    { 2, 1, 999, 2, 1 },
                    { 3, 2, 199, 3, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
