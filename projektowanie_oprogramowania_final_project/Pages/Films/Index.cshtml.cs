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

namespace projektowanie_oprogramowania_final_project.Pages.Films
{
    public class IndexModel : PageModel
    {
        private readonly CinemaDbContext _context;

        public IndexModel(CinemaDbContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; }

        public async Task OnGetAsync()
        {
            Film = await _context.Films
                .OrderBy(f => f.Title)
                .ToListAsync();
        }
    }
}
