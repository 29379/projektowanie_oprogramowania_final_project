using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projektowanie_oprogramowania_final_project;
using projektowanie_oprogramowania_final_project.Models;

namespace projektowanie_oprogramowania_final_project.Pages.Showings
{
    [Authorize(Roles = "Admin, Employee")]
    public class EditModel : PageModel
    {
        private readonly CinemaDbContext _context;

        public EditModel(CinemaDbContext context)
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
           ViewData["CinemaId"] = new SelectList(_context.Cinemas, "CinemaId", "Street");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Showing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShowingExists(Showing.ShowingId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ShowingExists(int id)
        {
            return _context.Showings.Any(e => e.ShowingId == id);
        }
    }
}
