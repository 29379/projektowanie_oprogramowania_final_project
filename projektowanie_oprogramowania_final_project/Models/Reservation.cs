using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime ReservationTime { get; set; }

        [Required]
        public Double Price { get; set; }

        [Required]
        public List<Seat> Seats { get; set; }

        [Required]
        public Payment ChosenPayment { get; set; } 

        public Reservation() { }

        public Reservation(int reservationId, DateTime reservationTime, double price, List<Seat> seats, Payment chosenPayment)
        {
            ReservationId = reservationId;
            ReservationTime = reservationTime;
            Price = price;
            Seats = seats;
            ChosenPayment = chosenPayment;
        }
    }
}
