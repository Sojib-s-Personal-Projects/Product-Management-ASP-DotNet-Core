﻿// <auto-generated />
using System;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ProductManagement.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230122201339_AddFieldInWorkersInfo")]
    partial class AddFieldInWorkersInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Infrastructure.Entities.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Entities.ApplicationRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Entities.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Entities.ApplicationUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Entities.ApplicationUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Entities.ApplicationUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Entities.Worker", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Roll");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FathersName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MothersName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PermanentDistrict")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PostName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Quota")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            Id = 11000001L,
                            DateOfBirth = new DateTime(1992, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FathersName = "ABDUL BATEN SARKER",
                            MothersName = "SALINA AKTER",
                            Name = "MD ISRAFIL SORKER",
                            PermanentDistrict = "Munshiganj",
                            PostName = "Stenographer-Cum-Computer Operator",
                            Quota = "Ansar-VDP",
                            User = "11LQWESM"
                        },
                        new
                        {
                            Id = 11000002L,
                            DateOfBirth = new DateTime(1993, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FathersName = "MD. ABDUL GONI",
                            MothersName = "HASINA AKTHER",
                            Name = "SYFUL ISLAM",
                            PermanentDistrict = "Kishorganj",
                            PostName = "Stenographer-Cum-Computer Operator",
                            Quota = "Physically Handicapped",
                            User = "146DK6YZ"
                        },
                        new
                        {
                            Id = 11000003L,
                            DateOfBirth = new DateTime(1996, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FathersName = "MD ALIMUDDIN MOLLA",
                            MothersName = "SEFALI BEGUM",
                            Name = "SUJAN",
                            PermanentDistrict = "Rajbari",
                            PostName = "Stenographer-Cum-Computer Operator",
                            Quota = "Non Quota",
                            User = "16ZHEPC4"
                        },
                        new
                        {
                            Id = 11000004L,
                            DateOfBirth = new DateTime(1994, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FathersName = "MD. ENAMUL HAQUE KHAN",
                            MothersName = "RINA BEGUM",
                            Name = "SUBARNA AKHTER",
                            PermanentDistrict = "Gopalganj",
                            PostName = "Stenographer-Cum-Computer Operator ",
                            Quota = "Non Quota",
                            User = "1718Q6MA"
                        },
                        new
                        {
                            Id = 11000005L,
                            DateOfBirth = new DateTime(1991, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FathersName = "LIAKOT ALI",
                            MothersName = "RASIDA BEGUM",
                            Name = "LUTFOR RAHMAN",
                            PermanentDistrict = " Rajbari",
                            PostName = "Stenographer-Cum-Computer Operator ",
                            Quota = "Ansar-VDP",
                            User = "17NUT467"
                        },
                        new
                        {
                            Id = 11000006L,
                            DateOfBirth = new DateTime(1991, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FathersName = "MD. NAOSHADUL HAQUE",
                            MothersName = "MOST. KHALEDA BIBI",
                            Name = "MOST. MAHBUBA KHANOM",
                            PermanentDistrict = "Naogaon",
                            PostName = "Stenographer-Cum-Computer Operator ",
                            Quota = "Non Quota",
                            User = "1BATJVHD"
                        },
                        new
                        {
                            Id = 11000007L,
                            DateOfBirth = new DateTime(1992, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FathersName = "NARAYAN CHANDRA SARKAR",
                            MothersName = "NANDA RANI SARKAR",
                            Name = "KRISHNO KUMAR SARKAR",
                            PermanentDistrict = "Bogura",
                            PostName = "Stenographer-Cum-Computer Operator ",
                            Quota = "Non Quota",
                            User = "1F26E9FU"
                        },
                        new
                        {
                            Id = 11000008L,
                            DateOfBirth = new DateTime(1992, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FathersName = "NARAYAN KUMAR DAS",
                            MothersName = "BASONA RANI DAS",
                            Name = "PROSENJIT KUMAR DAS",
                            PermanentDistrict = "Khulna",
                            PostName = "Stenographer-Cum-Computer Operator ",
                            Quota = "Non Quota",
                            User = "1EV6P37Z"
                        },
                        new
                        {
                            Id = 11000009L,
                            DateOfBirth = new DateTime(1990, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FathersName = "MD. MOYEN UDDIN",
                            MothersName = "SHUKHZAN KHATUN",
                            Name = "MD. TAREK AZIZ",
                            PermanentDistrict = "Kushtia",
                            PostName = "Stenographer-Cum-Computer Operator ",
                            Quota = "Child of Freedom Fighter",
                            User = "11LQWESM"
                        },
                        new
                        {
                            Id = 11000010L,
                            DateOfBirth = new DateTime(1990, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FathersName = "MONORANJAN KUNDO",
                            MothersName = "ANJANA KUNDO",
                            Name = "ANOUP KUNDO",
                            PermanentDistrict = "Manikganj",
                            PostName = "Stenographer-Cum-Computer Operator ",
                            Quota = "Non Quota",
                            User = "1JXCS1TV"
                        });
                });

            modelBuilder.Entity("Infrastructure.Entities.WorkerInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("BarCodeData")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double?>("Price")
                        .HasColumnType("double");

                    b.Property<bool>("PriceConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("Roll")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Roll")
                        .IsUnique();

                    b.ToTable("WorkersInformation");
                });

            modelBuilder.Entity("Infrastructure.Entities.ApplicationRoleClaim", b =>
                {
                    b.HasOne("Infrastructure.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infrastructure.Entities.ApplicationUserClaim", b =>
                {
                    b.HasOne("Infrastructure.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infrastructure.Entities.ApplicationUserLogin", b =>
                {
                    b.HasOne("Infrastructure.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infrastructure.Entities.ApplicationUserRole", b =>
                {
                    b.HasOne("Infrastructure.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infrastructure.Entities.ApplicationUserToken", b =>
                {
                    b.HasOne("Infrastructure.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infrastructure.Entities.WorkerInfo", b =>
                {
                    b.HasOne("Infrastructure.Entities.Worker", "Worker")
                        .WithOne("WorkerInfo")
                        .HasForeignKey("Infrastructure.Entities.WorkerInfo", "Roll")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("Infrastructure.Entities.Worker", b =>
                {
                    b.Navigation("WorkerInfo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}