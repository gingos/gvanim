namespace GvanimVS
{
    partial class LoginPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name_lb = new System.Windows.Forms.Label();
            this.user_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.password_lb = new System.Windows.Forms.Label();
            this.login_bt = new System.Windows.Forms.Button();
            this.signup_bt = new System.Windows.Forms.Button();
            this.exit_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GvanimVS.Properties.Resources.backgroundGvanim;
            this.pictureBox1.Location = new System.Drawing.Point(41, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(421, 186);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(118, 13);
            this.name_lb.TabIndex = 1;
            this.name_lb.Text = "תעודת זהות \\ אימייל:";
            // 
            // user_tb
            // 
            this.user_tb.Location = new System.Drawing.Point(224, 186);
            this.user_tb.Name = "user_tb";
            this.user_tb.Size = new System.Drawing.Size(179, 20);
            this.user_tb.TabIndex = 2;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(224, 224);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(179, 20);
            this.password_tb.TabIndex = 4;
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Location = new System.Drawing.Point(495, 224);
            this.password_lb.Name = "password_lb";
            this.password_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password_lb.Size = new System.Drawing.Size(44, 13);
            this.password_lb.TabIndex = 3;
            this.password_lb.Text = "סיסמא:";
            // 
            // login_bt
            // 
            this.login_bt.Location = new System.Drawing.Point(328, 278);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(75, 56);
            this.login_bt.TabIndex = 5;
            this.login_bt.Text = "כניסה למשתמשים רשומים";
            this.login_bt.UseVisualStyleBackColor = true;
            this.login_bt.Click += new System.EventHandler(this.login_bt_Click);
            // 
            // signup_bt
            // 
            this.signup_bt.Location = new System.Drawing.Point(224, 278);
            this.signup_bt.Name = "signup_bt";
            this.signup_bt.Size = new System.Drawing.Size(75, 56);
            this.signup_bt.TabIndex = 6;
            this.signup_bt.Text = "הרשמה למשתמשים חדשים";
            this.signup_bt.UseVisualStyleBackColor = true;
            // 
            // exit_bt
            // 
            this.exit_bt.Location = new System.Drawing.Point(41, 278);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(75, 56);
            this.exit_bt.TabIndex = 7;
            this.exit_bt.Text = "יציאה מהמערכת";
            this.exit_bt.UseVisualStyleBackColor = true;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 360);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.signup_bt);
            this.Controls.Add(this.login_bt);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.user_tb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.TextBox user_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.Button login_bt;
        private System.Windows.Forms.Button signup_bt;
        private System.Windows.Forms.Button exit_bt;
    }
}