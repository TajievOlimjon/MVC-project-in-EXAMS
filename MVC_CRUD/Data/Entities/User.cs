using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CRUD.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        [Column("First_Name")]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        [Column("Middle_Name")]
        public string? MiddleName { get; set; }
        [MaxLength(50)]
        [Required]
        [Column("Last_Name")]
        public string? LastName { get; set; }
        [MaxLength(15)]
        public string? Mobile { get; set; }
        [MaxLength(50)]
        [Required]
        public string? Email { get; set; }
        [MaxLength(32)]
        [Required]
        [Column("Password_Hash")]
        public string? PasswordHash { get; set; }
        [Column("Registered_At")]
        public DateTime RegisteredAt { get; set; }
        [Column("Last_Login")]
        public DateTime LastLogin { get; set; }
        public string? Intro { get; set; }
        public string? Profile { get; set; }
        public virtual List<Post>? Posts { get; set; }

    }
}
