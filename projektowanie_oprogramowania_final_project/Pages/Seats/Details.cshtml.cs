using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using projektowanie_oprogramowania_final_project;
using projektowanie_oprogramowania_final_project.Models;

namespace projektowanie_oprogramowania_final_project.Pages.Seats
{
    public class DetailsModel : PageModel
    {
        private readonly projektowanie_oprogramowania_final_project.CinemaDbContext _context;

        public DetailsModel(projektowanie_oprogramowania_final_project.CinemaDbContext context)
        {
            _context = context;
        }

        public Seat Seat { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seat = await _context.Seats
                .Include(s => s.Room).FirstOrDefaultAsync(m => m.SeatId == id);

            if (Seat == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
