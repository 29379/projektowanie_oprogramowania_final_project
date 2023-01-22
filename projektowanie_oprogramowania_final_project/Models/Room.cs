using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int RoomNumber { get; set; }

        public int? CinemaId { get; set; }
        //  Jest dobrze, trzeba dodać jakieś zapytanie do bd przy tworzeniu pokoi chyba

        public Cinema? Cinema { get; set; }
        //  Cinema: NullReference - object reference not set to an instance of an object

        public ICollection<Seat> Seats { get; set; }

        public ICollection<Showing> Showings { get; set; }

        public override string ToString()
        {
            return RoomNumber.ToString() + ", "; //+ Cinema.ToString();
        }

        /*
        public Room() { }

        public Room(int roomId, int roomNumber, ICollection<Seat> seats)
        {
            RoomId = roomId;
            RoomNumber = roomNumber;
            Seats = seats;
        }
        */
    }
}
