using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Employee
{

    public enum Position
    {
        admin,
        common
    }

    public class Employee : User.User
    {
        [Required]
        public Position Role { get; set; }

        public Employee(int id, string name, string surname, string email, string phoneNumber, string password, Position role)
        {
            UserId = id;
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
            Role = role;
        }

        public Employee(int id, string name, string surname, string email, string password, Position role)
            : this(id, name, surname, email, null, password, role) { }

        public Employee(int id, string name, string surname, string email, string phoneNumber, string password)
            : this(id, name, surname, email, phoneNumber, password, Position.common) { }

        public Employee(int id, string name, string surname, string email, string password)
            : this(id, name, surname, email, null, password, Position.common) { }
    }
}
