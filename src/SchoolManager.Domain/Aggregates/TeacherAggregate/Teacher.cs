using SchoolManager.Domain.Aggregates.CourseAggregate;
using SchoolManager.Domain.Aggregates.TeacherAggregate.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManager.Domain.Aggregates.TeacherAggregate
{
    public class Teacher
    {
        public TeacherId Id { get; private set; }
        public string Name { get; private set; }
        public Teacher(string name)
        {
            Name = name;

        }
    }
}