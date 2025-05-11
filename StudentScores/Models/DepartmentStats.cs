using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores.Models
{
    public class DepartmentStats
    {
        public string Department { get; set; }
        public int StudentCount { get; set; }
        public double AverageScore { get; set; }
        public int MinScore { get; set; }
        public int MaxScore { get; set; }
    }

}
