using IntranetCPT.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntranetCPT.Infra.Dados.Mapeamento
{
    public class Tb_ConteudoMap : IEntityTypeConfiguration<Tb_Conteudo>
    {
        public void Configure(EntityTypeBuilder<Tb_Conteudo> builder)
        {
            builder.ToTable("Tb_Conteudo");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Titulo)
                .IsRequired()
                .HasColumnName("Titulo");
            builder.Property(c => c.Introducao)
                .IsRequired()
                .HasColumnName("Introducao");
            builder.Property(c => c.Conteudo)
                .IsRequired()
                .HasColumnName("Conteudo");
        }
    }
}
