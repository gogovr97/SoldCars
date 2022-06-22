using Microsoft.EntityFrameworkCore.Migrations;

namespace SoldCars.Migrations
{
    public partial class initiall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Prise",
                table: "Notes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prise",
                table: "Notes");
        }
    }
}
