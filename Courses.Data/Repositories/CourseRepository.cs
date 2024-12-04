using Courses.Core.models;
using Courses.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Data.Repositories
{
    public class CourseRepository:ICourseRepository
    {
        private readonly DataContext _context;
        public CourseRepository(DataContext context)
        {
            _context = context;
        }
        public List<Course> GetList()
        {
            return _context.courses;
        }
    }
}
