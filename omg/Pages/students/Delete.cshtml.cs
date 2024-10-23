using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using omg.Data;
using omg.models;

namespace omg.Pages.students
{
    public class DeleteModel : PageModel
    {
        private readonly omg.Data.omgContext _context;

        public DeleteModel(omg.Data.omgContext context)
        {
            _context = context;
        }

        [BindProperty]
        public student student { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.student.FirstOrDefaultAsync(m => m.Id == id);

            if (student == null)
            {
                return NotFound();
            }
            else
            {
                student = student;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.student.FindAsync(id);
            if (student != null)
            {
                student = student;
                _context.student.Remove(student);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
