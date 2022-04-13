using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationPlanner.Migrations
{
    public partial class AddColumnNameToVacationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Vacations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Vacations");
        }
    }
}
