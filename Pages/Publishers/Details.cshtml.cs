﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sut_Iulia_Lab2.Data;
using Sut_Iulia_Lab2.Models;

namespace Sut_Iulia_Lab2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Sut_Iulia_Lab2.Data.Sut_Iulia_Lab2Context _context;

        public DetailsModel(Sut_Iulia_Lab2.Data.Sut_Iulia_Lab2Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
