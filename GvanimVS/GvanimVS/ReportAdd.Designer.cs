namespace GvanimVS
{
    partial class ReportAdd
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
            this.saveReport_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportSerialNum_lb = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.reportDiscription_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.activityDiscription_tb = new System.Windows.Forms.TextBox();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.ID_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveReport_bt
            // 
            this.saveReport_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveReport_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveReport_bt.ForeColor = System.Drawing.Color.White;
            this.saveReport_bt.Location = new System.Drawing.Point(141, 514);
            this.saveReport_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveReport_bt.Name = "saveReport_bt";
            this.saveReport_bt.Size = new System.Drawing.Size(172, 35);
            this.saveReport_bt.TabIndex = 0;
            this.saveReport_bt.Text = "שמור דו\"ח וסגור";
            this.saveReport_bt.UseVisualStyleBackColor = false;
            this.saveReport_bt.Click += new System.EventHandler(this.saveReport_bt_Click);
            this.saveReport_bt.MouseLeave += new System.EventHandler(this.saveReport_bt_MouseLeave);
            this.saveReport_bt.MouseHover += new System.EventHandler(this.saveReport_bt_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = ":מס\"ד";
            // 
            // ReportSerialNum_lb
            // 
            this.ReportSerialNum_lb.AutoSize = true;
            this.ReportSerialNum_lb.Location = new System.Drawing.Point(436, 75);
            this.ReportSerialNum_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportSerialNum_lb.Name = "ReportSerialNum_lb";
            this.ReportSerialNum_lb.Size = new System.Drawing.Size(91, 20);
            this.ReportSerialNum_lb.TabIndex = 3;
            this.ReportSerialNum_lb.Text = "mm-dd-yyyy";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(347, 123);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = ":שם המתמודד";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(347, 195);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 26);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = ":תאריך";
            // 
            // reportDiscription_tb
            // 
            this.reportDiscription_tb.Location = new System.Drawing.Point(143, 258);
            this.reportDiscription_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportDiscription_tb.Multiline = true;
            this.reportDiscription_tb.Name = "reportDiscription_tb";
            this.reportDiscription_tb.Size = new System.Drawing.Size(492, 81);
            this.reportDiscription_tb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = ":תיאור";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = ":פעולות שננקטו";
            // 
            // activityDiscription_tb
            // 
            this.activityDiscription_tb.Location = new System.Drawing.Point(141, 392);
            this.activityDiscription_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.activityDiscription_tb.Multiline = true;
            this.activityDiscription_tb.Name = "activityDiscription_tb";
            this.activityDiscription_tb.Size = new System.Drawing.Size(492, 81);
            this.activityDiscription_tb.TabIndex = 9;
            // 
            // cancel_bt
            // 
            this.cancel_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cancel_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_bt.ForeColor = System.Drawing.Color.White;
            this.cancel_bt.Location = new System.Drawing.Point(33, 514);
            this.cancel_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(100, 35);
            this.cancel_bt.TabIndex = 11;
            this.cancel_bt.Text = "ביטול";
            this.cancel_bt.UseVisualStyleBackColor = false;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            this.cancel_bt.MouseLeave += new System.EventHandler(this.cancel_bt_MouseLeave);
            this.cancel_bt.MouseHover += new System.EventHandler(this.cancel_bt_MouseHover);
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(537, 75);
            this.ID_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(33, 20);
            this.ID_lb.TabIndex = 12;
            this.ID_lb.Text = "ת.ז.";
            // 
            // ReportAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 565);
            this.ControlBox = false;
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.activityDiscription_tb);
            this.Controls.Add(this.reportDiscription_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ReportSerialNum_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveReport_bt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportAdd";
            this.ShowIcon = false;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveReport_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReportSerialNum_lb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reportDiscription_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox activityDiscription_tb;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Label ID_lb;
    }
}