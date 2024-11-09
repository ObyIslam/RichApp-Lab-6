using Microsoft.EntityFrameworkCore;
using Student_Class_Library;

namespace Student_MVC_App
{
    public class RazorDB : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public RazorDB(DbContextOptions<RazorDB> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Student>()
                .Property(s => s.Emailaddress)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Student>()
                .HasIndex(s => s.Emailaddress)
                .IsUnique();

            modelBuilder.Entity<Student>()
                .Property(s => s.Age)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Course>()
                .Property(c => c.DepartmentName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Course>()
                .Property(c => c.Lecturer)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
