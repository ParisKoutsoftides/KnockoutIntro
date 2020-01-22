using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KnockoutIntro;
using KnockoutIntro.Models;

namespace KnockoutIntro.Views.Author
{
    public class IndexModel : PageModel
    {
        private readonly KnockoutIntro.BookContext _context;

        public IndexModel(KnockoutIntro.BookContext context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; }

        public async Task OnGetAsync()
        {
            Author = await _context.Authors.ToListAsync();
        }
    }
}
