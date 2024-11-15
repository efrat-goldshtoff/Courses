﻿namespace Courses.models
{
    public class DataContext
    {
        public List<Course> courses { get; set; }
        public List<Student> students { get; set; }
        public List<Guide> guiders { get; set; }

        public DataContext()
        {
            courses = new List<Course>();
            students = new List<Student> { new Student() { Id = 1, Name = "chani", CodeCourse = 4 } };
            guiders = new List<Guide>();
        }
    }
}
