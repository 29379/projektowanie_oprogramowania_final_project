﻿using System.ComponentModel.DataAnnotations;
using System;
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

        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }

        public string Description { get; set; }

        [Required]
        public TimeSpan RunningTime { get; set; }

        public List<Showing> Showings { get; set; }
    }
}
