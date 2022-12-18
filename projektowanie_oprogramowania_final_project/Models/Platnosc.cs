using System.ComponentModel.DataAnnotations;
using System;

namespace projektowanie_oprogramowania_final_project.Models
{
    public enum MetodaPlatnosci
    {
        blik,
        PayU,
        przelewBankowy
    }

    public class Platnosc
    {
        [Key]
        public int PlatnoscId { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime DataGodzina { get; set; }

        [Required]
        public WersjaJezykowa WersjaJezykowa { get; set; }

        [Required]
        public MetodaPlatnosci MetodaPlatnosci { get; set; }
    }
}
