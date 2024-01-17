using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RIGProjeck.Class;

namespace RIGProjeck.Pages
{
    public class RegisterModel : PageModel
    {
        
            [BindProperty]
            public string Email { get; set; }

            [BindProperty]
            public string Username { get; set; }

            [BindProperty]
            public string Password { get; set; }
        
        User user = new User();
            public void OnGet()
        {
        }
        public void Register()
        {
            user.Register(Username,Password,Email);
        }
    }
}
