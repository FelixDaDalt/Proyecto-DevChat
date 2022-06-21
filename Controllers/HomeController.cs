using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Proyecto_DevChat.Models;
using System.Diagnostics;

namespace Proyecto_DevChat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> userm;

        public HomeController(ILogger<HomeController> logger,UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            userm = userManager;
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
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}