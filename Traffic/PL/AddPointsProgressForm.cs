using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MetroFramework;
using MetroFramework.Forms;
using Traffic.Models;
using Traffic.DAL;

namespace Traffic.PL
{
    public partial class AddPointsProgressForm : MetroForm
    {
        private string fileName;
        public static List<Point1> listOfPoint1 = new List<Point1>();
        public static List<Point2> listOfPoint2 = new List<Point2>();

        public AddPointsProgressForm(string file)
        {
            InitializeComponent();
            fileName = file;
            this.Text = "Adding Points";
        }

        private void AddPointsProgressForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddPointsProgressForm_Shown(object sender, EventArgs e)
        {
            Reading:
            try
            {
                progress.Value = 0;
                operationLabel.Text = "Reading Data...";
                operationLabel.Refresh();
                XmlDocument xmldoc = new XmlDocument();
                XmlNodeList xmlnode;
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                double lon, lat, elev;
                string name;
                Point1 pc1 = null;
                Point2 pc2 = null;
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("wpt");
                int records = xmlnode.Count;
                progress.Maximum = records;
                //bool ignore = false;
                for (int i = 0; i < records; i++)
                {
                    lon = Double.Parse(xmlnode[i].Attributes["lon"].Value);
                    lat = Double.Parse(xmlnode[i].Attributes["lat"].Value);
                    elev = Double.Parse(xmlnode[i].ChildNodes.Item(0).InnerText.Trim());
                    name = String.Format("{0}-{1:d4}", xmlnode[i].ChildNodes.Item(1).InnerText.Trim().ToString(), (DateTime.Now.Ticks / 10) % 10000);
                    pc1 = db.points1.Where(p => p.lon == lon && p.lat == lat).FirstOrDefault();
                    if (i == records - 1)
                    {
                        pc2 = db.points2.Where(p => p.lon == lon && p.lat == lat).FirstOrDefault();
                    }
                    if (pc1 != null || pc2 != null)
                    {
                        //if (!ignore)
                        //{
                        //    DialogResult dr = MetroMessageBox.Show(this, "This point exist before, Do you want to ignore all the exist points? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //    if (dr == DialogResult.Yes)
                        //    {
                        //        ignore = true;
                        //    }
                        //}
                        progress.Value += 1;
                        progress.Refresh();
                        operationLabel.Text = "Ignored Record " + (i + 1).ToString() + "...";
                        operationLabel.Refresh();
                        continue;
                    }
                    Point1 point1 = new Point1();
                    point1.lon = lon;
                    point1.lat = lat;
                    point1.elev = elev;
                    point1.name = name;
                    Point2 point2 = new Point2();
                    point2.lon = lon;
                    point2.lat = lat;
                    point2.elev = elev;
                    point2.name = name;
                    if (i == 0)
                    {
                        listOfPoint1.Add(point1);
                    }
                    else if (i == records - 1)
                    {
                        listOfPoint2.Add(point2);
                    } 
                    else
                    {
                        listOfPoint1.Add(point1);
                        listOfPoint2.Add(point2);
                    }
                    
                    progress.Value += 1;
                    progress.Refresh();
                    operationLabel.Text = "Adding Record " + (i + 1).ToString() + "...";
                    operationLabel.Refresh();
                }
                operationLabel.Text = "Done.";
                operationLabel.Refresh();
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroMessageBox.Show(this, "Some errors has occuered during processing the file. Original error: " + ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.Retry)
                {
                    goto Reading;
                }
                if (dr == DialogResult.Cancel)
                {
                    progress.Value = 0;
                    operationLabel.Text = "";
                }
            }
            this.Close();
        }

        private void operationLabel_Click(object sender, EventArgs e)
        {

        }

        private void progress_Click(object sender, EventArgs e)
        {

        }
    }
}
