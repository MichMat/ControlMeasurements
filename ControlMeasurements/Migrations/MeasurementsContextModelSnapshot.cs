﻿// <auto-generated />
using System;
using ControlMeasurements.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControlMeasurements.Migrations
{
    [DbContext(typeof(MeasurementsContext))]
    partial class MeasurementsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControlMeasurements.Models.MeasurementCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Measurement");

                    b.Property<string>("Place");

                    b.HasKey("Id");

                    b.ToTable("MeasurementsCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
