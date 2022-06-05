using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CRUD.Data.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Column("Author_Id")]
        public int AuthorId { get; set; }
        public User? Author { get; set; }
        [Column("Parent_Id")]
        public int ParentId { get; set; }
        [MaxLength(75)]
        [Required]
        public string? Title { get; set; }
        [MaxLength(100)]
        [Column("Meta_Title")]
        public string? MetaTitle { get; set; }
        [MaxLength(100)]
        public string? Slug { get; set; }
        public string? Summary { get; set; }
        public int Published { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime PublishedAt { get; set; }
        public string? Content { get; set; }
        public virtual List<PostComment>? PostComments { get; set; }
        public virtual List<PostMeta>? PostMetas { get; set; }
        public virtual List<PostCategory>? Categories { get; set; }
        public virtual List<PostTag>? PostTags { get; set; }


    }
}
