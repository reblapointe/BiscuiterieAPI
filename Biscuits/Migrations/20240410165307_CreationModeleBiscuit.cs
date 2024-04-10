using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buiscuiterie.Migrations
{
    public partial class CreationModeleBiscuit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biscuit",
                columns: table => new
                {
                    BiscuitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biscuit", x => x.BiscuitId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biscuit");
        }
    }
}
