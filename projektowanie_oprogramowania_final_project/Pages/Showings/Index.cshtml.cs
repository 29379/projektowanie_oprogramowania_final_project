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
    
    public class IndexModel : PageModel
    {
        private readonly CinemaDbContext _context;

        public IndexModel(CinemaDbContext context)
        {
            _context = context;
        }

        public IList<Showing> Showing { get;set; }

        public async Task OnGetAsync(int? id)
        {
            ViewData["Cinemas"] = _context.Cinemas.ToList();
            Showing = await _context.Showings
                .Include(s => s.Cinema)
                .Include(s => s.Room)
                .Include(s => s.Film)
                .Where(s => s.CinemaId == id).ToListAsync();
        }
    }
}
