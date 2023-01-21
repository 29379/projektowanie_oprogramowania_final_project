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

        //[DataType(DataType.DateTime)]
        //[Required]
        //public DateTime ReservationTime { get; set; }
        //  czy nie lepiej użyć tu po prostu Showing.Showtime? po co to w zasadzie było xd że czas transakcji? jak tak to można sobie dać spokój żeby było szybciej imo

        [Required]
        public double Price { get; set; }

        [Required]
        public ICollection<Seat> Seats { get; set; }

        [Required]
        public PaymentMethod ChosenPayment { get; set; }

        public int ShowingId { get; set; }

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
