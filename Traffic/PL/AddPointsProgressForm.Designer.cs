namespace Traffic.PL
{
    partial class AddPointsProgressForm
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
            this.progress = new MetroFramework.Controls.MetroProgressBar();
            this.operationLabel = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(23, 63);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(386, 23);
            this.progress.Step = 1;
            this.progress.TabIndex = 0;
            this.progress.Click += new System.EventHandler(this.progress_Click);
            // 
            // operationLabel
            // 
            this.operationLabel.Location = new System.Drawing.Point(23, 93);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(386, 23);
            this.operationLabel.TabIndex = 1;
            this.operationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.operationLabel.UseSelectable = true;
            this.operationLabel.Click += new System.EventHandler(this.operationLabel_Click);
            // 
            // AddPointsProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 141);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.progress);
            this.Name = "AddPointsProgressForm";
            this.Text = "Adding Points";
            this.Load += new System.EventHandler(this.AddPointsProgressForm_Load);
            this.Shown += new System.EventHandler(this.AddPointsProgressForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar progress;
        private MetroFramework.Controls.MetroLink operationLabel;
    }
}