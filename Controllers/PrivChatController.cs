using Microsoft.AspNetCore.Mvc;
using Proyecto_DevChat.Models;
using System.Text.Json;

namespace Proyecto_DevChat.Controllers
{
    public class PrivChatController : Controller
    {
        public ActionResult<List<RoomChat>> Index()
        {
            //Traer la lista de chats grupales
            List<RoomChat> roomChatList = null;
            string url = "https://localhost:7211/api/RoomChats";
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                roomChatList = JsonSerializer.Deserialize<List<RoomChat>>(content,
                    new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    ); 
            }
            return View(roomChatList);
        }

        public IActionResult Room(int room)
        {
            return View("Room",room);
        }
    }
}
