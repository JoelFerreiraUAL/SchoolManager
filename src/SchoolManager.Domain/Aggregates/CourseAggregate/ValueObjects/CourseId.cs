using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManager.Domain.Common.Models;

namespace SchoolManager.Domain.Aggregates.CourseAggregate.ValueObjects
{
    public sealed class CourseId : ValueObject
    {
        public int Value { get; private set; }
        private CourseId(int value)
        {
            Value = value;

        }
        public override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Value;
        }
        public static CourseId Create(int value)
        {
            return new CourseId(value);

        }
        private CourseId()
        {

        }
    }
}