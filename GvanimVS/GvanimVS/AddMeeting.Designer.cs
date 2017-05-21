namespace GvanimVS
{
    partial class AddMeeting
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
            this.SuspendLayout();
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(141, 103);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(227, 20);
            this.address_tb.TabIndex = 0;
            this.address_tb.Text = "כתובת";
            this.address_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addMeeting_bt
            // 
            this.addMeeting_bt.Location = new System.Drawing.Point(135, 558);
            this.addMeeting_bt.Name = "addMeeting_bt";
            this.addMeeting_bt.Size = new System.Drawing.Size(97, 23);
            this.addMeeting_bt.TabIndex = 2;
            this.addMeeting_bt.Text = "הוסף פגישה";
            this.addMeeting_bt.UseVisualStyleBackColor = true;
            this.addMeeting_bt.Click += new System.EventHandler(this.addMeeting_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(31, 558);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 2;
            this.cancel_bt.Text = "ביטול";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(533, 23);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(79, 13);
            this.name_lb.TabIndex = 3;
            this.name_lb.Text = " שם המתמודד:";
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.Location = new System.Drawing.Point(533, 71);
            this.date_lb.Name = "date_lb";
            this.date_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date_lb.Size = new System.Drawing.Size(118, 13);
            this.date_lb.TabIndex = 3;
            this.date_lb.Text = "תאריך ושעת הפגישה:";
            // 
            // address_lb
            // 
            this.address_lb.AutoSize = true;
            this.address_lb.Location = new System.Drawing.Point(566, 110);
            this.address_lb.Name = "address_lb";
            this.address_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.address_lb.Size = new System.Drawing.Size(85, 13);
            this.address_lb.TabIndex = 3;
            this.address_lb.Text = "מיקום הפגישה:";
            // 
            // mitmoded_cb
            // 
            this.mitmoded_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mitmoded_cb.FormattingEnabled = true;
            this.mitmoded_cb.Location = new System.Drawing.Point(279, 15);
            this.mitmoded_cb.Name = "mitmoded_cb";
            this.mitmoded_cb.Size = new System.Drawing.Size(220, 21);
            this.mitmoded_cb.TabIndex = 4;
            this.mitmoded_cb.SelectedIndexChanged += new System.EventHandler(this.mitmoded_cb_SelectedIndexChanged);
            // 
            // city_tb
            // 
            this.city_tb.Location = new System.Drawing.Point(432, 103);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(100, 20);
            this.city_tb.TabIndex = 0;
            this.city_tb.Text = "עיר";
            this.city_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(378, 63);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowCheckBox = true;
            this.datePicker.Size = new System.Drawing.Size(120, 20);
            this.datePicker.TabIndex = 5;
            // 
            // timePicker
            // 
            this.timePicker.Checked = false;
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(279, 63);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowCheckBox = true;
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(87, 20);
            this.timePicker.TabIndex = 6;
            // 
            // topics_tb
            // 
            this.topics_tb.Location = new System.Drawing.Point(57, 193);
            this.topics_tb.Multiline = true;
            this.topics_tb.Name = "topics_tb";
            this.topics_tb.Size = new System.Drawing.Size(591, 99);
            this.topics_tb.TabIndex = 7;
            this.topics_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // topic_lb
            // 
            this.topic_lb.AutoSize = true;
            this.topic_lb.Location = new System.Drawing.Point(489, 156);
            this.topic_lb.Name = "topic_lb";
            this.topic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.topic_lb.Size = new System.Drawing.Size(162, 13);
            this.topic_lb.TabIndex = 8;
            this.topic_lb.Text = "תיאור הנושאים שעלו בפגישה";
            // 
            // tasks_lb
            // 
            this.tasks_lb.AutoSize = true;
            this.tasks_lb.Location = new System.Drawing.Point(473, 320);
            this.tasks_lb.Name = "tasks_lb";
            this.tasks_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tasks_lb.Size = new System.Drawing.Size(178, 13);
            this.tasks_lb.TabIndex = 10;
            this.tasks_lb.Text = "משימות שהוגדרו להמשך התהליך";
            // 
            // tasks_tb
            // 
            this.tasks_tb.Location = new System.Drawing.Point(57, 357);
            this.tasks_tb.Multiline = true;
            this.tasks_tb.Name = "tasks_tb";
            this.tasks_tb.Size = new System.Drawing.Size(591, 99);
            this.tasks_tb.TabIndex = 9;
            this.tasks_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 629);
            this.Controls.Add(this.tasks_lb);
            this.Controls.Add(this.tasks_tb);
            this.Controls.Add(this.topic_lb);
            this.Controls.Add(this.topics_tb);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddMeeting";
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
    }
}