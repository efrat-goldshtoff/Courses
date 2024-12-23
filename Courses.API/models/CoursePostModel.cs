using Courses.Core.models;

namespace Courses.API.models
{
    public class CoursePostModel
    {
        //public int Id { get; set; }
        public string Subject { get; set; }
        public int MaxCount { get; set; }
        public int CurrentCount { get; set; }
        public EDayOfWeek Day { get; set; }
        //public bool Status { get; set; }
        public int GuideId { get; set; }
        //public List<Student> students { get; set; }
        //public Guide guide { get; set; }

    }
}
