using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CRUD.Data.Entities
{
    public class PostCategory
    {
        
        [Column("Post_Id")]
        public int PostId { get; set; }
        public Post? Post { get; set; }
        [Column("Category_Id")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
