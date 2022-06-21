using Microsoft.AspNetCore.Identity;

namespace Proyecto_DevChat.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Contacts = new HashSet<Contact>();
        }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
