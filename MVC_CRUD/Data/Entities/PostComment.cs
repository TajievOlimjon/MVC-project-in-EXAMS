using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CRUD.Data.Entities
{
    public class PostComment
    {
        [Key]
        public int Id { get; set; }
       
        [Column("Post_Id")]
        public int  PostId { get; set; }
        public Post? Post { get; set; }
        [Column("Parent_Id")]
        public int  ParentId { get; set; }
        [MaxLength(100)]
        [Required]
        public string? Title { get; set; }
        public int Published { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime PublishedAt { get; set; }
        public string? Content { get; set; }
       
    }
}
