using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Core.models;
using Courses.Core.Repositories;
using Courses.Core.Services;

namespace Courses.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _courseRepository;
        public StudentService(IStudentRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }



        public List<Student> GetList()
        {
            return _courseRepository.GetList();
        }

        public Student GetById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public void Add(Student student)
        {
            _courseRepository.Add(student);
        }

        public void Update(int id, Student student)
        {
            _courseRepository.Update(id, student);
        }

        public void UpdateStatus(int id, bool status)
        {
            _courseRepository.UpdateStatus(id, status);
        }
    }
}
