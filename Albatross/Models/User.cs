using System;
namespace Albatross.Models
{
    public class User
    {
        public int UserId { get; set; }
        /*public string FirstName { get; set; }
        public string LastName { get; set; } ---- Trengs ikke for MVP*/ 
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHashed { get; set; }

    }
}