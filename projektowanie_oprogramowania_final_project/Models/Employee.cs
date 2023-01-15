using System.ComponentModel.DataAnnotations;

namespace projektowanie_oprogramowania_final_project.Models
{

    public enum Position
    {
        admin,
        common
    }

    public class Employee : User
    {
        [Required]
        public Position Role { get; set; }

        public int CinemaId { get; set; }

        public Cinema? Cinema { get; set; }

        public Employee() { }

        public Employee(Position role, int id, string name, string surname, string email, string password, string phoneNumber = null)
        {
            UserId = id;
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
            Role = role;
        }

        /*
         public Employee(int id, string name, string surname, string email, string password, Position role)
            : this(id, name, surname, email, null, password, role) { }

        public Employee(int id, string name, string surname, string email, string phoneNumber, string password)
            : this(id, name, surname, email, phoneNumber, password, Position.common) { }

        public Employee(int id, string name, string surname, string email, string password)
            : this(id, name, surname, email, null, password, Position.common) { }
         */
    }
}
