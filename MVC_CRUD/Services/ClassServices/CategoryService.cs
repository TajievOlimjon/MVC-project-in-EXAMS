using AutoMapper;
using MVC_CRUD.Data;
using MVC_CRUD.Data.Entities;
using MVC_CRUD.Data.EntitiesDTO;

namespace MVC_CRUD.Services.ClassServices
{
    public class CategoryService
    {
        private readonly DataContext dataContext;
        private readonly IMapper mapper;

        public CategoryService(DataContext dataContext,IMapper mapper )
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public List<CategoryEntrieDTO> GetCategories()
        {
            var categories=( 
                           from c in dataContext.Categories
                           select new CategoryEntrieDTO
                           {
                               Id = c.Id,
                               ParentId = c.ParentId,
                               Title = c.Title,
                               MetaTitle = c.MetaTitle,
                               Slug=c.Slug,
                               Content = c.Content
                           } 
                               
                ).ToList();
            return categories;
        }
        public CategoryEntrieDTO GetCategoriesById(int Id)
        {
            var categories = (
                           from c in dataContext.Categories
                           where c.Id == Id
                           select new CategoryEntrieDTO
                           {
                               Id = c.Id,
                               ParentId = c.ParentId,
                               Title = c.Title,
                               MetaTitle = c.MetaTitle,
                               Slug = c.Slug,
                               Content = c.Content
                           }

                ).FirstOrDefault();
            return categories;
        }

        public int Insert(CategoryEntrieDTO category)
        {
            var newCategory = mapper.Map<Category>(category);
            dataContext.Categories.Add(newCategory);
            return dataContext.SaveChanges();
        }

        public int Update(CategoryEntrieDTO category)
        {
            var cat = dataContext.Categories.Find(category.Id);
            if (cat == null) return 0;
            cat.ParentId = category.ParentId;
            cat.Title = category.Title;
            cat.MetaTitle = category.MetaTitle;
            cat.Slug = category.Slug;
            cat.Content = category.Content;
            return dataContext.SaveChanges();
        }

        public int Delete(int Id)
        {
            var category = dataContext.Categories.Find(Id);
            if (category == null) return 0;
            dataContext.Categories.Remove(category);
            return dataContext.SaveChanges();
        }
    }
}
