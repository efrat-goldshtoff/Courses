using Courses.Core.models;
using Courses.Core.Repositories;
using Courses.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Service
{
    public class CourseService : ICoursesService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public List<Course> GetList()
        {
            return _courseRepository.GetList();
        }
        public Course GetById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public void Add(Course course)
        {
            _courseRepository.Add(course);
        }

        public void Update(int id, Course course)
        {
            _courseRepository.Update(id, course);
        }

        public void UpdateStatus(int id, bool status)
        {
            _courseRepository.UpdateStatus(id, status);
        }
    }
}
