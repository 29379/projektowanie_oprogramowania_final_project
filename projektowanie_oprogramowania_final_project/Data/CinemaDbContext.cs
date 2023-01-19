using projektowanie_oprogramowania_final_project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace projektowanie_oprogramowania_final_project
{
    public class CinemaDbContext : IdentityDbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options) { }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Showing> Showings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cinema>()
                .HasMany(a => a.Showings)
                .WithOne(c => c.Cinema)
                .OnDelete(DeleteBehavior.ClientCascade)
                .HasForeignKey(c => c.CinemaId);

            modelBuilder.Entity<Showing>()
                .HasOne(c => c.Cinema)
                .WithMany(a => a.Showings)
                .HasForeignKey(c => c.CinemaId);

            modelBuilder.Entity<Showing>()
                .Property(l => l.Language)
                .HasConversion<int>();

            modelBuilder.Entity<Showing>()
                .Property(l => l.Technology)
                .HasConversion<int>();
        }


    }
}
