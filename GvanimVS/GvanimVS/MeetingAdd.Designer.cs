namespace GvanimVS
{
    partial class MeetingAdd
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
            this.address_tb = new System.Windows.Forms.TextBox();
            this.addMeeting_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.name_lb = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.address_lb = new System.Windows.Forms.Label();
            this.mitmoded_cb = new System.Windows.Forms.ComboBox();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.topics_tb = new System.Windows.Forms.TextBox();
            this.topic_lb = new System.Windows.Forms.Label();
            this.tasks_lb = new System.Windows.Forms.Label();
            this.tasks_tb = new System.Windows.Forms.TextBox();
            this.occured_ck = new System.Windows.Forms.CheckBox();
            this.close_bt = new System.Windows.Forms.Button();
            this.add_meeting_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // address_tb
            // 
            this.address_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.address_tb.Location = new System.Drawing.Point(265, 158);
            this.address_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(301, 25);
            this.address_tb.TabIndex = 0;
            this.address_tb.Text = "כתובת";
            this.address_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addMeeting_bt
            // 
            this.addMeeting_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addMeeting_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMeeting_bt.ForeColor = System.Drawing.Color.White;
            this.addMeeting_bt.Location = new System.Drawing.Point(180, 858);
            this.addMeeting_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addMeeting_bt.Name = "addMeeting_bt";
            this.addMeeting_bt.Size = new System.Drawing.Size(129, 35);
            this.addMeeting_bt.TabIndex = 2;
            this.addMeeting_bt.Text = "הוסף פגישה";
            this.addMeeting_bt.UseVisualStyleBackColor = false;
            this.addMeeting_bt.Click += new System.EventHandler(this.addMeeting_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cancel_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_bt.Location = new System.Drawing.Point(41, 858);
            this.cancel_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(100, 35);
            this.cancel_bt.TabIndex = 2;
            this.cancel_bt.Text = "ביטול";
            this.cancel_bt.UseVisualStyleBackColor = false;
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(763, 31);
            this.name_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(101, 20);
            this.name_lb.TabIndex = 3;
            this.name_lb.Text = " שם המתמודד:";
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lb.Location = new System.Drawing.Point(711, 108);
            this.date_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_lb.Name = "date_lb";
            this.date_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date_lb.Size = new System.Drawing.Size(149, 20);
            this.date_lb.TabIndex = 3;
            this.date_lb.Text = "תאריך ושעת הפגישה:";
            // 
            // address_lb
            // 
            this.address_lb.AutoSize = true;
            this.address_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lb.Location = new System.Drawing.Point(755, 158);
            this.address_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address_lb.Name = "address_lb";
            this.address_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.address_lb.Size = new System.Drawing.Size(106, 20);
            this.address_lb.TabIndex = 3;
            this.address_lb.Text = "מיקום הפגישה:";
            // 
            // mitmoded_cb
            // 
            this.mitmoded_cb.BackColor = System.Drawing.Color.White;
            this.mitmoded_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mitmoded_cb.FormattingEnabled = true;
            this.mitmoded_cb.Location = new System.Drawing.Point(372, 28);
            this.mitmoded_cb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mitmoded_cb.Name = "mitmoded_cb";
            this.mitmoded_cb.Size = new System.Drawing.Size(336, 28);
            this.mitmoded_cb.TabIndex = 4;
            this.mitmoded_cb.SelectedIndexChanged += new System.EventHandler(this.mitmoded_cb_SelectedIndexChanged);
            // 
            // city_tb
            // 
            this.city_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.city_tb.Location = new System.Drawing.Point(576, 158);
            this.city_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(132, 25);
            this.city_tb.TabIndex = 0;
            this.city_tb.Text = "עיר";
            this.city_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(504, 97);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowCheckBox = true;
            this.datePicker.Size = new System.Drawing.Size(159, 25);
            this.datePicker.TabIndex = 5;
            // 
            // timePicker
            // 
            this.timePicker.Checked = false;
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(327, 97);
            this.timePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowCheckBox = true;
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(115, 25);
            this.timePicker.TabIndex = 6;
            // 
            // topics_tb
            // 
            this.topics_tb.Location = new System.Drawing.Point(76, 286);
            this.topics_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topics_tb.Multiline = true;
            this.topics_tb.Name = "topics_tb";
            this.topics_tb.Size = new System.Drawing.Size(787, 150);
            this.topics_tb.TabIndex = 7;
            this.topics_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // topic_lb
            // 
            this.topic_lb.AutoSize = true;
            this.topic_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_lb.Location = new System.Drawing.Point(650, 261);
            this.topic_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topic_lb.Name = "topic_lb";
            this.topic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.topic_lb.Size = new System.Drawing.Size(198, 20);
            this.topic_lb.TabIndex = 8;
            this.topic_lb.Text = "תיאור הנושאים שעלו בפגישה";
            // 
            // tasks_lb
            // 
            this.tasks_lb.AutoSize = true;
            this.tasks_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasks_lb.Location = new System.Drawing.Point(637, 464);
            this.tasks_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tasks_lb.Name = "tasks_lb";
            this.tasks_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tasks_lb.Size = new System.Drawing.Size(223, 20);
            this.tasks_lb.TabIndex = 10;
            this.tasks_lb.Text = "משימות שהוגדרו להמשך התהליך";
            // 
            // tasks_tb
            // 
            this.tasks_tb.Location = new System.Drawing.Point(76, 489);
            this.tasks_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tasks_tb.Multiline = true;
            this.tasks_tb.Name = "tasks_tb";
            this.tasks_tb.Size = new System.Drawing.Size(787, 150);
            this.tasks_tb.TabIndex = 9;
            this.tasks_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // occured_ck
            // 
            this.occured_ck.AutoSize = true;
            this.occured_ck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.occured_ck.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occured_ck.Location = new System.Drawing.Point(672, 217);
            this.occured_ck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.occured_ck.Name = "occured_ck";
            this.occured_ck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.occured_ck.Size = new System.Drawing.Size(186, 24);
            this.occured_ck.TabIndex = 12;
            this.occured_ck.Text = "האם התרחשה הפגישה?";
            this.occured_ck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.occured_ck.UseVisualStyleBackColor = true;
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(46, 670);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(85, 34);
            this.close_bt.TabIndex = 13;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            this.close_bt.MouseLeave += new System.EventHandler(this.close_bt_MouseLeave);
            this.close_bt.MouseHover += new System.EventHandler(this.close_bt_MouseHover);
            // 
            // add_meeting_bt
            // 
            this.add_meeting_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.add_meeting_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_meeting_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_meeting_bt.ForeColor = System.Drawing.Color.White;
            this.add_meeting_bt.Location = new System.Drawing.Point(159, 670);
            this.add_meeting_bt.Name = "add_meeting_bt";
            this.add_meeting_bt.Size = new System.Drawing.Size(106, 34);
            this.add_meeting_bt.TabIndex = 13;
            this.add_meeting_bt.Text = "הוסף פגישה";
            this.add_meeting_bt.UseVisualStyleBackColor = false;
            this.add_meeting_bt.Click += new System.EventHandler(this.addMeeting_bt_Click);
            this.add_meeting_bt.MouseLeave += new System.EventHandler(this.add_meeting_bt_MouseLeave);
            this.add_meeting_bt.MouseHover += new System.EventHandler(this.add_meeting_bt_MouseHover);
            // 
            // MeetingAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 733);
            this.ControlBox = false;
            this.Controls.Add(this.add_meeting_bt);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.topics_tb);
            this.Controls.Add(this.occured_ck);
            this.Controls.Add(this.tasks_lb);
            this.Controls.Add(this.tasks_tb);
            this.Controls.Add(this.topic_lb);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.mitmoded_cb);
            this.Controls.Add(this.address_lb);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.addMeeting_bt);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.address_tb);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MeetingAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMeeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.Button addMeeting_bt;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label date_lb;
        private System.Windows.Forms.Label address_lb;
        private System.Windows.Forms.ComboBox mitmoded_cb;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox topics_tb;
        private System.Windows.Forms.Label topic_lb;
        private System.Windows.Forms.Label tasks_lb;
        private System.Windows.Forms.TextBox tasks_tb;
        private System.Windows.Forms.CheckBox occured_ck;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button add_meeting_bt;
    }
}