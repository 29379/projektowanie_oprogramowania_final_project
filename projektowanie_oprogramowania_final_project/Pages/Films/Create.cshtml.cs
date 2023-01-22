using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using projektowanie_oprogramowania_final_project.Models;


namespace projektowanie_oprogramowania_final_project.Pages.Films
{
    [Authorize(Roles = "Admin, Employee")]
    public class CreateModel : PageModel
    {
        private readonly CinemaDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CreateModel(CinemaDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Film Film { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Film.Image != null)
            {
                string fileName = Guid.NewGuid().ToString() + "_" + Film.Image.FileName + ".jpg";
                string uploadFolder = Path.Combine(this._hostingEnvironment.WebRootPath, "upload");
                string imgPath = Path.Combine(uploadFolder, fileName);
                FileStream fs = new FileStream(imgPath, FileMode.CreateNew);
                Film.Image.CopyTo(fs);
                fs.Close();
                Film.ImagePath = Path.Combine("upload", fileName);
                
            }
            //Film.ImagePath = "beatka";

            _context.Films.Add(Film);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
