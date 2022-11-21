﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stoica_Denisa_Lab2.Data;
using Stoica_Denisa_Lab2.Models;

namespace Stoica_Denisa_Lab2.Pages.Publishers
{
    [Authorize(Roles = "Admin")]
    public class DetailsModel : PageModel
    {
        private readonly Stoica_Denisa_Lab2.Data.Stoica_Denisa_Lab2Context _context;

        public DetailsModel(Stoica_Denisa_Lab2.Data.Stoica_Denisa_Lab2Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
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
