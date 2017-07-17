namespace GvanimVS
{
    partial class ReportFind
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
            this.report_id_tb = new System.Windows.Forms.TextBox();
            this.report_id_lb = new System.Windows.Forms.Label();
            this.mitmoded_name_lb = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.datepicker_dtp = new System.Windows.Forms.DateTimePicker();
            this.mitmoded_name_cb = new System.Windows.Forms.ComboBox();
            this.searchReport_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.reports_dgv = new System.Windows.Forms.DataGridView();
            this.addReport_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reports_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // report_id_tb
            // 
            this.report_id_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_id_tb.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.report_id_tb.Location = new System.Drawing.Point(327, 60);
            this.report_id_tb.Name = "report_id_tb";
            this.report_id_tb.Size = new System.Drawing.Size(163, 25);
            this.report_id_tb.TabIndex = 0;
            // 
            // report_id_lb
            // 
            this.report_id_lb.AutoSize = true;
            this.report_id_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_id_lb.Location = new System.Drawing.Point(550, 60);
            this.report_id_lb.Name = "report_id_lb";
            this.report_id_lb.Size = new System.Drawing.Size(255, 20);
            this.report_id_lb.TabIndex = 1;
            this.report_id_lb.Text = "מס\"ד דו\"ח (ניתן לחפש גם ת.ז. מתמודד)";
            // 
            // mitmoded_name_lb
            // 
            this.mitmoded_name_lb.AutoSize = true;
            this.mitmoded_name_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitmoded_name_lb.Location = new System.Drawing.Point(540, 94);
            this.mitmoded_name_lb.Name = "mitmoded_name_lb";
            this.mitmoded_name_lb.Size = new System.Drawing.Size(268, 20);
            this.mitmoded_name_lb.TabIndex = 3;
            this.mitmoded_name_lb.Text = "אם ידוע שם המתמודד נא לבחור אותו כאן";
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lb.Location = new System.Drawing.Point(574, 128);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(234, 20);
            this.date_lb.TabIndex = 4;
            this.date_lb.Text = "אם ידוע התאריך נא לבחור אותו כאן";
            // 
            // datepicker_dtp
            // 
            this.datepicker_dtp.Checked = false;
            this.datepicker_dtp.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_dtp.Location = new System.Drawing.Point(327, 128);
            this.datepicker_dtp.Name = "datepicker_dtp";
            this.datepicker_dtp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datepicker_dtp.RightToLeftLayout = true;
            this.datepicker_dtp.ShowCheckBox = true;
            this.datepicker_dtp.Size = new System.Drawing.Size(163, 25);
            this.datepicker_dtp.TabIndex = 5;
            // 
            // mitmoded_name_cb
            // 
            this.mitmoded_name_cb.BackColor = System.Drawing.Color.White;
            this.mitmoded_name_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mitmoded_name_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mitmoded_name_cb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitmoded_name_cb.FormattingEnabled = true;
            this.mitmoded_name_cb.Location = new System.Drawing.Point(310, 96);
            this.mitmoded_name_cb.Name = "mitmoded_name_cb";
            this.mitmoded_name_cb.Size = new System.Drawing.Size(180, 28);
            this.mitmoded_name_cb.TabIndex = 6;
            // 
            // searchReport_bt
            // 
            this.searchReport_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.searchReport_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchReport_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchReport_bt.ForeColor = System.Drawing.Color.White;
            this.searchReport_bt.Location = new System.Drawing.Point(719, 347);
            this.searchReport_bt.Name = "searchReport_bt";
            this.searchReport_bt.Size = new System.Drawing.Size(97, 31);
            this.searchReport_bt.TabIndex = 7;
            this.searchReport_bt.Text = "חיפוש";
            this.searchReport_bt.UseVisualStyleBackColor = false;
            this.searchReport_bt.Click += new System.EventHandler(this.searchReport_bt_Click);
            this.searchReport_bt.MouseLeave += new System.EventHandler(this.searchReport_bt_MouseLeave);
            this.searchReport_bt.MouseHover += new System.EventHandler(this.searchReport_bt_MouseHover);
            // 
            // cancel_bt
            // 
            this.cancel_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cancel_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_bt.ForeColor = System.Drawing.Color.White;
            this.cancel_bt.Location = new System.Drawing.Point(57, 347);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(85, 31);
            this.cancel_bt.TabIndex = 7;
            this.cancel_bt.Text = "סגור";
            this.cancel_bt.UseVisualStyleBackColor = false;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            this.cancel_bt.MouseLeave += new System.EventHandler(this.cancel_bt_MouseLeave);
            this.cancel_bt.MouseHover += new System.EventHandler(this.cancel_bt_MouseHover);
            // 
            // reports_dgv
            // 
            this.reports_dgv.BackgroundColor = System.Drawing.Color.White;
            this.reports_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reports_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reports_dgv.Location = new System.Drawing.Point(27, 191);
            this.reports_dgv.Name = "reports_dgv";
            this.reports_dgv.ReadOnly = true;
            this.reports_dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reports_dgv.Size = new System.Drawing.Size(793, 150);
            this.reports_dgv.TabIndex = 8;
            this.reports_dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // addReport_bt
            // 
            this.addReport_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addReport_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReport_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReport_bt.ForeColor = System.Drawing.Color.White;
            this.addReport_bt.Location = new System.Drawing.Point(393, 347);
            this.addReport_bt.Name = "addReport_bt";
            this.addReport_bt.Size = new System.Drawing.Size(97, 31);
            this.addReport_bt.TabIndex = 9;
            this.addReport_bt.Text = "הוספת דו\"ח";
            this.addReport_bt.UseVisualStyleBackColor = false;
            this.addReport_bt.Click += new System.EventHandler(this.addReport_bt_Click);
            // 
            // ReportFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 410);
            this.ControlBox = false;
            this.Controls.Add(this.addReport_bt);
            this.Controls.Add(this.reports_dgv);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.searchReport_bt);
            this.Controls.Add(this.mitmoded_name_cb);
            this.Controls.Add(this.datepicker_dtp);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.mitmoded_name_lb);
            this.Controls.Add(this.report_id_lb);
            this.Controls.Add(this.report_id_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ReportFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindReport";
            ((System.ComponentModel.ISupportInitialize)(this.reports_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox report_id_tb;
        private System.Windows.Forms.Label report_id_lb;
        private System.Windows.Forms.Label mitmoded_name_lb;
        private System.Windows.Forms.Label date_lb;
        private System.Windows.Forms.DateTimePicker datepicker_dtp;
        private System.Windows.Forms.ComboBox mitmoded_name_cb;
        private System.Windows.Forms.Button searchReport_bt;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.DataGridView reports_dgv;
        private System.Windows.Forms.Button addReport_bt;
    }
}