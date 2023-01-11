﻿// <auto-generated />
using System;
using Lab4LukaszBednarek.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab4LukaszBednarek.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    partial class MovieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Lab4LukaszBednarek.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "A",
                            Name = "Action"
                        },
                        new
                        {
                            CategoryId = "C",
                            Name = "Comedy"
                        },
                        new
                        {
                            CategoryId = "D",
                            Name = "Drama"
                        },
                        new
                        {
                            CategoryId = "H",
                            Name = "Horror"
                        },
                        new
                        {
                            CategoryId = "K",
                            Name = "Kids"
                        },
                        new
                        {
                            CategoryId = "S",
                            Name = "SciFi"
                        });
                });

            modelBuilder.Entity("Lab4LukaszBednarek.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Rating")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = "A",
                            Rating = 9,
                            Title = "1917",
                            Year = 2019
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = "S",
                            Rating = 8,
                            Title = "Interstellar",
                            Year = 2014
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = "D",
                            Rating = 10,
                            Title = "Gladiator",
                            Year = 2000
                        });
                });

            modelBuilder.Entity("Lab4LukaszBednarek.Models.Movie", b =>
                {
                    b.HasOne("Lab4LukaszBednarek.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
