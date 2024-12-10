
using Courses.Core.models;

namespace Courses
{
    public interface IDataContext
    {
        List<Course> courses { get; set; }
        List<Student> students { get; set; }
        List<Guide> guiders { get; set; }
    }
}
