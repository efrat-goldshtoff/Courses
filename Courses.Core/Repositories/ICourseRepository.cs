using Courses.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Core.Repositories
{
    public interface ICourseRepository
    {
        public IEnumerable<Course> GetList();
        public Course GetById(int id);
        public Course Add(Course course);
        public void Update(int id, Course course);
        public void UpdateStatus(int id, bool status);
    }
}
