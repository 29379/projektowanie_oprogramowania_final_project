using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using projektowanie_oprogramowania_final_project;
using projektowanie_oprogramowania_final_project.Models;

namespace projektowanie_oprogramowania_final_project.Pages.Seats
{
    public class CreateModel : PageModel
    {
        private readonly projektowanie_oprogramowania_final_project.CinemaDbContext _context;

        public CreateModel(projektowanie_oprogramowania_final_project.CinemaDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["RoomId"] = new SelectList(_context.Rooms, "RoomId", "RoomId");
            return Page();
        }

        [BindProperty]
        public Seat Seat { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Seats.Add(Seat);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
