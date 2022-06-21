using Microsoft.AspNetCore.Mvc;

namespace Proyecto_DevChat.Controllers
{
    public class PrivChatController : Controller
    {
        public IActionResult Index()
        {
            //Traer la lista de chats grupales
            return View();
        }

        public IActionResult Room(int room)
        {
            return View("Room",room);
        }
    }
}
