namespace MVC_CRUD.Data.EntitiesDTO
{
    public class CategoryEntrieDTO
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string? Title { get; set; }
        public string? MetaTitle { get; set; }
        public string? Slug { get; set; }
        public string? Content { get; set; }
    }
}
