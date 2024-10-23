﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly omg.Data.omgContext _context;

        public IndexModel(omg.Data.omgContext context)
        {
            _context = context;
        }

        public IList<student> student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            student = await _context.student.ToListAsync();
        }
    }
}