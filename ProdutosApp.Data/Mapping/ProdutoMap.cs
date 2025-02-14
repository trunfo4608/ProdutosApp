using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Data.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {

        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("PRODUTO");


            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnName("DESCRICAO")
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasColumnName("PRECO")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.Qtde)
                .HasColumnName("QTDE")
                .IsRequired();

            builder.Property(p => p.DataCriacao)
                .HasColumnName("DATACRIACAO")
                .IsRequired();


            builder.Property(p => p.DataUltimaAlteracao)
                .HasColumnName("DATAULTIMAALTERACAO")
                .IsRequired();

            builder.Property(p => p.Ativo)
                .HasColumnName("ATIVO")
                .IsRequired();

        }
    }
}
