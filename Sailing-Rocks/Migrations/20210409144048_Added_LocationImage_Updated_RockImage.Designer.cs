﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sailing_Rocks;

namespace Sailing_Rocks.Migrations
{
    [DbContext(typeof(SailingRocksContext))]
    [Migration("20210409144048_Added_LocationImage_Updated_RockImage")]
    partial class Added_LocationImage_Updated_RockImage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sailing_Rocks.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LocatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("LocationImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RockId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RockId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Lat = "41.52906515532968",
                            Lng = "-81.65136941810817",
                            LocatedOn = new DateTime(2021, 4, 9, 10, 40, 47, 587, DateTimeKind.Local).AddTicks(6074),
                            LocationImage = "https://media-cdn.tripadvisor.com/media/photo-s/14/61/c4/4f/lighthouse-at-headlands.jpg",
                            RockId = 1
                        });
                });

            modelBuilder.Entity("Sailing_Rocks.Models.Rock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Rocks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2021, 4, 9, 10, 40, 47, 587, DateTimeKind.Local).AddTicks(1341),
                            Image = "https://thumbs.dreamstime.com/b/dwayne-johnson-80711565.jpg",
                            Name = "Dwyane",
                            Serial = "testSerial",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Sailing_Rocks.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hometown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Software Developer",
                            CreatedOn = new DateTime(2021, 4, 9, 10, 40, 47, 580, DateTimeKind.Local).AddTicks(2788),
                            Email = "jkepic19@gmail.com",
                            FirstName = "Jason",
                            Hometown = "Parma, OH",
                            Image = "https://jak719.github.io/images/HS5.png",
                            LastName = "Kepic",
                            Password = "password",
                            UserName = "jak719"
                        });
                });

            modelBuilder.Entity("Sailing_Rocks.Models.UserRock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RockId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RockId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRock");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RockId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Sailing_Rocks.Models.Location", b =>
                {
                    b.HasOne("Sailing_Rocks.Models.Rock", "rock")
                        .WithMany("Locations")
                        .HasForeignKey("RockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sailing_Rocks.Models.Rock", b =>
                {
                    b.HasOne("Sailing_Rocks.Models.User", "User")
                        .WithMany("Rocks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sailing_Rocks.Models.UserRock", b =>
                {
                    b.HasOne("Sailing_Rocks.Models.Rock", "Rock")
                        .WithMany("UserRocks")
                        .HasForeignKey("RockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sailing_Rocks.Models.User", "User")
                        .WithMany("UserRocks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
