using Student_Class_Library;

namespace Student_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDbContext myDbContext = new MyDbContext();

            Student student1 = new Student("Bob", 19, "bobthebuilder@gmail.com");
            Student student2 = new Student("Jerry", 20, "jerrythegoat@gmail.com");
            Student student3 = new Student("Jeremiah", 19, "jeremiah12@gmail.com");

            myDbContext.AddRange(student1, student2, student3);

            Course course1 = new Course("Computer Science", "Computer Building", "JamesDevers");
            Course course2 = new Course("Buisness Studies", "Buisness Building", "IgorKups");

            myDbContext.AddRange(course1, course2);

            myDbContext.SaveChanges();
        }
    }
}
