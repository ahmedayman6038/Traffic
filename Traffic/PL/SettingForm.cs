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

namespace Traffic
{
    public partial class SettingForm : MetroForm
    {
        public SettingForm()
        {
            InitializeComponent();
            sname.Text = Properties.Settings.Default.ServerName;
            dname.Text = Properties.Settings.Default.DatabaseName;
            pnumber.Text = Properties.Settings.Default.PortNumber;
            uname.Text = Properties.Settings.Default.UserName;
            password.Text = Properties.Settings.Default.Password;
            string themeValue = Properties.Settings.Default.Theme;
            if (themeValue == "Light")
            {
                theme.SelectedIndex = 0;
            }
            else
            {
                theme.SelectedIndex = 1;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerName = sname.Text;
            Properties.Settings.Default.DatabaseName = dname.Text;
            Properties.Settings.Default.PortNumber = pnumber.Text;
            Properties.Settings.Default.UserName = uname.Text;
            Properties.Settings.Default.Password = password.Text;
            Properties.Settings.Default.Theme = theme.Text;
            Properties.Settings.Default.Save();
            DialogResult dr = MetroMessageBox.Show(this, "Setting Saved Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(dr == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
