﻿namespace Proyecto_DevChat.Models
{
    public class MessageResponse
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string MessageBody { get; set; }
        public DateTime Date { get; set; }
    }
}
