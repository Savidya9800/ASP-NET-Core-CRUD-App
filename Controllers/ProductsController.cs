using AspnetCoreCRUDApp.Data;
using AspnetCoreCRUDApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreCRUDApp.Controllers
{
    public class ProductsController(AppDbContext db) : Controller
    {
        // GET: /Products
        public async Task<IActionResult> Index()
        {
            var list = await db.Products.AsNoTracking().ToListAsync();
            return View(list);
        }

        // GET: /Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id is null) return NotFound();
            var item = await db.Products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
            if (item is null) return NotFound();
            return View(item);
        }

        // GET: /Products/Create
        public IActionResult Create() => View();

        // POST: /Products/Create
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product model)
        {
            if (!ModelState.IsValid) return View(model);
            db.Add(model);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return NotFound();
            var item = await db.Products.FindAsync(id);
            if (item is null) return NotFound();
            return View(item);
        }

        // POST: /Products/Edit/5
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product model)
        {
            if (id != model.Id) return NotFound();
            if (!ModelState.IsValid) return View(model);

            try
            {
                db.Update(model);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await db.Products.AnyAsync(p => p.Id == id)) return NotFound();
                throw;
            }
        }

        // GET: /Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return NotFound();
            var item = await db.Products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
            if (item is null) return NotFound();
            return View(item);
        }

        // POST: /Products/Delete/5
        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await db.Products.FindAsync(id);
            if (item is not null)
            {
                db.Products.Remove(item);
                await db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
