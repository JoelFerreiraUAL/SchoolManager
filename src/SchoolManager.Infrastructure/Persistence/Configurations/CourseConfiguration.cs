using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManager.Domain.Aggregates.CourseAggregate;
using SchoolManager.Domain.Aggregates.CourseAggregate.ValueObjects;

namespace SchoolManager.Infrastructure.Persistence.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasConversion(id => id.Value, value => CourseId.Create(value)).ValueGeneratedOnAdd();
            builder.OwnsMany(c => c.TeacherIds, tib =>
                {
                    tib.WithOwner().HasForeignKey("CourseId");

                    tib.ToTable("CourseTeacherIds");

                    tib.HasKey("Id");

                    tib.Property(mi => mi.Value).ValueGeneratedNever().HasColumnName("CourseTeacherId");
                });

        }
    }
}