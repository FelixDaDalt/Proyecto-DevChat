using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proyecto_DevChat.Models;
using System.Security.Claims;
using System.Text.Json;

namespace Proyecto_DevChat.Controllers
{
    public class PrivChatController : Controller
    {
        [Authorize]
        public ActionResult<List<RoomResponse>> Index()
        {
            //Traer la lista de chats grupales
            List<RoomResponse> roomChatList = null;
            var claim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string url = "https://localhost:7211/api/RoomChats/" + claim;
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                roomChatList = JsonSerializer.Deserialize<List<RoomResponse>>(content,
                    new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    ); 
            }
            return View(roomChatList);
        }

        public IActionResult Room(int room, int category)
        {
            //Aca le pido a la api el historial de mensajes de la sala
            var claim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (category == 1) { }            
            string url = "https://localhost:7211/api/RoomChats/group/" + room;
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            RoomResponse roomChat = new RoomResponse();
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                roomChat = JsonSerializer.Deserialize<RoomResponse>(content,
                    new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
            return View("Room",roomChat);
        }
    }
}
