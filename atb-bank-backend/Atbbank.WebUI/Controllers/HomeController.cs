using Microsoft.AspNetCore.Mvc;

namespace Atbbank.WebUI.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
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
