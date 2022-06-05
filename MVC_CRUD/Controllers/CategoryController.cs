using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.Data.EntitiesDTO;
using MVC_CRUD.Services.ClassServices;

namespace MVC_CRUD.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService categoryService;

        public CategoryController(CategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categories = categoryService.GetCategories();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CategoryEntrieDTO());
        }

        [HttpPost]
        public IActionResult Create(CategoryEntrieDTO category)
        {
            if (ModelState.IsValid == true)
            {
                categoryService.Insert(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
          
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var category = categoryService.GetCategoriesById(Id);
            return View(category);
        }


        [HttpPost]
        public IActionResult Edit(CategoryEntrieDTO category)
        {
            if (ModelState.IsValid == false)
                return View(category);

            categoryService.Update(category);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            categoryService.Delete(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
