using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Reservation
    {
        public enum PaymentMethod
        {
            blik,
            PayU,
            bankTransfer
        }

        [Key]
        public int ReservationId { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime ReservationTime { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public List<Seat> Seats { get; set; }

        [Required]
        public PaymentMethod ChosenPayment { get; set; }

        public Customer? Customer { get; set; }

        public int CustomerId { get; set; }

        public int ShowingId { get; set; }
        public Showing? Showing;

        public Reservation() { }

        public Reservation(int reservationId, DateTime reservationTime, double price, List<Seat> seats, PaymentMethod chosenPayment)
        {
            ReservationId = reservationId;
            ReservationTime = reservationTime;
            Price = price;
            Seats = seats;
            ChosenPayment = chosenPayment;
        }
    }
}
