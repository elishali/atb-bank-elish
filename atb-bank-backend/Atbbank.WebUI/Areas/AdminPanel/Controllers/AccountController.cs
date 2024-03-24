using Atbbank.WebUI.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Atbbank.WebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated) return RedirectToAction("Index", "Home");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginVm model)
        {
            if(User.Identity.IsAuthenticated) RedirectToAction("Index", "Home");
            var user = await _userManager.FindByNameAsync(model.UserName);
            var result = await _signInManager
                .PasswordSignInAsync(user, model.Password, false, false);
            if(result.Succeeded) return RedirectToAction("Index", "Home");
            return View();
        }
    }
}
