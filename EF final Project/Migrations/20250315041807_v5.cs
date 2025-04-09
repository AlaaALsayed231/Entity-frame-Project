using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "reportTo",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_reportTo",
                table: "Employees",
                column: "reportTo");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_reportTo",
                table: "Employees",
                column: "reportTo",
                principalTable: "Employees",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_reportTo",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_reportTo",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "reportTo",
                table: "Employees");
        }
    }
}
