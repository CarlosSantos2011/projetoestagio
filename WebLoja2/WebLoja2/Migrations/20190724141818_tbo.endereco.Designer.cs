using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebLoja2.Context;

namespace WebLoja2.Migrations
{
    [DbContext(typeof(LojaContext))]
    [Migration("20190724141818_tbo.endereco")]
    partial class tboendereco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebLoja2.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Logradouro");

                    b.Property<string>("NomeLogradouro");

                    b.Property<double>("Numero");

                    b.HasKey("Id");

                    b.ToTable("Endereços");
                });
        }
    }
}
