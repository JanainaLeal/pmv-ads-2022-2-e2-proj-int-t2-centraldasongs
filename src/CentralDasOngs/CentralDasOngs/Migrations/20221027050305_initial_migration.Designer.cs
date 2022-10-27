﻿// <auto-generated />
using System;
using CentralDasOngs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CentralDasOngs.Migrations
{
    [DbContext(typeof(CentralDasOngsContext))]
    [Migration("20221027050305_initial_migration")]
    partial class initial_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CentralDasOngs.Models.AddressModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("StateId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("CentralDasOngs.Models.BankAccountModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<int>("Branch")
                        .HasColumnType("int");

                    b.Property<int>("UserOngId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("UserOngId")
                        .IsUnique();

                    b.ToTable("BankAccount");
                });

            modelBuilder.Entity("CentralDasOngs.Models.BankModel", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("CentralDasOngs.Models.StateModel", b =>
                {
                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UF");

                    b.ToTable("UFs");
                });

            modelBuilder.Entity("CentralDasOngs.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserModel");
                });

            modelBuilder.Entity("CentralDasOngs.Models.UserOngModel", b =>
                {
                    b.HasBaseType("CentralDasOngs.Models.UserModel");

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Cnpj")
                        .HasColumnType("bigint");

                    b.ToTable("user_ong");
                });

            modelBuilder.Entity("CentralDasOngs.Models.UserVoluntarioModel", b =>
                {
                    b.HasBaseType("CentralDasOngs.Models.UserModel");

                    b.Property<long>("Cpf")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateBirthDay")
                        .HasColumnType("datetime2");

                    b.ToTable("UserVoluntario");
                });

            modelBuilder.Entity("CentralDasOngs.Models.AddressModel", b =>
                {
                    b.HasOne("CentralDasOngs.Models.StateModel", "State")
                        .WithMany("Address")
                        .HasForeignKey("StateId");

                    b.HasOne("CentralDasOngs.Models.UserModel", "User")
                        .WithOne("Address")
                        .HasForeignKey("CentralDasOngs.Models.AddressModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CentralDasOngs.Models.BankAccountModel", b =>
                {
                    b.HasOne("CentralDasOngs.Models.BankModel", "Bank")
                        .WithMany("BankAccount")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CentralDasOngs.Models.UserOngModel", "UserOng")
                        .WithOne("BankAccount")
                        .HasForeignKey("CentralDasOngs.Models.BankAccountModel", "UserOngId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");

                    b.Navigation("UserOng");
                });

            modelBuilder.Entity("CentralDasOngs.Models.UserOngModel", b =>
                {
                    b.HasOne("CentralDasOngs.Models.UserModel", null)
                        .WithOne()
                        .HasForeignKey("CentralDasOngs.Models.UserOngModel", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CentralDasOngs.Models.UserVoluntarioModel", b =>
                {
                    b.HasOne("CentralDasOngs.Models.UserModel", null)
                        .WithOne()
                        .HasForeignKey("CentralDasOngs.Models.UserVoluntarioModel", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CentralDasOngs.Models.BankModel", b =>
                {
                    b.Navigation("BankAccount");
                });

            modelBuilder.Entity("CentralDasOngs.Models.StateModel", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("CentralDasOngs.Models.UserModel", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("CentralDasOngs.Models.UserOngModel", b =>
                {
                    b.Navigation("BankAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
