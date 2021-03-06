﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TakeHome.WebAPI.Data;

namespace TakeHome.WebAPI.Migrations
{
    [DbContext(typeof(TakeHomeDbContext))]
    [Migration("20201128203729_Seeding_Guid")]
    partial class Seeding_Guid
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TakeHome.WebAPI.Data.Entities.Invoice", b =>
                {
                    b.Property<Guid>("InvoiceNumber")
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ExchangeRate")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceVat")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SalesAgent")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("SettleDate")
                        .HasColumnType("datetime2");

                    b.HasKey("InvoiceNumber");

                    b.ToTable("Invoices");

                    b.HasData(
                        new
                        {
                            InvoiceNumber = new Guid("4fa4a36a-d5b3-4aee-b9e7-ae6df318b31d"),
                            Amount = 45000m,
                            Client = "Zubby Inc.",
                            Currency = "$",
                            DeliveryDate = new DateTime(2020, 11, 28, 21, 37, 28, 705, DateTimeKind.Local).AddTicks(1389),
                            Description = "Tax Invoice",
                            ExchangeRate = "4.30",
                            InvoiceDate = new DateTime(2020, 11, 28, 21, 37, 28, 703, DateTimeKind.Local).AddTicks(6310),
                            InvoiceVat = "7.5",
                            OrderNumber = "ORD3092",
                            SalesAgent = "Agent0982",
                            SettleDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
