﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShelfApi.Infrastructure.Data.ShelfApiDb;

#nullable disable

namespace ShelfApi.Infrastructure.Migrations
{
    [DbContext(typeof(ShelfApiDbContext))]
    [Migration("20240529073747_ChangeConfigsToMainSettings")]
    partial class ChangeConfigsToMainSettings
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<ulong>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(100);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(102);

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(103);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1000)
                        .HasDefaultValueSql("SYSUTCDATETIME()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1001);

                    b.Property<byte>("RoleId")
                        .HasColumnType("tinyint")
                        .HasColumnOrder(101);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<ulong>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(100);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(102);

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(103);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1000)
                        .HasDefaultValueSql("SYSUTCDATETIME()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1001);

                    b.Property<decimal>("UserId")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnOrder(101);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<ulong>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(100);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(101);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1000)
                        .HasDefaultValueSql("SYSUTCDATETIME()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1001);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(102);

                    b.Property<decimal>("UserId")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnOrder(1);

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<ulong>", b =>
                {
                    b.Property<decimal>("UserId")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnOrder(100);

                    b.Property<byte>("RoleId")
                        .HasColumnType("tinyint")
                        .HasColumnOrder(101);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1000)
                        .HasDefaultValueSql("SYSUTCDATETIME()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1001);

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<ulong>", b =>
                {
                    b.Property<decimal>("UserId")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnOrder(100);

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(101);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(102);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1000)
                        .HasDefaultValueSql("SYSUTCDATETIME()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1001);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(103);

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("ShelfApi.Domain.OrderAggregate.Order", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1000)
                        .HasDefaultValueSql("SYSUTCDATETIME()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1001);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasColumnOrder(101);

                    b.Property<decimal>("UserId")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnOrder(100);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ShelfApi.Domain.OrderAggregate.OrderLine", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1000)
                        .HasDefaultValueSql("SYSUTCDATETIME()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1001);

                    b.Property<decimal>("OrderId")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnOrder(100);

                    b.Property<decimal>("ProductId")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnOrder(101);

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnOrder(102);

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderLines");
                });

            modelBuilder.Entity("ShelfApi.Domain.ProductAggregate.Product", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1000)
                        .HasDefaultValueSql("SYSUTCDATETIME()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1001);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(100);

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnOrder(102);

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ShelfApi.Domain.SettingAggregate.MainSettings", b =>
                {
                    b.Property<byte>("Category")
                        .HasColumnType("tinyint")
                        .HasColumnOrder(101);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1000)
                        .HasDefaultValueSql("SYSUTCDATETIME()");

                    b.Property<string>("Data")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("{}")
                        .HasColumnOrder(102);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1001);

                    b.HasKey("Category");

                    b.ToTable("MainSettings");
                });

            modelBuilder.Entity("ShelfApi.Domain.UserAggregate.Role", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint")
                        .HasColumnOrder(1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(105);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1000)
                        .HasDefaultValueSql("SYSUTCDATETIME()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1001);

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnOrder(103);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnOrder(104);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("ShelfApi.Domain.UserAggregate.User", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnOrder(1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int")
                        .HasColumnOrder(117);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(111);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1000)
                        .HasDefaultValueSql("SYSUTCDATETIME()");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnOrder(106);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit")
                        .HasColumnOrder(108);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit")
                        .HasColumnOrder(100);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit")
                        .HasColumnOrder(116);

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset")
                        .HasColumnOrder(115);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasPrecision(2)
                        .HasColumnType("datetime2(2)")
                        .HasColumnOrder(1001);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnOrder(107);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnOrder(105);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(109);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(112);

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit")
                        .HasColumnOrder(113);

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(110);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit")
                        .HasColumnOrder(114);

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnOrder(104);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<ulong>", b =>
                {
                    b.HasOne("ShelfApi.Domain.UserAggregate.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<ulong>", b =>
                {
                    b.HasOne("ShelfApi.Domain.UserAggregate.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<ulong>", b =>
                {
                    b.HasOne("ShelfApi.Domain.UserAggregate.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<ulong>", b =>
                {
                    b.HasOne("ShelfApi.Domain.UserAggregate.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShelfApi.Domain.UserAggregate.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<ulong>", b =>
                {
                    b.HasOne("ShelfApi.Domain.UserAggregate.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShelfApi.Domain.OrderAggregate.Order", b =>
                {
                    b.HasOne("ShelfApi.Domain.UserAggregate.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.OwnsOne("ShelfApi.Domain.FinancialAggregate.Price", "ListPrice", b1 =>
                        {
                            b1.Property<decimal>("OrderId")
                                .HasColumnType("decimal(20,0)");

                            b1.Property<decimal>("Value")
                                .HasColumnType("DECIMAL(10,0)")
                                .HasColumnName("ListPrice")
                                .HasColumnOrder(102);

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });

                    b.OwnsOne("ShelfApi.Domain.FinancialAggregate.Price", "NetPrice", b1 =>
                        {
                            b1.Property<decimal>("OrderId")
                                .HasColumnType("decimal(20,0)");

                            b1.Property<decimal>("Value")
                                .HasColumnType("DECIMAL(10,0)")
                                .HasColumnName("NetPrice")
                                .HasColumnOrder(104);

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });

                    b.OwnsOne("ShelfApi.Domain.FinancialAggregate.Price", "TaxPrice", b1 =>
                        {
                            b1.Property<decimal>("OrderId")
                                .HasColumnType("decimal(20,0)");

                            b1.Property<decimal>("Value")
                                .HasColumnType("DECIMAL(10,0)")
                                .HasColumnName("TaxPrice")
                                .HasColumnOrder(103);

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });

                    b.Navigation("ListPrice")
                        .IsRequired();

                    b.Navigation("NetPrice")
                        .IsRequired();

                    b.Navigation("TaxPrice")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShelfApi.Domain.OrderAggregate.OrderLine", b =>
                {
                    b.HasOne("ShelfApi.Domain.OrderAggregate.Order", null)
                        .WithMany("Lines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShelfApi.Domain.ProductAggregate.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("ShelfApi.Domain.FinancialAggregate.Price", "TotalPrice", b1 =>
                        {
                            b1.Property<decimal>("OrderLineId")
                                .HasColumnType("decimal(20,0)");

                            b1.Property<decimal>("Value")
                                .HasColumnType("DECIMAL(10,0)")
                                .HasColumnName("TotalPrice")
                                .HasColumnOrder(103);

                            b1.HasKey("OrderLineId");

                            b1.ToTable("OrderLines");

                            b1.WithOwner()
                                .HasForeignKey("OrderLineId");
                        });

                    b.Navigation("Product");

                    b.Navigation("TotalPrice")
                        .IsRequired();
                });

            modelBuilder.Entity("ShelfApi.Domain.ProductAggregate.Product", b =>
                {
                    b.OwnsOne("ShelfApi.Domain.FinancialAggregate.Price", "Price", b1 =>
                        {
                            b1.Property<decimal>("ProductId")
                                .HasColumnType("decimal(20,0)");

                            b1.Property<decimal>("Value")
                                .HasColumnType("DECIMAL(10,0)")
                                .HasColumnName("Price")
                                .HasColumnOrder(101);

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.Navigation("Price")
                        .IsRequired();
                });

            modelBuilder.Entity("ShelfApi.Domain.OrderAggregate.Order", b =>
                {
                    b.Navigation("Lines");
                });
#pragma warning restore 612, 618
        }
    }
}
