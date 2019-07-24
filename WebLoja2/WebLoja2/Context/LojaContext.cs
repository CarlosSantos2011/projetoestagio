
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.Models;


namespace WebLoja2.Context
{
    public class LojaContext : DbContext
    {     
       
        public DbSet <Endereco> Endereços { get; set; }
        public DbSet <Contatos> Contatos { get; set; }
<<<<<<< HEAD
        public DbSet<Produto> Produto { get; set; }
=======
        public DbSet<Produtos> Produtos { get; set; }
>>>>>>> 30866b005970f756765ff9136656d50e9d9573a5

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }
    }
}