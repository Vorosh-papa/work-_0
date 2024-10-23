using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using omg.Data;
using omg.models;

namespace omg.Pages.teachers
{
    public class DeleteModel : PageModel
    {
        private readonly omg.Data.omgContext _context;

        public DeleteModel(omg.Data.omgContext context)
        {
            _context = context;
        }

        [BindProperty]
        public teacher teacher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.teacher.FirstOrDefaultAsync(m => m.Id == id);

            if (teacher == null)
            {
                return NotFound();
            }
            else
            {
                teacher = teacher;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.teacher.FindAsync(id);
            if (teacher != null)
            {
                teacher = teacher;
                _context.teacher.Remove(teacher);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
