﻿// <auto-generated />
using API_OF_YOUR_CHOICE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_OF_YOUR_CHOICE.Migrations
{
    [DbContext(typeof(AnimalReportContext))]
    [Migration("20220929212545_Update")]
    partial class Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API_OF_YOUR_CHOICE.Models.Fall2022_Class_of_your_choice.AnimalReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Animal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Bear")
                        .HasColumnType("int");

                    b.Property<int>("Deer")
                        .HasColumnType("int");

                    b.Property<int>("Duck")
                        .HasColumnType("int");

                    b.Property<int>("Elk")
                        .HasColumnType("int");

                    b.Property<int>("Spottings")
                        .HasColumnType("int");

                    b.Property<int>("Turkey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AnimalReports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Animal = "Deer",
                            Bear = 0,
                            Deer = 0,
                            Duck = 0,
                            Elk = 0,
                            Spottings = 100,
                            Turkey = 0
                        },
                        new
                        {
                            Id = 2,
                            Animal = "Turkey",
                            Bear = 0,
                            Deer = 0,
                            Duck = 0,
                            Elk = 0,
                            Spottings = 45,
                            Turkey = 0
                        },
                        new
                        {
                            Id = 3,
                            Animal = "Duck",
                            Bear = 0,
                            Deer = 0,
                            Duck = 0,
                            Elk = 0,
                            Spottings = 1000,
                            Turkey = 0
                        },
                        new
                        {
                            Id = 4,
                            Animal = "Bear",
                            Bear = 0,
                            Deer = 0,
                            Duck = 0,
                            Elk = 0,
                            Spottings = 21,
                            Turkey = 0
                        },
                        new
                        {
                            Id = 5,
                            Animal = "Elk",
                            Bear = 0,
                            Deer = 0,
                            Duck = 0,
                            Elk = 0,
                            Spottings = 2,
                            Turkey = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
