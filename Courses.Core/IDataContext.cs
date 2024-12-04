using Courses.Core.models;

namespace Courses.Core
{
    public interface IDataContext
    {
        List<Course> courses { get; set; }
        List<Student> students { get; set; }
        List<Guide> guiders { get; set; }
    }
}
