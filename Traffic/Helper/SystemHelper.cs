using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traffic.Models;

namespace Traffic.Helper
{
    class SystemHelper
    {
        private TrafficContext db;

        public SystemHelper()
        {
            db = new TrafficContext();
        }
    }
}
