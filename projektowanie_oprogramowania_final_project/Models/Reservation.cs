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

        /*  nie wiem jak to nazwać, nie chcę 'Payment' bo to nazwa klasy
            i nie chcę 'PaymentMethod' bo to nazwa wewnętrznego enuma
            w Paymencie */
        [Required]
        public Payment PPayment { get; set; } 
    }
}
