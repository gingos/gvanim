namespace GvanimVS
{
    partial class FindMeeting
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
            this.meetingID_tb = new System.Windows.Forms.TextBox();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.start_date_dtp = new System.Windows.Forms.DateTimePicker();
            this.firstName_lb = new System.Windows.Forms.Label();
            this.meetingID_lb = new System.Windows.Forms.Label();
            this.address_lb = new System.Windows.Forms.Label();
            this.city_lb = new System.Windows.Forms.Label();
            this.start_date_lb = new System.Windows.Forms.Label();
            this.searchMeeting_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.occured_chk = new System.Windows.Forms.CheckBox();
            this.lastName_lb = new System.Windows.Forms.Label();
            this.firstName_tb = new System.Windows.Forms.TextBox();
            this.lastName_tb = new System.Windows.Forms.TextBox();
            this.end_date_lb = new System.Windows.Forms.Label();
            this.end_date_dtp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // meetingID_tb
            // 
            this.meetingID_tb.Location = new System.Drawing.Point(224, 54);
            this.meetingID_tb.Name = "meetingID_tb";
            this.meetingID_tb.Size = new System.Drawing.Size(189, 20);
            this.meetingID_tb.TabIndex = 0;
            // 
            // city_tb
            // 
            this.city_tb.Location = new System.Drawing.Point(375, 128);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(198, 20);
            this.city_tb.TabIndex = 0;
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(28, 132);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(198, 20);
            this.address_tb.TabIndex = 0;
            // 
            // start_date_dtp
            // 
            this.start_date_dtp.Checked = false;
            this.start_date_dtp.Location = new System.Drawing.Point(373, 177);
            this.start_date_dtp.Name = "start_date_dtp";
            this.start_date_dtp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.start_date_dtp.RightToLeftLayout = true;
            this.start_date_dtp.ShowCheckBox = true;
            this.start_date_dtp.Size = new System.Drawing.Size(200, 20);
            this.start_date_dtp.TabIndex = 1;
            // 
            // firstName_lb
            // 
            this.firstName_lb.AutoSize = true;
            this.firstName_lb.Location = new System.Drawing.Point(582, 94);
            this.firstName_lb.Name = "firstName_lb";
            this.firstName_lb.Size = new System.Drawing.Size(51, 13);
            this.firstName_lb.TabIndex = 2;
            this.firstName_lb.Text = "שם פרטי";
            // 
            // meetingID_lb
            // 
            this.meetingID_lb.AutoSize = true;
            this.meetingID_lb.Location = new System.Drawing.Point(419, 57);
            this.meetingID_lb.Name = "meetingID_lb";
            this.meetingID_lb.Size = new System.Drawing.Size(214, 13);
            this.meetingID_lb.TabIndex = 2;
            this.meetingID_lb.Text = "מס\"ד פגישה (ניתן לחפש גם ת.ז. מתמודד)";
            // 
            // address_lb
            // 
            this.address_lb.AutoSize = true;
            this.address_lb.Location = new System.Drawing.Point(274, 139);
            this.address_lb.Name = "address_lb";
            this.address_lb.Size = new System.Drawing.Size(40, 13);
            this.address_lb.TabIndex = 2;
            this.address_lb.Text = "כתובת";
            // 
            // city_lb
            // 
            this.city_lb.AutoSize = true;
            this.city_lb.Location = new System.Drawing.Point(608, 135);
            this.city_lb.Name = "city_lb";
            this.city_lb.Size = new System.Drawing.Size(25, 13);
            this.city_lb.TabIndex = 2;
            this.city_lb.Text = "עיר";
            // 
            // start_date_lb
            // 
            this.start_date_lb.AutoSize = true;
            this.start_date_lb.Location = new System.Drawing.Point(594, 177);
            this.start_date_lb.Name = "start_date_lb";
            this.start_date_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.start_date_lb.Size = new System.Drawing.Size(42, 26);
            this.start_date_lb.TabIndex = 2;
            this.start_date_lb.Text = "טווח \r\nהתחלה";
            // 
            // searchMeeting_bt
            // 
            this.searchMeeting_bt.Location = new System.Drawing.Point(151, 347);
            this.searchMeeting_bt.Name = "searchMeeting_bt";
            this.searchMeeting_bt.Size = new System.Drawing.Size(75, 23);
            this.searchMeeting_bt.TabIndex = 5;
            this.searchMeeting_bt.Text = "חפש אירוע";
            this.searchMeeting_bt.UseVisualStyleBackColor = true;
            this.searchMeeting_bt.Click += new System.EventHandler(this.searchMeeting_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(43, 347);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 5;
            this.cancel_bt.Text = "סגור";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // occured_chk
            // 
            this.occured_chk.AutoSize = true;
            this.occured_chk.Location = new System.Drawing.Point(28, 50);
            this.occured_chk.Name = "occured_chk";
            this.occured_chk.Size = new System.Drawing.Size(140, 17);
            this.occured_chk.TabIndex = 6;
            this.occured_chk.Text = "האם הפגישה התקיימה";
            this.occured_chk.UseVisualStyleBackColor = true;
            // 
            // lastName_lb
            // 
            this.lastName_lb.AutoSize = true;
            this.lastName_lb.Location = new System.Drawing.Point(251, 94);
            this.lastName_lb.Name = "lastName_lb";
            this.lastName_lb.Size = new System.Drawing.Size(63, 13);
            this.lastName_lb.TabIndex = 7;
            this.lastName_lb.Text = "שם משפחה";
            // 
            // firstName_tb
            // 
            this.firstName_tb.Location = new System.Drawing.Point(375, 87);
            this.firstName_tb.Name = "firstName_tb";
            this.firstName_tb.Size = new System.Drawing.Size(198, 20);
            this.firstName_tb.TabIndex = 8;
            // 
            // lastName_tb
            // 
            this.lastName_tb.Location = new System.Drawing.Point(28, 87);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(198, 20);
            this.lastName_tb.TabIndex = 9;
            // 
            // end_date_lb
            // 
            this.end_date_lb.AutoSize = true;
            this.end_date_lb.Location = new System.Drawing.Point(283, 177);
            this.end_date_lb.Name = "end_date_lb";
            this.end_date_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.end_date_lb.Size = new System.Drawing.Size(34, 26);
            this.end_date_lb.TabIndex = 11;
            this.end_date_lb.Text = "טווח \r\nסיום";
            // 
            // end_date_dtp
            // 
            this.end_date_dtp.Checked = false;
            this.end_date_dtp.Location = new System.Drawing.Point(28, 177);
            this.end_date_dtp.Name = "end_date_dtp";
            this.end_date_dtp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.end_date_dtp.RightToLeftLayout = true;
            this.end_date_dtp.ShowCheckBox = true;
            this.end_date_dtp.Size = new System.Drawing.Size(200, 20);
            this.end_date_dtp.TabIndex = 10;
            // 
            // FindMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 397);
            this.Controls.Add(this.end_date_lb);
            this.Controls.Add(this.end_date_dtp);
            this.Controls.Add(this.lastName_tb);
            this.Controls.Add(this.firstName_tb);
            this.Controls.Add(this.lastName_lb);
            this.Controls.Add(this.occured_chk);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.searchMeeting_bt);
            this.Controls.Add(this.city_lb);
            this.Controls.Add(this.meetingID_lb);
            this.Controls.Add(this.start_date_lb);
            this.Controls.Add(this.address_lb);
            this.Controls.Add(this.firstName_lb);
            this.Controls.Add(this.start_date_dtp);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.meetingID_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindMeeting";
            this.Text = "FindMeeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox meetingID_tb;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.DateTimePicker start_date_dtp;
        private System.Windows.Forms.Label firstName_lb;
        private System.Windows.Forms.Label meetingID_lb;
        private System.Windows.Forms.Label address_lb;
        private System.Windows.Forms.Label city_lb;
        private System.Windows.Forms.Label start_date_lb;
        private System.Windows.Forms.Button searchMeeting_bt;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.CheckBox occured_chk;
        private System.Windows.Forms.Label lastName_lb;
        private System.Windows.Forms.TextBox firstName_tb;
        private System.Windows.Forms.TextBox lastName_tb;
        private System.Windows.Forms.Label end_date_lb;
        private System.Windows.Forms.DateTimePicker end_date_dtp;
    }
}