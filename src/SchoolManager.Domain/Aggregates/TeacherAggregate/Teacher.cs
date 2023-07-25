using SchoolManager.Domain.Aggregates.CourseAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManager.Domain.Aggregates.TeacherAggregate
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}