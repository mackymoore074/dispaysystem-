﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SystemModels;

#nullable disable

namespace SystemModels.Migrations
{
    [DbContext(typeof(InfoDbContext))]
    [Migration("20241126174303_UpdateRoleEnumAndOtherChanges")]
    partial class UpdateRoleEnumAndOtherChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DepartmentEmployee", b =>
                {
                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsId", "EmployeesId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("DepartmentEmployee");
                });

            modelBuilder.Entity("DepartmentNewsItem", b =>
                {
                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<int>("NewsItemsId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsId", "NewsItemsId");

                    b.HasIndex("NewsItemsId");

                    b.ToTable("DepartmentNewsItem");
                });

            modelBuilder.Entity("SystemModels.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AgencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("ScreenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ScreenId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AgencyId = 1,
                            DateCreated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8059),
                            DepartmentId = 1,
                            Email = "johndoe@agency.com",
                            FirstName = "John",
                            LastLogin = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8061),
                            LastName = "Doe",
                            LocationId = 1,
                            PasswordHash = "ade123",
                            Role = 2,
                            ScreenId = 1
                        },
                        new
                        {
                            Id = 2,
                            AgencyId = 2,
                            DateCreated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8065),
                            DepartmentId = 2,
                            Email = "janesmith@agency.com",
                            FirstName = "Jane",
                            LastLogin = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8066),
                            LastName = "Smith",
                            LocationId = 2,
                            PasswordHash = "ade123",
                            Role = 1,
                            ScreenId = 2
                        });
                });

            modelBuilder.Entity("SystemModels.Models.Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agencies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(7845),
                            Description = "Description for Agency1",
                            Name = "Agency1"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(7882),
                            Description = "Description for Agency2",
                            Name = "Agency2"
                        });
                });

            modelBuilder.Entity("SystemModels.Models.AllowedIpAddress", b =>
                {
                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("locationId")
                        .HasColumnType("int");

                    b.HasKey("IpAddress");

                    b.HasIndex("locationId");

                    b.ToTable("AllowedIpAddress");
                });

            modelBuilder.Entity("SystemModels.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AgencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("LocationId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AgencyId = 1,
                            DateCreated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8006),
                            Description = "Finance Department",
                            LocationId = 1,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 2,
                            AgencyId = 2,
                            DateCreated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8010),
                            Description = "Human Resources Department",
                            LocationId = 2,
                            Name = "HR"
                        });
                });

            modelBuilder.Entity("SystemModels.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SystemModels.Models.ErrorLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ErrorMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScreenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ErrorLogs");
                });

            modelBuilder.Entity("SystemModels.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("AgencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MenuItemsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("NewsItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("MenuItemsId");

                    b.HasIndex("NewsItemId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Finance St",
                            DateCreated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8022),
                            Name = "Foothill (Finance)"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 HR Ave",
                            DateCreated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8025),
                            Name = "Main Office (HR)"
                        });
                });

            modelBuilder.Entity("SystemModels.Models.MenuItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("MenuDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeOutDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("SystemModels.Models.NewsItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Agency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("ImportanceLevel")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("MoreInformationUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsItemBody")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("TimeOutDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NewsItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Agency = "Agency1",
                            DateCreated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8084),
                            ImportanceLevel = 1,
                            LastUpdated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8089),
                            MoreInformationUrl = "http://example.com",
                            NewsItemBody = "System maintenance scheduled.",
                            TimeOutDate = new DateTime(2024, 12, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8086),
                            Title = "Important Update"
                        },
                        new
                        {
                            Id = 2,
                            Agency = "Agency2",
                            DateCreated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8092),
                            ImportanceLevel = 2,
                            LastUpdated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8096),
                            MoreInformationUrl = "http://example.com",
                            NewsItemBody = "New company policy in effect.",
                            TimeOutDate = new DateTime(2024, 12, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8094),
                            Title = "New Policy"
                        });
                });

            modelBuilder.Entity("SystemModels.Models.Screen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastCheckedIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ScreenType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("LocationId");

                    b.ToTable("Screens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8037),
                            DepartmentId = 1,
                            IsOnline = true,
                            LastCheckedIn = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8040),
                            LastUpdated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8039),
                            LocationId = 1,
                            Name = "DM001",
                            ScreenType = "LED",
                            StatusMessage = "Active"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8043),
                            DepartmentId = 2,
                            IsOnline = true,
                            LastCheckedIn = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8046),
                            LastUpdated = new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8045),
                            LocationId = 2,
                            Name = "LH002",
                            ScreenType = "LCD",
                            StatusMessage = "Active"
                        });
                });

            modelBuilder.Entity("DepartmentEmployee", b =>
                {
                    b.HasOne("SystemModels.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SystemModels.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DepartmentNewsItem", b =>
                {
                    b.HasOne("SystemModels.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SystemModels.Models.NewsItem", null)
                        .WithMany()
                        .HasForeignKey("NewsItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SystemModels.Models.Admin", b =>
                {
                    b.HasOne("SystemModels.Models.Agency", "Agency")
                        .WithMany("Admins")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SystemModels.Models.Department", "Department")
                        .WithMany("Admins")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SystemModels.Models.Location", "Location")
                        .WithMany("Admins")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SystemModels.Models.Screen", "Screen")
                        .WithMany("Admins")
                        .HasForeignKey("ScreenId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Agency");

                    b.Navigation("Department");

                    b.Navigation("Location");

                    b.Navigation("Screen");
                });

            modelBuilder.Entity("SystemModels.Models.AllowedIpAddress", b =>
                {
                    b.HasOne("SystemModels.Models.Location", "Location")
                        .WithMany("AllowedIpAddresses")
                        .HasForeignKey("locationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("SystemModels.Models.Department", b =>
                {
                    b.HasOne("SystemModels.Models.Agency", "Agency")
                        .WithMany("Departments")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SystemModels.Models.Location", "Locations")
                        .WithMany("Departments")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Agency");

                    b.Navigation("Locations");
                });

            modelBuilder.Entity("SystemModels.Models.Location", b =>
                {
                    b.HasOne("SystemModels.Models.Agency", null)
                        .WithMany("Locations")
                        .HasForeignKey("AgencyId");

                    b.HasOne("SystemModels.Models.MenuItems", null)
                        .WithMany("Locations")
                        .HasForeignKey("MenuItemsId");

                    b.HasOne("SystemModels.Models.NewsItem", null)
                        .WithMany("Locations")
                        .HasForeignKey("NewsItemId");
                });

            modelBuilder.Entity("SystemModels.Models.Screen", b =>
                {
                    b.HasOne("SystemModels.Models.Department", "Department")
                        .WithMany("Screens")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SystemModels.Models.Location", "Location")
                        .WithMany("Screens")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("SystemModels.Models.Agency", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Departments");

                    b.Navigation("Locations");
                });

            modelBuilder.Entity("SystemModels.Models.Department", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Screens");
                });

            modelBuilder.Entity("SystemModels.Models.Location", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("AllowedIpAddresses");

                    b.Navigation("Departments");

                    b.Navigation("Screens");
                });

            modelBuilder.Entity("SystemModels.Models.MenuItems", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("SystemModels.Models.NewsItem", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("SystemModels.Models.Screen", b =>
                {
                    b.Navigation("Admins");
                });
#pragma warning restore 612, 618
        }
    }
}
