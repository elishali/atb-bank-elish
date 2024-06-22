using Atbbank.WebUI.AppCode.Services;
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

            var cards = db.Cards.Where(x=>x.DeletedBy == null).ToList();
            var usefulcard = db.UsefulCards.Where(x => x.DeletedBy == null).ToList();
            var slider=db.Sliders.Where(x => x.DeletedBy == null).ToList();


            var viewModel = new IndexViewModel
            {
                cards = cards,
                UsefulCards = usefulcard,
                sliders=slider
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

