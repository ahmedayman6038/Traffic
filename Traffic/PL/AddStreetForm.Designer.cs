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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.intersections = new MetroFramework.Controls.MetroGrid();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.addsigns = new MetroFramework.Controls.MetroTile();
            this.save = new MetroFramework.Controls.MetroTile();
            this.sdir = new MetroFramework.Controls.MetroTextBox();
            this.lbl2 = new MetroFramework.Controls.MetroLabel();
            this.sname = new MetroFramework.Controls.MetroTextBox();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.IntersectionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.case1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.case2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Case3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delay3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intersections)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 364);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(924, 201);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.intersections);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(442, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(482, 201);
            this.metroPanel3.TabIndex = 15;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
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
            this.IntersectionNumber,
            this.pnumber,
            this.case1,
            this.case2,
            this.Case3,
            this.delay1,
            this.delay2,
            this.delay3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.intersections.DefaultCellStyle = dataGridViewCellStyle2;
            this.intersections.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.intersections.EnableHeadersVisualStyles = false;
            this.intersections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.intersections.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.intersections.Location = new System.Drawing.Point(0, 6);
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
            this.intersections.Size = new System.Drawing.Size(482, 195);
            this.intersections.TabIndex = 13;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.addsigns);
            this.metroPanel2.Controls.Add(this.save);
            this.metroPanel2.Controls.Add(this.sdir);
            this.metroPanel2.Controls.Add(this.lbl2);
            this.metroPanel2.Controls.Add(this.sname);
            this.metroPanel2.Controls.Add(this.lbl1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.ForeColor = System.Drawing.SystemColors.Control;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(442, 201);
            this.metroPanel2.TabIndex = 14;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // addsigns
            // 
            this.addsigns.ActiveControl = null;
            this.addsigns.Location = new System.Drawing.Point(143, 97);
            this.addsigns.Name = "addsigns";
            this.addsigns.Size = new System.Drawing.Size(130, 101);
            this.addsigns.TabIndex = 18;
            this.addsigns.Text = "Add Sign";
            this.addsigns.TileImage = global::Traffic.Properties.Resources.sign;
            this.addsigns.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addsigns.UseSelectable = true;
            this.addsigns.UseTileImage = true;
            this.addsigns.Click += new System.EventHandler(this.metroTile2_Click_1);
            // 
            // save
            // 
            this.save.ActiveControl = null;
            this.save.Location = new System.Drawing.Point(7, 97);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(130, 101);
            this.save.TabIndex = 17;
            this.save.Text = "Save";
            this.save.TileImage = global::Traffic.Properties.Resources.save;
            this.save.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save.UseSelectable = true;
            this.save.UseTileImage = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // sdir
            // 
            // 
            // 
            // 
            this.sdir.CustomButton.Image = null;
            this.sdir.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.sdir.CustomButton.Name = "";
            this.sdir.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sdir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sdir.CustomButton.TabIndex = 1;
            this.sdir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sdir.CustomButton.UseSelectable = true;
            this.sdir.CustomButton.Visible = false;
            this.sdir.Lines = new string[0];
            this.sdir.Location = new System.Drawing.Point(121, 35);
            this.sdir.MaxLength = 32767;
            this.sdir.Name = "sdir";
            this.sdir.PasswordChar = '\0';
            this.sdir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sdir.SelectedText = "";
            this.sdir.SelectionLength = 0;
            this.sdir.SelectionStart = 0;
            this.sdir.ShortcutsEnabled = true;
            this.sdir.Size = new System.Drawing.Size(315, 23);
            this.sdir.TabIndex = 16;
            this.sdir.UseSelectable = true;
            this.sdir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sdir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 35);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(99, 19);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "Street Direction";
            // 
            // sname
            // 
            // 
            // 
            // 
            this.sname.CustomButton.Image = null;
            this.sname.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.sname.CustomButton.Name = "";
            this.sname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sname.CustomButton.TabIndex = 1;
            this.sname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sname.CustomButton.UseSelectable = true;
            this.sname.CustomButton.Visible = false;
            this.sname.Lines = new string[0];
            this.sname.Location = new System.Drawing.Point(121, 6);
            this.sname.MaxLength = 32767;
            this.sname.Name = "sname";
            this.sname.PasswordChar = '\0';
            this.sname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sname.SelectedText = "";
            this.sname.SelectionLength = 0;
            this.sname.SelectionStart = 0;
            this.sname.ShortcutsEnabled = true;
            this.sname.Size = new System.Drawing.Size(315, 23);
            this.sname.TabIndex = 14;
            this.sname.UseSelectable = true;
            this.sname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 6);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 19);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "Street Name";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.map);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(20, 60);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(924, 304);
            this.metroPanel4.TabIndex = 1;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(924, 304);
            this.map.TabIndex = 2;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            // 
            // IntersectionNumber
            // 
            this.IntersectionNumber.HeaderText = "Intersection Number";
            this.IntersectionNumber.Name = "IntersectionNumber";
            // 
            // pnumber
            // 
            this.pnumber.HeaderText = "Point Number";
            this.pnumber.Name = "pnumber";
            // 
            // case1
            // 
            this.case1.HeaderText = "Case 1";
            this.case1.Name = "case1";
            // 
            // case2
            // 
            this.case2.HeaderText = "Case 2";
            this.case2.Name = "case2";
            // 
            // Case3
            // 
            this.Case3.HeaderText = "Case 3";
            this.Case3.Name = "Case3";
            // 
            // delay1
            // 
            this.delay1.HeaderText = "Delay 1";
            this.delay1.Name = "delay1";
            // 
            // delay2
            // 
            this.delay2.HeaderText = "Delay 2";
            this.delay2.Name = "delay2";
            // 
            // delay3
            // 
            this.delay3.HeaderText = "Delay 3";
            this.delay3.Name = "delay3";
            // 
            // AddStreetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 585);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel1);
            this.Name = "AddStreetForm";
            this.Text = "Add Street";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intersections)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid intersections;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox sdir;
        private MetroFramework.Controls.MetroLabel lbl2;
        private MetroFramework.Controls.MetroTextBox sname;
        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private GMap.NET.WindowsForms.GMapControl map;
        private MetroFramework.Controls.MetroTile addsigns;
        private MetroFramework.Controls.MetroTile save;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntersectionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn case1;
        private System.Windows.Forms.DataGridViewTextBoxColumn case2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case3;
        private System.Windows.Forms.DataGridViewTextBoxColumn delay1;
        private System.Windows.Forms.DataGridViewTextBoxColumn delay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn delay3;
    }
}