using System.ComponentModel.DataAnnotations;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }

        [Required]
        public int Row { get; set; }

        [Required]
        public int SeatNumber { get; set; }
    }
}
