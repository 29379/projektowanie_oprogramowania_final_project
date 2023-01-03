using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace projektowanie_oprogramowania_final_project.Models
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

    public class Showing
    {
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

        /*  Może takie rozwiązanie? Może rezerwacje wpiąć do seansu?
            Wtedy załatwiony byłby problem tego czy wiemy, czy miejsce jest
            zajęte, bo jeśli byśmy chcieli się dowiedzieć czy miejsce wolne dla
            danego seansu, to loopowało by się po jego rezerwacjach i tam sprawdzało
            które miejsca są wolne a które zajęte. To chyba byłoby git? Czy nie?
         */
        [Required]
        public List<Reservation> Reservations { get; set; }

    }
}
