using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MetroFramework;
using MetroFramework.Forms;
using Traffic.DAL;
using Traffic.Models;
namespace Traffic.PL
{
    public partial class AddStreetForm : MetroForm 
    {
        private TrafficContext db;
        public AddStreetForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            db = TrafficDb.getConnection();
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.Theme = MetroThemeStyle.Dark;
                lbl1.Theme = MetroThemeStyle.Dark;
                lbl2.Theme = MetroThemeStyle.Dark;
                sname.Theme = MetroThemeStyle.Dark;
                sdir.Theme = MetroThemeStyle.Dark;
                save.Theme = MetroThemeStyle.Dark;
                addsigns.Theme = MetroThemeStyle.Dark;
                intersections.Theme = MetroThemeStyle.Dark;

            }
            else
            {
                this.Theme = MetroThemeStyle.Light;
                lbl1.Theme = MetroThemeStyle.Light;
                lbl2.Theme = MetroThemeStyle.Light;
                sname.Theme = MetroThemeStyle.Light;
                sdir.Theme = MetroThemeStyle.Light;
                save.Theme = MetroThemeStyle.Light;
                addsigns.Theme = MetroThemeStyle.Light;
                intersections.Theme = MetroThemeStyle.Light;
            }
        }


        /**
         * Add Sign Form
         * */
        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            AddSignsForm addSignsForm = new AddSignsForm();
            addSignsForm.Show(this);
        }

        private void map_Load(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Left;

            //use google provider
            map.MapProvider = GoogleMapProvider.Instance;
            //get tiles from server only
            map.Manager.Mode = AccessMode.ServerOnly;
            //not use proxy
            GMapProvider.WebProxy = null;
            //center map on moscow
            double initial_lat = AddPointsProgressForm.AllPoints[0].lat;
            double initial_lon = AddPointsProgressForm.AllPoints[0].lon;
            map.Position = new PointLatLng(initial_lat, initial_lon);

            //zoom min/max; default both = 2
            map.MinZoom = 1;
            map.MaxZoom = 20;
            //set zoom
            map.Zoom = 15;
            GMapOverlay mapOverlay = new GMapOverlay("marker");
            for (int i=0;i<AddPointsProgressForm.AllPoints.Count;i++)
            {
                double temp_lat = AddPointsProgressForm.AllPoints[i].lat;
                double temp_lon = AddPointsProgressForm.AllPoints[i].lon;
                var point = new PointLatLng(temp_lat, temp_lon);
                GMapMarker mapMarker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                mapOverlay.Markers.Add(mapMarker);
            }
            map.Overlays.Add(mapOverlay);
        }

        /**
         * Save Street Data
         * */
        private void save_Click(object sender, EventArgs e)
        {
            /////////////////////////Add Street in database/////////////////////////////
            Street st = new Street();
            st.streetName = sname.Text;
            st.direction = Int32.Parse(sdir.Text);
            db.streets.Add(st);
            db.SaveChanges();

            ////////////////////////Add points in database///////////////////////
             List<Point1> listOfPoint1 = new List<Point1>();
             List<Point2> listOfPoint2 = new List<Point2>();
            for (int rows = 0; rows < AddPointsProgressForm.AllPoints.Count-1; rows++)
            {
                AddPointsProgressForm.AllPoints[rows].street = st;
                db.points1.Add(AddPointsProgressForm.AllPoints[rows]);
                listOfPoint1.Add(AddPointsProgressForm.AllPoints[rows]);
                db.SaveChanges();
            }
            
            for (int rows = 1; rows < AddPointsProgressForm.AllPoints.Count; rows++)
            {
                AddPointsProgressForm.AllPoints[rows].street = st;
                Point2 point2 = new Point2();
                point2.id= AddPointsProgressForm.AllPoints[rows].id;
                point2.lat= AddPointsProgressForm.AllPoints[rows].lat;
                point2.lon= AddPointsProgressForm.AllPoints[rows].lon;
                point2.name= AddPointsProgressForm.AllPoints[rows].name;
                point2.elev = AddPointsProgressForm.AllPoints[rows].elev;
                db.points2.Add(point2);
                listOfPoint2.Add(point2);
                db.SaveChanges();
            }

            ////////////////////////Add Intersections in database///////////////////////
            Intersection tempForIntersection = new Intersection();
            for (int rows = 0; rows < intersections.Rows.Count - 1; rows++)
            {
                tempForIntersection.numberOfIntersection = rows + 1;
                tempForIntersection.pointIndex = Int32.Parse(intersections.Rows[rows].Cells[0].Value.ToString());
                tempForIntersection.case1 = Int32.Parse(intersections.Rows[rows].Cells[1].Value.ToString());
                tempForIntersection.case2 = Int32.Parse(intersections.Rows[rows].Cells[2].Value.ToString());
                tempForIntersection.case3 = Int32.Parse(intersections.Rows[rows].Cells[3].Value.ToString());
                tempForIntersection.delayTime1 = Int32.Parse(intersections.Rows[rows].Cells[4].Value.ToString());
                tempForIntersection.delayTime2 = Int32.Parse(intersections.Rows[rows].Cells[5].Value.ToString());
                tempForIntersection.delayTime3 = Int32.Parse(intersections.Rows[rows].Cells[6].Value.ToString());
                tempForIntersection.street = st;
                db.intersctions.Add(tempForIntersection);
                db.SaveChanges();
            }

            ////////////////////////Add Segments in database///////////////////////
            Segment tempSegment = new Segment();
            int first_intersection = Int32.Parse(intersections.Rows[0].Cells[0].Value.ToString());
            int last_intersection = Int32.Parse(intersections.Rows[intersections.Rows.Count - 2].Cells[0].Value.ToString());
            tempSegment.firstIntersection = first_intersection;
            tempSegment.secondIntersection = Int32.Parse(intersections.Rows[1].Cells[0].Value.ToString());
            for (int point = first_intersection, intersect = 1; ; point++)  //from first intersection to last intersection in the same street
            {
                if (point == tempSegment.secondIntersection)
                {
                    tempSegment.firstIntersection = tempSegment.secondIntersection;
                    if (tempSegment.firstIntersection == last_intersection)
                    {
                        db.SaveChanges();
                        break;
                    }
                    tempSegment.secondIntersection = Int32.Parse(intersections.Rows[++intersect].Cells[0].Value.ToString());
                }

                tempSegment.street = st;
                tempSegment.point1 = listOfPoint1[point - 1];
                tempSegment.point2 = listOfPoint2[point - 1];
                db.segment.Add(tempSegment);
                db.SaveChanges();

            }

            ////////////////////////Add TrafficBoard in database///////////////////////
            TrafficBoard tempTrafficBoard = new TrafficBoard();
            for (int row = 0; row < AddSignsForm.boards.Count; row++)
            {
                tempTrafficBoard.street = st;
                tempTrafficBoard.boardNumber = AddSignsForm.boards[row].boardNumber;
                tempTrafficBoard.point1 = listOfPoint1[Int32.Parse(AddSignsForm.boards[row].point1.name) - 1];
                tempTrafficBoard.point2 = listOfPoint2[Int32.Parse(AddSignsForm.boards[row].point2.name) - 1];
                db.trafficBoard.Add(tempTrafficBoard);
                db.SaveChanges();
            }
            db.SaveChanges();
            AddSignsForm.boards.RemoveRange(0, AddSignsForm.boards.Count);
            listOfPoint1.RemoveRange(0,listOfPoint1.Count);
            listOfPoint2.RemoveRange(0,listOfPoint2.Count);

            this.Close();
        }
    }
}
