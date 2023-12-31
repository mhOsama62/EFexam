﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exmDataLayer;

#nullable disable

namespace exmDataLayer.Migrations
{
    [DbContext(typeof(examDBContext))]
    partial class examDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("examDomin.Cars", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Gear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Km")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("examDomin.Custmor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Custmor");
                });

            modelBuilder.Entity("examDomin.Parts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Carid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quntity")
                        .HasColumnType("int");

                    b.Property<int>("SuppliersID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Carid");

                    b.HasIndex("SuppliersID");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("examDomin.Sales", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<int>("CustmorID")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("CarID");

                    b.HasIndex("CustmorID");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("examDomin.Suppliers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("examDomin.Parts", b =>
                {
                    b.HasOne("examDomin.Cars", "Car")
                        .WithMany("Part")
                        .HasForeignKey("Carid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("examDomin.Suppliers", "Supplier")
                        .WithMany()
                        .HasForeignKey("SuppliersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("examDomin.Sales", b =>
                {
                    b.HasOne("examDomin.Cars", "Car")
                        .WithMany()
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("examDomin.Custmor", "Custmor")
                        .WithMany()
                        .HasForeignKey("CustmorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Custmor");
                });

            modelBuilder.Entity("examDomin.Cars", b =>
                {
                    b.Navigation("Part");
                });
#pragma warning restore 612, 618
        }
    }
}
