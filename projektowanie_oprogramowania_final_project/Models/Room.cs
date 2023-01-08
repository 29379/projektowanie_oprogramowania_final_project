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

        [Required]
        public List<Seat> Seats { get; set; }

        public Room() { }

        public Room(int roomId, int roomNumber, List<Seat> seats)
        {
            RoomId = roomId;
            RoomNumber = roomNumber;
            Seats = seats;
        }
    }
}
