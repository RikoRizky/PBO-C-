using Microsoft.AspNetCore.Mvc;

namespace Modul11_GudangWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Privacy() => View();
    }
}
