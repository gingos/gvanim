namespace GvanimVS
{
    partial class UpdatePassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.ok_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "אנא הכניסי סיסמא";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "אנא הכניסי את אותה הסיסמא בשנית";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(219, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 19);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "_________________________________________________";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.Location = new System.Drawing.Point(221, 213);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 19);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "_________________________________________________";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cancel_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_bt.ForeColor = System.Drawing.Color.White;
            this.cancel_bt.Location = new System.Drawing.Point(33, 269);
            this.cancel_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(100, 35);
            this.cancel_bt.TabIndex = 3;
            this.cancel_bt.Text = "סגור";
            this.cancel_bt.UseVisualStyleBackColor = false;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            this.cancel_bt.MouseLeave += new System.EventHandler(this.cancel_bt_MouseLeave);
            this.cancel_bt.MouseHover += new System.EventHandler(this.cancel_bt_MouseHover);
            // 
            // ok_bt
            // 
            this.ok_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ok_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_bt.ForeColor = System.Drawing.Color.White;
            this.ok_bt.Location = new System.Drawing.Point(165, 269);
            this.ok_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(100, 35);
            this.ok_bt.TabIndex = 3;
            this.ok_bt.Text = "שמור וצא";
            this.ok_bt.UseVisualStyleBackColor = false;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            this.ok_bt.MouseLeave += new System.EventHandler(this.ok_bt_MouseLeave);
            this.ok_bt.MouseHover += new System.EventHandler(this.ok_bt_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(33, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "הסיסמאות אינן זהות";
            this.label3.Visible = false;
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 343);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ok_bt);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdatePassword";
            this.Text = "UpdatePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Button ok_bt;
        private System.Windows.Forms.Label label3;
    }
}