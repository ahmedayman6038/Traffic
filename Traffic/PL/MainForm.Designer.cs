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
            this.Settings = new MetroFramework.Controls.MetroTile();
            this.AddStreet = new MetroFramework.Controls.MetroTile();
            this.UpdateStreet = new MetroFramework.Controls.MetroTile();
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
            this.operationLabel.Size = new System.Drawing.Size(0, 0);
            this.operationLabel.TabIndex = 4;
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
            // Settings
            // 
            this.Settings.ActiveControl = null;
            this.Settings.Location = new System.Drawing.Point(315, 84);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(140, 130);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Settings.TileImage = global::Traffic.Properties.Resources.settings;
            this.Settings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Settings.UseSelectable = true;
            this.Settings.UseTileImage = true;
            this.Settings.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // AddStreet
            // 
            this.AddStreet.ActiveControl = null;
            this.AddStreet.Location = new System.Drawing.Point(23, 84);
            this.AddStreet.Name = "AddStreet";
            this.AddStreet.Size = new System.Drawing.Size(140, 130);
            this.AddStreet.TabIndex = 3;
            this.AddStreet.Text = "Add Street";
            this.AddStreet.TileImage = global::Traffic.Properties.Resources.map_location;
            this.AddStreet.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddStreet.UseSelectable = true;
            this.AddStreet.UseTileImage = true;
            this.AddStreet.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // UpdateStreet
            // 
            this.UpdateStreet.ActiveControl = null;
            this.UpdateStreet.Location = new System.Drawing.Point(169, 84);
            this.UpdateStreet.Name = "UpdateStreet";
            this.UpdateStreet.Size = new System.Drawing.Size(140, 130);
            this.UpdateStreet.TabIndex = 0;
            this.UpdateStreet.Text = "Update Street";
            this.UpdateStreet.TileImage = global::Traffic.Properties.Resources.refresh;
            this.UpdateStreet.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateStreet.UseSelectable = true;
            this.UpdateStreet.UseTileImage = true;
            this.UpdateStreet.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.AddStreet);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.UpdateStreet);
            this.Name = "MainForm";
            this.Text = "Traffic";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile UpdateStreet;
        private MetroFramework.Controls.MetroPanel panel;
        private MetroFramework.Controls.MetroRadioButton connected;
        private MetroFramework.Controls.MetroTile AddStreet;
        private MetroFramework.Controls.MetroTile Settings;
        private MetroFramework.Controls.MetroProgressBar progress;
        private MetroFramework.Controls.MetroLabel operationLabel;
    }
}

