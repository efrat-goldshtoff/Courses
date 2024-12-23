namespace Courses.Core.models
{
    public class Guide
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public List<Course> Courses { get; set; }
    }
}
