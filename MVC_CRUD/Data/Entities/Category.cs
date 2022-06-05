using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CRUD.Data.Entities
{
    public class Category
    {
       
        [Key]
        public int Id { get; set; }
        [Column("Parent_Id")]
        public int ParentId { get; set; }
        [MaxLength(75)]
        public string? Title { get; set; }
        [MaxLength(100)]
        [Column("Meta_Title")]
        public string? MetaTitle { get; set; }
        [MaxLength(100)]
        public string? Slug { get; set; }
        
        public string? Content { get; set; }
        public virtual List<PostCategory>? Posts { get; set; }

    }
}
