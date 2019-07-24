using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebLoja2.Migrations
{
    public partial class tboendereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endereços");
        }
    }
}
