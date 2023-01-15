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
        public int RoomNumber { get; set; }

        public int? CinemaId { get; set; }

        public Cinema? Cinema { get; set; }

        public ICollection<Seat> Seats { get; set; }

        public Room() { }

        public Room(int roomId, int roomNumber, ICollection<Seat> seats)
        {
            RoomId = roomId;
            RoomNumber = roomNumber;
            Seats = seats;
        }
    }
}
