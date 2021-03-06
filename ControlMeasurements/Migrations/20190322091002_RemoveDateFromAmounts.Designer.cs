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
    [Migration("20190322091002_RemoveDateFromAmounts")]
    partial class RemoveDateFromAmounts
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
