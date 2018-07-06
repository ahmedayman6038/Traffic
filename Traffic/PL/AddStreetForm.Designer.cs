namespace Traffic.PL
{
    partial class AddStreetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.sname = new MetroFramework.Controls.MetroTextBox();
            this.lbl2 = new MetroFramework.Controls.MetroLabel();
            this.sdir = new MetroFramework.Controls.MetroTextBox();
            this.lbl3 = new MetroFramework.Controls.MetroLabel();
            this.intersections = new MetroFramework.Controls.MetroGrid();
            this.PNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Case1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Case2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Case3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addsigns = new MetroFramework.Controls.MetroTile();
            this.addpoint = new MetroFramework.Controls.MetroTile();
            this.save = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.intersections)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(24, 82);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 19);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Street Name";
            // 
            // sname
            // 
            // 
            // 
            // 
            this.sname.CustomButton.Image = null;
            this.sname.CustomButton.Location = new System.Drawing.Point(341, 1);
            this.sname.CustomButton.Name = "";
            this.sname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sname.CustomButton.TabIndex = 1;
            this.sname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sname.CustomButton.UseSelectable = true;
            this.sname.CustomButton.Visible = false;
            this.sname.Lines = new string[0];
            this.sname.Location = new System.Drawing.Point(136, 78);
            this.sname.MaxLength = 32767;
            this.sname.Name = "sname";
            this.sname.PasswordChar = '\0';
            this.sname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sname.SelectedText = "";
            this.sname.SelectionLength = 0;
            this.sname.SelectionStart = 0;
            this.sname.ShortcutsEnabled = true;
            this.sname.Size = new System.Drawing.Size(363, 23);
            this.sname.TabIndex = 1;
            this.sname.UseSelectable = true;
            this.sname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.sname.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(24, 118);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(99, 19);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Street Direction";
            // 
            // sdir
            // 
            // 
            // 
            // 
            this.sdir.CustomButton.Image = null;
            this.sdir.CustomButton.Location = new System.Drawing.Point(341, 1);
            this.sdir.CustomButton.Name = "";
            this.sdir.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sdir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sdir.CustomButton.TabIndex = 1;
            this.sdir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sdir.CustomButton.UseSelectable = true;
            this.sdir.CustomButton.Visible = false;
            this.sdir.Lines = new string[0];
            this.sdir.Location = new System.Drawing.Point(136, 118);
            this.sdir.MaxLength = 32767;
            this.sdir.Name = "sdir";
            this.sdir.PasswordChar = '\0';
            this.sdir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sdir.SelectedText = "";
            this.sdir.SelectionLength = 0;
            this.sdir.SelectionStart = 0;
            this.sdir.ShortcutsEnabled = true;
            this.sdir.Size = new System.Drawing.Size(363, 23);
            this.sdir.TabIndex = 6;
            this.sdir.UseSelectable = true;
            this.sdir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sdir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl3.Location = new System.Drawing.Point(24, 163);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(142, 25);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "Add Intersections";
            this.lbl3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // intersections
            // 
            this.intersections.AllowUserToResizeRows = false;
            this.intersections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.intersections.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.intersections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intersections.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.intersections.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.intersections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.intersections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.intersections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PNumber,
            this.Case1,
            this.Case2,
            this.Case3,
            this.Delay1,
            this.Delay2,
            this.Delay3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.intersections.DefaultCellStyle = dataGridViewCellStyle2;
            this.intersections.EnableHeadersVisualStyles = false;
            this.intersections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.intersections.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.intersections.Location = new System.Drawing.Point(24, 194);
            this.intersections.Name = "intersections";
            this.intersections.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.intersections.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.intersections.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.intersections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.intersections.Size = new System.Drawing.Size(753, 257);
            this.intersections.TabIndex = 8;
            this.intersections.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.intersections_CellContentClick);
            // 
            // PNumber
            // 
            this.PNumber.HeaderText = "Point Number";
            this.PNumber.Name = "PNumber";
            // 
            // Case1
            // 
            this.Case1.HeaderText = "Case 1";
            this.Case1.Name = "Case1";
            // 
            // Case2
            // 
            this.Case2.HeaderText = "Case 2";
            this.Case2.Name = "Case2";
            // 
            // Case3
            // 
            this.Case3.HeaderText = "Case 3";
            this.Case3.Name = "Case3";
            // 
            // Delay1
            // 
            this.Delay1.HeaderText = "Delay 1";
            this.Delay1.Name = "Delay1";
            // 
            // Delay2
            // 
            this.Delay2.HeaderText = "Delay 2";
            this.Delay2.Name = "Delay2";
            // 
            // Delay3
            // 
            this.Delay3.HeaderText = "Delay 3";
            this.Delay3.Name = "Delay3";
            // 
            // addsigns
            // 
            this.addsigns.ActiveControl = null;
            this.addsigns.Location = new System.Drawing.Point(652, 78);
            this.addsigns.Name = "addsigns";
            this.addsigns.Size = new System.Drawing.Size(125, 110);
            this.addsigns.TabIndex = 9;
            this.addsigns.Text = "Add Signs";
            this.addsigns.TileImage = global::Traffic.Properties.Resources.sign;
            this.addsigns.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addsigns.UseSelectable = true;
            this.addsigns.UseTileImage = true;
            this.addsigns.Click += new System.EventHandler(this.addsigns_Click);
            // 
            // addpoint
            // 
            this.addpoint.ActiveControl = null;
            this.addpoint.Location = new System.Drawing.Point(521, 78);
            this.addpoint.Name = "addpoint";
            this.addpoint.Size = new System.Drawing.Size(125, 110);
            this.addpoint.TabIndex = 4;
            this.addpoint.Text = "Add Points";
            this.addpoint.TileImage = global::Traffic.Properties.Resources.placeholder__1_;
            this.addpoint.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addpoint.UseSelectable = true;
            this.addpoint.UseTileImage = true;
            this.addpoint.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(702, 457);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseSelectable = true;
            this.save.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // AddStreetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.save);
            this.Controls.Add(this.addsigns);
            this.Controls.Add(this.intersections);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.sdir);
            this.Controls.Add(this.addpoint);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.lbl1);
            this.Name = "AddStreetForm";
            this.Text = "Add Street";
            ((System.ComponentModel.ISupportInitialize)(this.intersections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroTextBox sname;
        private MetroFramework.Controls.MetroLabel lbl2;
        private MetroFramework.Controls.MetroTile addpoint;
        private MetroFramework.Controls.MetroTextBox sdir;
        private MetroFramework.Controls.MetroLabel lbl3;
        private MetroFramework.Controls.MetroGrid intersections;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay3;
        private MetroFramework.Controls.MetroTile addsigns;
        private MetroFramework.Controls.MetroButton save;
    }
}