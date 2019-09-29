using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntranetCPT.Infra.Dados.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Conteudo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: false),
                    Introducao = table.Column<string>(nullable: false),
                    Conteudo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Conteudo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Manuais",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: false),
                    Arquivo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Manuais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Ramais",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Setor = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Ramais", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Conteudo");

            migrationBuilder.DropTable(
                name: "Tb_Manuais");

            migrationBuilder.DropTable(
                name: "Tb_Ramais");
        }
    }
}
