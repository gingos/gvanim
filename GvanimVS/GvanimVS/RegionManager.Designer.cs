namespace GvanimVS
{
    partial class RegionManager
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
            this.addMitmoded_bt = new System.Windows.Forms.Button();
            this.addCoordinator_bt = new System.Windows.Forms.Button();
            this.showReports_bt = new System.Windows.Forms.Button();
            this.showMeetings_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMitmoded_bt
            // 
            this.addMitmoded_bt.Location = new System.Drawing.Point(495, 82);
            this.addMitmoded_bt.Name = "addMitmoded_bt";
            this.addMitmoded_bt.Size = new System.Drawing.Size(113, 23);
            this.addMitmoded_bt.TabIndex = 0;
            this.addMitmoded_bt.Text = "הוסף מתמודד";
            this.addMitmoded_bt.UseVisualStyleBackColor = true;
            this.addMitmoded_bt.Click += new System.EventHandler(this.addMitmoded_bt_Click);
            // 
            // addCoordinator_bt
            // 
            this.addCoordinator_bt.Location = new System.Drawing.Point(495, 128);
            this.addCoordinator_bt.Name = "addCoordinator_bt";
            this.addCoordinator_bt.Size = new System.Drawing.Size(112, 23);
            this.addCoordinator_bt.TabIndex = 1;
            this.addCoordinator_bt.Text = "הוסף רכז";
            this.addCoordinator_bt.UseVisualStyleBackColor = true;
            // 
            // showReports_bt
            // 
            this.showReports_bt.Location = new System.Drawing.Point(495, 182);
            this.showReports_bt.Name = "showReports_bt";
            this.showReports_bt.Size = new System.Drawing.Size(112, 23);
            this.showReports_bt.TabIndex = 2;
            this.showReports_bt.Text = "הצג דו\"חות";
            this.showReports_bt.UseVisualStyleBackColor = true;
            // 
            // showMeetings_bt
            // 
            this.showMeetings_bt.Location = new System.Drawing.Point(495, 238);
            this.showMeetings_bt.Name = "showMeetings_bt";
            this.showMeetings_bt.Size = new System.Drawing.Size(112, 23);
            this.showMeetings_bt.TabIndex = 3;
            this.showMeetings_bt.Text = "הצג פגישות";
            this.showMeetings_bt.UseVisualStyleBackColor = true;
            // 
            // RegionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 357);
            this.Controls.Add(this.showMeetings_bt);
            this.Controls.Add(this.showReports_bt);
            this.Controls.Add(this.addCoordinator_bt);
            this.Controls.Add(this.addMitmoded_bt);
            this.Name = "RegionManager";
            this.Text = "RegionManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMitmoded_bt;
        private System.Windows.Forms.Button addCoordinator_bt;
        private System.Windows.Forms.Button showReports_bt;
        private System.Windows.Forms.Button showMeetings_bt;
    }
}