using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW_13.Migrations
{
    /// <inheritdoc />
    public partial class qqw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_CurrentEmployeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CurrentEmployeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CurrentEmployeId",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ReportsTo",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "CurrentEmployeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CurrentEmployeId",
                table: "Employees",
                column: "CurrentEmployeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_CurrentEmployeId",
                table: "Employees",
                column: "CurrentEmployeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
