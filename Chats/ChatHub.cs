using Microsoft.AspNetCore.SignalR;
using Proyecto_DevChat.Models;
using System.Text.Json;

namespace Proyecto_DevChat.Chats
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string room, int roomId, string user, string message,string userId)
        {
            await Clients.Group(room).SendAsync("RecieveMessage", user, message);
            //aca tengo que mandar el msj a la api para que lo guarde
            MessageRequest mess = new MessageRequest();
            mess.MessageBody = message;
            mess.UserId = userId;
            mess.Date = DateTime.Now;
            mess.RoomChatId = roomId;
            string url = "https://localhost:7211/api/Messages";
            HttpClient httpClient = new HttpClient();
            string json = JsonSerializer.Serialize<MessageRequest>(mess);
            HttpContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await httpClient.PostAsync(url, content);
            if (httpResponse.IsSuccessStatusCode)
            {
                var result = httpResponse.Content.ReadAsStringAsync().Result;
            }

        }

        public async Task AddToGroup(string room)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
            await Clients.Group(room).SendAsync("Bienvenido", $"Bienvenido: { Context.ConnectionId}");
        }
    }
}
