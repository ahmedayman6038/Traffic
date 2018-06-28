using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic.Models
{
    public class Point1
    {
        public int id { get; set; }
     //   public int numberOfStreet { get; set; }
        public string name { get; set; }
        [Index("LOCATION_1", 1, IsUnique = true)]
        public double lon { get; set; }
        [Index("LOCATION_1", 2, IsUnique = true)]
        public double lat { get; set; }
        public double elev { get; set; }
        public int? streetId { get; set; }
        public virtual ICollection<Segment> segment { get; set; }
        public virtual Street street { get; set; }
    }
}
