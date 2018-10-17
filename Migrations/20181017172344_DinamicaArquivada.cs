using Microsoft.EntityFrameworkCore.Migrations;

namespace dinamicasAgile.Migrations
{
    public partial class DinamicaArquivada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Arquivada",
                table: "Dinamicas",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Arquivada",
                table: "Dinamicas");
        }
    }
}
