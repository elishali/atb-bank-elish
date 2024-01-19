using Atbbank.WebUI.Models.Entities;
using Atbbank.WebUI.Models.Persistences;
using Microsoft.AspNetCore.Mvc;

namespace Atbbank.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;

        public HomeController(DataContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var cards = db.Cards.ToList();
            var usefulcard = db.UsefulCards.ToList();
            var slider=db.Sliders.ToList();


            var viewModel = new IndexViewModel
            {
                cards = cards,
                UsefulCards = usefulcard,
                slider=slider,
            };
            return View(viewModel);



        }


        public IActionResult Business()
        {
            return View();
        }

        public IActionResult Kob()
        {
            return View();
        }
    }
}

