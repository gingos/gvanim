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
            this.ok_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.info_bt = new System.Windows.Forms.Button();
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
            // ok_bt
            // 
            this.ok_bt.Location = new System.Drawing.Point(229, 280);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(75, 23);
            this.ok_bt.TabIndex = 4;
            this.ok_bt.Text = "סגור";
            this.ok_bt.UseMnemonic = false;
            this.ok_bt.UseVisualStyleBackColor = true;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(140, 280);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 5;
            this.cancel_bt.Text = "ביטול";
            this.cancel_bt.UseVisualStyleBackColor = true;
            // 
            // info_bt
            // 
            this.info_bt.Location = new System.Drawing.Point(52, 25);
            this.info_bt.Name = "info_bt";
            this.info_bt.Size = new System.Drawing.Size(75, 23);
            this.info_bt.TabIndex = 6;
            this.info_bt.Text = "הצג פרטים";
            this.info_bt.UseVisualStyleBackColor = true;
            this.info_bt.Click += new System.EventHandler(this.info_bt_Click);
            // 
            // RegionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 357);
            this.Controls.Add(this.info_bt);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.ok_bt);
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
        private System.Windows.Forms.Button ok_bt;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Button info_bt;
    }
}