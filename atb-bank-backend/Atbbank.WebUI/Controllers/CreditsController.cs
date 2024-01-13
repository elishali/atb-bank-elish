using Microsoft.AspNetCore.Mvc;

namespace Atbbank.WebUI.Controllers
{
    public class CreditsController : Controller
    {
        public IActionResult Consumption_credit()
        {
            return View();
        }

        public IActionResult Atb_card_credit()
        {
            return View();
        }

        public IActionResult Deposit_credit()
        {
            return View();
        }

        public IActionResult Rates()
        {
            return View();
        }

        public IActionResult Credit_and_card_payment()
        {
            return View();
        }
    }
}
