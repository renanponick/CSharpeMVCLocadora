using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpeAvaliacaoMVCLocadora.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: false),
                    Dias = table.Column<int>(nullable: false),
                    FilmesLocados = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    DataLancamento = table.Column<string>(nullable: true),
                    Sinopse = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    EstoqueTotal = table.Column<int>(nullable: false),
                    EstoqueAtual = table.Column<int>(nullable: false),
                    Locado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Locacoes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteID = table.Column<int>(nullable: true),
                    DataLocacao = table.Column<DateTime>(nullable: false),
                    ValorTotal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacoes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Locacoes_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_ClienteID",
                table: "Locacoes",
                column: "ClienteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Locacoes");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
