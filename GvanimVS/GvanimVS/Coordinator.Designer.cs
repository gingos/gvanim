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
            this.SuspendLayout();
            // 
            // editReport_bt
            // 
            this.editReport_bt.Location = new System.Drawing.Point(281, 164);
            this.editReport_bt.Name = "editReport_bt";
            this.editReport_bt.Size = new System.Drawing.Size(97, 23);
            this.editReport_bt.TabIndex = 1;
            this.editReport_bt.Text = "ערוך דו\"ח";
            this.editReport_bt.UseVisualStyleBackColor = true;
            // 
            // addMeeting_bt
            // 
            this.addMeeting_bt.Location = new System.Drawing.Point(401, 209);
            this.addMeeting_bt.Name = "addMeeting_bt";
            this.addMeeting_bt.Size = new System.Drawing.Size(96, 23);
            this.addMeeting_bt.TabIndex = 2;
            this.addMeeting_bt.Text = "הוסף פגישה";
            this.addMeeting_bt.UseVisualStyleBackColor = true;
            // 
            // editMitmoded_bt
            // 
            this.editMitmoded_bt.Location = new System.Drawing.Point(375, 258);
            this.editMitmoded_bt.Name = "editMitmoded_bt";
            this.editMitmoded_bt.Size = new System.Drawing.Size(122, 23);
            this.editMitmoded_bt.TabIndex = 3;
            this.editMitmoded_bt.Text = "ערוך פרטי מתמודד";
            this.editMitmoded_bt.UseVisualStyleBackColor = true;
            // 
            // editMeeting_bt
            // 
            this.editMeeting_bt.Location = new System.Drawing.Point(259, 209);
            this.editMeeting_bt.Name = "editMeeting_bt";
            this.editMeeting_bt.Size = new System.Drawing.Size(119, 23);
            this.editMeeting_bt.TabIndex = 4;
            this.editMeeting_bt.Text = "ערוך פרטי פגישה";
            this.editMeeting_bt.UseVisualStyleBackColor = true;
            // 
            // showMeetings_bt
            // 
            this.showMeetings_bt.Location = new System.Drawing.Point(141, 209);
            this.showMeetings_bt.Name = "showMeetings_bt";
            this.showMeetings_bt.Size = new System.Drawing.Size(96, 23);
            this.showMeetings_bt.TabIndex = 5;
            this.showMeetings_bt.Text = "הצג פגישות";
            this.showMeetings_bt.UseVisualStyleBackColor = true;
            // 
            // writeReport_bt
            // 
            this.writeReport_bt.Location = new System.Drawing.Point(400, 164);
            this.writeReport_bt.Name = "writeReport_bt";
            this.writeReport_bt.Size = new System.Drawing.Size(97, 23);
            this.writeReport_bt.TabIndex = 0;
            this.writeReport_bt.Text = "כתוב דו\"ח";
            this.writeReport_bt.UseMnemonic = false;
            this.writeReport_bt.UseVisualStyleBackColor = true;
            this.writeReport_bt.Click += new System.EventHandler(this.writeReport_bt_Click);
            // 
            // Coordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 368);
            this.ControlBox = false;
            this.Controls.Add(this.showMeetings_bt);
            this.Controls.Add(this.editMeeting_bt);
            this.Controls.Add(this.editMitmoded_bt);
            this.Controls.Add(this.addMeeting_bt);
            this.Controls.Add(this.editReport_bt);
            this.Controls.Add(this.writeReport_bt);
            this.Name = "Coordinator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Coordinator";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button editReport_bt;
        private System.Windows.Forms.Button addMeeting_bt;
        private System.Windows.Forms.Button editMitmoded_bt;
        private System.Windows.Forms.Button editMeeting_bt;
        private System.Windows.Forms.Button showMeetings_bt;
        private System.Windows.Forms.Button writeReport_bt;
    }
}