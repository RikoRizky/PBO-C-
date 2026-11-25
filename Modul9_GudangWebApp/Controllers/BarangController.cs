using Microsoft.AspNetCore.Mvc;
using Modul9_GudangWebApp.Models;

namespace Modul9_GudangWebApp.Controllers
{
    public class BarangController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BarangController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Barang.ToList();
            return View(data);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Barang barang)
        {
            if (ModelState.IsValid)
            {
                _context.Barang.Add(barang);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(barang);
        }
    }
}
