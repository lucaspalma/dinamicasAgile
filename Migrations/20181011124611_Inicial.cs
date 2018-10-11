using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dinamicasAgile.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluxos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluxos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformacoesBasicas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Duracao = table.Column<string>(nullable: true),
                    Proposito = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacoesBasicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    FluxoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passos_Fluxos_FluxoId",
                        column: x => x.FluxoId,
                        principalTable: "Fluxos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dinamicas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ResumoId = table.Column<int>(nullable: true),
                    FluxoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinamicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dinamicas_Fluxos_FluxoId",
                        column: x => x.FluxoId,
                        principalTable: "Fluxos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dinamicas_InformacoesBasicas_ResumoId",
                        column: x => x.ResumoId,
                        principalTable: "InformacoesBasicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exemplos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Avaliacao = table.Column<string>(nullable: true),
                    Participante = table.Column<string>(nullable: true),
                    Tempo = table.Column<string>(nullable: true),
                    Contexto = table.Column<string>(nullable: true),
                    Motivo = table.Column<string>(nullable: true),
                    Metrica = table.Column<string>(nullable: true),
                    Observacao = table.Column<string>(nullable: true),
                    DinamicaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exemplos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exemplos_Dinamicas_DinamicaId",
                        column: x => x.DinamicaId,
                        principalTable: "Dinamicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Referencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    DinamicaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referencias_Dinamicas_DinamicaId",
                        column: x => x.DinamicaId,
                        principalTable: "Dinamicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dinamicas_FluxoId",
                table: "Dinamicas",
                column: "FluxoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dinamicas_ResumoId",
                table: "Dinamicas",
                column: "ResumoId");

            migrationBuilder.CreateIndex(
                name: "IX_Exemplos_DinamicaId",
                table: "Exemplos",
                column: "DinamicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Passos_FluxoId",
                table: "Passos",
                column: "FluxoId");

            migrationBuilder.CreateIndex(
                name: "IX_Referencias_DinamicaId",
                table: "Referencias",
                column: "DinamicaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exemplos");

            migrationBuilder.DropTable(
                name: "Passos");

            migrationBuilder.DropTable(
                name: "Referencias");

            migrationBuilder.DropTable(
                name: "Dinamicas");

            migrationBuilder.DropTable(
                name: "Fluxos");

            migrationBuilder.DropTable(
                name: "InformacoesBasicas");
        }
    }
}
