using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace projektowanie_oprogramowania_final_project.Models
{
    public enum PaymentMethod
    {
        blik,
        PayU,
        bankTransfer
    }

    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public ICollection<Seat> Seats { get; set; }

        [Required]
        public PaymentMethod ChosenPayment { get; set; }

        public int? ShowingId { get; set; }

        public Showing? Showing;

        public Reservation() { }

        public Reservation(int reservationId, double price, ICollection<Seat> seats, PaymentMethod chosenPayment)
        {
            ReservationId = reservationId;
            Price = price;
            Seats = seats;
            ChosenPayment = chosenPayment;
        }
    }
}
