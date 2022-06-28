namespace Proyecto_DevChat.Models
{
    public class MessageRequest
    {
        public string MessageBody { get; set; }
        public string UserId { get; set; }
        public DateTime Date { get; set; }
        public int RoomChatId { get; set; } 

    }
}
