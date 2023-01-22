using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using projektowanie_oprogramowania_final_project;
using projektowanie_oprogramowania_final_project.Models;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace projektowanie_oprogramowania_final_project.Pages.Showings
{
    [Authorize(Roles = "Admin, Employee")]
    public class CreateModel : PageModel
    {
        private readonly CinemaDbContext _context;

        public CreateModel(CinemaDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CinemaId"] = new SelectList(_context.Cinemas, "CinemaId", "Street");
            ViewData["FilmId"] = new SelectList(_context.Films, "FilmId", "Title");
            ViewData["Rooms"] = new SelectList(_context.Rooms, "RoomId", "RoomNumber");
            return Page();
        }

        [BindProperty]
        public Showing Showing { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Showings.Add(Showing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
