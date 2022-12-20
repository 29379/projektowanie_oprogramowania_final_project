using System.ComponentModel.DataAnnotations;
using System;
using System.Reflection;

namespace projektowanie_oprogramowania_final_project.Models
{
    public enum WersjaJezykowa
    {
        dubbing,
        napisy
    }

    public enum Technologia
    {
        _2D,
        _3D
    }

    public class Seans
    {
        [Key]
        public int SeansId { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime DataGodzina { get; set; }

        [Required]
        public WersjaJezykowa WersjaJezykowa { get; set; }

        [Required]
        public Technologia Technologia { get; set; }

    }
}
