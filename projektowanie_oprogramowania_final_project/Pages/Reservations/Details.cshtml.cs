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

namespace projektowanie_oprogramowania_final_project.Pages.Reservations
{
    public class DetailsModel : PageModel
    {
        private readonly CinemaDbContext _context;

        public DetailsModel(CinemaDbContext context)
        {
            _context = context;
        }

        public Reservation Reservation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reservation = await _context.Reservations.Include(r => r.User).FirstOrDefaultAsync(m => m.ReservationId == id);
            ViewData["ReservationSeats"] = _context.ReservationSeats.Include(s => s.Seat).Where(r => r.ReservationId == id);

            if (Reservation == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
