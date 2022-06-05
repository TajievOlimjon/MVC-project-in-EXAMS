using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CRUD.Data.Entities
{
    public class PostTag
    {
        [Column("Post_Id")]
        public int PostId { get; set; }
        public Post? Post { get; set; }
        [Column("Tag_Id")]
        public int TagId { get; set; }
        public Tag? Tag { get; set; }

    }
}
