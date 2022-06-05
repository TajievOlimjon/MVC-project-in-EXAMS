using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.Data.Entities;
using MVC_CRUD.Services;

namespace MVC_CRUD.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactService contactService;

        public ContactController(ContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var contacts=contactService.GetContacts();
            return View(contacts);
        }

        [HttpGet]
        public IActionResult Create()
        {                       
            return View(new Contact());
        }


        [HttpPost]
        public IActionResult Create(Contact contact)
        {
          
            if (ModelState.IsValid == true)
            {
                contactService.Insert(contact);
                return RedirectToAction(nameof(Index));
            }

            return View(contact);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var contact = contactService.GetContactById(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            
            if (ModelState.IsValid == false)
                return View(contact);

            try
            {
                contactService.Update(contact);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Something went wrong {ex.Message}");
                return View(contact);
            }

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = contactService.GetContactById(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            contactService.Delete(contact.Id);
            return RedirectToAction(nameof(Index));
        }



    }
}
