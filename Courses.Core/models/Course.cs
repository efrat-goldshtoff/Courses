namespace Courses.Core.models
{
    public enum EDayOfWeek
    {
        sunday = 2, monday = 4, tuesday = 8, wednesday = 16, thursday = 32
    }
    public class Course
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int GuideId { get; set; }
        public int MaxCount { get; set; }
        public int CurrentCount { get; set; }
        public EDayOfWeek Day { get; set; }
        public bool Status { get; set; }
    }
}
