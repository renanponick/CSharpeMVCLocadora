using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpeAvaliacaoMVCLocadora.Migrations
{
    public partial class Correcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocadoId",
                table: "Filmes");

            migrationBuilder.AddColumn<int>(
                name: "LocacaoId",
                table: "Filmes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocacaoId",
                table: "Filmes");

            migrationBuilder.AddColumn<int>(
                name: "LocadoId",
                table: "Filmes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
