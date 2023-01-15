﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using projektowanie_oprogramowania_final_project.Models;

namespace projektowanie_oprogramowania_final_project.Pages.Cinemas
{
    public class IndexModel : PageModel
    {
        private readonly CinemaDbContext _context;

        public IndexModel(CinemaDbContext context)
        {
            _context = context;
        }

        public IList<Cinema> Cinema { get;set; }

        public async Task OnGetAsync()
        {
            Cinema = await _context.Cinemas.ToListAsync();
        }
    }
}
