using System.ComponentModel.DataAnnotations;

namespace Proyecto_DevChat.Models
{
    public class CategoryChat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
