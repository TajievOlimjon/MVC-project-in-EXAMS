using MVC_CRUD.Data;
using MVC_CRUD.Data.Entities;

namespace MVC_CRUD.Services
{
    public class ContactService
    {
        private readonly DataContext dataContext;

        public ContactService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Contact> GetContacts()
        {
            var list = dataContext.Contacts.ToList();
            return list;
        }

        public Contact GetContactById(int id)
        {
            var d = dataContext.Contacts.Find(id);
             return d;
        }

        public int Insert(Contact contact)
        {
            dataContext.Contacts.Add(contact);
            var save = dataContext.SaveChanges();
            return save;
        }
        public int Update(Contact contact)
        {
            var prevouseContact = dataContext.Contacts.Find(contact.Id);
            if (prevouseContact == null) return 0;
            prevouseContact.FirstName = contact.FirstName;
            prevouseContact.LastName = contact.LastName;
            prevouseContact.Email = contact.Email;
            prevouseContact.Mobile=contact.Mobile;
            var save = dataContext.SaveChanges();
            return save;             
        }

        public int Delete(int Id)
        {
            var contact = dataContext.Contacts.Find(Id);
            if (contact == null) return 0;
            dataContext.Contacts.Remove(contact);
            var save = dataContext.SaveChanges();
            return save;
        }
    }
}
