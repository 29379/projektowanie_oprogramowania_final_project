using projektowanie_oprogramowania_final_project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.CodeAnalysis.Differencing;
using System.Diagnostics.Contracts;

namespace projektowanie_oprogramowania_final_project
{
    public class CinemaDbContext : IdentityDbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options) { }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationSeat> ReservationSeats { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Showing> Showings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cinema>()
                .HasMany(c => c.ScreeningRooms)
                .WithOne(r => r.Cinema);

            modelBuilder.Entity<Cinema>()
                .HasMany(c => c.Showings)
                .WithOne(s => s.Cinema);

            modelBuilder.Entity<Room>()
                .HasMany(c => c.Showings)
                .WithOne(s => s.Room);

            modelBuilder.Entity<Room>()
                .HasMany(c => c.Seats)
                .WithOne(s => s.Room);

            modelBuilder.Entity<Room>()
                .HasOne(r => r.Cinema)
                .WithMany(c => c.ScreeningRooms)
                .HasForeignKey(r => r.CinemaId);

            modelBuilder.Entity<Seat>()
                .HasOne(s => s.Room)
                .WithMany(r => r.Seats)
                .HasForeignKey(s => s.RoomId);

            modelBuilder.Entity<Film>()
                .HasMany(c => c.Showings)
                .WithOne(s => s.Film);

            modelBuilder.Entity<Showing>()
                .HasMany(s => s.Reservations)
                .WithOne(r => r.Showing);

            modelBuilder.Entity<Showing>()
                .HasOne(s => s.Cinema)
                .WithMany(c => c.Showings)
                .HasForeignKey(s => s.CinemaId);

            modelBuilder.Entity<Showing>()
                .HasOne(s => s.Room)
                .WithMany(r => r.Showings)
                .HasForeignKey(s => s.RoomId);

            modelBuilder.Entity<Showing>()
                .HasOne(s => s.Film)
                .WithMany(f => f.Showings)
                .HasForeignKey(s => s.FilmId);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Showing)
                .WithMany(s => s.Reservations)
                .HasForeignKey(r => r.ShowingId);

            modelBuilder.Entity<ReservationSeat>()
                .HasKey(c => new { c.ReservationId, c.SeatId });

            modelBuilder.Entity<Reservation>()
                .HasMany(c => c.ReservationSeats)
                .WithOne(s => s.Reservation)
                .HasForeignKey(c => c.ReservationId);

            modelBuilder.Entity<Seat>()
                .HasMany(c => c.ReservationSeats)
                .WithOne(s => s.Seat)
                .HasForeignKey(c => c.SeatId);

        }


    }
}
