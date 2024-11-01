﻿// <auto-generated />
using System;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessObjects.Migrations
{
    [DbContext(typeof(MyStoreDBContext))]
    partial class MyStoreDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessObjects.AccountMember", b =>
                {
                    b.Property<string>("MemberID")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MemberName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("MemberPassword")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("MemberRole")
                        .HasColumnType("int");

                    b.HasKey("MemberID");

                    b.ToTable("AccountMember");

                    b.HasData(
                        new
                        {
                            MemberID = "PS0001",
                            EmailAddress = "admin@CompanyName.com",
                            MemberName = "Administrator",
                            MemberPassword = "@1",
                            MemberRole = 1
                        },
                        new
                        {
                            MemberID = "PS0002",
                            EmailAddress = "staff@CompanyName.com",
                            MemberName = "Staff",
                            MemberPassword = "@2",
                            MemberRole = 2
                        },
                        new
                        {
                            MemberID = "PS0003",
                            EmailAddress = "member1@CompanyName.com",
                            MemberName = "Member 1",
                            MemberPassword = "@3",
                            MemberRole = 3
                        },
                        new
                        {
                            MemberID = "PS0004",
                            EmailAddress = "member2@CompanyName.com",
                            MemberName = "Member 2",
                            MemberPassword = "@3",
                            MemberRole = 3
                        });
                });

            modelBuilder.Entity("BusinessObjects.Categories", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Beverages"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Condiments"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Confections"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Dairy Products"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Grains/Cereals"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Meat/Poultry"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Produce"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Seafood"
                        });
                });

            modelBuilder.Entity("BusinessObjects.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryID = 3,
                            Price = 18.00m,
                            ProductName = "Chai",
                            UnitsInStock = 12
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryID = 1,
                            Price = 19.00m,
                            ProductName = "Chang",
                            UnitsInStock = 23
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryID = 2,
                            Price = 10.00m,
                            ProductName = "Aniseed Syrup",
                            UnitsInStock = 23
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryID = 2,
                            Price = 22.00m,
                            ProductName = "Chef Anton's Cajun Seasoning",
                            UnitsInStock = 34
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryID = 2,
                            Price = 21.35m,
                            ProductName = "Chef Anton's Gumbo Mix",
                            UnitsInStock = 45
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryID = 2,
                            Price = 25.00m,
                            ProductName = "Grandma's Boysenberry Spread",
                            UnitsInStock = 21
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryID = 7,
                            Price = 30.00m,
                            ProductName = "Uncle Bob's Organic Dried Pears",
                            UnitsInStock = 22
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryID = 2,
                            Price = 40.00m,
                            ProductName = "Northwoods Cranberry Sauce",
                            UnitsInStock = 10
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryID = 6,
                            Price = 97.00m,
                            ProductName = "Mishi Kobe Niku",
                            UnitsInStock = 12
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryID = 8,
                            Price = 31.00m,
                            ProductName = "Ikura",
                            UnitsInStock = 13
                        });
                });

            modelBuilder.Entity("BusinessObjects.Products", b =>
                {
                    b.HasOne("BusinessObjects.Categories", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("BusinessObjects.Categories", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
