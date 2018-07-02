using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            db = TrafficDb.getConnection();
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.Theme = MetroThemeStyle.Dark;
                lbl1.Theme = MetroThemeStyle.Dark;
                lbl2.Theme = MetroThemeStyle.Dark;
                lbl3.Theme = MetroThemeStyle.Dark;
                sname.Theme = MetroThemeStyle.Dark;
                sdir.Theme = MetroThemeStyle.Dark;
                addpoint.Theme = MetroThemeStyle.Dark;
                save.Theme = MetroThemeStyle.Dark;
                intersections.Theme = MetroThemeStyle.Dark;

            }
            else
            {
                this.Theme = MetroThemeStyle.Light;
                lbl1.Theme = MetroThemeStyle.Light;
                lbl2.Theme = MetroThemeStyle.Light;
                lbl3.Theme = MetroThemeStyle.Light;
                sname.Theme = MetroThemeStyle.Light;
                sdir.Theme = MetroThemeStyle.Light;
                addpoint.Theme = MetroThemeStyle.Light;
                save.Theme = MetroThemeStyle.Light;
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
            /////////////////////////Add Street in database/////////////////////////////
            Street st = new Street();
            st.streetName = sname.Text;
            string dir = sdir.Text;
            //Horizontal = 2
            //Vertical = 1
            if (dir.Equals("Horizontal"))
            {
                st.direction = 2;
            }
            else
            {
                st.direction = 1;
            }
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
            for (int rows = 0; rows < AddIntersectionForm.intersect.Count; rows++)
            {

                tempForIntersection.numberOfIntersection = AddIntersectionForm.intersect[rows].numberOfIntersection;
                tempForIntersection.pointIndex = AddIntersectionForm.intersect[rows].pointIndex;
                // tempForIntersection.caseOfIntersection = AddIntersectionForm.intersect[rows].caseOfIntersection;
                tempForIntersection.street = st;
                db.intersctions.Add(tempForIntersection);
                db.SaveChanges();
            }

            ////////////////////////Add Segments in database///////////////////////
            Segment tempSegment = new Segment();
            tempSegment.firstIntersection = 0;
            tempSegment.secondIntersection = AddIntersectionForm.intersect[0].pointIndex;
            for (int point = 1, intersect = 1; point <= AddPointsProgressForm.listOfPoint1.Count(); point++)  //from first point to last point in the same street
            {
                if (point == tempSegment.secondIntersection && intersect < AddIntersectionForm.intersect.Count)
                {
                    tempSegment.firstIntersection = tempSegment.secondIntersection;
                    tempSegment.secondIntersection = AddIntersectionForm.intersect[intersect++].pointIndex;
                }
                else if (point == tempSegment.secondIntersection)
                {
                    tempSegment.firstIntersection = AddIntersectionForm.intersect[--intersect].pointIndex;
                    tempSegment.secondIntersection = 0;
                }
                tempSegment.street = st;
                tempSegment.point1 = AddPointsProgressForm.listOfPoint1[point - 1];
                tempSegment.point2 = AddPointsProgressForm.listOfPoint2[point - 1];
                db.segment.Add(tempSegment);
                db.SaveChanges();
            }
            db.SaveChanges();
            AddIntersectionForm.intersect.RemoveRange(0, AddIntersectionForm.intersect.Count);
            AddPointsProgressForm.listOfPoint1.RemoveRange(0, AddPointsProgressForm.listOfPoint1.Count);
            AddPointsProgressForm.listOfPoint2.RemoveRange(0, AddPointsProgressForm.listOfPoint2.Count);


            this.Close();

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
    }
}
