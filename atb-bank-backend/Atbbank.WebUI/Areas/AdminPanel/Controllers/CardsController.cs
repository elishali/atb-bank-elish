using Atbbank.WebUI.Models.Entities;
using Atbbank.WebUI.Models.Persistences;
using Microsoft.AspNetCore.Mvc;

namespace Atbbank.WebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CardsController : Controller
    {
        private readonly DataContext db;

        public CardsController(DataContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var cards = db.Cards
                .Where(m => m.DeletedBy == null)
                .ToList();
            return View(cards);
        }   
        public IActionResult Create()
        {  
            return View();
        }

        [HttpPost]
        public IActionResult Create(Card model)
        {
            db.Cards.Add(model);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var model = db.Cards.FirstOrDefault(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = db.Cards.FirstOrDefault(m => m.Id == id);
            if (model == null)
                return NotFound();
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Card model)
        {
            db.Entry(model).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.Entry(model).Property(m => m.CreatedAt).IsModified = false;
            db.Entry(model).Property(m => m.CreatedBy).IsModified = false;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var model = db.Cards.FirstOrDefault(m => m.Id == id && m.DeletedBy == null);
            if (model == null)
            
                return Json(new
                {
                    error = true,
                    message = "Qeyd movcud deyil!"
                });
                db.Cards.Remove(model);
                db.SaveChanges();

            return Json(new
            {
                error = false,
                message = "Qeyd silindi!"
            });
        }
    }
}
