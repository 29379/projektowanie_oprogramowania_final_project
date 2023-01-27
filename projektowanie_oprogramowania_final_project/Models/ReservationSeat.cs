using Microsoft.CodeAnalysis.Differencing;
using System.Diagnostics.Contracts;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class ReservationSeat
    {
        public int? ReservationId { get; set; }
        public int? SeatId { get; set; }

        public Reservation Reservation { get; set; }
        public Seat Seat { get; set; }

        public ReservationSeat (int? reservationId, int? seatId)
        {
            ReservationId = reservationId;
            SeatId = seatId;
        }
    }
}
