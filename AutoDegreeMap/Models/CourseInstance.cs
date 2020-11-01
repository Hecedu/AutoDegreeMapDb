using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoDegreeMap.Models
{
    public class CourseInstance
    {
        public string CourseInstanceID { get; set; }

        //Parent course data
        public Course Course { get; set; }

        public string Semester { get; set; }
        public string Teacher { get; set; }
    }
}
