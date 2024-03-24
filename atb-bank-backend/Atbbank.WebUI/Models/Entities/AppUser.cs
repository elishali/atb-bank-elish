using Microsoft.AspNetCore.Identity;

namespace Atbbank.WebUI.Models.Entities
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
