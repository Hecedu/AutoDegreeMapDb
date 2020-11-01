﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoDegreeMap.Models
{
    public class Degree
    {
        public int DegreeId { get; set; }
        public string Name { get; set; }
        public int RequiredCredits { get; set; }
        public List<Course> RequiredCourses { get; set; }
    }
}
