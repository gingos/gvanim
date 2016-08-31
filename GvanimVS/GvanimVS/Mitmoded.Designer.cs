namespace GvanimVS
{
    partial class Mitmoded
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
            this.name_lb = new System.Windows.Forms.Label();
            this.name_dynamic_lb = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.ID_dynamic_lb = new System.Windows.Forms.Label();
            this.info_bt = new System.Windows.Forms.Button();
            this.show_employment_bt = new System.Windows.Forms.Button();
            this.show_reports_bt = new System.Windows.Forms.Button();
            this.add_employment_bt = new System.Windows.Forms.Button();
            this.add_report_bt = new System.Windows.Forms.Button();
            this.profile_pb = new System.Windows.Forms.PictureBox();
            this.close_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(557, 32);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(29, 13);
            this.name_lb.TabIndex = 0;
            this.name_lb.Text = "שם: ";
            // 
            // name_dynamic_lb
            // 
            this.name_dynamic_lb.AutoSize = true;
            this.name_dynamic_lb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name_dynamic_lb.Location = new System.Drawing.Point(460, 32);
            this.name_dynamic_lb.Name = "name_dynamic_lb";
            this.name_dynamic_lb.Size = new System.Drawing.Size(45, 13);
            this.name_dynamic_lb.TabIndex = 1;
            this.name_dynamic_lb.Text = "<name>";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(516, 68);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lb.Size = new System.Drawing.Size(70, 13);
            this.ID_lb.TabIndex = 2;
            this.ID_lb.Text = "תעודת זהות:";
            // 
            // ID_dynamic_lb
            // 
            this.ID_dynamic_lb.AutoSize = true;
            this.ID_dynamic_lb.Location = new System.Drawing.Point(460, 67);
            this.ID_dynamic_lb.Name = "ID_dynamic_lb";
            this.ID_dynamic_lb.Size = new System.Drawing.Size(30, 13);
            this.ID_dynamic_lb.TabIndex = 3;
            this.ID_dynamic_lb.Text = "<ID>";
            // 
            // info_bt
            // 
            this.info_bt.Location = new System.Drawing.Point(22, 22);
            this.info_bt.Name = "info_bt";
            this.info_bt.Size = new System.Drawing.Size(111, 23);
            this.info_bt.TabIndex = 4;
            this.info_bt.Text = "שינוי פרטים";
            this.info_bt.UseVisualStyleBackColor = true;
            this.info_bt.Click += new System.EventHandler(this.info_bt_Click);
            // 
            // show_employment_bt
            // 
            this.show_employment_bt.Location = new System.Drawing.Point(417, 132);
            this.show_employment_bt.Name = "show_employment_bt";
            this.show_employment_bt.Size = new System.Drawing.Size(166, 23);
            this.show_employment_bt.TabIndex = 6;
            this.show_employment_bt.Text = "הצג פריטי תעסוקה";
            this.show_employment_bt.UseVisualStyleBackColor = true;
            this.show_employment_bt.Click += new System.EventHandler(this.employment_bt_Click);
            // 
            // show_reports_bt
            // 
            this.show_reports_bt.Location = new System.Drawing.Point(213, 132);
            this.show_reports_bt.Name = "show_reports_bt";
            this.show_reports_bt.Size = new System.Drawing.Size(166, 23);
            this.show_reports_bt.TabIndex = 7;
            this.show_reports_bt.Text = "הצג דוחות";
            this.show_reports_bt.UseVisualStyleBackColor = true;
            // 
            // add_employment_bt
            // 
            this.add_employment_bt.Location = new System.Drawing.Point(417, 161);
            this.add_employment_bt.Name = "add_employment_bt";
            this.add_employment_bt.Size = new System.Drawing.Size(166, 23);
            this.add_employment_bt.TabIndex = 8;
            this.add_employment_bt.Text = "הוסף פריט תעסוקה";
            this.add_employment_bt.UseVisualStyleBackColor = true;
            // 
            // add_report_bt
            // 
            this.add_report_bt.Location = new System.Drawing.Point(213, 161);
            this.add_report_bt.Name = "add_report_bt";
            this.add_report_bt.Size = new System.Drawing.Size(166, 23);
            this.add_report_bt.TabIndex = 9;
            this.add_report_bt.Text = "הוסף דוח";
            this.add_report_bt.UseVisualStyleBackColor = true;
            // 
            // profile_pb
            // 
            this.profile_pb.Image = global::GvanimVS.Properties.Resources.anonymous_profile;
            this.profile_pb.Location = new System.Drawing.Point(22, 51);
            this.profile_pb.Name = "profile_pb";
            this.profile_pb.Size = new System.Drawing.Size(172, 172);
            this.profile_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_pb.TabIndex = 5;
            this.profile_pb.TabStop = false;
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(22, 299);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 10;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // Mitmoded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 358);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.add_report_bt);
            this.Controls.Add(this.add_employment_bt);
            this.Controls.Add(this.show_reports_bt);
            this.Controls.Add(this.show_employment_bt);
            this.Controls.Add(this.profile_pb);
            this.Controls.Add(this.info_bt);
            this.Controls.Add(this.ID_dynamic_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.name_dynamic_lb);
            this.Controls.Add(this.name_lb);
            this.Name = "Mitmoded";
            this.Text = "Mitmoded";
            this.Load += new System.EventHandler(this.Mitmoded_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profile_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label name_dynamic_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label ID_dynamic_lb;
        private System.Windows.Forms.Button info_bt;
        private System.Windows.Forms.PictureBox profile_pb;
        private System.Windows.Forms.Button show_employment_bt;
        private System.Windows.Forms.Button show_reports_bt;
        private System.Windows.Forms.Button add_employment_bt;
        private System.Windows.Forms.Button add_report_bt;
        private System.Windows.Forms.Button close_bt;
    }
}