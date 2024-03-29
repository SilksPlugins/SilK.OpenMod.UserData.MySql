﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SilK.OpenMod.UserData.MySql.Database;

namespace SilK.OpenMod.UserData.MySql.Migrations
{
    [DbContext(typeof(UserDataDbContext))]
    partial class UserDataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SilK.OpenMod.UserData.MySql.Database.Models.UserDataBanModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("ExpireDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("InstigatorId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("InstigatorType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Reason")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id", "Type");

                    b.ToTable("OpenModUserData_UserBans");
                });

            modelBuilder.Entity("SilK.OpenMod.UserData.MySql.Database.Models.UserDataModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("FirstSeen")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("LastSeen")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id", "Type");

                    b.ToTable("OpenModUserData_Users");
                });

            modelBuilder.Entity("SilK.OpenMod.UserData.MySql.Database.Models.UserDataObjectModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Key")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Object")
                        .HasColumnType("json");

                    b.HasKey("Id", "Type", "Key");

                    b.ToTable("OpenModUserData_UserDataObjects");
                });

            modelBuilder.Entity("SilK.OpenMod.UserData.MySql.Database.Models.UserDataPermissionModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Permission")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id", "Type", "Permission");

                    b.ToTable("OpenModUserData_UserPermissions");
                });

            modelBuilder.Entity("SilK.OpenMod.UserData.MySql.Database.Models.UserDataRoleModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Role")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id", "Type", "Role");

                    b.ToTable("OpenModUserData_UserRoles");
                });

            modelBuilder.Entity("SilK.OpenMod.UserData.MySql.Database.Models.UserDataBanModel", b =>
                {
                    b.HasOne("SilK.OpenMod.UserData.MySql.Database.Models.UserDataModel", "UserData")
                        .WithOne("BanInfo")
                        .HasForeignKey("SilK.OpenMod.UserData.MySql.Database.Models.UserDataBanModel", "Id", "Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SilK.OpenMod.UserData.MySql.Database.Models.UserDataObjectModel", b =>
                {
                    b.HasOne("SilK.OpenMod.UserData.MySql.Database.Models.UserDataModel", "UserData")
                        .WithMany("Data")
                        .HasForeignKey("Id", "Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SilK.OpenMod.UserData.MySql.Database.Models.UserDataPermissionModel", b =>
                {
                    b.HasOne("SilK.OpenMod.UserData.MySql.Database.Models.UserDataModel", "UserData")
                        .WithMany("Permissions")
                        .HasForeignKey("Id", "Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SilK.OpenMod.UserData.MySql.Database.Models.UserDataRoleModel", b =>
                {
                    b.HasOne("SilK.OpenMod.UserData.MySql.Database.Models.UserDataModel", "UserData")
                        .WithMany("Roles")
                        .HasForeignKey("Id", "Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
