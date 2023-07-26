using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManager.Domain.Common.Models;

namespace SchoolManager.Domain.Aggregates.StudentAggregate.ValueObjects
{
    public class StudentId : ValueObject
    {
        public int Value { get; private set; }
        private StudentId(int value)
        {
            Value = value;

        }
        public static StudentId Create(int value)
        {
            return new StudentId(value);

        }
        private StudentId()
        {

        }
        public override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}