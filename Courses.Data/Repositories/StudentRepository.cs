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
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Student> GetList()
        {
            return _context.students.Include(s => s.Courses);
        }

        public Student GetById(int id)
        {
            return _context.students.First(s => s.Id == id);

            //foreach (var stud in _context.students)
            //{
            //    if (stud.Id == id)
            //    {
            //        return stud;
            //    }
            //}
            //return new Student();
        }

        public Student Add(Student stud)
        {
            _context.students.Add(stud);
            _context.SaveChanges();
            return stud;
        }

        public void Update(int id, Student stud)
        {
            Student s = GetById(id);
            if (s == null)
                return;
            else
            {
                s.Name = stud.Name;
                s.IsActive = stud.IsActive;
                s.Courses = new List<Course>();
                foreach (Course course in stud.Courses)
                {
                    s.Courses.Add(course);
                }
            }
            _context.SaveChanges();
        }

        public void UpdateStatus(int id, bool status)
        {
            Student s = GetById(id);
            if (s != null)
                s.IsActive = status;
            _context.SaveChanges();
        }

    }
}
