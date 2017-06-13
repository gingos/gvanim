﻿namespace GvanimVS
{
    partial class unusualEventSearch
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
            this.end_date_lb = new System.Windows.Forms.Label();
            this.end_date_dtp = new System.Windows.Forms.DateTimePicker();
            this.city_lb = new System.Windows.Forms.Label();
            this.meetingID_lb = new System.Windows.Forms.Label();
            this.start_date_lb = new System.Windows.Forms.Label();
            this.address_lb = new System.Windows.Forms.Label();
            this.start_date_dtp = new System.Windows.Forms.DateTimePicker();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.place_tb = new System.Windows.Forms.TextBox();
            this.close_bt = new System.Windows.Forms.Button();
            this.searchEvent_bt = new System.Windows.Forms.Button();
            this.coordinatorID_lb = new System.Windows.Forms.Label();
            this.detailed_search = new System.Windows.Forms.Button();
            this.fast_search_bt = new System.Windows.Forms.Button();
            this.mitmoded_name_tb = new System.Windows.Forms.TextBox();
            this.events_dgv = new System.Windows.Forms.DataGridView();
            this.fastSearch_bt = new System.Windows.Forms.Button();
            this.extendedSerarch_bt = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.events_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // end_date_lb
            // 
            this.end_date_lb.AutoSize = true;
            this.end_date_lb.Location = new System.Drawing.Point(292, 138);
            this.end_date_lb.Name = "end_date_lb";
            this.end_date_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.end_date_lb.Size = new System.Drawing.Size(34, 26);
            this.end_date_lb.TabIndex = 26;
            this.end_date_lb.Text = "טווח \r\nסיום";
            this.end_date_lb.Visible = false;
            // 
            // end_date_dtp
            // 
            this.end_date_dtp.Checked = false;
            this.end_date_dtp.Location = new System.Drawing.Point(37, 138);
            this.end_date_dtp.Name = "end_date_dtp";
            this.end_date_dtp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.end_date_dtp.RightToLeftLayout = true;
            this.end_date_dtp.ShowCheckBox = true;
            this.end_date_dtp.Size = new System.Drawing.Size(200, 20);
            this.end_date_dtp.TabIndex = 25;
            this.end_date_dtp.Visible = false;
            // 
            // city_lb
            // 
            this.city_lb.AutoSize = true;
            this.city_lb.Location = new System.Drawing.Point(600, 100);
            this.city_lb.Name = "city_lb";
            this.city_lb.Size = new System.Drawing.Size(33, 13);
            this.city_lb.TabIndex = 16;
            this.city_lb.Text = "מקום";
            this.city_lb.Visible = false;
            // 
            // meetingID_lb
            // 
            this.meetingID_lb.AutoSize = true;
            this.meetingID_lb.Location = new System.Drawing.Point(422, 77);
            this.meetingID_lb.Name = "meetingID_lb";
            this.meetingID_lb.Size = new System.Drawing.Size(0, 13);
            this.meetingID_lb.TabIndex = 17;
            this.meetingID_lb.Visible = false;
            // 
            // start_date_lb
            // 
            this.start_date_lb.AutoSize = true;
            this.start_date_lb.Location = new System.Drawing.Point(603, 138);
            this.start_date_lb.Name = "start_date_lb";
            this.start_date_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.start_date_lb.Size = new System.Drawing.Size(42, 26);
            this.start_date_lb.TabIndex = 18;
            this.start_date_lb.Text = "טווח \r\nהתחלה";
            this.start_date_lb.Visible = false;
            // 
            // address_lb
            // 
            this.address_lb.AutoSize = true;
            this.address_lb.Location = new System.Drawing.Point(283, 100);
            this.address_lb.Name = "address_lb";
            this.address_lb.Size = new System.Drawing.Size(40, 13);
            this.address_lb.TabIndex = 19;
            this.address_lb.Text = "כתובת";
            this.address_lb.Visible = false;
            // 
            // start_date_dtp
            // 
            this.start_date_dtp.Checked = false;
            this.start_date_dtp.Location = new System.Drawing.Point(382, 138);
            this.start_date_dtp.Name = "start_date_dtp";
            this.start_date_dtp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.start_date_dtp.RightToLeftLayout = true;
            this.start_date_dtp.ShowCheckBox = true;
            this.start_date_dtp.Size = new System.Drawing.Size(200, 20);
            this.start_date_dtp.TabIndex = 15;
            this.start_date_dtp.Visible = false;
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(37, 93);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(198, 20);
            this.address_tb.TabIndex = 12;
            this.address_tb.Visible = false;
            // 
            // place_tb
            // 
            this.place_tb.Location = new System.Drawing.Point(382, 93);
            this.place_tb.Name = "place_tb";
            this.place_tb.Size = new System.Drawing.Size(198, 20);
            this.place_tb.TabIndex = 13;
            this.place_tb.Visible = false;
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(40, 12);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 27;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // searchEvent_bt
            // 
            this.searchEvent_bt.Location = new System.Drawing.Point(49, 187);
            this.searchEvent_bt.Name = "searchEvent_bt";
            this.searchEvent_bt.Size = new System.Drawing.Size(75, 23);
            this.searchEvent_bt.TabIndex = 27;
            this.searchEvent_bt.Text = "חפש אירוע";
            this.searchEvent_bt.UseVisualStyleBackColor = true;
            this.searchEvent_bt.Visible = false;
            this.searchEvent_bt.Click += new System.EventHandler(this.searchEvent_bt_Click);
            // 
            // coordinatorID_lb
            // 
            this.coordinatorID_lb.AutoSize = true;
            this.coordinatorID_lb.Location = new System.Drawing.Point(47, -149);
            this.coordinatorID_lb.Name = "coordinatorID_lb";
            this.coordinatorID_lb.Size = new System.Drawing.Size(142, 13);
            this.coordinatorID_lb.TabIndex = 32;
            this.coordinatorID_lb.Text = "<coordinatorID_dynamic_lb>";
            // 
            // detailed_search
            // 
            this.detailed_search.Location = new System.Drawing.Point(662, -125);
            this.detailed_search.Name = "detailed_search";
            this.detailed_search.Size = new System.Drawing.Size(10, 10);
            this.detailed_search.TabIndex = 31;
            this.detailed_search.Text = "חיפוש לפי פרטים נוספים";
            this.detailed_search.UseVisualStyleBackColor = true;
            // 
            // fast_search_bt
            // 
            this.fast_search_bt.Location = new System.Drawing.Point(865, -125);
            this.fast_search_bt.Name = "fast_search_bt";
            this.fast_search_bt.Size = new System.Drawing.Size(10, 10);
            this.fast_search_bt.TabIndex = 30;
            this.fast_search_bt.Text = "חיפוש מהיר";
            this.fast_search_bt.UseVisualStyleBackColor = true;
            // 
            // mitmoded_name_tb
            // 
            this.mitmoded_name_tb.Location = new System.Drawing.Point(956, -138);
            this.mitmoded_name_tb.Name = "mitmoded_name_tb";
            this.mitmoded_name_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mitmoded_name_tb.Size = new System.Drawing.Size(10, 20);
            this.mitmoded_name_tb.TabIndex = 29;
            this.mitmoded_name_tb.Text = "חיפוש שם מתמודד";
            // 
            // events_dgv
            // 
            this.events_dgv.AllowUserToAddRows = false;
            this.events_dgv.AllowUserToDeleteRows = false;
            this.events_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.events_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.events_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Place,
            this.Address,
            this.Subject});
            this.events_dgv.Location = new System.Drawing.Point(40, 232);
            this.events_dgv.Name = "events_dgv";
            this.events_dgv.ReadOnly = true;
            this.events_dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.events_dgv.Size = new System.Drawing.Size(570, 148);
            this.events_dgv.TabIndex = 28;
            this.events_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.events_dgv_CellContentClick);
            // 
            // fastSearch_bt
            // 
            this.fastSearch_bt.Location = new System.Drawing.Point(519, 12);
            this.fastSearch_bt.Name = "fastSearch_bt";
            this.fastSearch_bt.Size = new System.Drawing.Size(91, 23);
            this.fastSearch_bt.TabIndex = 27;
            this.fastSearch_bt.Text = "חיפוש מהיר";
            this.fastSearch_bt.UseVisualStyleBackColor = true;
            this.fastSearch_bt.Click += new System.EventHandler(this.fastSearch_bt_Click);
            // 
            // extendedSerarch_bt
            // 
            this.extendedSerarch_bt.Location = new System.Drawing.Point(397, 12);
            this.extendedSerarch_bt.Name = "extendedSerarch_bt";
            this.extendedSerarch_bt.Size = new System.Drawing.Size(103, 23);
            this.extendedSerarch_bt.TabIndex = 27;
            this.extendedSerarch_bt.Text = "חיפוש מורחב";
            this.extendedSerarch_bt.UseVisualStyleBackColor = true;
            this.extendedSerarch_bt.Click += new System.EventHandler(this.extendedSerarch_bt_Click);
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.FillWeight = 15F;
            this.Date.HeaderText = "תאריך";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Place
            // 
            this.Place.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Place.FillWeight = 15F;
            this.Place.HeaderText = "מקום";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.FillWeight = 15F;
            this.Address.HeaderText = "כתובת";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.FillWeight = 55F;
            this.Subject.HeaderText = "סוג אירוע";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // unusualEventSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 460);
            this.Controls.Add(this.coordinatorID_lb);
            this.Controls.Add(this.detailed_search);
            this.Controls.Add(this.fast_search_bt);
            this.Controls.Add(this.mitmoded_name_tb);
            this.Controls.Add(this.events_dgv);
            this.Controls.Add(this.extendedSerarch_bt);
            this.Controls.Add(this.fastSearch_bt);
            this.Controls.Add(this.searchEvent_bt);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.end_date_lb);
            this.Controls.Add(this.end_date_dtp);
            this.Controls.Add(this.city_lb);
            this.Controls.Add(this.meetingID_lb);
            this.Controls.Add(this.start_date_lb);
            this.Controls.Add(this.address_lb);
            this.Controls.Add(this.start_date_dtp);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.place_tb);
            this.Name = "unusualEventSearch";
            this.Text = "unusualEventSearch";
            this.Load += new System.EventHandler(this.unusualEventSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.events_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label end_date_lb;
        private System.Windows.Forms.DateTimePicker end_date_dtp;
        private System.Windows.Forms.Label city_lb;
        private System.Windows.Forms.Label meetingID_lb;
        private System.Windows.Forms.Label start_date_lb;
        private System.Windows.Forms.Label address_lb;
        private System.Windows.Forms.DateTimePicker start_date_dtp;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.TextBox place_tb;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button searchEvent_bt;
        private System.Windows.Forms.Label coordinatorID_lb;
        private System.Windows.Forms.Button detailed_search;
        private System.Windows.Forms.Button fast_search_bt;
        private System.Windows.Forms.TextBox mitmoded_name_tb;
        private System.Windows.Forms.DataGridView events_dgv;
        private System.Windows.Forms.Button fastSearch_bt;
        private System.Windows.Forms.Button extendedSerarch_bt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
    }
}