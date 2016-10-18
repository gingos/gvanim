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
            this.adress_tb = new System.Windows.Forms.TextBox();
            this.addMeeting_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mitmoded_cb = new System.Windows.Forms.ComboBox();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // adress_tb
            // 
            this.adress_tb.Location = new System.Drawing.Point(245, 240);
            this.adress_tb.Name = "adress_tb";
            this.adress_tb.Size = new System.Drawing.Size(100, 20);
            this.adress_tb.TabIndex = 0;
            this.adress_tb.Text = "כתובת";
            this.adress_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addMeeting_bt
            // 
            this.addMeeting_bt.Location = new System.Drawing.Point(184, 347);
            this.addMeeting_bt.Name = "addMeeting_bt";
            this.addMeeting_bt.Size = new System.Drawing.Size(97, 23);
            this.addMeeting_bt.TabIndex = 2;
            this.addMeeting_bt.Text = "הוסף פגישה";
            this.addMeeting_bt.UseVisualStyleBackColor = true;
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(89, 347);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 2;
            this.cancel_bt.Text = "ביטול";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 112);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " שם המתמודד:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 160);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "תאריך ושעת הפגישה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "אנא רשמי את מיקום הפגישה";
            // 
            // mitmoded_cb
            // 
            this.mitmoded_cb.FormattingEnabled = true;
            this.mitmoded_cb.Location = new System.Drawing.Point(224, 104);
            this.mitmoded_cb.Name = "mitmoded_cb";
            this.mitmoded_cb.Size = new System.Drawing.Size(121, 21);
            this.mitmoded_cb.TabIndex = 4;
            // 
            // city_tb
            // 
            this.city_tb.Location = new System.Drawing.Point(245, 202);
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
            this.datePicker.Location = new System.Drawing.Point(224, 152);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowCheckBox = true;
            this.datePicker.Size = new System.Drawing.Size(120, 20);
            this.datePicker.TabIndex = 5;
            // 
            // timePicker
            // 
            this.timePicker.Checked = false;
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(125, 152);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowCheckBox = true;
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(87, 20);
            this.timePicker.TabIndex = 6;
            // 
            // AddMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 408);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.mitmoded_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.addMeeting_bt);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.adress_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMeeting";
            this.Text = "AddMeeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adress_tb;
        private System.Windows.Forms.Button addMeeting_bt;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mitmoded_cb;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}