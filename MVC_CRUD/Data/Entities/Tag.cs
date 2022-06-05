using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD.Data.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        [MaxLength(75)]
        [Required]
        public string? Title { get; set; }
        [MaxLength(100)]
        public string? MetaTitle { get; set; }
        [MaxLength(100)]
        public string? Slug { get; set; }
        public string? Content { get; set; }
        public virtual List<PostTag>? Posts { get; set; }
    }
}
