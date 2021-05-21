﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using S5_CodeFirstEFCore.Web.Models;

namespace S5_CodeFirstEFCore.Web.Migrations
{
    [DbContext(typeof(CopaLibertadoresDBContext))]
    [Migration("20210521002820_New table Soccer Position v2")]
    partial class NewtableSoccerPositionv2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("S5_CodeFirstEFCore.Web.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("Date");

                    b.Property<int>("Dorsal")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("S5_CodeFirstEFCore.Web.Models.SoccerPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("SoccerPosition");
                });
#pragma warning restore 612, 618
        }
    }
}