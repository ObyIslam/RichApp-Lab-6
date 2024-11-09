using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Class_Library;
using Student_MVC_App;

namespace Student_MVC_App.Pages.CoursePage
{
    public class DetailsModel : PageModel
    {
        private readonly Student_MVC_App.RazorDB _context;

        public DetailsModel(Student_MVC_App.RazorDB context)
        {
            _context = context;
        }

        public Course Course { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Load the course and its enrolled students
            Course = await _context.Courses
                .Include(c => c.Students)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
