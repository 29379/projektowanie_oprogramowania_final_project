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

namespace projektowanie_oprogramowania_final_project.Pages.Seats
{
    [Authorize(Roles = "Admin, Employee")]
    public class IndexModel : PageModel
    {
        private readonly CinemaDbContext _context;

        public IndexModel(CinemaDbContext context)
        {
            _context = context;
        }

        public IList<Seat> Seat { get;set; }

        [BindProperty]
        public int cinema { get; set; }

        public async Task OnGetAsync(int? cinema_id, int? room_id)
        {
            ViewData["Cinemas"] = _context.Cinemas.ToList();
            ViewData["Rooms"] = _context.Rooms
                .Include(r => r.Cinema)
                .Where(r => r.CinemaId == cinema_id).ToList();

            Seat = await _context.Seats
                .Include(s => s.Room)
                .Include(s => s.Room.Cinema)
                .Where(s => s.Room.CinemaId == cinema_id)
                .Where(s => s.RoomId == room_id).ToListAsync();
        }
    }
}
