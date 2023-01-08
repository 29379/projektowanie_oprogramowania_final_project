using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Customer : User
    {
        [Required]
        public List<Reservation> Reservations { get; set; }

        public Customer() { }

        public Customer(List<Reservation> reservations, int id, string name, string surname, string email, string password, string phoneNumber = null)
        {
            Reservations = reservations;
            Name = name;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            UserId = id;
            Surname = surname;
        }
    }
}
