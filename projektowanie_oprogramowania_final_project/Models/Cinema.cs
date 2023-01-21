using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Number { get; set; }

        [Required]
        public string ZipCode { get; set; }

        public ICollection<Room> ScreeningRooms { get; set; }

        public ICollection<Showing> Showings { get; set; }

        public Cinema() { }

        public Cinema(int cinemaId, string street, int number, string zipCode, ICollection<Room> screeningRooms, ICollection<Showing> showings)
        {
            CinemaId = cinemaId;
            Street = street;
            Number = number;
            ZipCode = zipCode;
            ScreeningRooms = screeningRooms;
            Showings = showings;
        }

        public override string ToString()
        {
            string output = Street + " " + Number + ", " + ZipCode;
            return output;
        }
    }
}
