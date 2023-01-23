using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace projektowanie_oprogramowania_final_project.Pages.ManageAccounts
{
    [Authorize(Roles = "Admin")]

    public class DeleteModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public DeleteModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public IdentityUser MyUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyUser = await _userManager.FindByIdAsync(id);

            if (MyUser== null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyUser = await _userManager.FindByIdAsync(id);
 
            if (MyUser != null)
            {
                var result = await _userManager.DeleteAsync(MyUser);
                var userId = await _userManager.GetUserIdAsync(MyUser);
                if (!result.Succeeded)
                {
                    throw new InvalidOperationException($"Unexpected error occurred deleting user with ID '{userId}'.");
                }

                return RedirectToPage("./Index");
            }
            return RedirectToPage("./Index");
        }
    }
}
