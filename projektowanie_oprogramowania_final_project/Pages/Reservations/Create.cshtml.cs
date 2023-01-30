using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using projektowanie_oprogramowania_final_project;
using projektowanie_oprogramowania_final_project.Models;

namespace projektowanie_oprogramowania_final_project.Pages.Reservations
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly CinemaDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<IdentityUser> _userManager;

        public CreateModel(CinemaDbContext context, IWebHostEnvironment hostEnvironment, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;

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

            //rezerwacje na ten showing:
            var reservations = _context.Reservations.Where(r => r.ShowingId == id).ToList();

            //zajete miejsca na ten showing:
            List<Seat> reservedSeats = new();
            foreach(Reservation res in reservations)
            {
                var resSeats = _context.ReservationSeats.Where(r => r.ReservationId == res.ReservationId).Include(r => r.Seat).Select(r => r.Seat).ToList();
                reservedSeats.AddRange(resSeats);
            }

            var test = reservedSeats.Select(x => x.SeatId).ToList();

            //wszystkie miejsca na sali:
            var seats = _context.Seats.Where(s => s.RoomId == room)
                .AsQueryable();


            ViewData["SeatId"] = new SelectList(seats.Where(s => !test.Contains(s.SeatId)).OrderBy(s => s.Row), "SeatId", null);
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

            Reservation.ReservationSeats = new List<ReservationSeat>();
            for (int i = 0; i < SelectedAnswers.Count; i++)
            {
                Seat seat = _context.Seats.Where(s => s.SeatId == SelectedAnswers[i]).First();
                ReservationSeat seat2 = new ReservationSeat(Reservation.ReservationId, seat.SeatId);
                _context.ReservationSeats.Add(seat2);
                Reservation.ReservationSeats.Add(seat2);
            }

            ClaimsPrincipal currentUser = this.User;
            var currentUserName = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            Reservation.User = await _userManager.GetUserAsync(HttpContext.User);
            Reservation.UserId = Reservation.User.Id;

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
