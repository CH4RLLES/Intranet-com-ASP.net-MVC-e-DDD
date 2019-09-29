using IntranetCPT.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntranetCPT.Infra.Dados.Mapeamento
{
    public class Tb_RamaisMap : IEntityTypeConfiguration<Tb_Ramais>
    {
        public void Configure(EntityTypeBuilder<Tb_Ramais> builder)
        {
            builder.ToTable("Tb_Ramais");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Setor)
                .IsRequired()
                .HasColumnName("Setor");
            builder.Property(c => c.Telefone)
                .IsRequired()
                .HasColumnName("Telefone");
        }
    }
}
