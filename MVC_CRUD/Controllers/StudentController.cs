using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.Data.Entities;
using MVC_CRUD.Services;

namespace MVC_CRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService studentService;

        public StudentController(StudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var list = studentService.GetStudents();
            return View(list);
        }

       

        [HttpGet]
        public IActionResult Create()
        {
           return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid==true)
            {
                studentService.Create(student);
                return  RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var list = studentService.GetStudentById(Id);
            return View(list);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid == false)
                return View(student);

            studentService.Update(student);
            return RedirectToAction(nameof(Index));
                           
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            studentService.Delete(Id);
            return RedirectToAction(nameof(Index));
        }

        //[HttpPost]
        //public IActionResult Delete(Student student)
        //{
        //    studentService.Delete(student.Id);
        //    return RedirectToAction(nameof(Index));

        //}

    }
}
