using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sut_Iulia_Lab2.Data;
using Sut_Iulia_Lab2.Models;

namespace Sut_Iulia_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Sut_Iulia_Lab2.Data.Sut_Iulia_Lab2Context _context;

        public IndexModel(Sut_Iulia_Lab2.Data.Sut_Iulia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; } = default!;

       
        public IList<Book> Books { get; set; } = new List<Book>();
        public int? SelectedCategoryId { get; set; }

        public async Task OnGetAsync(int? categoryId)
        {
            
            Category = await _context.Category.ToListAsync();

            if (categoryId != null)
            {
                SelectedCategoryId = categoryId;

                Books = await _context.BookCategories
                    .Where(bc => bc.CategoryID == categoryId)
                    .Include(bc => bc.Book)
                        .ThenInclude(b => b.Author)
                    .Select(bc => bc.Book)
                    .ToListAsync();
            }
        }
    }
}
