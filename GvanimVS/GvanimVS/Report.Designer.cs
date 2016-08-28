namespace GvanimVS
{
    partial class Report
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
            this.saveReport_bt.Location = new System.Drawing.Point(106, 334);
            this.saveReport_bt.Name = "saveReport_bt";
            this.saveReport_bt.Size = new System.Drawing.Size(129, 23);
            this.saveReport_bt.TabIndex = 0;
            this.saveReport_bt.Text = "שמור דו\"ח וסגור";
            this.saveReport_bt.UseVisualStyleBackColor = true;
            this.saveReport_bt.Click += new System.EventHandler(this.saveReport_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ":מס\"ד";
            // 
            // ReportSerialNum_lb
            // 
            this.ReportSerialNum_lb.AutoSize = true;
            this.ReportSerialNum_lb.Location = new System.Drawing.Point(327, 49);
            this.ReportSerialNum_lb.Name = "ReportSerialNum_lb";
            this.ReportSerialNum_lb.Size = new System.Drawing.Size(51, 13);
            this.ReportSerialNum_lb.TabIndex = 3;
            this.ReportSerialNum_lb.Text = "yy-dd-mm";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ":שם המתמודד";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = ":תאריך";
            // 
            // reportDiscription_tb
            // 
            this.reportDiscription_tb.Location = new System.Drawing.Point(107, 168);
            this.reportDiscription_tb.Multiline = true;
            this.reportDiscription_tb.Name = "reportDiscription_tb";
            this.reportDiscription_tb.Size = new System.Drawing.Size(370, 54);
            this.reportDiscription_tb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = ":תאור";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = ":פעולות שננקטו";
            // 
            // activityDiscription_tb
            // 
            this.activityDiscription_tb.Location = new System.Drawing.Point(106, 255);
            this.activityDiscription_tb.Multiline = true;
            this.activityDiscription_tb.Name = "activityDiscription_tb";
            this.activityDiscription_tb.Size = new System.Drawing.Size(370, 54);
            this.activityDiscription_tb.TabIndex = 9;
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(25, 334);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 11;
            this.cancel_bt.Text = "ביטול";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(384, 49);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(18, 13);
            this.ID_lb.TabIndex = 12;
            this.ID_lb.Text = "ID";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 369);
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
            this.Name = "Report";
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