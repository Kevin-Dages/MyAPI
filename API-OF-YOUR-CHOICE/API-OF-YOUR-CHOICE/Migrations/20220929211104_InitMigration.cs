using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_OF_YOUR_CHOICE.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Animal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Turkey = table.Column<int>(type: "int", nullable: false),
                    Deer = table.Column<int>(type: "int", nullable: false),
                    Duck = table.Column<int>(type: "int", nullable: false),
                    Bear = table.Column<int>(type: "int", nullable: false),
                    Elk = table.Column<int>(type: "int", nullable: false),
                    Spottings = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalReports", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AnimalReports",
                columns: new[] { "Id", "Animal", "Bear", "Deer", "Duck", "Elk", "Spottings", "Turkey" },
                values: new object[,]
                {
                    { 1, "Deer", 0, 0, 0, 0, 100, 0 },
                    { 2, "Turkey", 0, 0, 0, 0, 45, 0 },
                    { 3, "Duck", 0, 0, 0, 0, 1000, 0 },
                    { 4, "Bear", 0, 0, 0, 0, 21, 0 },
                    { 5, "Elk", 0, 0, 0, 0, 2, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalReports");
        }
    }
}
