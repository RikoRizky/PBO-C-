using Microsoft.AspNetCore.Mvc;
using GudangWebApp.Models;
using GudangWebApp.ViewModels;

namespace GudangWebApp.Controllers
{
    public class BarangController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BarangController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Barang/Index
        public IActionResult Index()
        {
            var data = _context.Barang.ToList();
            return View(data);
        }

        // GET: /Barang/Create
        public IActionResult Create() => View();

        // POST: /Barang/Create
        [HttpPost]
        public IActionResult Create(BarangViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var barang = new Barang
                {
                    KodeBarang = vm.KodeBarang,
                    NamaBarang = vm.NamaBarang,
                    JumlahStok = vm.JumlahStok,
                    Kategori = vm.Kategori
                };
                _context.Barang.Add(barang);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        // GET: /Barang/Edit/5
        public IActionResult Edit(int id)
        {
            var barang = _context.Barang.Find(id);
            if (barang == null) return NotFound();
            return View(barang);
        }

        // POST: /Barang/Edit/5
        [HttpPost]
        public IActionResult Edit(Barang barang)
        {
            if (ModelState.IsValid)
            {
                _context.Barang.Update(barang);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(barang);
        }

        // GET: /Barang/Delete/5
        public IActionResult Delete(int id)
        {
            var barang = _context.Barang.Find(id);
            if (barang == null) return NotFound();
            return View(barang);
        }

        // POST: /Barang/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var barang = _context.Barang.Find(id);
            if (barang == null) return NotFound();
            _context.Barang.Remove(barang);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
