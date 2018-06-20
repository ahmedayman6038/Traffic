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
using MetroFramework.Forms;
using Traffic.Models;

namespace Traffic
{
    public partial class MainForm : MetroForm
    {
        private TrafficContext db;
        public MainForm()
        {
            InitializeComponent();
            db = new TrafficContext();
            Point1 point = new Point1();
            point.index = 1;
            point.lat = 15.66555;
            point.lon = -455.5554;
            point.elev = 66;
            db.points1.Add(point);
            db.SaveChanges();
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "c:\\";
            file.Filter = "Xml files (*.xml)|*.xml";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            DialogResult result = file.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    XmlDocument xmldoc = new XmlDocument();
                    XmlNodeList xmlnode;
                    int i = 0;
                    string str = null;
                    FileStream fs = new FileStream(file.FileName, FileMode.Open, FileAccess.Read);
                    xmldoc.Load(fs);
                    xmlnode = xmldoc.GetElementsByTagName("wpt");
                    for (i = 0; i <= xmlnode.Count - 1; i++)
                    {
                        xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                        str = xmlnode[i].Attributes["lon"].Value + "  " + xmlnode[i].Attributes["lat"].Value + "  " + xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                        MessageBox.Show(str);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }
        }
        

        private void metroTile2_Click(object sender, EventArgs e)
        {
            DisplayForm displayForm = new DisplayForm();
            displayForm.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }
    }
}
