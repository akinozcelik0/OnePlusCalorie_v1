﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnePlusCalorie.DAL.Context;

#nullable disable

namespace OnePlusCalorie.DAL.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20221202225916_Ninth")]
    partial class Ninth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AdminAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AdminSifre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("AdminAdi")
                        .IsUnique();

                    b.ToTable("Adminler");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.Besin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Besinler");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.BesinDegeri", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BesinID")
                        .HasColumnType("int");

                    b.Property<int?>("Gram")
                        .HasColumnType("int");

                    b.Property<int?>("Kalsiyum")
                        .HasColumnType("int");

                    b.Property<int?>("Karbonhidrat")
                        .HasColumnType("int");

                    b.Property<int?>("Kolestrol")
                        .HasColumnType("int");

                    b.Property<int?>("Lif")
                        .HasColumnType("int");

                    b.Property<int?>("Potasyum")
                        .HasColumnType("int");

                    b.Property<int?>("Protein")
                        .HasColumnType("int");

                    b.Property<int?>("Sodyum")
                        .HasColumnType("int");

                    b.Property<int?>("Yag")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BesinID")
                        .IsUnique();

                    b.ToTable("BesinDegerleri");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.BesinKategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BesinKategorileri");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.BesinOgun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BesinID")
                        .HasColumnType("int");

                    b.Property<int>("BesininOgunuID")
                        .HasColumnType("int");

                    b.Property<int>("OgunID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BesinID");

                    b.HasIndex("BesininOgunuID");

                    b.ToTable("BesinOgunTablosu");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.Kalori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BesinGrami")
                        .HasColumnType("int");

                    b.Property<int>("BesinID")
                        .HasColumnType("int");

                    b.Property<int>("_Kalori")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BesinID")
                        .IsUnique();

                    b.ToTable("Kaloriler");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.Kullanici", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UyelikTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.OgunDetaylari", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("BesinAltiID")
                        .HasColumnType("int");

                    b.Property<int?>("BesinBesID")
                        .HasColumnType("int");

                    b.Property<int?>("BesinBirID")
                        .HasColumnType("int");

                    b.Property<int?>("BesinDokuzID")
                        .HasColumnType("int");

                    b.Property<int?>("BesinDortID")
                        .HasColumnType("int");

                    b.Property<int?>("BesinIkiID")
                        .HasColumnType("int");

                    b.Property<int?>("BesinOnID")
                        .HasColumnType("int");

                    b.Property<int?>("BesinSekizID")
                        .HasColumnType("int");

                    b.Property<int?>("BesinUcID")
                        .HasColumnType("int");

                    b.Property<int?>("BesinYediID")
                        .HasColumnType("int");

                    b.Property<int?>("ToplamGram")
                        .HasColumnType("int");

                    b.Property<int?>("ToplamKalori")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("OgunDetaylar");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.OgunZamani", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("EklenmeZamani")
                        .HasColumnType("datetime2");

                    b.Property<string>("OgunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OgunID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OgunID")
                        .IsUnique();

                    b.ToTable("OgunZamanlari");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.ProfilBilgisi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Boy")
                        .HasColumnType("float");

                    b.Property<string>("Cinsiyet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("HamilelikDurumu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Kilo")
                        .HasColumnType("float");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<string>("ProfilResmi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("VucutKitleEndeksi")
                        .HasColumnType("float");

                    b.Property<int?>("Yas")
                        .HasColumnType("int");

                    b.Property<string>("YasamTarzi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciID")
                        .IsUnique();

                    b.ToTable("ProfilBilgileri");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.Besin", b =>
                {
                    b.HasOne("OnePlusCalorie.DATA.Entities.BesinKategori", "Kategori")
                        .WithMany("KategorininBesinleri")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.BesinDegeri", b =>
                {
                    b.HasOne("OnePlusCalorie.DATA.Entities.Besin", "DegerBesin")
                        .WithOne("BesininDegerleri")
                        .HasForeignKey("OnePlusCalorie.DATA.Entities.BesinDegeri", "BesinID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DegerBesin");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.BesinOgun", b =>
                {
                    b.HasOne("OnePlusCalorie.DATA.Entities.Besin", "OgununBesini")
                        .WithMany("BesinlerOgun")
                        .HasForeignKey("BesinID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnePlusCalorie.DATA.Entities.OgunDetaylari", "BesininOgunu")
                        .WithMany("OgunBesinleri")
                        .HasForeignKey("BesininOgunuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BesininOgunu");

                    b.Navigation("OgununBesini");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.Kalori", b =>
                {
                    b.HasOne("OnePlusCalorie.DATA.Entities.Besin", "KalorininBesini")
                        .WithOne("BesininKalorisi")
                        .HasForeignKey("OnePlusCalorie.DATA.Entities.Kalori", "BesinID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KalorininBesini");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.OgunZamani", b =>
                {
                    b.HasOne("OnePlusCalorie.DATA.Entities.OgunDetaylari", "ZamanOgun")
                        .WithOne("OgunZamani")
                        .HasForeignKey("OnePlusCalorie.DATA.Entities.OgunZamani", "OgunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ZamanOgun");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.ProfilBilgisi", b =>
                {
                    b.HasOne("OnePlusCalorie.DATA.Entities.Kullanici", "Kullanici")
                        .WithOne("ProfilBilgisi")
                        .HasForeignKey("OnePlusCalorie.DATA.Entities.ProfilBilgisi", "KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.Besin", b =>
                {
                    b.Navigation("BesininDegerleri")
                        .IsRequired();

                    b.Navigation("BesininKalorisi")
                        .IsRequired();

                    b.Navigation("BesinlerOgun");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.BesinKategori", b =>
                {
                    b.Navigation("KategorininBesinleri");
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.Kullanici", b =>
                {
                    b.Navigation("ProfilBilgisi")
                        .IsRequired();
                });

            modelBuilder.Entity("OnePlusCalorie.DATA.Entities.OgunDetaylari", b =>
                {
                    b.Navigation("OgunBesinleri");

                    b.Navigation("OgunZamani")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
