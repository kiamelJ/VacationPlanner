using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationPlanner.Migrations
{
    public partial class AddPersonToEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmpId", "Name" },
                values: new object[] { 7, "Micke" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmpId", "Name" },
                values: new object[] { 4, "Micke" });
        }
    }
}
