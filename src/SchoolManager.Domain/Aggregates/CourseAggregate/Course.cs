using SchoolManager.Domain.Aggregates.TeacherAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManager.Domain.Aggregates.CourseAggregate
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Teacher>? Teachers { get; set; }
    }
}