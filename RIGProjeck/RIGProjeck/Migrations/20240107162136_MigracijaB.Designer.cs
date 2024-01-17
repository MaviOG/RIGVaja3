﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RIGProjeck.Class;

#nullable disable

namespace RIGProjeck.Migrations
{
    [DbContext(typeof(NepremicninaDB))]
    [Migration("20240107162136_MigracijaB")]
    partial class MigracijaB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("RIGProjeck.Class.Nepremičnina", b =>
                {
                    b.Property<int>("NepremičninaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Komentarji")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ocena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("cena")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("dan_izgradnje")
                        .HasColumnType("TEXT");

                    b.Property<string>("lokacija")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("stevilo_balkonov")
                        .HasColumnType("INTEGER");

                    b.Property<int>("stevilo_kopalnic")
                        .HasColumnType("INTEGER");

                    b.Property<int>("stevilo_prostorov")
                        .HasColumnType("INTEGER");

                    b.Property<int>("stevilo_spalnic")
                        .HasColumnType("INTEGER");

                    b.Property<int>("velikost")
                        .HasColumnType("INTEGER");

                    b.HasKey("NepremičninaID");

                    b.ToTable("Nepremicninas");
                });
#pragma warning restore 612, 618
        }
    }
}