using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Showing
    {
        public enum LanguageVersion
        {
            dubbing,
            subtitles
        }

        public enum TechnologyVersion
        {
            _2D,
            _3D
        }

        [Key]
        public int ShowingId { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Showtime { get; set; }

        [Required]
        public Room ScreeningRoom { get; set; }

        [Required]
        public LanguageVersion Language { get; set; }

        [Required]
        public TechnologyVersion Technology { get; set; }

        /* Jeśli byśmy chcieli się dowiedzieć czy miejsce wolne dla
            danego seansu, to loopowało by się po jego rezerwacjach i tam sprawdzało
            które miejsca są wolne a które zajęte.  */
        
        public ICollection<Reservation> Reservations { get; set; }

        [Required]
        public Film ShowedFilm { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(0.0, Double.MaxValue, ErrorMessage = "The value has to be bigger than 0")]
        public double Price { get; set; }

        public int? CinemaId { get; set; }

        public Cinema? Cinema { get; set; }
    }
}
