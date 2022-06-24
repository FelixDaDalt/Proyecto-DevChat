namespace Proyecto_DevChat.Models
{
    public class MessageRequest
    {
        public string UserId { get; set; }
        public int RoomChatId { get; set; }
        public string MessageBody { get; set; }
        public DateTime Date { get; set; }
    }
}
