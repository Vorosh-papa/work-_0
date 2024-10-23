using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using omg.Data;
using omg.models;

namespace omg.Pages.groups
{
    public class DetailsModel : PageModel
    {
        private readonly omg.Data.omgContext _context;

        public DetailsModel(omg.Data.omgContext context)
        {
            _context = context;
        }

        public group group { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var group = await _context.group.FirstOrDefaultAsync(m => m.Id == id);
            if (group == null)
            {
                return NotFound();
            }
            else
            {
                group = group;
            }
            return Page();
        }
    }
}
