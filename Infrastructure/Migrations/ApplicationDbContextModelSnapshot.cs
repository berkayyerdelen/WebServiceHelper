﻿// <auto-generated />
using System;
using Infrastructure.ApplicationContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Project", b =>
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
                            CreatedDate = new DateTime(2020, 3, 6, 13, 28, 46, 834, DateTimeKind.Local).AddTicks(5631),
                            ModifiedBy = "Berkay",
                            ProjectName = "Project1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Berkay",
                            CreatedDate = new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1150),
                            ModifiedBy = "Berkay",
                            ProjectName = "Project2"
                        });
                });

            modelBuilder.Entity("Domain.Entities.WebAppDetails", b =>
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
                            CreatedDate = new DateTime(2020, 3, 6, 13, 28, 46, 837, DateTimeKind.Local).AddTicks(9710),
                            WebAppAltUrl = "www.google.com.tr/altUrl1",
                            WebAppId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Berkay",
                            CreatedDate = new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1043),
                            WebAppAltUrl = "www.google.com.tr/altUrl2",
                            WebAppId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Berkay",
                            CreatedDate = new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1088),
                            WebAppAltUrl = "www.google.com.tr/altUrl3",
                            WebAppId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "Berkay",
                            CreatedDate = new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1233),
                            WebAppAltUrl = "www.google.com.tr/altUrl1",
                            WebAppId = 2
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "Berkay",
                            CreatedDate = new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1255),
                            WebAppAltUrl = "www.google.com.tr/altUrl2",
                            WebAppId = 2
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "Berkay",
                            CreatedDate = new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1279),
                            WebAppAltUrl = "www.google.com.tr/altUrl3",
                            WebAppId = 2
                        });
                });

            modelBuilder.Entity("Domain.Entities.WebApps", b =>
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
                            CreatedDate = new DateTime(2020, 3, 6, 13, 28, 46, 837, DateTimeKind.Local).AddTicks(6614),
                            ProjectId = 1,
                            WebAppType = (byte)1,
                            WebAppUrl = "www.google.com.tr/"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Berkay",
                            CreatedDate = new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1186),
                            ProjectId = 2,
                            WebAppType = (byte)1,
                            WebAppUrl = "www.google.com.tr/"
                        });
                });

            modelBuilder.Entity("Domain.Entities.WebAppDetails", b =>
                {
                    b.HasOne("Domain.Entities.WebApps", "WebServices")
                        .WithMany("WebAppDetails")
                        .HasForeignKey("WebAppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.WebApps", b =>
                {
                    b.HasOne("Domain.Entities.Project", "Project")
                        .WithMany("Webapps")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
