﻿// <auto-generated />
using System;
using DataSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataSql.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231108181937_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("DataSql.Classes.Instrument", b =>
                {
                    b.Property<string>("InstrumentIdentifier")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("InstrumentIdentifier");

                    b.Property<string>("InstrumentType")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("InstrumentType");

                    b.Property<string>("LocalCurrencyCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("TEXT")
                        .HasColumnName("LocalCurrencyCode");

                    b.HasKey("InstrumentIdentifier");

                    b.ToTable("Instrument");
                });

            modelBuilder.Entity("DataSql.Classes.InstrumentType", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("InstrumentType");
                });

            modelBuilder.Entity("DataSql.Classes.MarketPrice", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT")
                        .HasColumnName("Date")
                        .HasColumnOrder(1);

                    b.Property<string>("InstrumentIdentifier")
                        .HasColumnType("TEXT")
                        .HasColumnName("InstrumentIdentifier")
                        .HasColumnOrder(2);

                    b.Property<decimal?>("Price")
                        .HasPrecision(24, 8)
                        .HasColumnType("TEXT")
                        .HasColumnName("Price");

                    b.HasKey("Date", "InstrumentIdentifier");

                    b.ToTable("MarketPrice");
                });
#pragma warning restore 612, 618
        }
    }
}
