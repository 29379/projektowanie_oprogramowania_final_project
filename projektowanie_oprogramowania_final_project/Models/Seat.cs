using System.ComponentModel.DataAnnotations;
using System;

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

        /*  To chyba nie może być tutaj, albo będzie musiało inaczej działać.
            Przy takiej logice jeśli ktoś kupi bilet na siedzenie np 9
            w danej sali na wtorek 17.00, to dopóki seans nie przeminie, 
            to to siedzenie będzie 'occupied' i nie będzie można
            kupić biletu np na środę.   */
        [Required]
        public bool Occupied { get; set; }
    }
}
