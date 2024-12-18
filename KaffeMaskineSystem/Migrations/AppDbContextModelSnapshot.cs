﻿// <auto-generated />
using System;
using KaffeMaskineSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KaffeMaskineSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KaffeMaskineSystem.Models.Cleaning", b =>
                {
                    b.Property<int>("CleaningID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CleaningID"));

                    b.Property<string>("CleanedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CleaningDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CoffeeMachineID")
                        .HasColumnType("int");

                    b.HasKey("CleaningID");

                    b.HasIndex("CoffeeMachineID");

                    b.ToTable("Cleanings");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.CoffeeMachine", b =>
                {
                    b.Property<int>("CoffeeMachineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoffeeMachineID"));

                    b.Property<int>("CoffeeBeansLevel")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MilkPowderLevel")
                        .HasColumnType("int");

                    b.Property<int>("SugarLevel")
                        .HasColumnType("int");

                    b.Property<int>("WaterLevel")
                        .HasColumnType("int");

                    b.HasKey("CoffeeMachineID");

                    b.ToTable("CoffeeMachines");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.History", b =>
                {
                    b.Property<int>("HistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoryID"));

                    b.Property<int>("CoffeeMachineID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HistoryID");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.MachineMaintenanceRecord", b =>
                {
                    b.Property<int>("MachineMaintenanceRecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MachineMaintenanceRecordID"));

                    b.Property<int>("CoffeeMachineID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MachineMaintenanceRecordID");

                    b.HasIndex("CoffeeMachineID");

                    b.ToTable("MachineMaintenanceRecords");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.Notification", b =>
                {
                    b.Property<int>("NotificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationID"));

                    b.Property<int>("CoffeeMachineID")
                        .HasColumnType("int");

                    b.Property<DateTime>("NotificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotificationType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("NotificationID");

                    b.HasIndex("CoffeeMachineID");

                    b.HasIndex("UserID");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.Refill", b =>
                {
                    b.Property<int>("RefillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RefillID"));

                    b.Property<int>("CoffeeAmount")
                        .HasColumnType("int");

                    b.Property<int>("CoffeeMachineID")
                        .HasColumnType("int");

                    b.Property<int>("MilkPowderAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("RefillDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SugarAmount")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("RefillID");

                    b.HasIndex("CoffeeMachineID");

                    b.HasIndex("UserID");

                    b.ToTable("Refills");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.TrayEmptyingRecord", b =>
                {
                    b.Property<int>("TrayEmptyingRecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrayEmptyingRecordID"));

                    b.Property<int>("CoffeeMachineID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeEmptied")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("TrayEmptyingRecordID");

                    b.HasIndex("CoffeeMachineID");

                    b.ToTable("TrayEmptyingRecords");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.TubeChange", b =>
                {
                    b.Property<int>("TubeChangeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TubeChangeID"));

                    b.Property<DateTime>("ChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ChangedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CoffeeMachineID")
                        .HasColumnType("int");

                    b.HasKey("TubeChangeID");

                    b.HasIndex("CoffeeMachineID");

                    b.ToTable("TubeChanges");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.Cleaning", b =>
                {
                    b.HasOne("KaffeMaskineSystem.Models.CoffeeMachine", "CoffeeMachine")
                        .WithMany()
                        .HasForeignKey("CoffeeMachineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoffeeMachine");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.MachineMaintenanceRecord", b =>
                {
                    b.HasOne("KaffeMaskineSystem.Models.CoffeeMachine", "CoffeeMachine")
                        .WithMany()
                        .HasForeignKey("CoffeeMachineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoffeeMachine");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.Notification", b =>
                {
                    b.HasOne("KaffeMaskineSystem.Models.CoffeeMachine", "CoffeeMachine")
                        .WithMany()
                        .HasForeignKey("CoffeeMachineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KaffeMaskineSystem.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoffeeMachine");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.Refill", b =>
                {
                    b.HasOne("KaffeMaskineSystem.Models.CoffeeMachine", "CoffeeMachine")
                        .WithMany()
                        .HasForeignKey("CoffeeMachineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KaffeMaskineSystem.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoffeeMachine");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.TrayEmptyingRecord", b =>
                {
                    b.HasOne("KaffeMaskineSystem.Models.CoffeeMachine", "CoffeeMachine")
                        .WithMany()
                        .HasForeignKey("CoffeeMachineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoffeeMachine");
                });

            modelBuilder.Entity("KaffeMaskineSystem.Models.TubeChange", b =>
                {
                    b.HasOne("KaffeMaskineSystem.Models.CoffeeMachine", "CoffeeMachine")
                        .WithMany()
                        .HasForeignKey("CoffeeMachineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoffeeMachine");
                });
#pragma warning restore 612, 618
        }
    }
}
