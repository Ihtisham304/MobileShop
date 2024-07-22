﻿// <auto-generated />
using System;
using AfaqMobileShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AfaqMobileShop.Server.Migrations
{
    [DbContext(typeof(AfaqMobileShopContext))]
    [Migration("20240718082103_SeedBuyingTable")]
    partial class SeedBuyingTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AfaqMobileShop.Shared.Models.Buy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adrss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("CNICPicture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMEI1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMEI2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PurchasePrice")
                        .HasColumnType("int");

                    b.Property<string>("Specs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Buying");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adrss = "NSR",
                            CNIC = "173743753773",
                            CNICPicture = new byte[] { 0, 1, 2, 3, 4, 5 },
                            Color = "red",
                            Date = new DateTime(2024, 7, 18, 13, 21, 1, 663, DateTimeKind.Local).AddTicks(9596),
                            FName = "Jan",
                            IMEI1 = "s54646chghchfg",
                            IMEI2 = "no979879jh986",
                            MobileModel = "2020",
                            MobileNumber = "03048034098",
                            Name = "Khan",
                            PurchasePrice = 2300,
                            Specs = "8gb 128gb"
                        });
                });

            modelBuilder.Entity("AfaqMobileShop.Shared.Models.Sell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Baqaya")
                        .HasColumnType("int");

                    b.Property<string>("CNIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Garranty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMEI1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMEI2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("SellDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Warranty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wasol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("AfaqMobileShop.Shared.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
