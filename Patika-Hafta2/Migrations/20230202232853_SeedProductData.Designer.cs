﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Patika_Hafta1_Odev.Data;

namespace Patika_Hafta1_Odev.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20230202232853_SeedProductData")]
    partial class SeedProductData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Patika_Hafta1_Odev.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 1, 31, 2, 28, 52, 710, DateTimeKind.Local).AddTicks(2068),
                            Name = "Bilgisayar",
                            Price = 20000m,
                            Stock = 300
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2023, 1, 31, 2, 28, 52, 711, DateTimeKind.Local).AddTicks(7459),
                            Name = "Telefon",
                            Price = 12000m,
                            Stock = 3200
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2023, 1, 31, 2, 28, 52, 711, DateTimeKind.Local).AddTicks(7485),
                            Name = "Klavye",
                            Price = 1000m,
                            Stock = 3200
                        });
                });
#pragma warning restore 612, 618
        }
    }
}