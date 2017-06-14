namespace GvanimVS
{
    partial class CoordinatorCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordinatorCard));
            this.update_password_bt = new System.Windows.Forms.Button();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.ok_bt = new System.Windows.Forms.Button();
            this.phone2_tb = new System.Windows.Forms.TextBox();
            this.phone2_lb = new System.Windows.Forms.Label();
            this.phone1_tb = new System.Windows.Forms.TextBox();
            this.phone1_lb = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.street_lb = new System.Windows.Forms.Label();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.city_lb = new System.Windows.Forms.Label();
            this.ID_tb = new System.Windows.Forms.TextBox();
            this.ID_lb = new System.Windows.Forms.Label();
            this.birth_lb = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lastName_tb = new System.Windows.Forms.TextBox();
            this.lastName_lb = new System.Windows.Forms.Label();
            this.firstName_tb = new System.Windows.Forms.TextBox();
            this.firstName_lb = new System.Windows.Forms.Label();
            this.profile_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // update_password_bt
            // 
            this.update_password_bt.Location = new System.Drawing.Point(124, 256);
            this.update_password_bt.Name = "update_password_bt";
            this.update_password_bt.Size = new System.Drawing.Size(75, 38);
            this.update_password_bt.TabIndex = 44;
            this.update_password_bt.Text = "עדכון סיסמא";
            this.update_password_bt.UseVisualStyleBackColor = true;
            this.update_password_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(12, 192);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(153, 20);
            this.email_tb.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 192);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "מייל";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(12, 308);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 41;
            this.cancel_bt.Text = "ביטול";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // ok_bt
            // 
            this.ok_bt.Location = new System.Drawing.Point(124, 308);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(75, 23);
            this.ok_bt.TabIndex = 40;
            this.ok_bt.Text = "שמור וצא";
            this.ok_bt.UseVisualStyleBackColor = true;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // phone2_tb
            // 
            this.phone2_tb.Location = new System.Drawing.Point(221, 308);
            this.phone2_tb.Name = "phone2_tb";
            this.phone2_tb.Size = new System.Drawing.Size(200, 20);
            this.phone2_tb.TabIndex = 38;
            // 
            // phone2_lb
            // 
            this.phone2_lb.AutoSize = true;
            this.phone2_lb.Location = new System.Drawing.Point(427, 308);
            this.phone2_lb.Name = "phone2_lb";
            this.phone2_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone2_lb.Size = new System.Drawing.Size(47, 13);
            this.phone2_lb.TabIndex = 37;
            this.phone2_lb.Text = "טלפון 2";
            // 
            // phone1_tb
            // 
            this.phone1_tb.Location = new System.Drawing.Point(221, 271);
            this.phone1_tb.Name = "phone1_tb";
            this.phone1_tb.Size = new System.Drawing.Size(200, 20);
            this.phone1_tb.TabIndex = 36;
            // 
            // phone1_lb
            // 
            this.phone1_lb.AutoSize = true;
            this.phone1_lb.Location = new System.Drawing.Point(427, 271);
            this.phone1_lb.Name = "phone1_lb";
            this.phone1_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone1_lb.Size = new System.Drawing.Size(47, 13);
            this.phone1_lb.TabIndex = 35;
            this.phone1_lb.Text = "טלפון 1";
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(221, 234);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(200, 20);
            this.address_tb.TabIndex = 34;
            // 
            // street_lb
            // 
            this.street_lb.AutoSize = true;
            this.street_lb.Location = new System.Drawing.Point(427, 234);
            this.street_lb.Name = "street_lb";
            this.street_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.street_lb.Size = new System.Drawing.Size(56, 13);
            this.street_lb.TabIndex = 33;
            this.street_lb.Text = "רחוב ומס\'";
            // 
            // city_tb
            // 
            this.city_tb.Location = new System.Drawing.Point(221, 192);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(200, 20);
            this.city_tb.TabIndex = 32;
            // 
            // city_lb
            // 
            this.city_lb.AutoSize = true;
            this.city_lb.Location = new System.Drawing.Point(427, 192);
            this.city_lb.Name = "city_lb";
            this.city_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.city_lb.Size = new System.Drawing.Size(64, 13);
            this.city_lb.TabIndex = 31;
            this.city_lb.Text = "עיר מגורים";
            // 
            // ID_tb
            // 
            this.ID_tb.Location = new System.Drawing.Point(221, 152);
            this.ID_tb.Name = "ID_tb";
            this.ID_tb.Size = new System.Drawing.Size(200, 20);
            this.ID_tb.TabIndex = 30;
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(427, 152);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lb.Size = new System.Drawing.Size(67, 13);
            this.ID_lb.TabIndex = 29;
            this.ID_lb.Text = "תעודת זהות";
            this.ID_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birth_lb
            // 
            this.birth_lb.AutoSize = true;
            this.birth_lb.Location = new System.Drawing.Point(427, 113);
            this.birth_lb.Name = "birth_lb";
            this.birth_lb.Size = new System.Drawing.Size(69, 13);
            this.birth_lb.TabIndex = 28;
            this.birth_lb.Text = "תאריך לידה";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // lastName_tb
            // 
            this.lastName_tb.Location = new System.Drawing.Point(221, 70);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(200, 20);
            this.lastName_tb.TabIndex = 26;
            // 
            // lastName_lb
            // 
            this.lastName_lb.AutoSize = true;
            this.lastName_lb.Location = new System.Drawing.Point(427, 70);
            this.lastName_lb.Name = "lastName_lb";
            this.lastName_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lastName_lb.Size = new System.Drawing.Size(63, 13);
            this.lastName_lb.TabIndex = 25;
            this.lastName_lb.Text = "שם משפחה";
            // 
            // firstName_tb
            // 
            this.firstName_tb.Location = new System.Drawing.Point(221, 32);
            this.firstName_tb.Name = "firstName_tb";
            this.firstName_tb.Size = new System.Drawing.Size(200, 20);
            this.firstName_tb.TabIndex = 24;
            // 
            // firstName_lb
            // 
            this.firstName_lb.AutoSize = true;
            this.firstName_lb.Location = new System.Drawing.Point(427, 32);
            this.firstName_lb.Name = "firstName_lb";
            this.firstName_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstName_lb.Size = new System.Drawing.Size(51, 13);
            this.firstName_lb.TabIndex = 23;
            this.firstName_lb.Text = "שם פרטי";
            this.firstName_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profile_pb
            // 
            this.profile_pb.Image = ((System.Drawing.Image)(resources.GetObject("profile_pb.Image")));
            this.profile_pb.InitialImage = ((System.Drawing.Image)(resources.GetObject("profile_pb.InitialImage")));
            this.profile_pb.Location = new System.Drawing.Point(12, 32);
            this.profile_pb.Name = "profile_pb";
            this.profile_pb.Size = new System.Drawing.Size(187, 140);
            this.profile_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_pb.TabIndex = 39;
            this.profile_pb.TabStop = false;
            this.profile_pb.Click += new System.EventHandler(this.profile_pb_Click);
            // 
            // CoordinatorCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 370);
            this.Controls.Add(this.update_password_bt);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.ok_bt);
            this.Controls.Add(this.profile_pb);
            this.Controls.Add(this.phone2_tb);
            this.Controls.Add(this.phone2_lb);
            this.Controls.Add(this.phone1_tb);
            this.Controls.Add(this.phone1_lb);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.street_lb);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.city_lb);
            this.Controls.Add(this.ID_tb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.birth_lb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lastName_tb);
            this.Controls.Add(this.lastName_lb);
            this.Controls.Add(this.firstName_tb);
            this.Controls.Add(this.firstName_lb);
            this.Name = "CoordinatorCard";
            this.Text = "CoordinatorCard";
            ((System.ComponentModel.ISupportInitialize)(this.profile_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_password_bt;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Button ok_bt;
        private System.Windows.Forms.PictureBox profile_pb;
        private System.Windows.Forms.TextBox phone2_tb;
        private System.Windows.Forms.Label phone2_lb;
        private System.Windows.Forms.TextBox phone1_tb;
        private System.Windows.Forms.Label phone1_lb;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.Label street_lb;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.Label city_lb;
        private System.Windows.Forms.TextBox ID_tb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label birth_lb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox lastName_tb;
        private System.Windows.Forms.Label lastName_lb;
        private System.Windows.Forms.TextBox firstName_tb;
        private System.Windows.Forms.Label firstName_lb;
    }
}