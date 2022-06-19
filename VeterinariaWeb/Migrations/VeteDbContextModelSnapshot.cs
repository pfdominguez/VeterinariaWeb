﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VeterinariaWeb.Model;

namespace VeterinariaWeb.Migrations
{
    [DbContext(typeof(VeteDbContext))]
    partial class VeteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnimalPacient", b =>
                {
                    b.Property<int>("AnimalesidAnimal")
                        .HasColumnType("int");

                    b.Property<int>("PacientsIdPaciente")
                        .HasColumnType("int");

                    b.HasKey("AnimalesidAnimal", "PacientsIdPaciente");

                    b.HasIndex("PacientsIdPaciente");

                    b.ToTable("AnimalPacient");
                });

            modelBuilder.Entity("VeterinariaWeb.Model.Animal", b =>
                {
                    b.Property<int>("idAnimal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tipoAnimal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAnimal");

                    b.ToTable("Animales");
                });

            modelBuilder.Entity("VeterinariaWeb.Model.Pacient", b =>
                {
                    b.Property<int>("IdPaciente")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("Atendido")
                        .HasColumnType("bit");

                    b.Property<string>("ClaseAnimal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoRuta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDueno")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("NombrePaciente")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TipoAtencion")
                        .HasColumnType("int");

                    b.HasKey("IdPaciente");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("AnimalPacient", b =>
                {
                    b.HasOne("VeterinariaWeb.Model.Animal", null)
                        .WithMany()
                        .HasForeignKey("AnimalesidAnimal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VeterinariaWeb.Model.Pacient", null)
                        .WithMany()
                        .HasForeignKey("PacientsIdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
