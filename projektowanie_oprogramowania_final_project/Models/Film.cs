using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

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

        //  - - - - - - - - - - - - - - - - - - - - - 
        //  - - - - - - - - - - - - - - - - - - - - - 

        public string? FilePath { get; set; } = null;

        [NotMapped]
        public string Image =>
            FilePath is { } path ? $"/upload/{path}" : "/images/no-image.jpg";

        [NotMapped]
        public IFormFile? FormFile { get; set; } = null;
    }
}
