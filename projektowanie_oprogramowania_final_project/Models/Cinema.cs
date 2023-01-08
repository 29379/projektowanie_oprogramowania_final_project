using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class InstitutionAddress //  'Structs are not a supported Entity Framework type', więc zmieniłem na pomniejszą klasę
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Street { get; set; }

        [Required]
        public int Number { get; set; }
        
        [Required]
        public string ZipCode { get; set; }

        public InstitutionAddress() { }

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
        [Key]
        public int CinemaId { get; set; }

        [Required]
        public InstitutionAddress Address { get; set; }

        [Required]
        public List<Room> ScreeningRooms { get; set; }

        [Required]
        public List<Employee> Employees { get; set; }

        [Required]
        public List<Showing> Showings { get; set; }

        public Cinema() { }

        public Cinema(int cinemaId, InstitutionAddress address, List<Room> screeningRooms, List<Employee> employees, List<Showing> showings)
        {
            CinemaId = cinemaId;
            Address = address;
            ScreeningRooms = screeningRooms;
            Employees = employees;
            Showings = showings;
        }
    }
}
