using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Proyecto_DevChat.Data;
using Proyecto_DevChat.Models;
using Proyecto_DevChat.Services;
using System.Diagnostics;

namespace Proyecto_DevChat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> userm;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger,UserManager<IdentityUser> userManager, ApplicationDbContext db)
        {
            _logger = logger;
            userm = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            var aux = User.Identity.ToString();
            var currentuser = userm.GetUserAsync(User);
            return View();
        }
        [Authorize]
        public IActionResult Privacy()
        {
            if (User.Identity.IsAuthenticated)
            {
                //ContactoService c = new ContactoService(_db);
                //var userId = userm.GetUserId(HttpContext.User);
                //var contactId = "bea76ac7-46f5-4812-83ca-7644177e9ea1";
                //c.AddContact(userId, contactId);
                var u = userm.GetUserAsync(HttpContext.User).Result;
                var x = _db.Us.OfType<Contact>().ToList();
                
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}