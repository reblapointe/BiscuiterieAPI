using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buiscuiterie.Migrations
{
    public partial class propriétaire : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProprietaireId",
                table: "Biscuit",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProprietaireId",
                table: "Biscuit");
        }
    }
}
