using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationPlanner.Migrations
{
    public partial class AddNewSeedToEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 4,
                column: "Name",
                value: "Micke");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmpId", "Name" },
                values: new object[] { 6, "Gösta" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmpId", "Name" },
                values: new object[] { 5, "Anna" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 4,
                column: "Name",
                value: "Stephen");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmpId", "Name" },
                values: new object[,]
                {
                    { 1, "Micke" },
                    { 2, "Anna" },
                    { 3, "Simon" }
                });
        }
    }
}
