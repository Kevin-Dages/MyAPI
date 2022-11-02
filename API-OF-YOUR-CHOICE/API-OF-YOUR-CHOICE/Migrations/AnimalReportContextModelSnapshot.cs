﻿// <auto-generated />
using API_OF_YOUR_CHOICE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_OF_YOUR_CHOICE.Migrations
{
    [DbContext(typeof(AnimalReportContext))]
    partial class AnimalReportContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Spottings")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AnimalReports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Animal = "Deer",
                            Spottings = 100
                        },
                        new
                        {
                            Id = 2,
                            Animal = "Turkey",
                            Spottings = 45
                        },
                        new
                        {
                            Id = 3,
                            Animal = "Duck",
                            Spottings = 1000
                        },
                        new
                        {
                            Id = 4,
                            Animal = "Bear",
                            Spottings = 21
                        },
                        new
                        {
                            Id = 5,
                            Animal = "Elk",
                            Spottings = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
