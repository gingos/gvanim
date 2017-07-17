namespace GvanimVS
{
    partial class PsychiatricCheckUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.visitDate_dtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.discription_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveCheckUp_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.doctorName_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.close_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "תאריך הביקור";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // visitDate_dtp
            // 
            this.visitDate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.visitDate_dtp.Location = new System.Drawing.Point(434, 89);
            this.visitDate_dtp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visitDate_dtp.Name = "visitDate_dtp";
            this.visitDate_dtp.Size = new System.Drawing.Size(147, 26);
            this.visitDate_dtp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "פירוט המצב ע\"פ דיווח";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // discription_tb
            // 
            this.discription_tb.Location = new System.Drawing.Point(64, 232);
            this.discription_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discription_tb.Multiline = true;
            this.discription_tb.Name = "discription_tb";
            this.discription_tb.Size = new System.Drawing.Size(517, 152);
            this.discription_tb.TabIndex = 2;
            this.discription_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(413, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "צרף מכתב ביקור";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // saveCheckUp_btn
            // 
            this.saveCheckUp_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveCheckUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCheckUp_btn.ForeColor = System.Drawing.Color.White;
            this.saveCheckUp_btn.Location = new System.Drawing.Point(64, 412);
            this.saveCheckUp_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveCheckUp_btn.Name = "saveCheckUp_btn";
            this.saveCheckUp_btn.Size = new System.Drawing.Size(100, 35);
            this.saveCheckUp_btn.TabIndex = 4;
            this.saveCheckUp_btn.Text = "שמור ביקור";
            this.saveCheckUp_btn.UseVisualStyleBackColor = false;
            this.saveCheckUp_btn.Click += new System.EventHandler(this.saveCheckUp_btn_Click);
            this.saveCheckUp_btn.MouseLeave += new System.EventHandler(this.saveCheckUp_btn_MouseLeave);
            this.saveCheckUp_btn.MouseHover += new System.EventHandler(this.saveCheckUp_btn_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "שם הרופא ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // doctorName_tb
            // 
            this.doctorName_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.doctorName_tb.Location = new System.Drawing.Point(184, 163);
            this.doctorName_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doctorName_tb.Name = "doctorName_tb";
            this.doctorName_tb.Size = new System.Drawing.Size(398, 25);
            this.doctorName_tb.TabIndex = 2;
            this.doctorName_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 480);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "מכתב ביקור צורף בהצלחה";
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(65, 506);
            this.close_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(100, 35);
            this.close_bt.TabIndex = 6;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Click += new System.EventHandler(this.button2_Click);
            this.close_bt.MouseLeave += new System.EventHandler(this.close_bt_MouseLeave);
            this.close_bt.MouseHover += new System.EventHandler(this.close_bt_MouseHover);
            // 
            // PsychiatricCheckUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 603);
            this.ControlBox = false;
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveCheckUp_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doctorName_tb);
            this.Controls.Add(this.discription_tb);
            this.Controls.Add(this.visitDate_dtp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PsychiatricCheckUp";
            this.Text = "PsychiatricCheckUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker visitDate_dtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox discription_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveCheckUp_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox doctorName_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button close_bt;
    }
}