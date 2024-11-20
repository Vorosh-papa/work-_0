using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Work4.Data;
using Work4.Models;

namespace Work4.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Work4.Data.BookContext _context;

        public IndexModel(Work4.Data.BookContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
