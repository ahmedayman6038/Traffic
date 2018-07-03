namespace Traffic
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl8 = new MetroFramework.Controls.MetroLabel();
            this.theme = new MetroFramework.Controls.MetroComboBox();
            this.cancel = new MetroFramework.Controls.MetroButton();
            this.save = new MetroFramework.Controls.MetroButton();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.lbl6 = new MetroFramework.Controls.MetroLabel();
            this.uname = new MetroFramework.Controls.MetroTextBox();
            this.lbl5 = new MetroFramework.Controls.MetroLabel();
            this.dname = new MetroFramework.Controls.MetroTextBox();
            this.lbl3 = new MetroFramework.Controls.MetroLabel();
            this.sname = new MetroFramework.Controls.MetroTextBox();
            this.lbl2 = new MetroFramework.Controls.MetroLabel();
            this.lbl7 = new MetroFramework.Controls.MetroLabel();
            this.pnumber = new MetroFramework.Controls.MetroTextBox();
            this.lbl4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(51, 304);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(49, 19);
            this.lbl8.TabIndex = 0;
            this.lbl8.Text = "Theme";
            this.lbl8.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // theme
            // 
            this.theme.FormattingEnabled = true;
            this.theme.ItemHeight = 23;
            this.theme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.theme.Location = new System.Drawing.Point(168, 304);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(156, 29);
            this.theme.TabIndex = 1;
            this.theme.Theme = MetroFramework.MetroThemeStyle.Light;
            this.theme.UseSelectable = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(249, 364);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cancel.UseSelectable = true;
            this.cancel.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(168, 364);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.Theme = MetroFramework.MetroThemeStyle.Light;
            this.save.UseSelectable = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(22, 73);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(96, 19);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Server Settings";
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(168, 222);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(156, 23);
            this.password.TabIndex = 15;
            this.password.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.UseSelectable = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(51, 226);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(63, 19);
            this.lbl6.TabIndex = 14;
            this.lbl6.Text = "Password";
            this.lbl6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // uname
            // 
            // 
            // 
            // 
            this.uname.CustomButton.Image = null;
            this.uname.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.uname.CustomButton.Name = "";
            this.uname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uname.CustomButton.TabIndex = 1;
            this.uname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uname.CustomButton.UseSelectable = true;
            this.uname.CustomButton.Visible = false;
            this.uname.Lines = new string[0];
            this.uname.Location = new System.Drawing.Point(168, 193);
            this.uname.MaxLength = 32767;
            this.uname.Name = "uname";
            this.uname.PasswordChar = '\0';
            this.uname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uname.SelectedText = "";
            this.uname.SelectionLength = 0;
            this.uname.SelectionStart = 0;
            this.uname.ShortcutsEnabled = true;
            this.uname.Size = new System.Drawing.Size(156, 23);
            this.uname.TabIndex = 13;
            this.uname.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uname.UseSelectable = true;
            this.uname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(51, 197);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(75, 19);
            this.lbl5.TabIndex = 12;
            this.lbl5.Text = "User Name";
            this.lbl5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dname
            // 
            // 
            // 
            // 
            this.dname.CustomButton.Image = null;
            this.dname.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.dname.CustomButton.Name = "";
            this.dname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dname.CustomButton.TabIndex = 1;
            this.dname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dname.CustomButton.UseSelectable = true;
            this.dname.CustomButton.Visible = false;
            this.dname.Lines = new string[0];
            this.dname.Location = new System.Drawing.Point(168, 135);
            this.dname.MaxLength = 32767;
            this.dname.Name = "dname";
            this.dname.PasswordChar = '\0';
            this.dname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dname.SelectedText = "";
            this.dname.SelectionLength = 0;
            this.dname.SelectionStart = 0;
            this.dname.ShortcutsEnabled = true;
            this.dname.Size = new System.Drawing.Size(156, 23);
            this.dname.TabIndex = 11;
            this.dname.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dname.UseSelectable = true;
            this.dname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(51, 139);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(103, 19);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "Database Name";
            this.lbl3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // sname
            // 
            // 
            // 
            // 
            this.sname.CustomButton.Image = null;
            this.sname.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.sname.CustomButton.Name = "";
            this.sname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sname.CustomButton.TabIndex = 1;
            this.sname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sname.CustomButton.UseSelectable = true;
            this.sname.CustomButton.Visible = false;
            this.sname.Lines = new string[0];
            this.sname.Location = new System.Drawing.Point(168, 106);
            this.sname.MaxLength = 32767;
            this.sname.Name = "sname";
            this.sname.PasswordChar = '\0';
            this.sname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sname.SelectedText = "";
            this.sname.SelectionLength = 0;
            this.sname.SelectionStart = 0;
            this.sname.ShortcutsEnabled = true;
            this.sname.Size = new System.Drawing.Size(156, 23);
            this.sname.TabIndex = 9;
            this.sname.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sname.UseSelectable = true;
            this.sname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(51, 110);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(87, 19);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Server Name";
            this.lbl2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(17, 266);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(103, 19);
            this.lbl7.TabIndex = 16;
            this.lbl7.Text = "General Settings";
            // 
            // pnumber
            // 
            // 
            // 
            // 
            this.pnumber.CustomButton.Image = null;
            this.pnumber.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.pnumber.CustomButton.Name = "";
            this.pnumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pnumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pnumber.CustomButton.TabIndex = 1;
            this.pnumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pnumber.CustomButton.UseSelectable = true;
            this.pnumber.CustomButton.Visible = false;
            this.pnumber.Lines = new string[0];
            this.pnumber.Location = new System.Drawing.Point(168, 164);
            this.pnumber.MaxLength = 32767;
            this.pnumber.Name = "pnumber";
            this.pnumber.PasswordChar = '\0';
            this.pnumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pnumber.SelectedText = "";
            this.pnumber.SelectionLength = 0;
            this.pnumber.SelectionStart = 0;
            this.pnumber.ShortcutsEnabled = true;
            this.pnumber.Size = new System.Drawing.Size(156, 23);
            this.pnumber.TabIndex = 18;
            this.pnumber.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pnumber.UseSelectable = true;
            this.pnumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pnumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(51, 168);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(87, 19);
            this.lbl4.TabIndex = 17;
            this.lbl4.Text = "Port Number";
            this.lbl4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 410);
            this.Controls.Add(this.pnumber);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.password);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.dname);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.theme);
            this.Controls.Add(this.lbl8);
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.Resizable = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl8;
        private MetroFramework.Controls.MetroComboBox theme;
        private MetroFramework.Controls.MetroButton cancel;
        private MetroFramework.Controls.MetroButton save;
        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroLabel lbl6;
        private MetroFramework.Controls.MetroTextBox uname;
        private MetroFramework.Controls.MetroLabel lbl5;
        private MetroFramework.Controls.MetroTextBox dname;
        private MetroFramework.Controls.MetroLabel lbl3;
        private MetroFramework.Controls.MetroTextBox sname;
        private MetroFramework.Controls.MetroLabel lbl2;
        private MetroFramework.Controls.MetroLabel lbl7;
        private MetroFramework.Controls.MetroTextBox pnumber;
        private MetroFramework.Controls.MetroLabel lbl4;
    }
}