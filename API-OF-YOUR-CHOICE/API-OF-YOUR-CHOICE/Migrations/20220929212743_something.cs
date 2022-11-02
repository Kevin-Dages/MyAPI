using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_OF_YOUR_CHOICE.Migrations
{
    public partial class something : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bear",
                table: "AnimalReports");

            migrationBuilder.DropColumn(
                name: "Deer",
                table: "AnimalReports");

            migrationBuilder.DropColumn(
                name: "Duck",
                table: "AnimalReports");

            migrationBuilder.DropColumn(
                name: "Elk",
                table: "AnimalReports");

            migrationBuilder.DropColumn(
                name: "Turkey",
                table: "AnimalReports");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bear",
                table: "AnimalReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deer",
                table: "AnimalReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Duck",
                table: "AnimalReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Elk",
                table: "AnimalReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Turkey",
                table: "AnimalReports",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
