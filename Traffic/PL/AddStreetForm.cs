﻿using System;
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
                addsigns.Theme = MetroThemeStyle.Dark;
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
            for (int rows = 0; rows < intersections.Rows.Count - 1; rows++)
            {
                tempForIntersection.numberOfIntersection = rows;
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
            ////////////////////////Add Segments in database///////////////////////
            Segment tempSegment = new Segment();
            int first_intersection = Int32.Parse(intersections.Rows[0].Cells[0].Value.ToString());
            int last_intersection = Int32.Parse(intersections.Rows[intersections.Rows.Count-2].Cells[0].Value.ToString());
            tempSegment.firstIntersection = first_intersection;
            tempSegment.secondIntersection = Int32.Parse(intersections.Rows[1].Cells[0].Value.ToString());
            for (int point = first_intersection, intersect = 1;point <intersections.Rows.Count-1 ; point++)  //from first intersection to last intersection in the same street
            {
                if (point == tempSegment.secondIntersection && intersect < intersections.Rows.Count - 1)
                {
                    tempSegment.firstIntersection = tempSegment.secondIntersection;
                    tempSegment.secondIntersection = Int32.Parse(intersections.Rows[intersect++].Cells[0].Value.ToString());
                }
                if (point == tempSegment.secondIntersection)
                {
                    db.SaveChanges();
                    break;
                }
                tempSegment.street = st;
                tempSegment.point1 = AddPointsProgressForm.listOfPoint1[point - 1];
                tempSegment.point2 = AddPointsProgressForm.listOfPoint2[point - 1];
                db.segment.Add(tempSegment);
                db.SaveChanges();
               
            }
           
            db.SaveChanges();
            AddPointsProgressForm.listOfPoint1.RemoveRange(0, AddPointsProgressForm.listOfPoint1.Count);
            AddPointsProgressForm.listOfPoint2.RemoveRange(0, AddPointsProgressForm.listOfPoint2.Count);

            this.Close();
        }

        private void intersections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
