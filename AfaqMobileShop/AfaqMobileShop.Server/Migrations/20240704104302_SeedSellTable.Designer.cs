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
    [Migration("20240704104302_SeedSellTable")]
    partial class SeedSellTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AfaqMobileShop.Shared.Models.Sell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Baqaya = 10000,
                            CNIC = "173743753773",
                            Garranty = "2year",
                            IMEI1 = "s54646chghchfg",
                            IMEI2 = "no979879jh986",
                            Name = "Khan",
                            Price = 30000,
                            SellDate = new DateTime(2024, 7, 4, 15, 43, 1, 61, DateTimeKind.Local).AddTicks(1457),
                            Warranty = "1year",
                            Wasol = 20000
                        },
                        new
                        {
                            Id = 2,
                            Baqaya = 10000,
                            CNIC = "173743753773",
                            Garranty = "2year",
                            IMEI1 = "s54646chghchfg",
                            IMEI2 = "no979879jh986",
                            Name = "Jan",
                            Price = 30000,
                            SellDate = new DateTime(2024, 7, 4, 15, 43, 1, 61, DateTimeKind.Local).AddTicks(1472),
                            Warranty = "1year",
                            Wasol = 20000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
