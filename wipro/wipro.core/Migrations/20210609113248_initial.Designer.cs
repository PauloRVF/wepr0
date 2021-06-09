﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wipro.core.Data.Context;

namespace wipro.core.Migrations
{
    [DbContext(typeof(wpContext))]
    [Migration("20210609113248_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("wipro.core.Model.Moeda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Simbolo")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.HasKey("Id");

                    b.ToTable("Moeda");
                });

            modelBuilder.Entity("wipro.core.Model.Processo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_Fim")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Data_Inicio")
                        .HasColumnType("datetime");

                    b.Property<int?>("MoedaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MoedaId");

                    b.ToTable("Processos");
                });

            modelBuilder.Entity("wipro.core.Model.Processo", b =>
                {
                    b.HasOne("wipro.core.Model.Moeda", "Moeda")
                        .WithMany()
                        .HasForeignKey("MoedaId");

                    b.Navigation("Moeda");
                });
#pragma warning restore 612, 618
        }
    }
}