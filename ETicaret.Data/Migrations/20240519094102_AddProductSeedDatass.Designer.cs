﻿// <auto-generated />
using ETicaretWebUI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ETicaretWebUI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240519094102_AddProductSeedDatass")]
    partial class AddProductSeedDatass
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ETicaret.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categoriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Aksiyon"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Bilim-Kurgu"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Tarih"
                        });
                });

            modelBuilder.Entity("ETicaret.Model.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "WEET8998",
                            Description = "Kumaş Baggy Pantolon İndigo ST00122-Siyah",
                            ISBN = "ST00122-Siyah",
                            ListPrice = 550.99000000000001,
                            Price = 529.99000000000001,
                            Price100 = 500.0,
                            Price50 = 509.99000000000001,
                            Title = "Kumaş Baggy Pantolon"
                        },
                        new
                        {
                            Id = 2,
                            Author = "STRE6655",
                            Description = "Studios Ltd. United Kingdom Oversize T-Shirt Beyaz",
                            ISBN = "ST00275-Beyaz",
                            ListPrice = 449.99000000000001,
                            Price = 429.99000000000001,
                            Price100 = 400.0,
                            Price50 = 410.99000000000001,
                            Title = "United Kingdom Oversize"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}