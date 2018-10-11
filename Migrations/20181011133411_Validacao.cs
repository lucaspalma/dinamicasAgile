using Microsoft.EntityFrameworkCore.Migrations;

namespace dinamicasAgile.Migrations
{
    public partial class Validacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dinamicas_Fluxos_FluxoId",
                table: "Dinamicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Dinamicas_InformacoesBasicas_ResumoId",
                table: "Dinamicas");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Passos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "InformacoesBasicas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "InformacoesBasicas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Proposito",
                table: "InformacoesBasicas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Duracao",
                table: "InformacoesBasicas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tempo",
                table: "Exemplos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Participante",
                table: "Exemplos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Motivo",
                table: "Exemplos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contexto",
                table: "Exemplos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Avaliacao",
                table: "Exemplos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ResumoId",
                table: "Dinamicas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FluxoId",
                table: "Dinamicas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dinamicas_Fluxos_FluxoId",
                table: "Dinamicas",
                column: "FluxoId",
                principalTable: "Fluxos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dinamicas_InformacoesBasicas_ResumoId",
                table: "Dinamicas",
                column: "ResumoId",
                principalTable: "InformacoesBasicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dinamicas_Fluxos_FluxoId",
                table: "Dinamicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Dinamicas_InformacoesBasicas_ResumoId",
                table: "Dinamicas");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Passos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "InformacoesBasicas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "InformacoesBasicas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Proposito",
                table: "InformacoesBasicas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Duracao",
                table: "InformacoesBasicas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Tempo",
                table: "Exemplos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Participante",
                table: "Exemplos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Motivo",
                table: "Exemplos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Contexto",
                table: "Exemplos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Avaliacao",
                table: "Exemplos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ResumoId",
                table: "Dinamicas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FluxoId",
                table: "Dinamicas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Dinamicas_Fluxos_FluxoId",
                table: "Dinamicas",
                column: "FluxoId",
                principalTable: "Fluxos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dinamicas_InformacoesBasicas_ResumoId",
                table: "Dinamicas",
                column: "ResumoId",
                principalTable: "InformacoesBasicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
