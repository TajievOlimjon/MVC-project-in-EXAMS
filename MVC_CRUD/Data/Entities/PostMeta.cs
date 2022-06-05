using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CRUD.Data.Entities
{
    public class PostMeta
    {
        [Key]
        public int Id { get; set; }
        [Column("Post_Id")]
        public int PostId { get; set; }
        public Post? Post { get; set; }
        public string? Key { get; set; }
        public string? Content { get; set; }

    }
}
