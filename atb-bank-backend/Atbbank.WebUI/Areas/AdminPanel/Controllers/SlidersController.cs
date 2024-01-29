using Atbbank.WebUI.Models.Entities;
using Atbbank.WebUI.Models.Persistences;
using Microsoft.AspNetCore.Mvc;

namespace Atbbank.WebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]

    public class SlidersController : Controller
    {
        private readonly DataContext db;

        public SlidersController(DataContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var sliders = db.Sliders
                .Where(m => m.DeletedBy == null)
                .ToList();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Slider model)
        {
            db.Sliders.Add(model);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var model = db.Sliders.FirstOrDefault(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = db.Sliders.FirstOrDefault(m => m.Id == id);
            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Slider model)
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.Entry(model).Property(m => m.CreatedAt).IsModified = false;
            db.Entry(model).Property(m => m.CreatedBy).IsModified = false;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var model = db.Sliders.FirstOrDefault(m => m.Id == id && m.DeletedBy == null);
            if (model == null)

                return Json(new
                {
                    error = true,
                    message = "Qeyd movcud deyil!"
                });
            db.Sliders.Remove(model);
            db.SaveChanges();

            return Json(new
            {
                error = false,
                message = "Qeyd silindi!"
            });
        }
    }
}
