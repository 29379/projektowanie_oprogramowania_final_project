using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projektowanie_oprogramowania_final_project;
using projektowanie_oprogramowania_final_project.Models;

namespace projektowanie_oprogramowania_final_project.Pages.Reservations
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly CinemaDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public CreateModel(CinemaDbContext context, IWebHostEnvironment hostEnvironment)
        {
            
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult OnGet(int? id)
        {
            var room = _context.Showings
                        .Include(s => s.Room)
                        .Where(s => s.ShowingId == id)
                        .Select(s => s.RoomId)
                        .First();

            var showing = _context.Showings.Include(s => s.Film).Where(s => s.ShowingId == id).First();
            ViewData["Showing"] = showing;
            ViewData["ShowingId"] = showing.ShowingId;
            ViewData["SeatId"] = new SelectList(_context.Seats.Where(s => s.RoomId == room), "SeatId", null);
            return Page();
        }

        [BindProperty]
        public Reservation Reservation { get; set; }

        [BindProperty]
        public List<int> SelectedAnswers { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Reservation.Seats = new List<Seat>();
            for (int i = 0; i < SelectedAnswers.Count; i++)
            {
                Seat seat = _context.Seats.Where(s => s.SeatId == SelectedAnswers[i]).First();
                Reservation.Seats.Add(seat);
            }
            _context.Reservations.Add(Reservation);
            await _context.SaveChangesAsync();
            if (User.IsInRole("Admin") || User.IsInRole("Employee"))
            {
                return RedirectToPage("./Index");
            }
            else
            {
                return RedirectToPage("./Details", new { id = Reservation.ReservationId });
            }
            
        }

        public IActionResult OnGetPrice(int showing_id, int tickets)
        {
            var price = _context.Showings.Where(s => s.ShowingId == showing_id).First().Price * tickets;
            return new JsonResult(price);
        }

    }
}
