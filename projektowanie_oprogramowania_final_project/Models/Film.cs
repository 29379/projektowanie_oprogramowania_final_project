using System.ComponentModel.DataAnnotations;
using System;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Film
    {
        [Key]
        public int FilmId { get; set; }

        [Required]
        public string Tytul { get; set; }

        [Required]
        public string Rezyser { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DataWydania { get; set; }

        public string Opis { get; set; }

        [Required]
        public TimeSpan CzasTrwania { get; set; }
    }
}
