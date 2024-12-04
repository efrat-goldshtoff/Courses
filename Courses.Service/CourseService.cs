using Courses.Core.models;
using Courses.Core.Repositories;
using Courses.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Service
{
    public class CourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public List<Course> GetAll()
        {
            return _courseRepository.GetList();
        }
    }
}
