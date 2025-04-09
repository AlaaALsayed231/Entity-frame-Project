using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Employees_salesRepEmployeeNum",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "salesRepEmployeeNum",
                table: "Customers",
                newName: "SalesRepEmployeeNum");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_salesRepEmployeeNum",
                table: "Customers",
                newName: "IX_Customers_SalesRepEmployeeNum");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Employees_SalesRepEmployeeNum",
                table: "Customers",
                column: "SalesRepEmployeeNum",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Employees_SalesRepEmployeeNum",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "SalesRepEmployeeNum",
                table: "Customers",
                newName: "salesRepEmployeeNum");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_SalesRepEmployeeNum",
                table: "Customers",
                newName: "IX_Customers_salesRepEmployeeNum");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Employees_salesRepEmployeeNum",
                table: "Customers",
                column: "salesRepEmployeeNum",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
