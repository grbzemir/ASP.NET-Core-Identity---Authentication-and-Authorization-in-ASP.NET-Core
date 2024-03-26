using ASP.NET_Core_Identity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Core_Identity.Pages.Shared
{
    public class LoginModel : PageModel
    {

        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {

            this.signInManager = signInManager;
            this.userManager = userManager;
            
        }
        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {

            if (ModelState.IsValid)
            {

                var IdentityResult = await signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, lockoutOnFailure: false);
                 
                if(IdentityResult.Succeeded)

                {

                    if(returnUrl == null || returnUrl == "/")
                    {
                        return RedirectToPage("/Index");
                    }

                    else

                    {

                        return RedirectToPage(returnUrl);
                    }


                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }

            return Page();
        }


    }
}
