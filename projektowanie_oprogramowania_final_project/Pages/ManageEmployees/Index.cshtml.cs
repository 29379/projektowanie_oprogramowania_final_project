using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace projektowanie_oprogramowania_final_project.Areas.Identity.Pages.Account.ManageEmployees
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public IList<IdentityUser> Users { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Users = await _userManager.GetUsersInRoleAsync("Employee");
            if (Users == null)
            {
                return NotFound("There are no employees registered in the system");
            }
            return Page();
        }
    }
}
