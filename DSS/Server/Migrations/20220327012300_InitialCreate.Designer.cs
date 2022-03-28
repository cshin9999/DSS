﻿// <auto-generated />
using System;
using DSS.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DSS.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220327012300_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DSS.Shared.Carrier", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ConfigurationId")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("ConfigurationId");

                    b.ToTable("Carriers");
                });

            modelBuilder.Entity("DSS.Shared.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("DSS.Shared.Carrier", b =>
                {
                    b.HasOne("DSS.Shared.Configuration", null)
                        .WithMany("Carriers")
                        .HasForeignKey("ConfigurationId");
                });

            modelBuilder.Entity("DSS.Shared.Configuration", b =>
                {
                    b.Navigation("Carriers");
                });
#pragma warning restore 612, 618
        }
    }
}