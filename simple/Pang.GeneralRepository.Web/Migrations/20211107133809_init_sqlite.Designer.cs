﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pang.GeneralRepository.Web.Data;

namespace Pang.GeneralRepository.Web.Migrations
{
    [DbContext(typeof(SimpleDbContext))]
    [Migration("20211107133809_init_sqlite")]
    partial class init_sqlite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Pang.GeneralRepository.Web.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DeleteMark")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EnableMark")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ModifyUserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Pang.GeneralRepository.Web.Entities.UserItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DeleteMark")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EnableMark")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ModifyUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserItem");
                });

            modelBuilder.Entity("Pang.GeneralRepository.Web.Entities.UserItem", b =>
                {
                    b.HasOne("Pang.GeneralRepository.Web.Entities.User", null)
                        .WithMany("UserItems")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Pang.GeneralRepository.Web.Entities.User", b =>
                {
                    b.Navigation("UserItems");
                });
#pragma warning restore 612, 618
        }
    }
}
