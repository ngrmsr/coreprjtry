﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF;

namespace Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200926134052_13990705_Add_LoneDetail_and_Address")]
    partial class _13990705_Add_LoneDetail_and_Address
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Try_Core_Entities.AccountModel", b =>
                {
                    b.Property<int>("AccountModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("UserModelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AccountModelId");

                    b.HasIndex("UserModelId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Try_Core_Entities.LoanModel", b =>
                {
                    b.Property<int>("LoanModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("LoanDetailModelId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LoanModelId");

                    b.HasIndex("LoanDetailModelId")
                        .IsUnique()
                        .HasFilter("[LoanDetailModelId] IS NOT NULL");

                    b.ToTable("Loan");
                });

            modelBuilder.Entity("Try_Core_Entities.Model.AccountLoanModel", b =>
                {
                    b.Property<int>("AccountLoanModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountsAccountModelId")
                        .HasColumnType("int");

                    b.Property<int?>("LoansLoanModelId")
                        .HasColumnType("int");

                    b.HasKey("AccountLoanModelId");

                    b.HasIndex("AccountsAccountModelId");

                    b.HasIndex("LoansLoanModelId");

                    b.ToTable("AccountLoan");
                });

            modelBuilder.Entity("Try_Core_Entities.Model.LoanDetailModel", b =>
                {
                    b.Property<int>("LoanDetailModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountPerInstallment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("InstallmentStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoanIdentifierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfInstallments")
                        .HasColumnType("int");

                    b.HasKey("LoanDetailModelId");

                    b.ToTable("LoanDetailModel");
                });

            modelBuilder.Entity("Try_Core_Entities.UserModel", b =>
                {
                    b.Property<int>("UserModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserModelId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Try_Core_Entities.AccountModel", b =>
                {
                    b.HasOne("Try_Core_Entities.UserModel", "user")
                        .WithMany("Accounts")
                        .HasForeignKey("UserModelId");

                    b.OwnsOne("Try_Core_Entities.Model.AddressModel", "address", b1 =>
                        {
                            b1.Property<int>("AccountModelId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("AccountModelId");

                            b1.ToTable("Account");

                            b1.WithOwner()
                                .HasForeignKey("AccountModelId");
                        });
                });

            modelBuilder.Entity("Try_Core_Entities.LoanModel", b =>
                {
                    b.HasOne("Try_Core_Entities.Model.LoanDetailModel", "loanDetail")
                        .WithOne()
                        .HasForeignKey("Try_Core_Entities.LoanModel", "LoanDetailModelId");
                });

            modelBuilder.Entity("Try_Core_Entities.Model.AccountLoanModel", b =>
                {
                    b.HasOne("Try_Core_Entities.AccountModel", "Accounts")
                        .WithMany()
                        .HasForeignKey("AccountsAccountModelId");

                    b.HasOne("Try_Core_Entities.LoanModel", "Loans")
                        .WithMany()
                        .HasForeignKey("LoansLoanModelId");
                });
#pragma warning restore 612, 618
        }
    }
}
