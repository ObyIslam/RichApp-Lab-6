namespace Student_Class_Library
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Emailaddress { get; set; }
        public List<Course> Courses { get; set; } // students have one to many relationships with courses

 
        public Student(string name, int age, string emailaddress)
        {
            Name = name;
            Age = age;
            Emailaddress = emailaddress;
            Courses = new List<Course>(); 
        }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public string Lecturer { get; set; }
        public List<Student> Students { get; set; } // courses have one to many relationships with students


        public Course(string name, string departmentName, string lecturer)
        {
            Name = name;
            DepartmentName = departmentName;
            Lecturer = lecturer;
            Students = new List<Student>(); 
        }
    }
}
