using Microsoft.AspNetCore.Mvc;

namespace Modul10_GudangWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Privacy() => View();
    }
}
