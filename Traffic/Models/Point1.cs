using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic.Models
{
    class Point1
    {
        public int id { get; set; }
        public int index { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public double elev { get; set; }
        public virtual ICollection<Segment> segment { get; set; }
    }
}
