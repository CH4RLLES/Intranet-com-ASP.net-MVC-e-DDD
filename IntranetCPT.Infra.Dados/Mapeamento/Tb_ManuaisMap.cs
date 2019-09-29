using IntranetCPT.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntranetCPT.Infra.Dados.Mapeamento
{
    public class Tb_ManuaisMap : IEntityTypeConfiguration<Tb_Manuais>
    {
        public void Configure(EntityTypeBuilder<Tb_Manuais> builder)
        {
            builder.ToTable("Tb_Manuais");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Titulo)
                .IsRequired()
                .HasColumnName("Titulo");
            builder.Property(c => c.Arquivo)
                .IsRequired()
                .HasColumnName("Arquivo");
        }
    }
}
