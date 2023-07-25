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
        public StudentId(int value)
        {
            Value = value;

        }
        public override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}