using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Film
    {
        [Key]
        public int FilmId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Director { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Description { get; set; }

        [Required]
        public TimeSpan RunningTime { get; set; }

        public String ImagePath { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        public ICollection<Showing> Showings { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
