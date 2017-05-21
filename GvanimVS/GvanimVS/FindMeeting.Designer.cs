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
            this.adress_tb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mitmodedName_cb = new System.Windows.Forms.ComboBox();
            this.Occured_cb = new System.Windows.Forms.ComboBox();
            this.searchMeeting_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // meetingID_tb
            // 
            this.meetingID_tb.Location = new System.Drawing.Point(194, 57);
            this.meetingID_tb.Name = "meetingID_tb";
            this.meetingID_tb.Size = new System.Drawing.Size(100, 20);
            this.meetingID_tb.TabIndex = 0;
            // 
            // city_tb
            // 
            this.city_tb.Location = new System.Drawing.Point(194, 138);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(100, 20);
            this.city_tb.TabIndex = 0;
            this.city_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // adress_tb
            // 
            this.adress_tb.Location = new System.Drawing.Point(194, 177);
            this.adress_tb.Name = "adress_tb";
            this.adress_tb.Size = new System.Drawing.Size(100, 20);
            this.adress_tb.TabIndex = 0;
            this.adress_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "אנא בחרי את שם המתמודד";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "אם ידוע מס\"ד של הפגישה נא לרשום אותו כאן";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "אם ידועה הכתובת נא לרשום אותה כאן";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "אם ידוע שם העיר נא לרשום אותו כאן";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "האם הפגישה התקיימה או בוטלה";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "אם ידוע התאריך נא לכתוב אותו כאן";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // mitmodedName_cb
            // 
            this.mitmodedName_cb.FormattingEnabled = true;
            this.mitmodedName_cb.Location = new System.Drawing.Point(173, 95);
            this.mitmodedName_cb.Name = "mitmodedName_cb";
            this.mitmodedName_cb.Size = new System.Drawing.Size(121, 21);
            this.mitmodedName_cb.TabIndex = 3;
            // 
            // Occured_cb
            // 
            this.Occured_cb.FormattingEnabled = true;
            this.Occured_cb.Location = new System.Drawing.Point(171, 220);
            this.Occured_cb.Name = "Occured_cb";
            this.Occured_cb.Size = new System.Drawing.Size(121, 21);
            this.Occured_cb.TabIndex = 4;
            // 
            // searchMeeting_bt
            // 
            this.searchMeeting_bt.Location = new System.Drawing.Point(216, 321);
            this.searchMeeting_bt.Name = "searchMeeting_bt";
            this.searchMeeting_bt.Size = new System.Drawing.Size(75, 23);
            this.searchMeeting_bt.TabIndex = 5;
            this.searchMeeting_bt.Text = "חפש פגישה";
            this.searchMeeting_bt.UseVisualStyleBackColor = true;
            this.searchMeeting_bt.Click += new System.EventHandler(this.searchMeeting_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(108, 321);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 5;
            this.cancel_bt.Text = "ביטול";
            this.cancel_bt.UseVisualStyleBackColor = true;
            // 
            // FindMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 374);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.searchMeeting_bt);
            this.Controls.Add(this.Occured_cb);
            this.Controls.Add(this.mitmodedName_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.adress_tb);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.meetingID_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindMeeting";
            this.Text = "FindMeeting";
            this.Load += new System.EventHandler(this.FindMeeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox meetingID_tb;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.TextBox adress_tb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox mitmodedName_cb;
        private System.Windows.Forms.ComboBox Occured_cb;
        private System.Windows.Forms.Button searchMeeting_bt;
        private System.Windows.Forms.Button cancel_bt;
    }
}