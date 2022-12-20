using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Sala
    {
        [Key]
        public int SalaId { get; set; }

        [Required]
        public int SalaNumer { get; set; }

    }
}
