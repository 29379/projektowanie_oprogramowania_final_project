using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace projektowanie_oprogramowania_final_project.Pages.Contact
{
    [Authorize]
    public class CreateModel : PageModel
    {

        public class InputModel
        {
            [Required]
            [StringLength(50, ErrorMessage = "Max length of the message title is 50 characters")]
            public string Title { get; set; }

            [Required]
            [StringLength(1000, ErrorMessage = "Max length of the message is 1000 characters")]
            public string Message { get; set; }

        }

   
        public CreateModel(){ }

        public IdentityUser MyUser;
        [BindProperty]
        public InputModel Input { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPostAsync()
        {
            return RedirectToPage("Home");
        }

    }
}
