using Microsoft.AspNetCore.Mvc;

namespace Atbbank.WebUI.Controllers
{
    public class DepositsController : Controller
    {
        public IActionResult Classic_deposit()
        {
            return View();
        }
                public IActionResult Rates()
        {
            return View();
        }

    }
}
