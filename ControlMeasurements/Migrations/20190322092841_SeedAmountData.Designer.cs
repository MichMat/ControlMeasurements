﻿// <auto-generated />
using System;
using ControlMeasurements.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControlMeasurements.Migrations
{
    [DbContext(typeof(MeasurementsContext))]
    [Migration("20190322092841_SeedAmountData")]
    partial class SeedAmountData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControlMeasurements.Models.Amount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MeasurementType");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("Amounts");

                    b.HasData(
                        new { Id = new Guid("2695f178-3c7f-46e1-a41b-6ead72724af8"), MeasurementType = 1, Price = 0.0 },
                        new { Id = new Guid("87243441-0c03-4de3-b110-40cafa170f66"), MeasurementType = 0, Price = 0.0 },
                        new { Id = new Guid("4a9a1542-2bb1-4398-a8ea-b48ea8009733"), MeasurementType = 3, Price = 0.0 },
                        new { Id = new Guid("0763c616-4099-48d9-be6c-7b332db79fe0"), MeasurementType = 2, Price = 0.0 }
                    );
                });

            modelBuilder.Entity("ControlMeasurements.Models.Measurement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("MeasurementType");

                    b.Property<int>("PlaceType");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.ToTable("Measurements");
                });
#pragma warning restore 612, 618
        }
    }
}
