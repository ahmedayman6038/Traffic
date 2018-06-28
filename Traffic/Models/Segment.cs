using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic.Models
{
    public class Segment
    {
        public int id { get; set; }
        public int firstIntersection { get; set; }
        public int secondIntersection { get; set; }
        public int? point1Id { get; set; }
        public int? point2Id { get; set; }
        public int? streetId { get; set; }
        public virtual Street street { get; set; }
        public virtual Point1 point1 { get; set; }
        public virtual Point2 point2 { get; set; }
    }
}
