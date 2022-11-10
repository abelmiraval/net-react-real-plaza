﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealPlaza.DataAccess;

namespace RealPlaza.DataAccess.Migrations
{
    [DbContext(typeof(RealPlazaDbContext))]
    partial class RealPlazaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RealPlaza.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Televisores",
                            Name = "Televisores",
                            Status = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laptop",
                            Name = "Laptop",
                            Status = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Celulares",
                            Name = "Celulares",
                            Status = false
                        });
                });

            modelBuilder.Entity("RealPlaza.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avatar = "https://realplaza.vtexassets.com/arquivos/ids/19952643-800-auto?v=637787185990700000&width=800&height=auto&aspect=true",
                            CategoryId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Televisor SAMSUNG LED 70' Ultra HD / 4K Smart",
                            Price = 1000m,
                            Status = false
                        },
                        new
                        {
                            Id = 2,
                            Avatar = "https://realplaza.vtexassets.com/arquivos/ids/29355975-800-auto?v=637926621748600000&width=800&height=auto&aspect=true",
                            CategoryId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Laptop TUF GAMING 8GB RAM 512GB SSD",
                            Price = 5000m,
                            Status = false
                        },
                        new
                        {
                            Id = 3,
                            Avatar = "https://realplaza.vtexassets.com/arquivos/ids/30749072-800-auto?v=638016157038870000&width=800&height=auto&aspect=true",
                            CategoryId = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Motorola Moto G9 Power RAM 4GB 128GB Azul",
                            Price = 2000m,
                            Status = false
                        },
                        new
                        {
                            Id = 4,
                            Avatar = "https://realplaza.vtexassets.com/arquivos/ids/16669049-800-auto?v=637583552723330000&width=800&height=auto&aspect=true",
                            CategoryId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Televisor Sony 4K HDR Processor X1 65",
                            Price = 1000m,
                            Status = false
                        },
                        new
                        {
                            Id = 5,
                            Avatar = "https://realplaza.vtexassets.com/arquivos/ids/18614998-300-auto?v=637769274914830000&width=300&height=auto&aspect=true",
                            CategoryId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Laptop MAC M2 16GB RAM 512GB SSD",
                            Price = 6000m,
                            Status = false
                        },
                        new
                        {
                            Id = 6,
                            Avatar = "https://realplaza.vtexassets.com/arquivos/ids/17895992-800-auto?v=637741743708070000&width=800&height=auto&aspect=true",
                            CategoryId = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Impresora Multifuncional Epson L3210 Ecotank",
                            Price = 2000m,
                            Status = false
                        },
                        new
                        {
                            Id = 7,
                            Avatar = "https://realplaza.vtexassets.com/arquivos/ids/30794966-800-auto?v=638019917577870000&width=800&height=auto&aspect=true",
                            CategoryId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Televisor Samsung Smart TV 65' Crystal UHD 4K",
                            Price = 1000m,
                            Status = false
                        },
                        new
                        {
                            Id = 8,
                            Avatar = "https://realplaza.vtexassets.com/arquivos/ids/17871602-800-auto?v=637738853647470000&width=800&height=auto&aspect=true",
                            CategoryId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Netbook LENOVO D330-10IGL 32GB RAM 512GB SSD",
                            Price = 7000m,
                            Status = false
                        },
                        new
                        {
                            Id = 9,
                            Avatar = "https://realplaza.vtexassets.com/arquivos/ids/29754680-800-auto?v=637953073800630000&width=800&height=auto&aspect=true",
                            CategoryId = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Parlante bluetooth JBL Party Box 710 potencia 800W RMS",
                            Price = 2000m,
                            Status = false
                        },
                        new
                        {
                            Id = 10,
                            Avatar = "https://realplaza.vtexassets.com/arquivos/ids/29471812-800-auto?v=637934066359800000&width=800&height=auto&aspect=true",
                            CategoryId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Apple MacBook Pro con M1 Max Chip",
                            Price = 1000m,
                            Status = false
                        });
                });

            modelBuilder.Entity("RealPlaza.Entities.Product", b =>
                {
                    b.HasOne("RealPlaza.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
