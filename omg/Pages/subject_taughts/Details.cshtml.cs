using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using omg.Data;
using omg.models;

namespace omg.Pages.subject_taughts
{
    public class DetailsModel : PageModel
    {
        private readonly omg.Data.omgContext _context;

        public DetailsModel(omg.Data.omgContext context)
        {
            _context = context;
        }

        public subject_taught subject_taught { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject_taught = await _context.subject_taught.FirstOrDefaultAsync(m => m.Id == id);
            if (subject_taught == null)
            {
                return NotFound();
            }
            else
            {
                subject_taught = subject_taught;
            }
            return Page();
        }
    }
}
