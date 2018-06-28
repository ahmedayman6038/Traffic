using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Traffic.DAL;
using Traffic.PL;

namespace Traffic
{
    public partial class MainForm : MetroForm
    {
        private TrafficContext db;
        public static MetroRadioButton connect;
        public MainForm()
        {
            InitializeComponent();
            connect = connected;
            db = TrafficDb.getConnection();
            if (TrafficDb.checkConnection())
            {
                connect.Checked = true;
            }
            else
            {
                connect.Checked = false;
            }
            operationLabel.Text = "";
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            AddStreetForm addStreetForm = new AddStreetForm();
            addStreetForm.Show();
        }
        

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }
    }
}
