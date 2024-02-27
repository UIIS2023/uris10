﻿// <auto-generated />
using System;
using DokumentiService.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DokumentiService.Migrations
{
    [DbContext(typeof(DokumentContext))]
    partial class DokumentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DokumentiService.Entities.DokumentEntity", b =>
                {
                    b.Property<Guid>("DokumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DatumDonosenja")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EksterniDokumentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InterniDokumentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Sablon")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("StatusDokumenta")
                        .HasColumnType("int");

                    b.HasKey("DokumentID");

                    b.HasIndex("EksterniDokumentID");

                    b.HasIndex("InterniDokumentID");

                    b.ToTable("Dokumenti");

                    b.HasData(
                        new
                        {
                            DokumentID = new Guid("c9c1ccd3-e953-490e-b69c-cf903d8758f9"),
                            DatumDonosenja = new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EksterniDokumentID = new Guid("475b61f1-dccd-404a-a657-43fb9ec729ce"),
                            InterniDokumentID = new Guid("858930f0-92ec-4975-b697-0c7afb2842de"),
                            Sablon = 5,
                            StatusDokumenta = 4
                        },
                        new
                        {
                            DokumentID = new Guid("378ffff9-f997-4b7f-8c6e-c674918ef2e9"),
                            DatumDonosenja = new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EksterniDokumentID = new Guid("72922197-afd8-49ad-877b-6573b7d50714"),
                            InterniDokumentID = new Guid("9813acc5-35f5-4d3b-886c-42a6aaf162b9"),
                            Sablon = 5,
                            StatusDokumenta = 4
                        });
                });

            modelBuilder.Entity("DokumentiService.Entities.EksterniDokumentEntity", b =>
                {
                    b.Property<Guid>("EksterniDokumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PutanjaDokumenta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EksterniDokumentID");

                    b.ToTable("EksterniDokumenti");

                    b.HasData(
                        new
                        {
                            EksterniDokumentID = new Guid("475b61f1-dccd-404a-a657-43fb9ec729ce"),
                            PutanjaDokumenta = "Ovo je samo da vidimo sta ce da pise"
                        },
                        new
                        {
                            EksterniDokumentID = new Guid("72922197-afd8-49ad-877b-6573b7d50714"),
                            PutanjaDokumenta = "Ovo je nesto nesto da vidimo sta ce da pise drugi deo brapoooo"
                        });
                });

            modelBuilder.Entity("DokumentiService.Entities.InterniDokumentEntity", b =>
                {
                    b.Property<Guid>("InterniDokumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PutanjaDokumenta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("InterniDokumentID");

                    b.ToTable("InterniDokumenti");

                    b.HasData(
                        new
                        {
                            InterniDokumentID = new Guid("858930f0-92ec-4975-b697-0c7afb2842de"),
                            PutanjaDokumenta = "Internal man"
                        },
                        new
                        {
                            InterniDokumentID = new Guid("9813acc5-35f5-4d3b-886c-42a6aaf162b9"),
                            PutanjaDokumenta = "Internal bratskciiii"
                        });
                });

            modelBuilder.Entity("DokumentiService.Entities.DokumentEntity", b =>
                {
                    b.HasOne("DokumentiService.Entities.EksterniDokumentEntity", "EksterniDokument")
                        .WithMany("Dokument")
                        .HasForeignKey("EksterniDokumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DokumentiService.Entities.InterniDokumentEntity", "InterniDokument")
                        .WithMany("Dokument")
                        .HasForeignKey("InterniDokumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EksterniDokument");

                    b.Navigation("InterniDokument");
                });

            modelBuilder.Entity("DokumentiService.Entities.EksterniDokumentEntity", b =>
                {
                    b.Navigation("Dokument");
                });

            modelBuilder.Entity("DokumentiService.Entities.InterniDokumentEntity", b =>
                {
                    b.Navigation("Dokument");
                });
#pragma warning restore 612, 618
        }
    }
}
