using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoDegreeMap.Models
{
    public class SemesterPlan
    {
        public int SemesterPlanId { get; set; }

        public List<Course> Courses { get; set; }
    }
}
