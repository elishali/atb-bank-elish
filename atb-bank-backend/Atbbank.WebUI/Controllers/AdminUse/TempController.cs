using Atbbank.WebUI.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Atbbank.WebUI.Controllers.AdminUse
{
    public class TempController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _usermanager;

        public TempController(RoleManager<IdentityRole> roleManager,UserManager<AppUser>usermanager)
        {
            _roleManager = roleManager;
            _usermanager = usermanager;
        }
        public async Task<IActionResult> Index()
        {
            
            return Ok();
        }
        //public async Task<IActionResult> Index()
        //{
        //    await _roleManager.CreateAsync(new IdentityRole("Admin"));
        //    await _roleManager.CreateAsync(new IdentityRole("User"));


        //    var user = new AppUser
        //    {
        //        Name = "Elish",
        //        SurName = "Ali",
        //        Email = "elnarama@gmail.com",
        //        UserName = "elnarama@gmail.com"
        //    };
        //    await _usermanager.CreateAsync(user, "Salam@1235!");

        //    await _usermanager.AddToRoleAsync(user, "Admin");
        //    return Ok();
        //}
    }
}
