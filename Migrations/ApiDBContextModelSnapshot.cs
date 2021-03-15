﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Data.Contexts;

namespace api.Migrations
{
    [DbContext(typeof(ApiDBContext))]
    partial class ApiDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api.Models.Cor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fabricante")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cores");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Codigo = "1",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 1,
                            Nome = "Branco"
                        },
                        new
                        {
                            Id = 101,
                            Codigo = "2",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 1,
                            Nome = "Preto"
                        },
                        new
                        {
                            Id = 102,
                            Codigo = "3",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 1,
                            Nome = "Vermelho"
                        },
                        new
                        {
                            Id = 103,
                            Codigo = "1",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 2,
                            Nome = "Branco"
                        },
                        new
                        {
                            Id = 104,
                            Codigo = "2",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 2,
                            Nome = "Preto"
                        },
                        new
                        {
                            Id = 105,
                            Codigo = "3",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 2,
                            Nome = "Vermelho"
                        },
                        new
                        {
                            Id = 106,
                            Codigo = "1",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 3,
                            Nome = "Branco"
                        },
                        new
                        {
                            Id = 107,
                            Codigo = "2",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 3,
                            Nome = "Preto"
                        },
                        new
                        {
                            Id = 108,
                            Codigo = "3",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 3,
                            Nome = "Vermelho"
                        },
                        new
                        {
                            Id = 109,
                            Codigo = "1",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 4,
                            Nome = "Branco"
                        },
                        new
                        {
                            Id = 110,
                            Codigo = "2",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 4,
                            Nome = "Preto"
                        },
                        new
                        {
                            Id = 111,
                            Codigo = "3",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 4,
                            Nome = "Vermelho"
                        },
                        new
                        {
                            Id = 112,
                            Codigo = "1",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 5,
                            Nome = "Branco"
                        },
                        new
                        {
                            Id = 113,
                            Codigo = "2",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 5,
                            Nome = "Preto"
                        },
                        new
                        {
                            Id = 114,
                            Codigo = "3",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 5,
                            Nome = "Vermelho"
                        });
                });

            modelBuilder.Entity("api.Models.Fabricante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fabricantes");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Codigo = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Fiat"
                        },
                        new
                        {
                            Id = 101,
                            Codigo = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "GM"
                        },
                        new
                        {
                            Id = 102,
                            Codigo = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Volkswagen"
                        },
                        new
                        {
                            Id = 103,
                            Codigo = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Ford"
                        },
                        new
                        {
                            Id = 104,
                            Codigo = 5,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Hyundai"
                        });
                });

            modelBuilder.Entity("api.Models.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fabricante")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Modelos");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Codigo = "1",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 1,
                            Nome = "Mobi"
                        },
                        new
                        {
                            Id = 101,
                            Codigo = "2",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 1,
                            Nome = "Cronos"
                        },
                        new
                        {
                            Id = 102,
                            Codigo = "3",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 1,
                            Nome = "Toro"
                        },
                        new
                        {
                            Id = 103,
                            Codigo = "1",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 2,
                            Nome = "Onix"
                        },
                        new
                        {
                            Id = 104,
                            Codigo = "2",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 2,
                            Nome = "Cruze"
                        },
                        new
                        {
                            Id = 105,
                            Codigo = "3",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 2,
                            Nome = "Captiva"
                        },
                        new
                        {
                            Id = 106,
                            Codigo = "1",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 3,
                            Nome = "Up!"
                        },
                        new
                        {
                            Id = 107,
                            Codigo = "2",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 3,
                            Nome = "Virtus"
                        },
                        new
                        {
                            Id = 108,
                            Codigo = "3",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 3,
                            Nome = "Amarok"
                        },
                        new
                        {
                            Id = 109,
                            Codigo = "1",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 4,
                            Nome = "Ka"
                        },
                        new
                        {
                            Id = 110,
                            Codigo = "2",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 4,
                            Nome = "Fiesta"
                        },
                        new
                        {
                            Id = 111,
                            Codigo = "3",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 4,
                            Nome = "Ranger"
                        },
                        new
                        {
                            Id = 112,
                            Codigo = "1",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 5,
                            Nome = "HB20"
                        },
                        new
                        {
                            Id = 113,
                            Codigo = "2",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 5,
                            Nome = "Elantra"
                        },
                        new
                        {
                            Id = 114,
                            Codigo = "3",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fabricante = 5,
                            Nome = "Santa Fé"
                        });
                });

            modelBuilder.Entity("api.Models.Revisao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chassi")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRevisao")
                        .HasColumnType("datetime2");

                    b.Property<double>("Km")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Chassi", "Km")
                        .IsUnique();

                    b.ToTable("Revisoes");
                });

            modelBuilder.Entity("api.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chassi")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.Property<string>("Cor")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fabricante")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("api.Models.Revisao", b =>
                {
                    b.HasOne("api.Models.Veiculo", "Veiculo")
                        .WithMany("Revisoes")
                        .HasForeignKey("Chassi")
                        .HasPrincipalKey("Chassi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("api.Models.Veiculo", b =>
                {
                    b.Navigation("Revisoes");
                });
#pragma warning restore 612, 618
        }
    }
}
