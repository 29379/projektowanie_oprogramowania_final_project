using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using projektowanie_oprogramowania_final_project;
using projektowanie_oprogramowania_final_project.Models;

namespace projektowanie_oprogramowania_final_project.Pages.Films
{
    [Authorize(Roles = "Admin, Employee")]
    public class DeleteModel : PageModel
    {
        private readonly CinemaDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public DeleteModel(CinemaDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        [BindProperty]
        public Film Film { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Film = await _context.Films
                .FirstOrDefaultAsync(m => m.FilmId == id);

            if (Film == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Film = await _context.Films.FindAsync(id);

            if (Film != null)
            {
                if (Film.FilePath != null)
                {
                    string folder = Path.Combine(_hostingEnvironment.WebRootPath, "upload");
                    string filePath = Path.Combine(folder, Film.FilePath);
                    Film.FilePath = null;
                    if (System.IO.File.Exists(filePath))
                    {
                        FileInfo fi = new(filePath);
                        if (fi != null)
                        {
                            System.IO.File.Delete(filePath);
                            fi.Delete();
                        }
                    }
                }
                _context.Films.Remove(Film);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}
