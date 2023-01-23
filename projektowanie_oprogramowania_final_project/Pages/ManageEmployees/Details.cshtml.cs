using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace projektowanie_oprogramowania_final_project.Pages.ManageEmployees
{
    [Authorize(Roles = "Admin")]
    public class DetailsModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public DetailsModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IdentityUser MyUser { get; set; }
        public string Role { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MyUser = await _userManager.FindByIdAsync(id);
            if (MyUser == null)
            {
                return NotFound();
            }
            else
            {
                _ = await _userManager.IsInRoleAsync(MyUser, "Employee") ? Role = "Employee" : Role = " - ";
            }

            return Page();
        }
    }
}
