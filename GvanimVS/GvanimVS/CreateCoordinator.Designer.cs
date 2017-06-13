namespace GvanimVS
{
    partial class CreateCoordinator
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
            this.private_name_lb = new System.Windows.Forms.Label();
            this.firstName_tb = new System.Windows.Forms.TextBox();
            this.family_name_lb = new System.Windows.Forms.Label();
            this.lastName_tb = new System.Windows.Forms.TextBox();
            this.email_lb = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.identity_lb = new System.Windows.Forms.Label();
            this.identity_tb = new System.Windows.Forms.TextBox();
            this.password_lb = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.close_bt = new System.Windows.Forms.Button();
            this.save_bt = new System.Windows.Forms.Button();
            this.email_exception_lb = new System.Windows.Forms.Label();
            this.identity_exception_lb = new System.Windows.Forms.Label();
            this.job_lb = new System.Windows.Forms.Label();
            this.job_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // private_name_lb
            // 
            this.private_name_lb.AutoSize = true;
            this.private_name_lb.Location = new System.Drawing.Point(416, 49);
            this.private_name_lb.Name = "private_name_lb";
            this.private_name_lb.Size = new System.Drawing.Size(51, 13);
            this.private_name_lb.TabIndex = 0;
            this.private_name_lb.Text = "שם פרטי";
            // 
            // firstName_tb
            // 
            this.firstName_tb.Location = new System.Drawing.Point(292, 46);
            this.firstName_tb.Name = "firstName_tb";
            this.firstName_tb.Size = new System.Drawing.Size(100, 20);
            this.firstName_tb.TabIndex = 1;
            // 
            // family_name_lb
            // 
            this.family_name_lb.AutoSize = true;
            this.family_name_lb.Location = new System.Drawing.Point(416, 90);
            this.family_name_lb.Name = "family_name_lb";
            this.family_name_lb.Size = new System.Drawing.Size(63, 13);
            this.family_name_lb.TabIndex = 0;
            this.family_name_lb.Text = "שם משפחה";
            // 
            // lastName_tb
            // 
            this.lastName_tb.Location = new System.Drawing.Point(292, 87);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(100, 20);
            this.lastName_tb.TabIndex = 1;
            // 
            // email_lb
            // 
            this.email_lb.AutoSize = true;
            this.email_lb.Location = new System.Drawing.Point(416, 135);
            this.email_lb.Name = "email_lb";
            this.email_lb.Size = new System.Drawing.Size(75, 13);
            this.email_lb.TabIndex = 0;
            this.email_lb.Text = "כתובת דוא\"ל";
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(292, 132);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(100, 20);
            this.email_tb.TabIndex = 1;
            // 
            // identity_lb
            // 
            this.identity_lb.AutoSize = true;
            this.identity_lb.Location = new System.Drawing.Point(416, 180);
            this.identity_lb.Name = "identity_lb";
            this.identity_lb.Size = new System.Drawing.Size(67, 13);
            this.identity_lb.TabIndex = 0;
            this.identity_lb.Text = "תעודת זהות";
            // 
            // identity_tb
            // 
            this.identity_tb.Location = new System.Drawing.Point(292, 177);
            this.identity_tb.Name = "identity_tb";
            this.identity_tb.Size = new System.Drawing.Size(100, 20);
            this.identity_tb.TabIndex = 1;
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Location = new System.Drawing.Point(416, 229);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(89, 13);
            this.password_lb.TabIndex = 0;
            this.password_lb.Text = "סיסמא ראשונית";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(292, 226);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(100, 20);
            this.password_tb.TabIndex = 1;
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(46, 291);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 2;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // save_bt
            // 
            this.save_bt.Location = new System.Drawing.Point(156, 290);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(75, 23);
            this.save_bt.TabIndex = 3;
            this.save_bt.Text = "שמור";
            this.save_bt.UseVisualStyleBackColor = true;
            this.save_bt.Click += new System.EventHandler(this.save_bt_Click);
            // 
            // email_exception_lb
            // 
            this.email_exception_lb.AutoSize = true;
            this.email_exception_lb.ForeColor = System.Drawing.Color.Red;
            this.email_exception_lb.Location = new System.Drawing.Point(141, 135);
            this.email_exception_lb.Name = "email_exception_lb";
            this.email_exception_lb.Size = new System.Drawing.Size(132, 13);
            this.email_exception_lb.TabIndex = 4;
            this.email_exception_lb.Text = "כתובת אימייל לא תקינה";
            this.email_exception_lb.Visible = false;
            // 
            // identity_exception_lb
            // 
            this.identity_exception_lb.AutoSize = true;
            this.identity_exception_lb.ForeColor = System.Drawing.Color.Red;
            this.identity_exception_lb.Location = new System.Drawing.Point(153, 180);
            this.identity_exception_lb.Name = "identity_exception_lb";
            this.identity_exception_lb.Size = new System.Drawing.Size(119, 13);
            this.identity_exception_lb.TabIndex = 4;
            this.identity_exception_lb.Text = "תעודת זהות לא תקינה";
            this.identity_exception_lb.Visible = false;
            // 
            // job_lb
            // 
            this.job_lb.AutoSize = true;
            this.job_lb.Location = new System.Drawing.Point(416, 272);
            this.job_lb.Name = "job_lb";
            this.job_lb.Size = new System.Drawing.Size(40, 13);
            this.job_lb.TabIndex = 0;
            this.job_lb.Text = "תפקיד";
            // 
            // job_cb
            // 
            this.job_cb.FormattingEnabled = true;
            this.job_cb.Items.AddRange(new object[] {
            "מנהלת",
            "רכזת"});
            this.job_cb.Location = new System.Drawing.Point(271, 269);
            this.job_cb.Name = "job_cb";
            this.job_cb.Size = new System.Drawing.Size(121, 21);
            this.job_cb.TabIndex = 5;
            // 
            // CreateCoordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 363);
            this.Controls.Add(this.job_cb);
            this.Controls.Add(this.identity_exception_lb);
            this.Controls.Add(this.email_exception_lb);
            this.Controls.Add(this.save_bt);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.identity_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.lastName_tb);
            this.Controls.Add(this.firstName_tb);
            this.Controls.Add(this.job_lb);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.identity_lb);
            this.Controls.Add(this.email_lb);
            this.Controls.Add(this.family_name_lb);
            this.Controls.Add(this.private_name_lb);
            this.Name = "CreateCoordinator";
            this.Text = "CreateCoordinator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label private_name_lb;
        private System.Windows.Forms.TextBox firstName_tb;
        private System.Windows.Forms.Label family_name_lb;
        private System.Windows.Forms.TextBox lastName_tb;
        private System.Windows.Forms.Label email_lb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label identity_lb;
        private System.Windows.Forms.TextBox identity_tb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button save_bt;
        private System.Windows.Forms.Label email_exception_lb;
        private System.Windows.Forms.Label identity_exception_lb;
        private System.Windows.Forms.Label job_lb;
        private System.Windows.Forms.ComboBox job_cb;
    }
}