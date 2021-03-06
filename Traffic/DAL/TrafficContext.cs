﻿using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traffic.Models;

namespace Traffic.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class TrafficContext : DbContext
    {
        public TrafficContext(string connectionString) : base(connectionString)
        {

        }
        public DbSet<Point1> points1 { get; set; }
        public DbSet<Point2> points2 { get; set; }
        public DbSet<Segment> segment { get; set; }
        public DbSet<Intersection> intersctions { get; set; }
        public DbSet<Street> streets { get; set; }
        public DbSet<TrafficBoard> trafficBoard { get; set; }
    }
}
