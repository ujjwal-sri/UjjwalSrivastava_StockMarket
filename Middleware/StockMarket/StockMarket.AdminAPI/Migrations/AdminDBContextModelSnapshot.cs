﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockMarket.AdminAPI.DBAccess;

namespace StockMarket.AdminAPI.Migrations
{
    [DbContext(typeof(AdminDBContext))]
    partial class AdminDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockMarket.AdminAPI.Models.Company", b =>
                {
                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("BoardOfDirectors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEO")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("CompanyWriteup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListInStockExchanges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StockCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TurnOver")
                        .HasColumnType("int");

                    b.HasKey("CompanyCode");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("StockMarket.AdminAPI.Models.IPO", b =>
                {
                    b.Property<int>("IPOID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<double>("PricePerShare")
                        .HasColumnType("float");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("StockExchange")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<int>("TotalNumberOfShare")
                        .HasColumnType("int");

                    b.HasKey("IPOID");

                    b.ToTable("IPO");
                });

            modelBuilder.Entity("StockMarket.AdminAPI.Models.StockPrice", b =>
                {
                    b.Property<int>("RowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<double>("CurrentPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<string>("StockExchange")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RowId");

                    b.HasIndex("CompanyCode");

                    b.ToTable("StockPrice");
                });

            modelBuilder.Entity("StockMarket.AdminAPI.Models.User", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Confirmed")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("StockMarket.AdminAPI.Models.StockPrice", b =>
                {
                    b.HasOne("StockMarket.AdminAPI.Models.Company", "Company")
                        .WithMany("StockPrices")
                        .HasForeignKey("CompanyCode");
                });
#pragma warning restore 612, 618
        }
    }
}
