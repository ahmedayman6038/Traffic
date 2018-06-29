using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic.Models
{
    public class Intersection
    {
        public int id { get; set; }
        public int numberOfIntersection { get; set; }
        public int pointIndex { get; set; }
        public int case1 { get; set; }
        public int case2 { get; set; }
        public int case3 { get; set; }
        public double delayTime1 { get; set; }
        public double delayTime2 { get; set; }
        public double delayTime3 { get; set; }
        public int? streetId { get; set; }
        public virtual Street street { get; set; }
    }
}
