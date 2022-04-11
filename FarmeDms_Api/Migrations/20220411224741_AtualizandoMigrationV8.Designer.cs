﻿// <auto-generated />
using FarmeDms_Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FarmeDms_Api.Migrations
{
    [DbContext(typeof(_DbContext))]
    [Migration("20220411224741_AtualizandoMigrationV8")]
    partial class AtualizandoMigrationV8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FarmeDms_Api.Models.Produtos", b =>
                {
                    b.Property<int>("Id_Produto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_Loja")
                        .HasColumnType("int");

                    b.Property<string>("Nome_Produto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Preco_Produto")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade_Produto")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_Produto");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
