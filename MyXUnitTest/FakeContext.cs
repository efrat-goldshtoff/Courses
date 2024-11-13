using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.models;

namespace MyXUnitTest
{
    internal class FakeContext
    {
        public List<Course> courses { get; set; }
        public List<Student> students { get; set; }
        public List<Guide> guiders { get; set; }

        public FakeContext()
        {
            courses = new List<Course>();
            students = new List<Student> { new Student() { Id = 1, Name = "chani", CodeCourse = 4 } };
            guiders = new List<Guide>();
        }
    }
}
