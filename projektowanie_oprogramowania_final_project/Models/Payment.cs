using System.ComponentModel.DataAnnotations;
using System;

namespace projektowanie_oprogramowania_final_project.Models
{
    public enum PaymentMethod
    {
        blik,
        PayU,
        bankTransfer
    }

    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime PaymentTime { get; set; }

        [Required]
        public LanguageVersion Language { get; set; }

        [Required]
        public PaymentMethod Method { get; set; }
    }
}
