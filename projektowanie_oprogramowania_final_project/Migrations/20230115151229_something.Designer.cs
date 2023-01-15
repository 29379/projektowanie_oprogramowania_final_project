﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projektowanie_oprogramowania_final_project;

namespace projektowanie_oprogramowania_final_project.Migrations
{
    [DbContext(typeof(CinemaDbContext))]
    [Migration("20230115151229_something")]
    partial class something
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Cinema", b =>
                {
                    b.Property<int>("CinemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CinemaId");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("RunningTime")
                        .HasColumnType("time");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChosenPayment")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReservationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShowingId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ShowingId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CinemaId")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("RoomId");

                    b.HasIndex("CinemaId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.HasKey("SeatId");

                    b.HasIndex("ReservationId");

                    b.HasIndex("RoomId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Showing", b =>
                {
                    b.Property<int>("ShowingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CinemaId")
                        .HasColumnType("int");

                    b.Property<int>("Language")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ScreeningRoomRoomId")
                        .HasColumnType("int");

                    b.Property<int?>("ShowedFilmFilmId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Showtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Technology")
                        .HasColumnType("int");

                    b.HasKey("ShowingId");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ScreeningRoomRoomId");

                    b.HasIndex("ShowedFilmFilmId");

                    b.ToTable("Showings");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Customer", b =>
                {
                    b.HasBaseType("projektowanie_oprogramowania_final_project.Models.User");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Employee", b =>
                {
                    b.HasBaseType("projektowanie_oprogramowania_final_project.Models.User");

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasIndex("CinemaId");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Reservation", b =>
                {
                    b.HasOne("projektowanie_oprogramowania_final_project.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projektowanie_oprogramowania_final_project.Models.Showing", null)
                        .WithMany("Reservations")
                        .HasForeignKey("ShowingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Room", b =>
                {
                    b.HasOne("projektowanie_oprogramowania_final_project.Models.Cinema", "Cinema")
                        .WithMany("ScreeningRooms")
                        .HasForeignKey("CinemaId");

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Seat", b =>
                {
                    b.HasOne("projektowanie_oprogramowania_final_project.Models.Reservation", null)
                        .WithMany("Seats")
                        .HasForeignKey("ReservationId");

                    b.HasOne("projektowanie_oprogramowania_final_project.Models.Room", "Room")
                        .WithMany("Seats")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Showing", b =>
                {
                    b.HasOne("projektowanie_oprogramowania_final_project.Models.Cinema", "Cinema")
                        .WithMany("Showings")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("projektowanie_oprogramowania_final_project.Models.Room", "ScreeningRoom")
                        .WithMany()
                        .HasForeignKey("ScreeningRoomRoomId");

                    b.HasOne("projektowanie_oprogramowania_final_project.Models.Film", "ShowedFilm")
                        .WithMany()
                        .HasForeignKey("ShowedFilmFilmId");

                    b.Navigation("Cinema");

                    b.Navigation("ScreeningRoom");

                    b.Navigation("ShowedFilm");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Employee", b =>
                {
                    b.HasOne("projektowanie_oprogramowania_final_project.Models.Cinema", "Cinema")
                        .WithMany("Employees")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Cinema", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("ScreeningRooms");

                    b.Navigation("Showings");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Reservation", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Room", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Showing", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("projektowanie_oprogramowania_final_project.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
