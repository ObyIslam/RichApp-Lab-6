using Student_Class_Library;

namespace Student_MVC_App
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<RazorDB>();

            if (context == null || context.Students == null || context.Courses == null)
            {
                throw new ArgumentNullException("Null RazorDB context or DbSet");
            }

            if (context.Students.Any() || context.Courses.Any())
            {
                return;   // DB has already been seeded
            }

            var student1 = new Student("Igor Kups", 20, "Igorkups24@gmail.com");
            var student2 = new Student("Alice Johnson", 22, "alice.johnson@example.com");

 
            var course1 = new Course("Programming", "Computing", "Oby Islam");
            var course2 = new Course("Data Structures", "Computer Science", "John Smith");




            student1.Courses.Add(course1);
            student1.Courses.Add(course2);
            student2.Courses.Add(course2);
            context.Students.AddRange(student1, student2);
            context.Courses.AddRange(course1, course2);

            context.SaveChanges();
        }
    }
}
