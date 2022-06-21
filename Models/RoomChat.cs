﻿using System.ComponentModel.DataAnnotations;

namespace Proyecto_DevChat.Models
{
    public class RoomChat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public CategoryChat Category { get; set; }
    }
}
