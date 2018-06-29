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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.dirTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.intersections = new MetroFramework.Controls.MetroGrid();
            this.PNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Case1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Case2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Case3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.intersections)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Street Name";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(341, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(136, 78);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(363, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Street Direction";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(652, 78);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(125, 110);
            this.metroTile2.TabIndex = 5;
            this.metroTile2.Text = "Save";
            this.metroTile2.TileImage = global::Traffic.Properties.Resources.save;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(521, 78);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(125, 110);
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Text = "Add Points";
            this.metroTile1.TileImage = global::Traffic.Properties.Resources.placeholder__1_;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // dirTxt
            // 
            // 
            // 
            // 
            this.dirTxt.CustomButton.Image = null;
            this.dirTxt.CustomButton.Location = new System.Drawing.Point(341, 1);
            this.dirTxt.CustomButton.Name = "";
            this.dirTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dirTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dirTxt.CustomButton.TabIndex = 1;
            this.dirTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dirTxt.CustomButton.UseSelectable = true;
            this.dirTxt.CustomButton.Visible = false;
            this.dirTxt.Lines = new string[0];
            this.dirTxt.Location = new System.Drawing.Point(136, 118);
            this.dirTxt.MaxLength = 32767;
            this.dirTxt.Name = "dirTxt";
            this.dirTxt.PasswordChar = '\0';
            this.dirTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dirTxt.SelectedText = "";
            this.dirTxt.SelectionLength = 0;
            this.dirTxt.SelectionStart = 0;
            this.dirTxt.ShortcutsEnabled = true;
            this.dirTxt.Size = new System.Drawing.Size(363, 23);
            this.dirTxt.TabIndex = 6;
            this.dirTxt.UseSelectable = true;
            this.dirTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dirTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(24, 163);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(142, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Add Intersections";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
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
            this.intersections.Size = new System.Drawing.Size(753, 283);
            this.intersections.TabIndex = 8;
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
            // AddStreetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.intersections);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dirTxt);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddStreetForm";
            this.Text = "Add Street";
            ((System.ComponentModel.ISupportInitialize)(this.intersections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTextBox dirTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid intersections;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay3;
    }
}