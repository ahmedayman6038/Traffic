using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic.Models
{
    class Intersection
    {
        public int id { get; set; }
        public int direction { get; set; }
        public string streetName { get; set; }
        public int pointIndex { get; set; }
    }
}
