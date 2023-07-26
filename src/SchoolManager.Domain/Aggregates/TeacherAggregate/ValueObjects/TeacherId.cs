using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManager.Domain.Common.Models;

namespace SchoolManager.Domain.Aggregates.TeacherAggregate.ValueObjects
{
    public class TeacherId : ValueObject
    {
        public int Value { get; private set; }

        private TeacherId(int value)
        {
            Value = value;

        }
        public static TeacherId Create(int value)
        {
            return new TeacherId(value);

        }

        public override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}