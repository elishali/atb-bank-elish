using Microsoft.AspNetCore.Mvc;

namespace Atbbank.WebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class UsefulCardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
