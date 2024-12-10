using Courses.Core.models;
using Microsoft.EntityFrameworkCore;

namespace Courses.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Guide> guiders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=my_db");
        }

        //public DataContext()
        //{
        //    courses = new List<Course>();
        //    students = new List<Student> { new Student() { Id = 1, Name = "chani", CodeCourse = 4 } };
        //    guiders = new List<Guide>();
        //}
    }
}
