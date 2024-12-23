﻿namespace Courses.Core.models
{
    public enum EDayOfWeek
    {
        sunday = 1, monday = 2, tuesday = 3, wednesday = 4, thursday = 5
    }
    public class Course
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int MaxCount { get; set; }
        public int CurrentCount { get; set; }
        public EDayOfWeek Day { get; set; }
        public bool Status { get; set; }
        public int GuideId { get; set; }
        public List<Student> students { get; set; }
        public Guide guide { get; set; }

    }
}
