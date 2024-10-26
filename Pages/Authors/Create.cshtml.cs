﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sut_Iulia_Lab2.Data;
using Sut_Iulia_Lab2.Models;

namespace Sut_Iulia_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Sut_Iulia_Lab2.Data.Sut_Iulia_Lab2Context _context;

        public CreateModel(Sut_Iulia_Lab2.Data.Sut_Iulia_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

            return Page();
            
        }
        
        [BindProperty]
        public Author Author { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Authors.Add(Author);
            await _context.SaveChangesAsync();
           
            return RedirectToPage("./Index");
        }
    }
}
