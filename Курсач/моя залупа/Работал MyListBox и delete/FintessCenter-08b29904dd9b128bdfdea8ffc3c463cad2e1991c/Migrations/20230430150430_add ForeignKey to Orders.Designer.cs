﻿// <auto-generated />
using System;
using FitnessCenter.BD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessCenter.Migrations
{
    [DbContext(typeof(BDContext))]
    [Migration("20230430150430_add ForeignKey to Orders")]
    partial class addForeignKeytoOrders
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitnessCenter.BD.EntitiesBD.Abonements", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Validity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VisitingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abonements");
                });

            modelBuilder.Entity("FitnessCenter.BD.EntitiesBD.Clients", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("FitnessCenter.BD.EntitiesBD.Orders", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AbonementsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AbonementsId");

                    b.HasIndex("ClientsId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FitnessCenter.BD.EntitiesBD.Orders", b =>
                {
                    b.HasOne("FitnessCenter.BD.EntitiesBD.Abonements", "Abonement")
                        .WithMany("Orders")
                        .HasForeignKey("AbonementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessCenter.BD.EntitiesBD.Clients", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abonement");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("FitnessCenter.BD.EntitiesBD.Abonements", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FitnessCenter.BD.EntitiesBD.Clients", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
