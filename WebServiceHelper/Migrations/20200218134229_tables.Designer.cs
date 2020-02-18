﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebServiceHelper.Context;

namespace WebServiceHelper.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200218134229_tables")]
    partial class tables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebServiceHelper.Entities.Domains.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Berkay",
                            CreatedDate = new DateTime(2020, 2, 18, 16, 42, 28, 368, DateTimeKind.Local).AddTicks(2689),
                            ModifiedBy = "Berkay",
                            ProjectName = "Project1"
                        });
                });

            modelBuilder.Entity("WebServiceHelper.Entities.Domains.WebAppDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WebAppAltUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WebAppId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WebAppId");

                    b.ToTable("WebAppDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Berkay",
                            CreatedDate = new DateTime(2020, 2, 18, 16, 42, 28, 370, DateTimeKind.Local).AddTicks(9167),
                            WebAppAltUrl = "www.google.com.tr/altUrl1",
                            WebAppId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Berkay",
                            CreatedDate = new DateTime(2020, 2, 18, 16, 42, 28, 371, DateTimeKind.Local).AddTicks(902),
                            WebAppAltUrl = "www.google.com.tr/altUrl2",
                            WebAppId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Berkay",
                            CreatedDate = new DateTime(2020, 2, 18, 16, 42, 28, 371, DateTimeKind.Local).AddTicks(958),
                            WebAppAltUrl = "www.google.com.tr/altUrl3",
                            WebAppId = 1
                        });
                });

            modelBuilder.Entity("WebServiceHelper.Entities.Domains.WebApps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<byte>("WebAppType")
                        .HasColumnType("tinyint");

                    b.Property<string>("WebAppUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("WebApps");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Berkay",
                            CreatedDate = new DateTime(2020, 2, 18, 16, 42, 28, 370, DateTimeKind.Local).AddTicks(5037),
                            ProjectId = 1,
                            WebAppType = (byte)1,
                            WebAppUrl = "www.google.com.tr/"
                        });
                });

            modelBuilder.Entity("WebServiceHelper.Entities.Domains.WebAppDetails", b =>
                {
                    b.HasOne("WebServiceHelper.Entities.Domains.WebApps", "WebServices")
                        .WithMany("WebAppDetails")
                        .HasForeignKey("WebAppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebServiceHelper.Entities.Domains.WebApps", b =>
                {
                    b.HasOne("WebServiceHelper.Entities.Domains.Project", "Project")
                        .WithMany("WebServices")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
