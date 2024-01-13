using Microsoft.AspNetCore.Mvc;

namespace Atbbank.WebUI.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Bank_information()
        {
            return View();
        }
    }
}
