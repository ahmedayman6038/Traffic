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
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.operationLabel = new MetroFramework.Controls.MetroLabel();
            this.progress = new MetroFramework.Controls.MetroProgressBar();
            this.connected = new MetroFramework.Controls.MetroRadioButton();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel.Controls.Add(this.operationLabel);
            this.panel.Controls.Add(this.progress);
            this.panel.Controls.Add(this.connected);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.ForeColor = System.Drawing.Color.Transparent;
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(20, 405);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(760, 25);
            this.panel.TabIndex = 2;
            this.panel.UseCustomBackColor = true;
            this.panel.UseCustomForeColor = true;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.ForeColor = System.Drawing.Color.White;
            this.operationLabel.Location = new System.Drawing.Point(441, 1);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(133, 19);
            this.operationLabel.TabIndex = 4;
            this.operationLabel.Text = "Creating data base ...";
            this.operationLabel.UseCustomBackColor = true;
            this.operationLabel.UseCustomForeColor = true;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(149, 5);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(286, 15);
            this.progress.Step = 1;
            this.progress.TabIndex = 3;
            this.progress.Theme = MetroFramework.MetroThemeStyle.Light;
            this.progress.Click += new System.EventHandler(this.progress_Click);
            // 
            // connected
            // 
            this.connected.AutoSize = true;
            this.connected.Enabled = false;
            this.connected.ForeColor = System.Drawing.Color.White;
            this.connected.Location = new System.Drawing.Point(23, 5);
            this.connected.Name = "connected";
            this.connected.Size = new System.Drawing.Size(81, 15);
            this.connected.TabIndex = 2;
            this.connected.Text = "Connected";
            this.connected.UseCustomBackColor = true;
            this.connected.UseCustomForeColor = true;
            this.connected.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(315, 84);
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
            this.metroTile3.Location = new System.Drawing.Point(23, 84);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(140, 130);
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Add Street";
            this.metroTile3.TileImage = global::Traffic.Properties.Resources.map_location;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(169, 84);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(140, 130);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Update Street";
            this.metroTile1.TileImage = global::Traffic.Properties.Resources.refresh;
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
            this.Controls.Add(this.panel);
            this.Controls.Add(this.metroTile1);
            this.Name = "MainForm";
            this.Text = "Traffic";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel panel;
        private MetroFramework.Controls.MetroRadioButton connected;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroProgressBar progress;
        private MetroFramework.Controls.MetroLabel operationLabel;
    }
}

