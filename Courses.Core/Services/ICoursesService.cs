using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Core.models;

namespace Courses.Core.Services
{
    public interface ICoursesService
    {
        public List<Course> GetList();
        public Course GetById(int id);
        public void Add(Course course);
        public void Update(int id, Course course);
        public void UpdateStatus(int id, bool status);
    }
}
