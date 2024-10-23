﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using omg.Data;
using omg.models;

namespace omg.Pages.students
{
    public class CreateModel : PageModel
    {
        private readonly omg.Data.omgContext _context;

        public CreateModel(omg.Data.omgContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public student student { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.student.Add(student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}