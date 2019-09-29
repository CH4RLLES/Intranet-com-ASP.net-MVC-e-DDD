using IntranetCPT.Dominio.Entidades;
using IntranetCPT.Infra.Dados.Mapeamento;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntranetCPT.Infra.Dados.Contexto
{
    public class SistemaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("server=DFCPT0048D\\LOCALDB;database=Intranet;trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tb_Conteudo>(new Tb_ConteudoMap().Configure);
            modelBuilder.Entity<Tb_Ramais>(new Tb_RamaisMap().Configure);
            modelBuilder.Entity<Tb_Manuais>(new Tb_ManuaisMap().Configure);
        }

        public DbSet<Tb_Conteudo> Tb_Conteudos { get; set; }
        public DbSet<Tb_Manuais> Tb_Manuais { get; set; }
        public DbSet<Tb_Ramais> Tb_Ramais { get; set; }
    }
}
