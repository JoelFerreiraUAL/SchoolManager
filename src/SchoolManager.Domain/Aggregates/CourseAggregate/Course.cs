using SchoolManager.Domain.Aggregates.CourseAggregate.ValueObjects;
using SchoolManager.Domain.Aggregates.TeacherAggregate;
using SchoolManager.Domain.Aggregates.TeacherAggregate.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManager.Domain.Aggregates.CourseAggregate
{
    public sealed class Course
    {
        private List<TeacherId> _teacherIds = new();
        public CourseId Id { get; private set; }
        public string Name { get; private set; }
        public IReadOnlyList<TeacherId> TeacherIds => _teacherIds.AsReadOnly();

        private Course(string name, List<TeacherId>? teacherIds = null)
        {
            Name = name;
            _teacherIds = teacherIds ?? new();

        }
        public static Course Create(string name, List<TeacherId>? teacherIds = null)
        {
            return new Course(name, teacherIds);

        }
    }
}