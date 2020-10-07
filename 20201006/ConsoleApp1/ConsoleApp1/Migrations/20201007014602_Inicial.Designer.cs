﻿// <auto-generated />
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(TareasDbContext))]
    [Migration("20201007014602_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("ConsoleApp1.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TipoId");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("ConsoleApp1.TipoTarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TipoTarea");
                });

            modelBuilder.Entity("ConsoleApp1.Usuario", b =>
                {
                    b.Property<int>("UsuarioPK")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnName("Password")
                        .HasColumnType("char(20)");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("UsuarioPK");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ConsoleApp1.Tarea", b =>
                {
                    b.HasOne("ConsoleApp1.TipoTarea", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
