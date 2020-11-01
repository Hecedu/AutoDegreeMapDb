using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoDegreeMap.Models
{
    public class ApplicationDbContext  : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseInstance> CourseInstances { get; set; }
        public DbSet<SemesterPlan> SemesterPlans { get; set; }
        public DbSet<Degree> Degrees { get; set; }
    }
}
