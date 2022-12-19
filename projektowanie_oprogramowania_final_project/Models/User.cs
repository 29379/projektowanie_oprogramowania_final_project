using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [RegularExpression(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$")]
        public string Email { get; set; }
        [RegularExpression(@"^\\+?[1-9][0-9]{7,14}$")]
        public string? PhoneNumber { get; set; }
        [Required]
        protected string Password;
        public void SetPassword(string password)
        {
            try
            {
                if (Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,16}$"))
                {
                    Password = password;
                }
            }
            catch (ArgumentException arg)
            {
                Console.WriteLine(arg.Source);
            }
            catch (TimeoutException time)
            {
                Console.WriteLine(time.Source);
            }
        }
        public string GetPassword() => Password;

        public User() { }

        public User(int id, string name, string surname, string email, string phoneNumber, string password) 
        {
            UserId = id;
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }

        public User(int id, string name, string surname, string email, string password)
            : this(id, name, surname, email, null, password) { }
    }
}
