using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationPlanner.Migrations
{
    public partial class AddRelationOneToManyEmployeeVacation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "Vacations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeEmpId",
                table: "Vacations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_EmployeeEmpId",
                table: "Vacations",
                column: "EmployeeEmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Employees_EmployeeEmpId",
                table: "Vacations",
                column: "EmployeeEmpId",
                principalTable: "Employees",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Employees_EmployeeEmpId",
                table: "Vacations");

            migrationBuilder.DropIndex(
                name: "IX_Vacations_EmployeeEmpId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "EmployeeEmpId",
                table: "Vacations");
        }
    }
}
