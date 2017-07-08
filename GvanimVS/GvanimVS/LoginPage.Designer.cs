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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.status_pb = new System.Windows.Forms.PictureBox();
            this.name_lb = new System.Windows.Forms.Label();
            this.login_bt = new System.Windows.Forms.Button();
            this.user_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.password_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.status_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // status_pb
            // 
            this.status_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.status_pb.Image = ((System.Drawing.Image)(resources.GetObject("status_pb.Image")));
            this.status_pb.Location = new System.Drawing.Point(12, 12);
            this.status_pb.Name = "status_pb";
            this.status_pb.Size = new System.Drawing.Size(28, 27);
            this.status_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.status_pb.TabIndex = 9;
            this.status_pb.TabStop = false;
            // 
            // name_lb
            // 
            this.name_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.ForeColor = System.Drawing.Color.Black;
            this.name_lb.Location = new System.Drawing.Point(395, 118);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(142, 20);
            this.name_lb.TabIndex = 11;
            this.name_lb.Text = "תעודת זהות \\ אימייל:";
            // 
            // login_bt
            // 
            this.login_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.login_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_bt.ForeColor = System.Drawing.Color.White;
            this.login_bt.Location = new System.Drawing.Point(260, 273);
            this.login_bt.Margin = new System.Windows.Forms.Padding(25);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(229, 28);
            this.login_bt.TabIndex = 15;
            this.login_bt.Text = "כניסה למשתמשים רשומים";
            this.login_bt.UseVisualStyleBackColor = false;
            // 
            // user_tb
            // 
            this.user_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_tb.ForeColor = System.Drawing.Color.DarkGray;
            this.user_tb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.user_tb.Location = new System.Drawing.Point(203, 150);
            this.user_tb.MaxLength = 50;
            this.user_tb.Name = "user_tb";
            this.user_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.user_tb.Size = new System.Drawing.Size(329, 13);
            this.user_tb.TabIndex = 12;
            this.user_tb.Text = "_______________________________________________________";
            // 
            // password_tb
            // 
            this.password_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_tb.ForeColor = System.Drawing.Color.DarkGray;
            this.password_tb.Location = new System.Drawing.Point(203, 231);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(329, 13);
            this.password_tb.TabIndex = 13;
            this.password_tb.Text = "___________________________________________________________";
            // 
            // password_lb
            // 
            this.password_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lb.ForeColor = System.Drawing.Color.Black;
            this.password_lb.Location = new System.Drawing.Point(481, 197);
            this.password_lb.Name = "password_lb";
            this.password_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password_lb.Size = new System.Drawing.Size(56, 20);
            this.password_lb.TabIndex = 14;
            this.password_lb.Text = "סיסמא:";
            // 
            // LoginPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 418);
            this.ControlBox = false;
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.login_bt);
            this.Controls.Add(this.user_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.status_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.Shown += new System.EventHandler(this.LoginPage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.status_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox status_pb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Button login_bt;
        private System.Windows.Forms.TextBox user_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label password_lb;
    }
}