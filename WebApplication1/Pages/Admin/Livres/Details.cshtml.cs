using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.Admin.Livres
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly WebApplication1.Data.DataContext _context;

        public DetailsModel(WebApplication1.Data.DataContext context)
        {
            _context = context;
        }

        public Livre Livre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Livre = await _context.Livres.FirstOrDefaultAsync(m => m.LivreID == id);

            if (Livre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
