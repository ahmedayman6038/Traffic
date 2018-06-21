namespace Traffic
{
    partial class MainForm
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.operationLabel = new MetroFramework.Controls.MetroLabel();
            this.progress = new MetroFramework.Controls.MetroProgressBar();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroPanel1.Controls.Add(this.operationLabel);
            this.metroPanel1.Controls.Add(this.progress);
            this.metroPanel1.Controls.Add(this.metroRadioButton1);
            this.metroPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 425);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(800, 25);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.ForeColor = System.Drawing.Color.White;
            this.operationLabel.Location = new System.Drawing.Point(315, 1);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(133, 19);
            this.operationLabel.TabIndex = 4;
            this.operationLabel.Text = "Creating data base ...";
            this.operationLabel.UseCustomBackColor = true;
            this.operationLabel.UseCustomForeColor = true;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(169, 5);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(140, 15);
            this.progress.Step = 1;
            this.progress.TabIndex = 3;
            this.progress.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Enabled = false;
            this.metroRadioButton1.ForeColor = System.Drawing.Color.White;
            this.metroRadioButton1.Location = new System.Drawing.Point(23, 5);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(81, 15);
            this.metroRadioButton1.TabIndex = 2;
            this.metroRadioButton1.Text = "Connected";
            this.metroRadioButton1.UseCustomBackColor = true;
            this.metroRadioButton1.UseCustomForeColor = true;
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(461, 73);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(140, 130);
            this.metroTile4.TabIndex = 4;
            this.metroTile4.Text = "Settings";
            this.metroTile4.TileImage = global::Traffic.Properties.Resources.settings;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(315, 73);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(140, 130);
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Add Data";
            this.metroTile3.TileImage = global::Traffic.Properties.Resources.folders;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(169, 73);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(140, 130);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Connect Database";
            this.metroTile2.TileImage = global::Traffic.Properties.Resources.database_with_internet_conection;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 73);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(140, 130);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Add Database";
            this.metroTile1.TileImage = global::Traffic.Properties.Resources.add__1_;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Traffic";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroProgressBar progress;
        private MetroFramework.Controls.MetroLabel operationLabel;
    }
}

