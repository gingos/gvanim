namespace GvanimVS
{
    partial class RegionManagerCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegionManagerCard));
            this.firstName_lb = new System.Windows.Forms.Label();
            this.firstName_tb = new System.Windows.Forms.TextBox();
            this.lastName_tb = new System.Windows.Forms.TextBox();
            this.lastName_lb = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.birth_lb = new System.Windows.Forms.Label();
            this.ID_tb = new System.Windows.Forms.TextBox();
            this.ID_lb = new System.Windows.Forms.Label();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.city_lb = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.street_lb = new System.Windows.Forms.Label();
            this.phone1_tb = new System.Windows.Forms.TextBox();
            this.phone1_lb = new System.Windows.Forms.Label();
            this.phone2_tb = new System.Windows.Forms.TextBox();
            this.phone2_lb = new System.Windows.Forms.Label();
            this.profile_pb = new System.Windows.Forms.PictureBox();
            this.ok_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName_lb
            // 
            this.firstName_lb.AutoSize = true;
            this.firstName_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_lb.Location = new System.Drawing.Point(469, 41);
            this.firstName_lb.Name = "firstName_lb";
            this.firstName_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstName_lb.Size = new System.Drawing.Size(66, 20);
            this.firstName_lb.TabIndex = 0;
            this.firstName_lb.Text = "שם פרטי";
            this.firstName_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstName_tb
            // 
            this.firstName_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.firstName_tb.Location = new System.Drawing.Point(263, 41);
            this.firstName_tb.Name = "firstName_tb";
            this.firstName_tb.Size = new System.Drawing.Size(200, 25);
            this.firstName_tb.TabIndex = 1;
            this.firstName_tb.Click += new System.EventHandler(this.firstName_tb_Click);
            // 
            // lastName_tb
            // 
            this.lastName_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lastName_tb.Location = new System.Drawing.Point(263, 79);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(200, 25);
            this.lastName_tb.TabIndex = 3;
            this.lastName_tb.Click += new System.EventHandler(this.lastName_tb_Click);
            // 
            // lastName_lb
            // 
            this.lastName_lb.AutoSize = true;
            this.lastName_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_lb.Location = new System.Drawing.Point(469, 79);
            this.lastName_lb.Name = "lastName_lb";
            this.lastName_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lastName_lb.Size = new System.Drawing.Size(86, 20);
            this.lastName_lb.TabIndex = 2;
            this.lastName_lb.Text = "שם משפחה";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // birth_lb
            // 
            this.birth_lb.AutoSize = true;
            this.birth_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_lb.Location = new System.Drawing.Point(469, 122);
            this.birth_lb.Name = "birth_lb";
            this.birth_lb.Size = new System.Drawing.Size(83, 20);
            this.birth_lb.TabIndex = 5;
            this.birth_lb.Text = "תאריך לידה";
            // 
            // ID_tb
            // 
            this.ID_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ID_tb.Location = new System.Drawing.Point(263, 161);
            this.ID_tb.Name = "ID_tb";
            this.ID_tb.Size = new System.Drawing.Size(200, 25);
            this.ID_tb.TabIndex = 7;
            this.ID_tb.Click += new System.EventHandler(this.ID_tb_Click);
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lb.Location = new System.Drawing.Point(469, 161);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lb.Size = new System.Drawing.Size(85, 20);
            this.ID_lb.TabIndex = 6;
            this.ID_lb.Text = "תעודת זהות";
            this.ID_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // city_tb
            // 
            this.city_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.city_tb.Location = new System.Drawing.Point(263, 201);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(200, 25);
            this.city_tb.TabIndex = 9;
            this.city_tb.Click += new System.EventHandler(this.city_tb_Click);
            // 
            // city_lb
            // 
            this.city_lb.AutoSize = true;
            this.city_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_lb.Location = new System.Drawing.Point(469, 201);
            this.city_lb.Name = "city_lb";
            this.city_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.city_lb.Size = new System.Drawing.Size(77, 20);
            this.city_lb.TabIndex = 8;
            this.city_lb.Text = "עיר מגורים";
            // 
            // address_tb
            // 
            this.address_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.address_tb.Location = new System.Drawing.Point(263, 243);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(200, 25);
            this.address_tb.TabIndex = 11;
            this.address_tb.Click += new System.EventHandler(this.address_tb_Click);
            // 
            // street_lb
            // 
            this.street_lb.AutoSize = true;
            this.street_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street_lb.Location = new System.Drawing.Point(469, 243);
            this.street_lb.Name = "street_lb";
            this.street_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.street_lb.Size = new System.Drawing.Size(71, 20);
            this.street_lb.TabIndex = 10;
            this.street_lb.Text = "רחוב ומס\'";
            // 
            // phone1_tb
            // 
            this.phone1_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone1_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.phone1_tb.Location = new System.Drawing.Point(263, 280);
            this.phone1_tb.Name = "phone1_tb";
            this.phone1_tb.Size = new System.Drawing.Size(200, 25);
            this.phone1_tb.TabIndex = 13;
            this.phone1_tb.Click += new System.EventHandler(this.phone1_tb_Click);
            // 
            // phone1_lb
            // 
            this.phone1_lb.AutoSize = true;
            this.phone1_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone1_lb.Location = new System.Drawing.Point(469, 280);
            this.phone1_lb.Name = "phone1_lb";
            this.phone1_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone1_lb.Size = new System.Drawing.Size(56, 20);
            this.phone1_lb.TabIndex = 12;
            this.phone1_lb.Text = "טלפון 1";
            // 
            // phone2_tb
            // 
            this.phone2_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone2_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.phone2_tb.Location = new System.Drawing.Point(263, 317);
            this.phone2_tb.Name = "phone2_tb";
            this.phone2_tb.Size = new System.Drawing.Size(200, 25);
            this.phone2_tb.TabIndex = 15;
            this.phone2_tb.Click += new System.EventHandler(this.phone2_tb_Click);
            // 
            // phone2_lb
            // 
            this.phone2_lb.AutoSize = true;
            this.phone2_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone2_lb.Location = new System.Drawing.Point(469, 317);
            this.phone2_lb.Name = "phone2_lb";
            this.phone2_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone2_lb.Size = new System.Drawing.Size(56, 20);
            this.phone2_lb.TabIndex = 14;
            this.phone2_lb.Text = "טלפון 2";
            // 
            // profile_pb
            // 
            this.profile_pb.Image = ((System.Drawing.Image)(resources.GetObject("profile_pb.Image")));
            this.profile_pb.InitialImage = ((System.Drawing.Image)(resources.GetObject("profile_pb.InitialImage")));
            this.profile_pb.Location = new System.Drawing.Point(20, 41);
            this.profile_pb.Name = "profile_pb";
            this.profile_pb.Size = new System.Drawing.Size(187, 140);
            this.profile_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_pb.TabIndex = 16;
            this.profile_pb.TabStop = false;
            this.profile_pb.Click += new System.EventHandler(this.profile_pb_Click);
            // 
            // ok_bt
            // 
            this.ok_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ok_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_bt.ForeColor = System.Drawing.Color.White;
            this.ok_bt.Location = new System.Drawing.Point(107, 345);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(92, 32);
            this.ok_bt.TabIndex = 18;
            this.ok_bt.Text = "שמור וצא";
            this.ok_bt.UseVisualStyleBackColor = false;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            this.ok_bt.MouseLeave += new System.EventHandler(this.ok_bt_MouseLeave);
            this.ok_bt.MouseHover += new System.EventHandler(this.ok_bt_MouseHover);
            // 
            // cancel_bt
            // 
            this.cancel_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cancel_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_bt.ForeColor = System.Drawing.Color.White;
            this.cancel_bt.Location = new System.Drawing.Point(12, 345);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(85, 32);
            this.cancel_bt.TabIndex = 19;
            this.cancel_bt.Text = "ביטול";
            this.cancel_bt.UseVisualStyleBackColor = false;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            this.cancel_bt.MouseLeave += new System.EventHandler(this.cancel_bt_MouseLeave);
            this.cancel_bt.MouseHover += new System.EventHandler(this.cancel_bt_MouseHover);
            // 
            // email_tb
            // 
            this.email_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.email_tb.Location = new System.Drawing.Point(12, 201);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(195, 25);
            this.email_tb.TabIndex = 21;
            this.email_tb.Click += new System.EventHandler(this.email_tb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 201);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "מייל";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(107, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 54);
            this.button1.TabIndex = 22;
            this.button1.Text = "עדכון סיסמא";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // RegionManagerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 412);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RegionManagerCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegionManagerCard";
            ((System.ComponentModel.ISupportInitialize)(this.profile_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName_lb;
        private System.Windows.Forms.TextBox firstName_tb;
        private System.Windows.Forms.TextBox lastName_tb;
        private System.Windows.Forms.Label lastName_lb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label birth_lb;
        private System.Windows.Forms.TextBox ID_tb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.Label city_lb;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.Label street_lb;
        private System.Windows.Forms.TextBox phone1_tb;
        private System.Windows.Forms.Label phone1_lb;
        private System.Windows.Forms.TextBox phone2_tb;
        private System.Windows.Forms.Label phone2_lb;
        private System.Windows.Forms.PictureBox profile_pb;
        private System.Windows.Forms.Button ok_bt;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}