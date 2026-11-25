using Microsoft.AspNetCore.Mvc;

namespace Modul9_GudangWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Privacy() => View();
    }
}
