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
    public class DeleteModel : PageModel
    {
        private readonly omg.Data.omgContext _context;

        public DeleteModel(omg.Data.omgContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assessmentka = await _context.assessmentka.FindAsync(id);
            if (assessmentka != null)
            {
                assessmentka = assessmentka;
                _context.assessmentka.Remove(assessmentka);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
