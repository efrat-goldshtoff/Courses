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
        List<Course> GetList();
    }
}
