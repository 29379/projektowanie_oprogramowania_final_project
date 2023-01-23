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

        [ForeignKey(nameof(CinemaId))]
        public virtual Cinema Cinema { get; set; }

        [InverseProperty(nameof(Seat.Room))]
        public ICollection<Seat> Seats { get; set; }

        [InverseProperty(nameof(Showing.ScreeningRoom))]
        public ICollection<Showing> Showings { get; set; }

        public override string ToString()
        {
            return RoomNumber + "";
        }
    }
}
