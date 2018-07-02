using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Traffic.DAL;

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
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.Theme = MetroThemeStyle.Dark;
                lbl1.Theme = MetroThemeStyle.Dark;
                lbl2.Theme = MetroThemeStyle.Dark;
                lbl3.Theme = MetroThemeStyle.Dark;
                lbl4.Theme = MetroThemeStyle.Dark;
                lbl5.Theme = MetroThemeStyle.Dark;
                lbl6.Theme = MetroThemeStyle.Dark;
                lbl7.Theme = MetroThemeStyle.Dark;
                lbl8.Theme = MetroThemeStyle.Dark;
                sname.Theme = MetroThemeStyle.Dark;
                dname.Theme = MetroThemeStyle.Dark;
                pnumber.Theme = MetroThemeStyle.Dark;
                uname.Theme = MetroThemeStyle.Dark;
                password.Theme = MetroThemeStyle.Dark;
                theme.Theme = MetroThemeStyle.Dark;
                save.Theme = MetroThemeStyle.Dark;
                cancel.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                this.Theme = MetroThemeStyle.Light;
                lbl1.Theme = MetroThemeStyle.Light;
                lbl2.Theme = MetroThemeStyle.Light;
                lbl3.Theme = MetroThemeStyle.Light;
                lbl4.Theme = MetroThemeStyle.Light;
                lbl5.Theme = MetroThemeStyle.Light;
                lbl6.Theme = MetroThemeStyle.Light;
                lbl7.Theme = MetroThemeStyle.Light;
                lbl8.Theme = MetroThemeStyle.Light;
                sname.Theme = MetroThemeStyle.Light;
                dname.Theme = MetroThemeStyle.Light;
                pnumber.Theme = MetroThemeStyle.Light;
                uname.Theme = MetroThemeStyle.Light;
                password.Theme = MetroThemeStyle.Light;
                theme.Theme = MetroThemeStyle.Light;
                save.Theme = MetroThemeStyle.Light;
                cancel.Theme = MetroThemeStyle.Light;
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
            DialogResult dr = MetroMessageBox.Show(this, "Setting Saved Succesfully, Application will be reload", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(dr == DialogResult.OK)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
