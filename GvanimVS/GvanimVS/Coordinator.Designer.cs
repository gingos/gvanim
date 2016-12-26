namespace GvanimVS
{
    partial class Coordinator
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
            this.editReport_bt = new System.Windows.Forms.Button();
            this.addMeeting_bt = new System.Windows.Forms.Button();
            this.editMitmoded_bt = new System.Windows.Forms.Button();
            this.editMeeting_bt = new System.Windows.Forms.Button();
            this.showMeetings_bt = new System.Windows.Forms.Button();
            this.writeReport_bt = new System.Windows.Forms.Button();
            this.close_bt = new System.Windows.Forms.Button();
            this.addMitmoded_bt = new System.Windows.Forms.Button();
            this.editCoordinator_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editReport_bt
            // 
            this.editReport_bt.Location = new System.Drawing.Point(236, 135);
            this.editReport_bt.Name = "editReport_bt";
            this.editReport_bt.Size = new System.Drawing.Size(120, 23);
            this.editReport_bt.TabIndex = 1;
            this.editReport_bt.Text = "חפש דו\"ח";
            this.editReport_bt.UseVisualStyleBackColor = true;
            this.editReport_bt.Click += new System.EventHandler(this.editReport_bt_Click);
            // 
            // addMeeting_bt
            // 
            this.addMeeting_bt.Enabled = false;
            this.addMeeting_bt.Location = new System.Drawing.Point(364, 175);
            this.addMeeting_bt.Name = "addMeeting_bt";
            this.addMeeting_bt.Size = new System.Drawing.Size(133, 23);
            this.addMeeting_bt.TabIndex = 2;
            this.addMeeting_bt.Text = "הוסף פגישה";
            this.addMeeting_bt.UseVisualStyleBackColor = true;
            this.addMeeting_bt.Click += new System.EventHandler(this.addMeeting_bt_Click);
            // 
            // editMitmoded_bt
            // 
            this.editMitmoded_bt.Location = new System.Drawing.Point(236, 95);
            this.editMitmoded_bt.Name = "editMitmoded_bt";
            this.editMitmoded_bt.Size = new System.Drawing.Size(122, 23);
            this.editMitmoded_bt.TabIndex = 3;
            this.editMitmoded_bt.Text = "ערוך מתמודד";
            this.editMitmoded_bt.UseVisualStyleBackColor = true;
            this.editMitmoded_bt.Click += new System.EventHandler(this.editMitmoded_bt_Click);
            // 
            // editMeeting_bt
            // 
            this.editMeeting_bt.Location = new System.Drawing.Point(236, 175);
            this.editMeeting_bt.Name = "editMeeting_bt";
            this.editMeeting_bt.Size = new System.Drawing.Size(119, 23);
            this.editMeeting_bt.TabIndex = 4;
            this.editMeeting_bt.Text = "ערוך פרטי פגישה";
            this.editMeeting_bt.UseVisualStyleBackColor = true;
            this.editMeeting_bt.Click += new System.EventHandler(this.editMeeting_bt_Click);
            // 
            // showMeetings_bt
            // 
            this.showMeetings_bt.Location = new System.Drawing.Point(134, 175);
            this.showMeetings_bt.Name = "showMeetings_bt";
            this.showMeetings_bt.Size = new System.Drawing.Size(96, 23);
            this.showMeetings_bt.TabIndex = 5;
            this.showMeetings_bt.Text = "הצג פגישות";
            this.showMeetings_bt.UseVisualStyleBackColor = true;
            // 
            // writeReport_bt
            // 
            this.writeReport_bt.Enabled = false;
            this.writeReport_bt.Location = new System.Drawing.Point(364, 135);
            this.writeReport_bt.Name = "writeReport_bt";
            this.writeReport_bt.Size = new System.Drawing.Size(134, 23);
            this.writeReport_bt.TabIndex = 0;
            this.writeReport_bt.Text = "כתוב דו\"ח";
            this.writeReport_bt.UseMnemonic = false;
            this.writeReport_bt.UseVisualStyleBackColor = true;
            this.writeReport_bt.Click += new System.EventHandler(this.writeReport_bt_Click);
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(141, 309);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 6;
            this.close_bt.Text = "יציאה";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // addMitmoded_bt
            // 
            this.addMitmoded_bt.Location = new System.Drawing.Point(364, 95);
            this.addMitmoded_bt.Name = "addMitmoded_bt";
            this.addMitmoded_bt.Size = new System.Drawing.Size(133, 23);
            this.addMitmoded_bt.TabIndex = 7;
            this.addMitmoded_bt.Text = "הוסף מתמודד חדש";
            this.addMitmoded_bt.UseVisualStyleBackColor = true;
            this.addMitmoded_bt.Click += new System.EventHandler(this.addMitmoded_bt_Click);
            // 
            // editCoordinator_bt
            // 
            this.editCoordinator_bt.Location = new System.Drawing.Point(32, 23);
            this.editCoordinator_bt.Name = "editCoordinator_bt";
            this.editCoordinator_bt.Size = new System.Drawing.Size(106, 21);
            this.editCoordinator_bt.TabIndex = 8;
            this.editCoordinator_bt.Text = "עדכן פרטי רכז";
            this.editCoordinator_bt.UseVisualStyleBackColor = true;
            // 
            // Coordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 368);
            this.Controls.Add(this.editCoordinator_bt);
            this.Controls.Add(this.addMitmoded_bt);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.showMeetings_bt);
            this.Controls.Add(this.editMeeting_bt);
            this.Controls.Add(this.editMitmoded_bt);
            this.Controls.Add(this.addMeeting_bt);
            this.Controls.Add(this.editReport_bt);
            this.Controls.Add(this.writeReport_bt);
            this.Name = "Coordinator";
            this.ShowIcon = false;
            this.Text = "Coordinator";
            this.Load += new System.EventHandler(this.Coordinator_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button editReport_bt;
        private System.Windows.Forms.Button addMeeting_bt;
        private System.Windows.Forms.Button editMitmoded_bt;
        private System.Windows.Forms.Button editMeeting_bt;
        private System.Windows.Forms.Button showMeetings_bt;
        private System.Windows.Forms.Button writeReport_bt;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button addMitmoded_bt;
        private System.Windows.Forms.Button editCoordinator_bt;
    }
}