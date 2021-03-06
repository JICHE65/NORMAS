// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Normas.Api.Models;

namespace Normas.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Normas")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Normas.Api.Models.Norma", b =>
                {
                    b.Property<int>("NormaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipoRequisitoId")
                        .HasColumnType("int");

                    b.HasKey("NormaID");

                    b.ToTable("Normas");

                    b.HasData(
                        new
                        {
                            NormaID = 1,
                            Activo = true,
                            Clave = "abc123",
                            Descripcion = "descripcion",
                            FechaPublicacion = new DateTime(2021, 5, 11, 21, 58, 27, 164, DateTimeKind.Local).AddTicks(4211),
                            TipoRequisitoId = 1
                        });
                });

            modelBuilder.Entity("Normas.Api.Models.TipoRequisito", b =>
                {
                    b.Property<int>("TipoRequisitoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TipoRequisitoId");

                    b.ToTable("TipoRequisitos");

                    b.HasData(
                        new
                        {
                            TipoRequisitoId = 1,
                            Descripcion = "Norma Oficial Mexicana (NOM)"
                        },
                        new
                        {
                            TipoRequisitoId = 2,
                            Descripcion = "Especificacion CFE"
                        },
                        new
                        {
                            TipoRequisitoId = 3,
                            Descripcion = "Reglamento Federal"
                        },
                        new
                        {
                            TipoRequisitoId = 4,
                            Descripcion = "Reglamento Estatal"
                        },
                        new
                        {
                            TipoRequisitoId = 5,
                            Descripcion = "reglamento Municipal"
                        },
                        new
                        {
                            TipoRequisitoId = 6,
                            Descripcion = "estandar internacional"
                        },
                        new
                        {
                            TipoRequisitoId = 7,
                            Descripcion = "Norma de Referencia"
                        },
                        new
                        {
                            TipoRequisitoId = 8,
                            Descripcion = "Norma mexicana"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
