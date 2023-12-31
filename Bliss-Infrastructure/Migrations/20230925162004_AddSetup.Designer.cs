﻿// <auto-generated />
using System;
using Bliss_Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bliss_Infrastructure.Migrations
{
    [DbContext(typeof(BlissDBContext))]
    [Migration("20230925162004_AddSetup")]
    partial class AddSetup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bliss_Domain.Entities.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Maya"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "GCash"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Cimb"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Tonik"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Uno"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            Name = "Komo"
                        });
                });

            modelBuilder.Entity("Bliss_Domain.Entities.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("Bliss_Domain.Entities.ExpenseCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExpenseCategoroes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Groceries, Dine out, etc.",
                            IsDeleted = false,
                            Name = "Food"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Household Bills",
                            IsDeleted = false,
                            Name = "Household Bills"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Credit Card payments",
                            IsDeleted = false,
                            Name = "Credit Card"
                        });
                });

            modelBuilder.Entity("Bliss_Domain.Entities.Income", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(15,2)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("Bliss_Domain.Entities.IncomeCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IncomeCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Salary from fulltime job",
                            IsDeleted = false,
                            Name = "Full-time Job"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Stock Dividends",
                            IsDeleted = false,
                            Name = "Investment"
                        });
                });

            modelBuilder.Entity("Bliss_Domain.Entities.Jar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AllottedAmount")
                        .HasColumnType("decimal(15,2)");

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<decimal>("CurrentAmount")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDigital")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PercentOfIncomeAlloted")
                        .HasColumnType("decimal(15,2)");

                    b.Property<decimal>("RemainingAmount")
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("Jars");
                });

            modelBuilder.Entity("Bliss_Domain.Entities.Expense", b =>
                {
                    b.HasOne("Bliss_Domain.Entities.ExpenseCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Bliss_Domain.Entities.Income", b =>
                {
                    b.HasOne("Bliss_Domain.Entities.IncomeCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Bliss_Domain.Entities.Jar", b =>
                {
                    b.HasOne("Bliss_Domain.Entities.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });
#pragma warning restore 612, 618
        }
    }
}
