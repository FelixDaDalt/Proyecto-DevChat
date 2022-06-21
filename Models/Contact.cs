namespace Proyecto_DevChat.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser Users { get; set; }
    }
}
