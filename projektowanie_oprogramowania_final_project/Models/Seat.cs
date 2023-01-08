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

        public Seat() { }

        public Seat(int seatId, int row, int seatNumber)
        {
            SeatId = seatId;
            Row = row;
            SeatNumber = seatNumber;
        }
    }
}
