﻿// <auto-generated />
using System;
using DTPersonalInfoTracker.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DTPersonalInfoTracker.Migrations
{
    [DbContext(typeof(PITDbContext))]
    [Migration("20220810062226_LogLayerAdded")]
    partial class LogLayerAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DTPersonalInfoTracker.Models.LogModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("DTPersonalInfoTracker.Models.PersonelModel", b =>
                {
                    b.Property<string>("RecordId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bolum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CepNumarasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pozisyon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PozisyonSeviyesi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SicilNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SirketEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yonetici")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecordId");

                    b.ToTable("Personels");
                });
#pragma warning restore 612, 618
        }
    }
}
