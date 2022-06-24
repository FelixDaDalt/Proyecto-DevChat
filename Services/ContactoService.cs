using Proyecto_DevChat.Data;
using Proyecto_DevChat.Models;

namespace Proyecto_DevChat.Services
{
    public class ContactoService
    {
        private readonly ApplicationDbContext _db;
        public ContactoService(ApplicationDbContext db)
        {
            _db = db;   
        }
        public void AddContact(string idUser, string idContact)
        {
            Contact c = new Contact();
            c.contactUser = idContact;
            c.UserId = idUser;
            _db.Contacts.Add(c);
            _db.SaveChanges();
            var x = _db.Us.OfType<Contact>().ToList();
        }
    }
}
