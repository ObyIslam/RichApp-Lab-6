using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Class_Library;
using Student_MVC_App;

namespace Student_MVC_App.Pages.StudentPage
{
    public class DetailsModel : PageModel
    {
        private readonly Student_MVC_App.RazorDB _context;

        public DetailsModel(Student_MVC_App.RazorDB context)
        {
            _context = context;
        }

        public Student Student { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students
                .Include(s => s.Courses) // Include related Courses
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Student == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
