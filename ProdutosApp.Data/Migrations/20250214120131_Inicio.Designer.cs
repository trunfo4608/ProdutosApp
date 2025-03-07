﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProdutosApp.Data.Context;

#nullable disable

namespace ProdutosApp.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250214120131_Inicio")]
    partial class Inicio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProdutosApp.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Ativo")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("ATIVO");

                    b.Property<DateTime?>("DataCriacao")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATACRIACAO");

                    b.Property<DateTime?>("DataUltimaAlteracao")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAULTIMAALTERACAO");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("NOME");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("PRECO");

                    b.Property<int>("Qtde")
                        .HasColumnType("int")
                        .HasColumnName("QTDE");

                    b.HasKey("Id");

                    b.ToTable("PRODUTO", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
