using Microsoft.EntityFrameworkCore;
using MVC_CRUD.Data.Entities;

namespace MVC_CRUD.Data
{
    public class DataContext:DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
