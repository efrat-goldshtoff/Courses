using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Core.models;
using Courses.Core.Repositories;

namespace Courses.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _context;
        public CourseRepository(DataContext context)
        {
            _context = context;
        }
        public List<Course> GetList()
        {
            return _context.courses.ToList();
        }

        public Course GetById(int id)
        {
            foreach (var course in _context.courses)
            {
                if (course.Id == id)
                {
                    return course;
                }
            }
            return null;
        }

        public void Add(Course course)
        {
            _context.courses.Add(course);
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
                c.GuideId = course.GuideId;
                c.MaxCount = course.MaxCount;
                c.CurrentCount = course.CurrentCount;
            }
        }

        public void UpdateStatus(int id, bool status)
        {
            Course c = GetById(id);
            if (c != null)
                c.Status = status;
        }
    }
}
