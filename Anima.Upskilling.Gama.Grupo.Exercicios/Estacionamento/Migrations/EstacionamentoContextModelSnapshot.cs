﻿// <auto-generated />
using System;
using Estacionamento.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Estacionamento.Migrations
{
    [DbContext(typeof(EstacionamentoContext))]
    partial class EstacionamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Estacionamento.Models.ClienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("text");

                    b.Property<string>("NumeroCelular")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Estacionamento.Models.TicketModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("DescricaoVeiculo")
                        .HasColumnType("text");

                    b.Property<DateTime>("Entrada")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("IdCliente")
                        .HasColumnType("integer");

                    b.Property<int?>("IdVeiculo")
                        .HasColumnType("integer");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Saida")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Estacionamento.Models.VeiculoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cor")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Fabricante")
                        .HasColumnType("text");

                    b.Property<int>("IdCliente")
                        .HasColumnType("integer");

                    b.Property<string>("Modelo")
                        .HasColumnType("text");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("text");

                    b.Property<string>("Placa")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
