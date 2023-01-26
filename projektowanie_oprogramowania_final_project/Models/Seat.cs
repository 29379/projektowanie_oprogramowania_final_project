using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Row { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int SeatNumber { get; set; }

        public int? RoomId { get; set; }

        public Room Room { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public override string ToString()
        {
            return "row: " + Row + ", seat: " + SeatNumber;
        }
    }
}
