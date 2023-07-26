using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManager.Domain.Aggregates.CourseAggregate;
using SchoolManager.Domain.Aggregates.StudentAggregate;
using SchoolManager.Domain.Aggregates.TeacherAggregate;

namespace SchoolManager.Infrastructure.Persistence
{
    public class SchoolManagerDbContext : DbContext
    {
        public SchoolManagerDbContext(DbContextOptions<SchoolManagerDbContext> options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SchoolManagerDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}