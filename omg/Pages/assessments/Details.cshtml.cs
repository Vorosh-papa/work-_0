using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using omg.Data;
using omg.models;

namespace omg.Pages.assessments
{
    public class DetailsModel : PageModel
    {
        private readonly omg.Data.omgContext _context;

        public DetailsModel(omg.Data.omgContext context)
        {
            _context = context;
        }

        public assessmentka assessmentka { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assessmentka = await _context.assessmentka.FirstOrDefaultAsync(m => m.Id == id);
            if (assessmentka == null)
            {
                return NotFound();
            }
            else
            {
                assessmentka = assessmentka;
            }
            return Page();
        }
    }
}
