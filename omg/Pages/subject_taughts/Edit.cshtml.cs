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

namespace omg.Pages.subject_taughts
{
    public class EditModel : PageModel
    {
        private readonly omg.Data.omgContext _context;

        public EditModel(omg.Data.omgContext context)
        {
            _context = context;
        }

        [BindProperty]
        public subject_taught subject_taught { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject_taught =  await _context.subject_taught.FirstOrDefaultAsync(m => m.Id == id);
            if (subject_taught == null)
            {
                return NotFound();
            }
            subject_taught = subject_taught;
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

            _context.Attach(subject_taught).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!subject_taughtExists(subject_taught.Id))
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

        private bool subject_taughtExists(int id)
        {
            return _context.subject_taught.Any(e => e.Id == id);
        }
    }
}
