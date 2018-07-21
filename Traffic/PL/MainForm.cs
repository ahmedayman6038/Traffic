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
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            panel.Width = this.Width;
            db = TrafficDb.getConnection();
            if (TrafficDb.checkConnection())
            {
                connected.Checked = true;
            }
            else
            {
                connected.Checked = false;
            }
            if(Properties.Settings.Default.Theme == "Dark")
            {
                this.Theme = MetroThemeStyle.Dark;
                AddStreet.Theme = MetroThemeStyle.Dark;
                UpdateStreet.Theme = MetroThemeStyle.Dark;
                Settings.Theme = MetroThemeStyle.Dark;
                connected.Theme = MetroThemeStyle.Dark;
                progress.Theme = MetroThemeStyle.Dark;
                operationLabel.Theme = MetroThemeStyle.Dark;

            }
            else
            {
                this.Theme = MetroThemeStyle.Light;
                AddStreet.Theme = MetroThemeStyle.Light;
                UpdateStreet.Theme = MetroThemeStyle.Light;
                Settings.Theme = MetroThemeStyle.Light;
                connected.Theme = MetroThemeStyle.Light;
                progress.Theme = MetroThemeStyle.Light;
                operationLabel.Theme = MetroThemeStyle.Light;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile3_Click(object sender, EventArgs e)
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
                AddStreetForm addStreetForm = new AddStreetForm();
                addStreetForm.Show();
            }
        }
        

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }

        private void progress_Click(object sender, EventArgs e)
        {

        }
    }
}
