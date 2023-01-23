using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [InverseProperty(nameof(Room.Cinema))]
        public ICollection<Room> ScreeningRooms { get; set; }

        [InverseProperty(nameof(Showing.Cinema))]
        public ICollection<Showing> Showings { get; set; }

        public override string ToString()
        {
            return Street + " " + Number + ", " + ZipCode;
        }
    }
}
