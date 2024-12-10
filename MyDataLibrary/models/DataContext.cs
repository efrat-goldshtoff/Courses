
using Courses.Core;

namespace Courses.models
{
    public class DataContext : IDataContext
    {
        public List<Core.models.Course> courses { get; set; }
        public List<Core.models.Student> students { get; set; }
        public List<Core.models.Guide> guiders { get; set; }
       
        public DataContext()
        {
            courses = new List<Core.models.Course>();
            students = new List<Core.models.Student> {
                new Core.models.Student() { Id = 1, Name = "chani", CodeCourse = 4 }
            };
            guiders =  new List<Core.models.Guide>();
        }
    }
}
