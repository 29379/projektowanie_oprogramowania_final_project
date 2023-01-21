using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using projektowanie_oprogramowania_final_project.Models;

namespace projektowanie_oprogramowania_final_project.Pages.Cinemas
{
    [Authorize(Roles = "Admin, Employee")]
    public class DetailsModel : PageModel
    {
        private readonly CinemaDbContext _context;

        public DetailsModel(CinemaDbContext context)
        {
            _context = context;
        }

        public Cinema Cinema { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cinema = await _context.Cinemas.FirstOrDefaultAsync(m => m.CinemaId == id);

            if (Cinema == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
