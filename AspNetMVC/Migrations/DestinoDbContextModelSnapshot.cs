﻿// <auto-generated />
using AspNetMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetMVC.Migrations
{
    [DbContext(typeof(DestinoDbContext))]
    partial class DestinoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AspNetMVC.Models.Destinos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Origem")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Destinos");
                });
#pragma warning restore 612, 618
        }
    }
}