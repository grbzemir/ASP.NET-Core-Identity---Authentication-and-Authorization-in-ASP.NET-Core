using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Core_Identity.Pages
{
    public class LogautModel : PageModel
    {

        private readonly SignInManager<IdentityUser> signInManager;

        public LogautModel(SignInManager<IdentityUser> signInManager)
        {

            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }

        public IActionResult OnPostDontLogutPostAsync()
        {
            
            return RedirectToPage("/Index");
        }


    }
}
