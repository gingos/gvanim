namespace GvanimVS
{
    partial class MeetingFind
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
            this.meetingID_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingID_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.meetingID_tb.Location = new System.Drawing.Point(302, 86);
            this.meetingID_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meetingID_tb.Name = "meetingID_tb";
            this.meetingID_tb.Size = new System.Drawing.Size(251, 25);
            this.meetingID_tb.TabIndex = 0;
            this.meetingID_tb.Click += new System.EventHandler(this.meetingID_tb_Click);
            // 
            // city_tb
            // 
            this.city_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.city_tb.Location = new System.Drawing.Point(499, 203);
            this.city_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(263, 25);
            this.city_tb.TabIndex = 0;
            this.city_tb.Click += new System.EventHandler(this.city_tb_Click);
            // 
            // address_tb
            // 
            this.address_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.address_tb.Location = new System.Drawing.Point(39, 203);
            this.address_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(263, 25);
            this.address_tb.TabIndex = 0;
            this.address_tb.Click += new System.EventHandler(this.address_tb_Click);
            // 
            // start_date_dtp
            // 
            this.start_date_dtp.Checked = false;
            this.start_date_dtp.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_date_dtp.Location = new System.Drawing.Point(580, 272);
            this.start_date_dtp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start_date_dtp.Name = "start_date_dtp";
            this.start_date_dtp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.start_date_dtp.RightToLeftLayout = true;
            this.start_date_dtp.ShowCheckBox = true;
            this.start_date_dtp.Size = new System.Drawing.Size(182, 25);
            this.start_date_dtp.TabIndex = 1;
            // 
            // firstName_lb
            // 
            this.firstName_lb.AutoSize = true;
            this.firstName_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_lb.Location = new System.Drawing.Point(780, 137);
            this.firstName_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstName_lb.Name = "firstName_lb";
            this.firstName_lb.Size = new System.Drawing.Size(66, 20);
            this.firstName_lb.TabIndex = 2;
            this.firstName_lb.Text = "שם פרטי";
            // 
            // meetingID_lb
            // 
            this.meetingID_lb.AutoSize = true;
            this.meetingID_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingID_lb.Location = new System.Drawing.Point(576, 86);
            this.meetingID_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meetingID_lb.Name = "meetingID_lb";
            this.meetingID_lb.Size = new System.Drawing.Size(270, 20);
            this.meetingID_lb.TabIndex = 2;
            this.meetingID_lb.Text = "מס\"ד פגישה (ניתן לחפש גם ת.ז. מתמודד)";
            // 
            // address_lb
            // 
            this.address_lb.AutoSize = true;
            this.address_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lb.Location = new System.Drawing.Point(369, 206);
            this.address_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address_lb.Name = "address_lb";
            this.address_lb.Size = new System.Drawing.Size(52, 20);
            this.address_lb.TabIndex = 2;
            this.address_lb.Text = "כתובת";
            // 
            // city_lb
            // 
            this.city_lb.AutoSize = true;
            this.city_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_lb.Location = new System.Drawing.Point(812, 206);
            this.city_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.city_lb.Name = "city_lb";
            this.city_lb.Size = new System.Drawing.Size(30, 20);
            this.city_lb.TabIndex = 2;
            this.city_lb.Text = "עיר";
            // 
            // start_date_lb
            // 
            this.start_date_lb.AutoSize = true;
            this.start_date_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_lb.Location = new System.Drawing.Point(792, 272);
            this.start_date_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.start_date_lb.Name = "start_date_lb";
            this.start_date_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.start_date_lb.Size = new System.Drawing.Size(58, 40);
            this.start_date_lb.TabIndex = 2;
            this.start_date_lb.Text = "טווח \r\nהתחלה";
            // 
            // searchMeeting_bt
            // 
            this.searchMeeting_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.searchMeeting_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchMeeting_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMeeting_bt.ForeColor = System.Drawing.Color.White;
            this.searchMeeting_bt.Location = new System.Drawing.Point(201, 403);
            this.searchMeeting_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchMeeting_bt.Name = "searchMeeting_bt";
            this.searchMeeting_bt.Size = new System.Drawing.Size(100, 35);
            this.searchMeeting_bt.TabIndex = 5;
            this.searchMeeting_bt.Text = "חפש אירוע";
            this.searchMeeting_bt.UseVisualStyleBackColor = false;
            this.searchMeeting_bt.Click += new System.EventHandler(this.searchMeeting_bt_Click);
            this.searchMeeting_bt.MouseLeave += new System.EventHandler(this.searchMeeting_bt_MouseLeave);
            this.searchMeeting_bt.MouseHover += new System.EventHandler(this.searchMeeting_bt_MouseHover);
            // 
            // cancel_bt
            // 
            this.cancel_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cancel_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_bt.ForeColor = System.Drawing.Color.White;
            this.cancel_bt.Location = new System.Drawing.Point(57, 403);
            this.cancel_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(100, 35);
            this.cancel_bt.TabIndex = 5;
            this.cancel_bt.Text = "סגור";
            this.cancel_bt.UseVisualStyleBackColor = false;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            this.cancel_bt.MouseLeave += new System.EventHandler(this.cancel_bt_MouseLeave);
            this.cancel_bt.MouseHover += new System.EventHandler(this.cancel_bt_MouseHover);
            // 
            // occured_chk
            // 
            this.occured_chk.AutoSize = true;
            this.occured_chk.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occured_chk.Location = new System.Drawing.Point(37, 86);
            this.occured_chk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.occured_chk.Name = "occured_chk";
            this.occured_chk.Size = new System.Drawing.Size(177, 24);
            this.occured_chk.TabIndex = 6;
            this.occured_chk.Text = "האם הפגישה התקיימה";
            this.occured_chk.UseVisualStyleBackColor = true;
            // 
            // lastName_lb
            // 
            this.lastName_lb.AutoSize = true;
            this.lastName_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_lb.Location = new System.Drawing.Point(335, 137);
            this.lastName_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastName_lb.Name = "lastName_lb";
            this.lastName_lb.Size = new System.Drawing.Size(86, 20);
            this.lastName_lb.TabIndex = 7;
            this.lastName_lb.Text = "שם משפחה";
            // 
            // firstName_tb
            // 
            this.firstName_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.firstName_tb.Location = new System.Drawing.Point(499, 137);
            this.firstName_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstName_tb.Name = "firstName_tb";
            this.firstName_tb.Size = new System.Drawing.Size(263, 25);
            this.firstName_tb.TabIndex = 8;
            this.firstName_tb.Click += new System.EventHandler(this.firstName_tb_Click);
            // 
            // lastName_tb
            // 
            this.lastName_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lastName_tb.Location = new System.Drawing.Point(39, 137);
            this.lastName_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(263, 25);
            this.lastName_tb.TabIndex = 9;
            this.lastName_tb.Click += new System.EventHandler(this.lastName_tb_Click);
            // 
            // end_date_lb
            // 
            this.end_date_lb.AutoSize = true;
            this.end_date_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_lb.Location = new System.Drawing.Point(369, 272);
            this.end_date_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.end_date_lb.Name = "end_date_lb";
            this.end_date_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.end_date_lb.Size = new System.Drawing.Size(41, 40);
            this.end_date_lb.TabIndex = 11;
            this.end_date_lb.Text = "טווח \r\nסיום";
            // 
            // end_date_dtp
            // 
            this.end_date_dtp.Checked = false;
            this.end_date_dtp.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_date_dtp.Location = new System.Drawing.Point(147, 272);
            this.end_date_dtp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.end_date_dtp.Name = "end_date_dtp";
            this.end_date_dtp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.end_date_dtp.RightToLeftLayout = true;
            this.end_date_dtp.ShowCheckBox = true;
            this.end_date_dtp.Size = new System.Drawing.Size(155, 25);
            this.end_date_dtp.TabIndex = 10;
            // 
            // MeetingFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 488);
            this.ControlBox = false;
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MeetingFind";
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