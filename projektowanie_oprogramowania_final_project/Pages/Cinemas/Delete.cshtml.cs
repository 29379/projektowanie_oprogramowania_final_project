using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using projektowanie_oprogramowania_final_project.Models;

namespace projektowanie_oprogramowania_final_project.Pages.Cinemas
{
    public class DeleteModel : PageModel
    {
        private readonly CinemaDbContext _context;

        public DeleteModel(CinemaDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cinema = await _context.Cinemas.FindAsync(id);

            if (Cinema != null)
            {
                _context.Cinemas.Remove(Cinema);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
