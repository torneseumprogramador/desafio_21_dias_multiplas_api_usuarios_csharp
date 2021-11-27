﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UsuarioAPI.Servicos;

namespace UsuarioAPI.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211126083518_Usuarios")]
    partial class Usuarios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("UsuarioAPI.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_criacao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("email");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("int")
                        .HasColumnName("empresa_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("senha");

                    b.HasKey("Id");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
