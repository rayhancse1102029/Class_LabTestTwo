﻿// <auto-generated />
using System;
using LabTesttTwo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LabTesttTwo.Migrations
{
    [DbContext(typeof(IncomeTaxDbContext))]
    [Migration("20201125030823_add_cls_student_reg_2")]
    partial class add_cls_student_reg_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LabTesttTwo.Data.Entity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AddressDetails");

                    b.Property<int?>("AddressType");

                    b.Property<string>("Citizenship")
                        .HasMaxLength(50);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("EmpCode")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .HasMaxLength(100);

                    b.Property<string>("ImagePath")
                        .HasMaxLength(300);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<decimal?>("MaxAmount");

                    b.Property<string>("NationalIdentityNo")
                        .HasMaxLength(100);

                    b.Property<int?>("NationalIdentityType");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy");

                    b.Property<bool>("isActive");

                    b.Property<int?>("isVarified");

                    b.Property<string>("org");

                    b.Property<string>("otpCode");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy");

                    b.Property<int?>("userId");

                    b.Property<int?>("userTypeId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("LabTesttTwo.Models.IncomeTax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("asseYear");

                    b.Property<string>("circel");

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy");

                    b.Property<string>("dateOFBirth");

                    b.Property<bool>("familyStatus");

                    b.Property<string>("father");

                    b.Property<string>("husbandORWife");

                    b.Property<bool>("isResident");

                    b.Property<string>("mobileOffice");

                    b.Property<string>("mother");

                    b.Property<string>("nameOFEmployee");

                    b.Property<string>("nameOfAsse");

                    b.Property<string>("nid");

                    b.Property<string>("presentAddress");

                    b.Property<string>("prmanentAddress");

                    b.Property<string>("residential");

                    b.Property<string>("taxZone");

                    b.Property<string>("tin");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy");

                    b.Property<string>("utin");

                    b.Property<string>("vatRegistrationNo");

                    b.HasKey("Id");

                    b.ToTable("IncomeTaxes");
                });

            modelBuilder.Entity("LabTesttTwo.Models.StudentReg", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cls");

                    b.Property<string>("dept");

                    b.Property<string>("email");

                    b.Property<string>("father");

                    b.Property<string>("mobile");

                    b.Property<string>("mother");

                    b.Property<string>("name");

                    b.Property<string>("parmanent");

                    b.Property<string>("present");

                    b.Property<string>("roll");

                    b.HasKey("id");

                    b.ToTable("StudentRegs");
                });

            modelBuilder.Entity("LabTesttTwo.Models.StudentRegistration", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("clsName")
                        .IsRequired();

                    b.Property<DateTime?>("cretedAt");

                    b.Property<string>("dept");

                    b.Property<string>("email");

                    b.Property<string>("father");

                    b.Property<string>("mobile")
                        .IsRequired();

                    b.Property<string>("mother");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("parmanent");

                    b.Property<string>("present")
                        .IsRequired();

                    b.Property<string>("roll")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("StudentRegistrations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LabTesttTwo.Data.Entity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LabTesttTwo.Data.Entity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LabTesttTwo.Data.Entity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LabTesttTwo.Data.Entity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
