using System.ComponentModel.DataAnnotations;
using System;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Miejsce
    {
        [Key]
        public int MiejsceId { get; set; }

        [Required]
        public int Rzad { get; set; }

        [Required]
        public int NumerMiejsca { get; set; }

        [Required]
        public bool Zajete { get; set; }
    }
}
