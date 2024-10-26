﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sut_Iulia_Lab2.Data;
using Sut_Iulia_Lab2.Models;

namespace Sut_Iulia_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Sut_Iulia_Lab2.Data.Sut_Iulia_Lab2Context _context;

        public IndexModel(Sut_Iulia_Lab2.Data.Sut_Iulia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Authors { get;set; } = new List<Author>();

        public async Task OnGetAsync()
        {
            
             Authors = await _context.Authors.ToListAsync();
           
        }
    }
}
