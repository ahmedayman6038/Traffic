using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic.Models
{
    class Street
    {
        public int id { get; set; }
        public string streetName { get; set; }
        public int direction { get; set; }
        public virtual ICollection<Segment> segment { get; set; }
        public virtual ICollection<Intersection> intersection { get; set; }
    }
}
