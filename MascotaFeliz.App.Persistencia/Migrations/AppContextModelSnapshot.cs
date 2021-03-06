// <auto-generated />
using System;
using MascotaFeliz.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Afiliado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PropietarioId")
                        .HasColumnType("int");

                    b.Property<int?>("SugerenciaCuidadoId")
                        .HasColumnType("int");

                    b.Property<string>("TipoMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VeterinarioId")
                        .HasColumnType("int");

                    b.Property<int?>("Visitaid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropietarioId");

                    b.HasIndex("SugerenciaCuidadoId");

                    b.HasIndex("VeterinarioId");

                    b.HasIndex("Visitaid");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SugerenciaCuidado");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Visita", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Entorno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaVisita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("FrecuenciaCardiaca")
                        .HasColumnType("real");

                    b.Property<int>("FrecuenciaRespiratoria")
                        .HasColumnType("int");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<float>("Temperatura")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Visitas");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Propietario", b =>
                {
                    b.HasBaseType("MascotaFeliz.App.Dominio.Persona");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdCliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Propietario");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("MascotaFeliz.App.Dominio.Persona");

                    b.Property<int>("IdVenterinario")
                        .HasColumnType("int");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Mascota", b =>
                {
                    b.HasOne("MascotaFeliz.App.Dominio.Propietario", "Propietario")
                        .WithMany()
                        .HasForeignKey("PropietarioId");

                    b.HasOne("MascotaFeliz.App.Dominio.SugerenciaCuidado", "SugerenciaCuidado")
                        .WithMany()
                        .HasForeignKey("SugerenciaCuidadoId");

                    b.HasOne("MascotaFeliz.App.Dominio.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId");

                    b.HasOne("MascotaFeliz.App.Dominio.Visita", "Visita")
                        .WithMany()
                        .HasForeignKey("Visitaid");

                    b.Navigation("Propietario");

                    b.Navigation("SugerenciaCuidado");

                    b.Navigation("Veterinario");

                    b.Navigation("Visita");
                });
#pragma warning restore 612, 618
        }
    }
}
