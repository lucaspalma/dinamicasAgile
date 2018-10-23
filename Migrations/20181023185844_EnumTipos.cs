using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dinamicasAgile.Migrations
{
    public partial class EnumTipos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "InformacoesBasicas");

            migrationBuilder.CreateTable(
                name: "TiposDinamicas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: false),
                    InformacoesBasicasId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDinamicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TiposDinamicas_InformacoesBasicas_InformacoesBasicasId",
                        column: x => x.InformacoesBasicasId,
                        principalTable: "InformacoesBasicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TiposDinamicas_InformacoesBasicasId",
                table: "TiposDinamicas",
                column: "InformacoesBasicasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TiposDinamicas");

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "InformacoesBasicas",
                nullable: false,
                defaultValue: "");
        }
    }
}
