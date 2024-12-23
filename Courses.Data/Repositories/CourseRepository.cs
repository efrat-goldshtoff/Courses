using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Core.models;
using Courses.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Courses.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _context;
        public CourseRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetList()
        {
            return _context.courses.Include(c=>c.guide);
        }

        public Course GetById(int id)
        {
            return _context.courses.Include(c=>c.guide).First(c=>c.Id== id);
            //foreach (var course in _context.courses)
            //{
            //    if (course.Id == id)
            //    {
            //        return course;
            //    }
            //}
            //return new Course();
        }

        public Course Add(Course course)
        {
            _context.courses.Add(course);
            _context.SaveChanges();
            return course;
        }

        public void Update(int id, Course course)
        {
            Course c = GetById(id);
            if (c == null)
                return;
            else
            {
                c.Subject = course.Subject;
                c.Day = course.Day;
                c.guide = new Guide();
                c.guide.Id = course.guide.Id;
                c.guide.Name= course.guide.Name;
                c.guide.Courses = new List<Course>();
                foreach (Course item in course.guide.Courses)
                {
                    c.guide.Courses.Add(item);
                }
                c.MaxCount = course.MaxCount;
                c.CurrentCount = course.CurrentCount;
            }
            _context.SaveChanges();
        }

        public void UpdateStatus(int id, bool status)
        {
            Course c = GetById(id);
            if (c != null)
                c.Status = status;
            _context.SaveChanges();
        }
    }
}
