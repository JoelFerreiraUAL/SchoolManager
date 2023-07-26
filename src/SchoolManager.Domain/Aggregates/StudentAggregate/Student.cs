using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManager.Domain.Aggregates.StudentAggregate.ValueObjects;

namespace SchoolManager.Domain.Aggregates.StudentAggregate
{
    public sealed class Student
    {
        public StudentId Id { get; private set; }
        public string Name { get; private set; }

        private Student(string name)
        {
            Name = name;

        }
        public static Student Create(string name)
        {
            return new Student(name);

        }
        private Student()
        {

        }
    }
}