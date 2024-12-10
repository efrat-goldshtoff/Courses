using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Core.models;
using Courses.Core.Repositories;

namespace Courses.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }
        public List<Student> GetList()
        {
            return _context.students;
        }

        public Student GetById(int id)
        {
            foreach (var stud in _context.students)
            {
                if (stud.Id == id)
                {
                    return stud;
                }
            }
            return null;
        }

        public void Add(Student stud)
        {
            _context.students.Add(stud);
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
                s.CodeCourse = stud.CodeCourse;
            }
        }

        public void UpdateStatus(int id, bool status)
        {
            Student s = GetById(id);
            if (s != null)
                s.IsActive = status;
        }


    }
}
