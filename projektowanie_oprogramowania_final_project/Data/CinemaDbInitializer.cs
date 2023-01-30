using System.Linq;
using projektowanie_oprogramowania_final_project.Models;

namespace projektowanie_oprogramowania_final_project.Data
{
    public class CinemaDbInitializer
    {

        public static void SeedData(CinemaDbContext context)
        {
            SeedCinemas(context);
            SeedRooms(context);
            SeedSeats(context);
        }

        public static void SeedCinemas(CinemaDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Cinemas.Any())
            {
                return;
            }

            var myCinemas = new Cinema[]
            {
                new Cinema{Street="Sezamkowa", Number=1, ZipCode="53-680"},
                new Cinema{Street="Grunwaldzka", Number=13, ZipCode="50-001"},
                new Cinema{Street="Nowowiejska", Number=64, ZipCode="50-004"}
            };

            context.Cinemas.AddRange(myCinemas);
            context.SaveChanges();
        }

        public static void SeedRooms(CinemaDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Rooms.Any())
            {
                return;
            }

            var myRooms = new Room[]
            {
                new Room{RoomNumber=1, CinemaId=1},
                new Room{RoomNumber=2, CinemaId=1},
                new Room{RoomNumber=3, CinemaId=1},
                new Room{RoomNumber=4, CinemaId=1},
                new Room{RoomNumber=5, CinemaId=1},
                new Room{RoomNumber=1, CinemaId=2},
                new Room{RoomNumber=2, CinemaId=2},
                new Room{RoomNumber=1, CinemaId=3},
                new Room{RoomNumber=2, CinemaId=3}
            };

            context.Rooms.AddRange(myRooms);
            context.SaveChanges();
        }

        public static void SeedSeats(CinemaDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Seats.Any())
            {
                return;
            }

            var mySeats = new Seat[]
            {
                new Seat{ Row=1, SeatNumber=1, RoomId=1 },
                new Seat{ Row=1, SeatNumber=2, RoomId=1 },
                new Seat{ Row=1, SeatNumber=3, RoomId=1 },
                new Seat{ Row=1, SeatNumber=4, RoomId=1 },
                new Seat{ Row=1, SeatNumber=5, RoomId=1 },
                new Seat{ Row=2, SeatNumber=1, RoomId=1 },
                new Seat{ Row=2, SeatNumber=2, RoomId=1 },
                new Seat{ Row=2, SeatNumber=3, RoomId=1 },
                new Seat{ Row=2, SeatNumber=4, RoomId=1 },
                new Seat{ Row=2, SeatNumber=5, RoomId=1 },
                new Seat{ Row=3, SeatNumber=1, RoomId=1 },
                new Seat{ Row=3, SeatNumber=2, RoomId=1 },
                new Seat{ Row=3, SeatNumber=3, RoomId=1 },
                new Seat{ Row=3, SeatNumber=4, RoomId=1 },
                new Seat{ Row=3, SeatNumber=5, RoomId=1 },

                new Seat{ Row=1, SeatNumber=1, RoomId=2 },
                new Seat{ Row=1, SeatNumber=2, RoomId=2 },
                new Seat{ Row=1, SeatNumber=3, RoomId=2 },
                new Seat{ Row=1, SeatNumber=4, RoomId=2 },
                new Seat{ Row=1, SeatNumber=5, RoomId=2 },
                new Seat{ Row=2, SeatNumber=1, RoomId=2 },
                new Seat{ Row=2, SeatNumber=2, RoomId=2 },
                new Seat{ Row=2, SeatNumber=3, RoomId=2 },
                new Seat{ Row=2, SeatNumber=4, RoomId=2 },
                new Seat{ Row=2, SeatNumber=5, RoomId=2 },
                new Seat{ Row=3, SeatNumber=1, RoomId=2 },
                new Seat{ Row=3, SeatNumber=2, RoomId=2 },
                new Seat{ Row=3, SeatNumber=3, RoomId=2 },
                new Seat{ Row=3, SeatNumber=4, RoomId=2 },
                new Seat{ Row=3, SeatNumber=5, RoomId=2 },

                new Seat{ Row=1, SeatNumber=1, RoomId=3 },
                new Seat{ Row=1, SeatNumber=2, RoomId=3 },
                new Seat{ Row=1, SeatNumber=3, RoomId=3 },
                new Seat{ Row=1, SeatNumber=4, RoomId=3 },
                new Seat{ Row=1, SeatNumber=5, RoomId=3 },
                new Seat{ Row=2, SeatNumber=1, RoomId=3 },
                new Seat{ Row=2, SeatNumber=2, RoomId=3 },
                new Seat{ Row=2, SeatNumber=3, RoomId=3 },
                new Seat{ Row=2, SeatNumber=4, RoomId=3 },
                new Seat{ Row=2, SeatNumber=5, RoomId=3 },
                new Seat{ Row=3, SeatNumber=1, RoomId=3 },
                new Seat{ Row=3, SeatNumber=2, RoomId=3 },
                new Seat{ Row=3, SeatNumber=3, RoomId=3 },
                new Seat{ Row=3, SeatNumber=4, RoomId=3 },
                new Seat{ Row=3, SeatNumber=5, RoomId=3 },

                new Seat{ Row=1, SeatNumber=1, RoomId=4 },
                new Seat{ Row=1, SeatNumber=2, RoomId=4 },
                new Seat{ Row=1, SeatNumber=3, RoomId=4 },
                new Seat{ Row=1, SeatNumber=4, RoomId=4 },
                new Seat{ Row=1, SeatNumber=5, RoomId=4 },
                new Seat{ Row=2, SeatNumber=1, RoomId=4 },
                new Seat{ Row=2, SeatNumber=2, RoomId=4 },
                new Seat{ Row=2, SeatNumber=3, RoomId=4 },
                new Seat{ Row=2, SeatNumber=4, RoomId=4 },
                new Seat{ Row=2, SeatNumber=5, RoomId=4 },
                new Seat{ Row=3, SeatNumber=1, RoomId=4 },
                new Seat{ Row=3, SeatNumber=2, RoomId=4 },
                new Seat{ Row=3, SeatNumber=3, RoomId=4 },
                new Seat{ Row=3, SeatNumber=4, RoomId=4 },
                new Seat{ Row=3, SeatNumber=5, RoomId=4 },

                new Seat{ Row=1, SeatNumber=1, RoomId=5 },
                new Seat{ Row=1, SeatNumber=2, RoomId=5 },
                new Seat{ Row=1, SeatNumber=3, RoomId=5 },
                new Seat{ Row=1, SeatNumber=4, RoomId=5 },
                new Seat{ Row=1, SeatNumber=5, RoomId=5 },
                new Seat{ Row=2, SeatNumber=1, RoomId=5 },
                new Seat{ Row=2, SeatNumber=2, RoomId=5 },
                new Seat{ Row=2, SeatNumber=3, RoomId=5 },
                new Seat{ Row=2, SeatNumber=4, RoomId=5 },
                new Seat{ Row=2, SeatNumber=5, RoomId=5 },
                new Seat{ Row=3, SeatNumber=1, RoomId=5 },
                new Seat{ Row=3, SeatNumber=2, RoomId=5 },
                new Seat{ Row=3, SeatNumber=3, RoomId=5 },
                new Seat{ Row=3, SeatNumber=4, RoomId=5 },
                new Seat{ Row=3, SeatNumber=5, RoomId=5 },
            
                new Seat{ Row=1, SeatNumber=1, RoomId=6 },
                new Seat{ Row=1, SeatNumber=2, RoomId=6 },
                new Seat{ Row=1, SeatNumber=3, RoomId=6 },
                new Seat{ Row=1, SeatNumber=4, RoomId=6 },
                new Seat{ Row=1, SeatNumber=5, RoomId=6 },
                new Seat{ Row=2, SeatNumber=1, RoomId=6 },
                new Seat{ Row=2, SeatNumber=2, RoomId=6 },
                new Seat{ Row=2, SeatNumber=3, RoomId=6 },
                new Seat{ Row=2, SeatNumber=4, RoomId=6 },
                new Seat{ Row=2, SeatNumber=5, RoomId=6 },
                new Seat{ Row=3, SeatNumber=1, RoomId=6 },
                new Seat{ Row=3, SeatNumber=2, RoomId=6 },
                new Seat{ Row=3, SeatNumber=3, RoomId=6 },
                new Seat{ Row=3, SeatNumber=4, RoomId=6 },
                new Seat{ Row=3, SeatNumber=5, RoomId=6 },

                new Seat{ Row=1, SeatNumber=1, RoomId=7 },
                new Seat{ Row=1, SeatNumber=2, RoomId=7 },
                new Seat{ Row=1, SeatNumber=3, RoomId=7 },
                new Seat{ Row=1, SeatNumber=4, RoomId=7 },
                new Seat{ Row=1, SeatNumber=5, RoomId=7 },
                new Seat{ Row=2, SeatNumber=1, RoomId=7 },
                new Seat{ Row=2, SeatNumber=2, RoomId=7 },
                new Seat{ Row=2, SeatNumber=3, RoomId=7 },
                new Seat{ Row=2, SeatNumber=4, RoomId=7 },
                new Seat{ Row=2, SeatNumber=5, RoomId=7 },
                new Seat{ Row=3, SeatNumber=1, RoomId=7 },
                new Seat{ Row=3, SeatNumber=2, RoomId=7 },
                new Seat{ Row=3, SeatNumber=3, RoomId=7 },
                new Seat{ Row=3, SeatNumber=4, RoomId=7 },
                new Seat{ Row=3, SeatNumber=5, RoomId=7 },

                new Seat{ Row=1, SeatNumber=1, RoomId=8 },
                new Seat{ Row=1, SeatNumber=2, RoomId=8 },
                new Seat{ Row=1, SeatNumber=3, RoomId=8 },
                new Seat{ Row=1, SeatNumber=4, RoomId=8 },
                new Seat{ Row=1, SeatNumber=5, RoomId=8 },
                new Seat{ Row=2, SeatNumber=1, RoomId=8 },
                new Seat{ Row=2, SeatNumber=2, RoomId=8 },
                new Seat{ Row=2, SeatNumber=3, RoomId=8 },
                new Seat{ Row=2, SeatNumber=4, RoomId=8 },
                new Seat{ Row=2, SeatNumber=5, RoomId=8 },
                new Seat{ Row=3, SeatNumber=1, RoomId=8 },
                new Seat{ Row=3, SeatNumber=2, RoomId=8 },
                new Seat{ Row=3, SeatNumber=3, RoomId=8 },
                new Seat{ Row=3, SeatNumber=4, RoomId=8 },
                new Seat{ Row=3, SeatNumber=5, RoomId=8 },

                new Seat{ Row=1, SeatNumber=1, RoomId=9 },
                new Seat{ Row=1, SeatNumber=2, RoomId=9 },
                new Seat{ Row=1, SeatNumber=3, RoomId=9 },
                new Seat{ Row=1, SeatNumber=4, RoomId=9 },
                new Seat{ Row=1, SeatNumber=5, RoomId=9 },
                new Seat{ Row=2, SeatNumber=1, RoomId=9 },
                new Seat{ Row=2, SeatNumber=2, RoomId=9 },
                new Seat{ Row=2, SeatNumber=3, RoomId=9 },
                new Seat{ Row=2, SeatNumber=4, RoomId=9 },
                new Seat{ Row=2, SeatNumber=5, RoomId=9 },
                new Seat{ Row=3, SeatNumber=1, RoomId=9 },
                new Seat{ Row=3, SeatNumber=2, RoomId=9 },
                new Seat{ Row=3, SeatNumber=3, RoomId=9 },
                new Seat{ Row=3, SeatNumber=4, RoomId=9 },
                new Seat{ Row=3, SeatNumber=5, RoomId=9 },
            };

            context.Seats.AddRange(mySeats);
            context.SaveChanges();
        }

    }
}
