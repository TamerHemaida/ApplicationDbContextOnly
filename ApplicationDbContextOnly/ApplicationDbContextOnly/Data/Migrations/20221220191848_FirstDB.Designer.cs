﻿// <auto-generated />
using System;
using ApplicationDbContextOnly.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApplicationDbContextOnly.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221220191848_FirstDB")]
    partial class FirstDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationDbContextOnly.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "326aaa65-f69d-48ca-8bb7-031bb7fb8abb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0b8ddcf0-452f-4f0a-82b3-3dde685b1375",
                            Email = "sysadmin@sysadmin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SYSADMIN@SYSADMIN.COM",
                            NormalizedUserName = "SYSADMIN@SYSADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMEo0/1kIHUPHUEO0/qs5k4LgjmW6DplQ9+rraq03Ws5+oceRgvf7TAWcDvvz3sNNA==",
                            SecurityStamp = "21dcfa2c-033c-4b8b-affc-98a16efd4f91",
                            TwoFactorEnabled = false,
                            UserName = "sysadmin@sysadmin.com"
                        });
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.Department", b =>
                {
                    b.Property<byte>("DepartmentId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Complex")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EducationPath")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("DepartmentId")
                        .HasColumnType("tinyint");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDepartmentManager")
                        .HasColumnType("bit");

                    b.Property<byte>("JobId")
                        .HasColumnType("tinyint");

                    b.Property<byte>("MajorId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("JobId");

                    b.HasIndex("MajorId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.Job", b =>
                {
                    b.Property<byte>("JobId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JobArName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JobEnName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.Major", b =>
                {
                    b.Property<byte>("MajorId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("MajorArName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .UseCollation("Arabic_CI_AS");

                    b.Property<string>("MajorEnName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("MajorId");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.PdfFile", b =>
                {
                    b.Property<int>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("PhysicalFileName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime");

                    b.HasKey("FileId")
                        .HasName("PK_FileId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.PhotoCopyCenter", b =>
                {
                    b.Property<byte>("PhotoCopyCenterId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .UseCollation("Arabic_CI_AS");

                    b.Property<string>("Email")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("('')")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<bool>("IsDefaultForApplicationDbContextOnly")
                        .ValueGeneratedOnAdd()
                        .IsUnicode(false)
                        .HasColumnType("bit")
                        .HasDefaultValueSql("0");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasDefaultValueSql("('')")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .UseCollation("Arabic_CI_AS");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasDefaultValueSql("('')")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PhotoCopyCenterId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("PhotoCopyCenters");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.PrintOrder", b =>
                {
                    b.Property<int>("PrintOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(12)")
                        .UseCollation("Arabic_CI_AS");

                    b.Property<byte>("CountOfCopies")
                        .HasColumnType("tinyint");

                    b.Property<string>("CoveringType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("DepartmentManagerDecision")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<DateTime>("DepartmentManagerLastActionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .UseCollation("Arabic_CI_AS");

                    b.Property<long>("OrderNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("OrderRegisterDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Orientation")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("PageSize")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<byte>("PagesPerPaper")
                        .HasColumnType("tinyint");

                    b.Property<byte>("PagesZoom")
                        .HasColumnType("tinyint");

                    b.Property<byte>("PhotoCopyCenterId")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("PhotoCopyCenterLastActionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhotoCopyCenterState")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("PrintManageLastActionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PrintManagerDecision")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PrintOrderName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PrintSide")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .UseCollation("Arabic_CI_AS");

                    b.Property<string>("Stapling")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .UseCollation("Arabic_CI_AS");

                    b.HasKey("PrintOrderId")
                        .HasName("PK_PrintOrder_PrintOrderId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PhotoCopyCenterId");

                    b.ToTable("PrintOrders");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.PrintOrderModelView", b =>
                {
                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("CountOfCopies")
                        .HasColumnType("tinyint");

                    b.Property<string>("CoveringType")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<byte>("DepartmentId")
                        .HasColumnType("tinyint");

                    b.Property<string>("DepartmentManagerDecision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DepartmentManagerLastActionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EducationPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDefaultForApplicationDbContextOnly")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDepartmentManager")
                        .HasColumnType("bit");

                    b.Property<string>("JobArName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("JobId")
                        .HasColumnType("tinyint");

                    b.Property<string>("MajorArName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("MajorId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OrderNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("OrderRegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Orientation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("PagesPerPaper")
                        .HasColumnType("tinyint");

                    b.Property<byte>("PagesZoom")
                        .HasColumnType("tinyint");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("PhotoCopyCenterId")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("PhotoCopyCenterLastActionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhotoCopyCenterMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoCopyCenterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoCopyCenterState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PrintManageLastActionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PrintManagerDecision")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("PrintOrderId")
                        .HasColumnType("int");

                    b.Property<string>("PrintOrderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrintSide")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stapling")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime2");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "c94eb536-cba2-4d3e-95e5-148277072706",
                            ConcurrencyStamp = "c94eb536-cba2-4d3e-95e5-148277072706",
                            Name = "Users",
                            NormalizedName = "USERS"
                        },
                        new
                        {
                            Id = "7c5ea8c3-1ba4-4845-b173-e874682de4f2",
                            ConcurrencyStamp = "7c5ea8c3-1ba4-4845-b173-e874682de4f2",
                            Name = "Admins",
                            NormalizedName = "ADMINS"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "326aaa65-f69d-48ca-8bb7-031bb7fb8abb",
                            RoleId = "7c5ea8c3-1ba4-4845-b173-e874682de4f2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.Employee", b =>
                {
                    b.HasOne("ApplicationDbContextOnly.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationDbContextOnly.Models.Job", "Job")
                        .WithMany("Employees")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationDbContextOnly.Models.Major", "Major")
                        .WithMany("Employees")
                        .HasForeignKey("MajorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationDbContextOnly.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("Employees")
                        .HasForeignKey("ApplicationDbContextOnly.Models.Employee", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Department");

                    b.Navigation("Job");

                    b.Navigation("Major");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.PdfFile", b =>
                {
                    b.HasOne("ApplicationDbContextOnly.Models.Employee", "Employee")
                        .WithMany("PdfFiles")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.PhotoCopyCenter", b =>
                {
                    b.HasOne("ApplicationDbContextOnly.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("PhotoCopyCenter")
                        .HasForeignKey("ApplicationDbContextOnly.Models.PhotoCopyCenter", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.PrintOrder", b =>
                {
                    b.HasOne("ApplicationDbContextOnly.Models.Employee", "Employee")
                        .WithMany("PrintOrders")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationDbContextOnly.Models.PhotoCopyCenter", "PhotoCopyCenter")
                        .WithMany()
                        .HasForeignKey("PhotoCopyCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("PhotoCopyCenter");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ApplicationDbContextOnly.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ApplicationDbContextOnly.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationDbContextOnly.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ApplicationDbContextOnly.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.ApplicationUser", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("PhotoCopyCenter");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.Employee", b =>
                {
                    b.Navigation("PdfFiles");

                    b.Navigation("PrintOrders");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.Job", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("ApplicationDbContextOnly.Models.Major", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
