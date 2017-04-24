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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "תאריך הביקור";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // visitDate_dtp
            // 
            this.visitDate_dtp.Location = new System.Drawing.Point(588, 66);
            this.visitDate_dtp.Name = "visitDate_dtp";
            this.visitDate_dtp.Size = new System.Drawing.Size(200, 20);
            this.visitDate_dtp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "פירוט המצב ע\"פ דיווח";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // discription_tb
            // 
            this.discription_tb.Location = new System.Drawing.Point(399, 159);
            this.discription_tb.Multiline = true;
            this.discription_tb.Name = "discription_tb";
            this.discription_tb.Size = new System.Drawing.Size(389, 100);
            this.discription_tb.TabIndex = 2;
            this.discription_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "צרף מכתב ביקור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveCheckUp_btn
            // 
            this.saveCheckUp_btn.Location = new System.Drawing.Point(399, 276);
            this.saveCheckUp_btn.Name = "saveCheckUp_btn";
            this.saveCheckUp_btn.Size = new System.Drawing.Size(75, 23);
            this.saveCheckUp_btn.TabIndex = 4;
            this.saveCheckUp_btn.Text = "שמור ביקור";
            this.saveCheckUp_btn.UseVisualStyleBackColor = true;
            this.saveCheckUp_btn.Click += new System.EventHandler(this.saveCheckUp_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(805, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "שם הרופא ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // doctorName_tb
            // 
            this.doctorName_tb.Location = new System.Drawing.Point(399, 111);
            this.doctorName_tb.Name = "doctorName_tb";
            this.doctorName_tb.Size = new System.Drawing.Size(389, 20);
            this.doctorName_tb.TabIndex = 2;
            this.doctorName_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "מכתב ביקור צורף בהצלחה";
            // 
            // PsychiatricCheckUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 392);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveCheckUp_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doctorName_tb);
            this.Controls.Add(this.discription_tb);
            this.Controls.Add(this.visitDate_dtp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
    }
}