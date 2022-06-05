using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD.Data.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string? LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Email { get; set; }
        public string? Mobile { get; set; }
    }
}
