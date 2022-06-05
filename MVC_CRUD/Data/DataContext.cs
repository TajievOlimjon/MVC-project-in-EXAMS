using Microsoft.EntityFrameworkCore;
using MVC_CRUD.Data.Entities;

namespace MVC_CRUD.Data
{
    public class DataContext:DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTag>().HasKey(sc => new { sc.PostId, sc.TagId });
            modelBuilder.Entity<PostCategory>().HasKey(sc => new { sc.PostId, sc.CategoryId });
        }
       

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostMeta> PostMetas { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
