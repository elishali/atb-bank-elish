using Microsoft.AspNetCore.Mvc;

namespace Atbbank.WebUI.Controllers
{
    public class MortgagesController : Controller
    {
        public IActionResult Mortgage()
        {
            return View();
        }
        
        public IActionResult Good_mortage()
        {
            return View();
        }
        
        public IActionResult MIDA()
        {
            return View();
        }
        
        public IActionResult Rates()
        {
            return View();
        }


    }
}
