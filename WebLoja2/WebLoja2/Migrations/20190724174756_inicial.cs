using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebLoja2.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Celular = table.Column<string>(nullable: true),
                    Comercial = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Residencial = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereços",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bairro = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    NomeLogradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereços", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    TempoGarantia = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    Valor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Endereços");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
