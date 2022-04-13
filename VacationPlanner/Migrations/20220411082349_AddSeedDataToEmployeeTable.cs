using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationPlanner.Migrations
{
    public partial class AddSeedDataToEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmpId", "Name" },
                values: new object[,]
                {
                    { 1, "Micke" },
                    { 2, "Anna" },
                    { 3, "Simon" },
                    { 4, "Stephen" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 4);
        }
    }
}
