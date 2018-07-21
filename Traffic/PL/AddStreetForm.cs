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

        private void metroTile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Allowed Extension|*.xml;*.gpx";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            DialogResult result = file.ShowDialog();
            if (result == DialogResult.OK)
            {
                AddPointsProgressForm addPointsProgressForm = new AddPointsProgressForm(file.FileName);
                addPointsProgressForm.Show();
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
           

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void addsigns_Click(object sender, EventArgs e)
        {
            AddSignsForm addSignsForm = new AddSignsForm();
            addSignsForm.Show();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

            /////////////////////////Add Street in database/////////////////////////////
            Street st = new Street();
            st.streetName = sname.Text;
            st.direction = Int32.Parse(sdir.Text);
            db.streets.Add(st);
            db.SaveChanges();

            ////////////////////////Add points in database///////////////////////
            for (int rows = 0; rows < AddPointsProgressForm.listOfPoint1.Count; rows++)
            {
                AddPointsProgressForm.listOfPoint1[rows].street = st;
                AddPointsProgressForm.listOfPoint2[rows].street = st;
                db.points1.Add(AddPointsProgressForm.listOfPoint1[rows]);
                db.points2.Add(AddPointsProgressForm.listOfPoint2[rows]);
                db.SaveChanges();
            }

            ////////////////////////Add Intersections in database///////////////////////
            Intersection tempForIntersection = new Intersection();
            for (int rows = 0; rows < intersections.Rows.Count - 1; rows++)
            {
                tempForIntersection.numberOfIntersection = rows+1;
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
<<<<<<< HEAD
            for (int point = Int32.Parse(intersections.Rows[0].Cells[0].Value.ToString()), intersect = 1; point < intersections.Rows.Count - 1; point++)  //from first point to last point in the same street
=======
            for (int point = first_intersection, intersect =1; ; point++)  //from first intersection to last intersection in the same street
>>>>>>> 5177bae9b6dcda642745045c7f0d13555d51cf42
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
                tempSegment.point1 = AddPointsProgressForm.listOfPoint1[point - 1];
                tempSegment.point2 = AddPointsProgressForm.listOfPoint2[point - 1];
                db.segment.Add(tempSegment);
                db.SaveChanges();

            }
<<<<<<< HEAD

=======
            ////////////////////////Add TrafficBoard in database///////////////////////
            TrafficBoard tempTrafficBoard = new TrafficBoard();
            for (int row = 0; row < AddSignsForm.boards.Count; row++)
            {
                tempTrafficBoard.street = st;
                tempTrafficBoard.boardNumber = AddSignsForm.boards[row].boardNumber;
                tempTrafficBoard.point1 = AddPointsProgressForm.listOfPoint1[Int32.Parse(AddSignsForm.boards[row].point1.name) - 1];
                tempTrafficBoard.point2 = AddPointsProgressForm.listOfPoint2[Int32.Parse(AddSignsForm.boards[row].point2.name) - 1];
                db.trafficBoard.Add(tempTrafficBoard);
                db.SaveChanges();
            }
>>>>>>> 5177bae9b6dcda642745045c7f0d13555d51cf42
            db.SaveChanges();
            AddSignsForm.boards.RemoveRange(0, AddSignsForm.boards.Count);
            AddPointsProgressForm.listOfPoint1.RemoveRange(0, AddPointsProgressForm.listOfPoint1.Count);
            AddPointsProgressForm.listOfPoint2.RemoveRange(0, AddPointsProgressForm.listOfPoint2.Count);

            this.Close();
        }

        private void intersections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {

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
            map.Position = new PointLatLng(37.31917, -122.04511);

            //zoom min/max; default both = 2
            map.MinZoom = 1;
            map.MaxZoom = 20;
            //set zoom
            map.Zoom = 15;
            var point = new PointLatLng(37.31917, -122.04511);
            GMapMarker mapMarker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
            var point2 = new PointLatLng(37.36764, -122.16986);
            GMapMarker mapMarker2 = new GMarkerGoogle(point2, GMarkerGoogleType.red_dot);
            var point3 = new PointLatLng(37.37138, -122.14286);
            GMapMarker mapMarker3 = new GMarkerGoogle(point3, GMarkerGoogleType.red_dot);
            GMapOverlay mapOverlay = new GMapOverlay("marker");
            mapOverlay.Markers.Add(mapMarker);
            mapOverlay.Markers.Add(mapMarker2);

            mapOverlay.Markers.Add(mapMarker3);

            map.Overlays.Add(mapOverlay);
        }
    }
}
