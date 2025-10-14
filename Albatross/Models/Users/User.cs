using System;
using System.ComponentModel.DataAnnotations;
namespace Albatross.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string PasswordHashed { get; set; }

        public ICollection<User>Users { get; set; }
    }
}







/* using System;
namespace Albatross.Models
{
    public class User
    {
        public int UserId { get; set; }
        // public string FirstName { get; set; }
        // public string LastName { get; set; } ---- Trengs ikke for MVP
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHashed { get; set; }

    }
}


*/