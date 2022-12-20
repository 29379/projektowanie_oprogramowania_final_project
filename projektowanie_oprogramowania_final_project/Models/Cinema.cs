using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cinema
{

    public struct InstitutionAddress
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public string ZipCode { get; set; }

        public InstitutionAddress(string street, int number, string zipCode)
        {
            Street = street;
            Number = number;
            ZipCode = zipCode;
        }

        public override string ToString() => base.ToString();
    }

    public class Cinema
    {
        [Required]
        public InstitutionAddress Address { get; set; }

        [Required]
        public List<Object> ScreeningRoom { get; set; }

        [Required]
        public List<Employee.Employee> Employees { get; set; }
    }
}
