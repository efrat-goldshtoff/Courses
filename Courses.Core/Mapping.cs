using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Core.DTOs;
using Courses.Core.models;

namespace Courses.Core
{
    public class Mapping
    {
        public CourseDto MapToCourseDto(Course value)
        {
            return new CourseDto
            {
                Id = value.Id,
                Subject = value.Subject,
                CurrentCount = value.CurrentCount,
                MaxCount = value.MaxCount,
                GuideId = value.GuideId,
                Day = value.Day
            };
        }
        public GuideDto MapToGuideDto(Guide value)
        {
            return new GuideDto
            {
                Id = value.Id,
                Name = value.Name,
                IsActive = value.IsActive
            };
        }
        public StudentDto MapToStudentDto(Student value)
        {
            return new StudentDto
            {
                Id = value.Id,
                Name = value.Name,
                IsActive = value.IsActive
            };
        }

    }
}
