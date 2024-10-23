using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using omg.Data;
using omg.models;

namespace omg.Pages.assessments
{
    public class EditModel : PageModel
    {
        private readonly omg.Data.omgContext _context;

        public EditModel(omg.Data.omgContext context)
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

            var assessmentka =  await _context.assessmentka.FirstOrDefaultAsync(m => m.Id == id);
            if (assessmentka == null)
            {
                return NotFound();
            }
            assessmentka = assessmentka;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(assessmentka).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!assessmentkaExists(assessmentka.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool assessmentkaExists(int id)
        {
            return _context.assessmentka.Any(e => e.Id == id);
        }
    }
}
