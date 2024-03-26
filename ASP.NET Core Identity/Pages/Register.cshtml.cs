using ASP.NET_Core_Identity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Core_Identity.Pages
{
    public class RegisterModel : PageModel
    {

        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]

        public Register Model { get; set; }

        public RegisterModel(UserManager<IdentityUser> userManager , SignInManager<IdentityUser> signInManager)

        {

            this.userManager = userManager;
            this.signInManager = signInManager;

          
        }
        public void OnGet()
        {


        }

        public async Task<IActionResult> OnPostAsync()


        {


            if(ModelState.IsValid)

            {

                var user = new IdentityUser()

                {
    
                        UserName = Model.Email,
    
                        Email = Model.Email
    
                    };

                var result = await userManager.CreateAsync(user, Model.Password);

                if(result.Succeeded)

                {

                    await signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToPage("/Index");

                }

                foreach(var error in result.Errors)

                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

            }


            return Page();
            //if (ModelState.IsValid)
            //{
            //    var user = new IdentityUser { UserName = Model.Email, Email = Model.Email };
            //    var result = await userManager.CreateAsync(user, Model.Password);
            //    if (result.Succeeded)
            //    {
            //        await signInManager.SignInAsync(user, isPersistent: false);
            //        return RedirectToPage("/Index");
            //    }
            //    foreach (var error in result.Errors)
            //    {
            //        ModelState.AddModelError(string.Empty, error.Description);
            //    }
            //}
            //return Page();  


        }
    }
}
