﻿// <auto-generated />
using System;
using CentralOngs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CentralOngs.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221108232120_hanges")]
    partial class hanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CentralOngs.Models.AddressModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StateName");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("CentralOngs.Models.BankAccountModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AccountType")
                        .HasColumnType("integer");

                    b.Property<int>("BankId")
                        .HasColumnType("integer");

                    b.Property<int>("Branch")
                        .HasColumnType("integer");

                    b.Property<int>("UserOngId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("UserOngId")
                        .IsUnique();

                    b.ToTable("BankAccount");
                });

            modelBuilder.Entity("CentralOngs.Models.BankModel", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Code"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Code");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("CentralOngs.Models.StateModel", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.ToTable("UFs");
                });

            modelBuilder.Entity("CentralOngs.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("UserModel");
                });

            modelBuilder.Entity("CentralOngs.Models.UserOngModel", b =>
                {
                    b.HasBaseType("CentralOngs.Models.UserModel");

                    b.Property<long>("Cnpj")
                        .HasColumnType("bigint");

                    b.ToTable("user_ong");
                });

            modelBuilder.Entity("CentralOngs.Models.UserVoluntarioModel", b =>
                {
                    b.HasBaseType("CentralOngs.Models.UserModel");

                    b.Property<long>("Cpf")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateBirthDay")
                        .HasColumnType("timestamp with time zone");

                    b.ToTable("UserVoluntario");
                });

            modelBuilder.Entity("CentralOngs.Models.AddressModel", b =>
                {
                    b.HasOne("CentralOngs.Models.StateModel", "State")
                        .WithMany("Address")
                        .HasForeignKey("StateName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CentralOngs.Models.UserModel", "User")
                        .WithOne("Address")
                        .HasForeignKey("CentralOngs.Models.AddressModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CentralOngs.Models.BankAccountModel", b =>
                {
                    b.HasOne("CentralOngs.Models.BankModel", "Bank")
                        .WithMany("BankAccount")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CentralOngs.Models.UserOngModel", "UserOng")
                        .WithOne("BankAccount")
                        .HasForeignKey("CentralOngs.Models.BankAccountModel", "UserOngId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");

                    b.Navigation("UserOng");
                });

            modelBuilder.Entity("CentralOngs.Models.UserOngModel", b =>
                {
                    b.HasOne("CentralOngs.Models.UserModel", null)
                        .WithOne()
                        .HasForeignKey("CentralOngs.Models.UserOngModel", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CentralOngs.Models.UserVoluntarioModel", b =>
                {
                    b.HasOne("CentralOngs.Models.UserModel", null)
                        .WithOne()
                        .HasForeignKey("CentralOngs.Models.UserVoluntarioModel", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CentralOngs.Models.BankModel", b =>
                {
                    b.Navigation("BankAccount");
                });

            modelBuilder.Entity("CentralOngs.Models.StateModel", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("CentralOngs.Models.UserModel", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("CentralOngs.Models.UserOngModel", b =>
                {
                    b.Navigation("BankAccount")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
