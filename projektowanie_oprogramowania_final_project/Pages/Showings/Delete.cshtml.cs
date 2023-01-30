using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using projektowanie_oprogramowania_final_project;
using projektowanie_oprogramowania_final_project.Models;

namespace projektowanie_oprogramowania_final_project.Pages.Showings
{
    [Authorize(Roles = "Admin")]
    public class DeleteModel : PageModel
    {
        private readonly CinemaDbContext _context;

        public DeleteModel(CinemaDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Showing Showing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Showing = await _context.Showings
                .Include(s => s.Cinema).FirstOrDefaultAsync(m => m.ShowingId == id);

            if (Showing == null)
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

            Showing = await _context.Showings.FindAsync(id);

            if (Showing != null)
            {
                _context.Showings.Remove(Showing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
