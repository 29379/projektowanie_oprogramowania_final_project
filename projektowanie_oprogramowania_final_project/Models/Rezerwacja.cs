using System.ComponentModel.DataAnnotations;
using System;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Rezerwacja
    {
        [Key]
        public int RezerwacjaId { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime DataGodzina { get; set; }

        [Required]
        public Double Koszt { get; set; }
    }
}
