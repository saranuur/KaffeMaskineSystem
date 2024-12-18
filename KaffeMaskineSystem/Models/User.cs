using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaffeMaskineSystem.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Role { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public User()
        {
        }

        // User constructor
        public User(int userID, string firstName, string lastName, string email, string role, string passwordHash)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Role = role;
            PasswordHash = passwordHash;
        }
    }
}