using SchoolManager.Domain.Aggregates.CourseAggregate;
using SchoolManager.Domain.Aggregates.TeacherAggregate.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManager.Domain.Aggregates.TeacherAggregate
{
    public sealed class Teacher
    {
        public TeacherId Id { get; private set; }
        public string Name { get; private set; }

        private Teacher(string name)
        {
            Name = name;

        }

        public static Teacher Create(string name)
        {
            return new Teacher(name);

        }
        private Teacher()
        {

        }
    }
}