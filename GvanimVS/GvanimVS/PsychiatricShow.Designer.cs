namespace GvanimVS
{
    partial class PsychiatricShow
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
            this.detailed_search_bt = new System.Windows.Forms.Button();
            this.fast_search_bt = new System.Windows.Forms.Button();
            this.mitmoded_name_tb = new System.Windows.Forms.TextBox();
            this.followUps_dgv = new System.Windows.Forms.DataGridView();
            this.add_psy_followup_bt = new System.Windows.Forms.Button();
            this.close_bt = new System.Windows.Forms.Button();
            this.coordinatorID_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.followUps_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // detailed_search_bt
            // 
            this.detailed_search_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.detailed_search_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailed_search_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailed_search_bt.ForeColor = System.Drawing.Color.White;
            this.detailed_search_bt.Location = new System.Drawing.Point(283, 75);
            this.detailed_search_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailed_search_bt.Name = "detailed_search_bt";
            this.detailed_search_bt.Size = new System.Drawing.Size(229, 35);
            this.detailed_search_bt.TabIndex = 12;
            this.detailed_search_bt.Text = "חיפוש לפי פרטים נוספים";
            this.detailed_search_bt.UseVisualStyleBackColor = false;
            this.detailed_search_bt.Click += new System.EventHandler(this.detailed_search_Click);
            this.detailed_search_bt.MouseLeave += new System.EventHandler(this.detailed_search_MouseLeave);
            this.detailed_search_bt.MouseHover += new System.EventHandler(this.detailed_search_MouseHover);
            // 
            // fast_search_bt
            // 
            this.fast_search_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.fast_search_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fast_search_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fast_search_bt.ForeColor = System.Drawing.Color.White;
            this.fast_search_bt.Location = new System.Drawing.Point(520, 75);
            this.fast_search_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fast_search_bt.Name = "fast_search_bt";
            this.fast_search_bt.Size = new System.Drawing.Size(113, 35);
            this.fast_search_bt.TabIndex = 11;
            this.fast_search_bt.Text = "חיפוש מהיר";
            this.fast_search_bt.UseVisualStyleBackColor = false;
            this.fast_search_bt.Click += new System.EventHandler(this.fast_search_bt_Click);
            this.fast_search_bt.MouseLeave += new System.EventHandler(this.fast_search_bt_MouseLeave);
            this.fast_search_bt.MouseHover += new System.EventHandler(this.fast_search_bt_MouseHover);
            // 
            // mitmoded_name_tb
            // 
            this.mitmoded_name_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mitmoded_name_tb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitmoded_name_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.mitmoded_name_tb.Location = new System.Drawing.Point(641, 79);
            this.mitmoded_name_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mitmoded_name_tb.Name = "mitmoded_name_tb";
            this.mitmoded_name_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mitmoded_name_tb.Size = new System.Drawing.Size(228, 18);
            this.mitmoded_name_tb.TabIndex = 10;
            this.mitmoded_name_tb.Text = "חיפוש שם מתמודד";
            // 
            // followUps_dgv
            // 
            this.followUps_dgv.AllowUserToAddRows = false;
            this.followUps_dgv.AllowUserToDeleteRows = false;
            this.followUps_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.followUps_dgv.BackgroundColor = System.Drawing.Color.White;
            this.followUps_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.followUps_dgv.Location = new System.Drawing.Point(95, 157);
            this.followUps_dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.followUps_dgv.Name = "followUps_dgv";
            this.followUps_dgv.ReadOnly = true;
            this.followUps_dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.followUps_dgv.Size = new System.Drawing.Size(774, 191);
            this.followUps_dgv.TabIndex = 13;
            // 
            // add_psy_followup_bt
            // 
            this.add_psy_followup_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.add_psy_followup_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_psy_followup_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_psy_followup_bt.ForeColor = System.Drawing.Color.White;
            this.add_psy_followup_bt.Location = new System.Drawing.Point(701, 391);
            this.add_psy_followup_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_psy_followup_bt.Name = "add_psy_followup_bt";
            this.add_psy_followup_bt.Size = new System.Drawing.Size(168, 35);
            this.add_psy_followup_bt.TabIndex = 14;
            this.add_psy_followup_bt.Text = "הוספת דו\"ח מעקב";
            this.add_psy_followup_bt.UseVisualStyleBackColor = false;
            this.add_psy_followup_bt.Click += new System.EventHandler(this.add_psy_followup_bt_Click);
            this.add_psy_followup_bt.MouseLeave += new System.EventHandler(this.add_psy_followup_bt_MouseLeave);
            this.add_psy_followup_bt.MouseHover += new System.EventHandler(this.add_psy_followup_bt_MouseHover);
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(95, 391);
            this.close_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(100, 35);
            this.close_bt.TabIndex = 15;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            this.close_bt.MouseLeave += new System.EventHandler(this.close_bt_MouseLeave);
            this.close_bt.MouseHover += new System.EventHandler(this.close_bt_MouseHover);
            // 
            // coordinatorID_lb
            // 
            this.coordinatorID_lb.AutoSize = true;
            this.coordinatorID_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordinatorID_lb.Location = new System.Drawing.Point(104, 35);
            this.coordinatorID_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coordinatorID_lb.Name = "coordinatorID_lb";
            this.coordinatorID_lb.Size = new System.Drawing.Size(193, 20);
            this.coordinatorID_lb.TabIndex = 16;
            this.coordinatorID_lb.Text = "<coordinatorID_dynamic_lb>";
            // 
            // PsychiatricShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 488);
            this.ControlBox = false;
            this.Controls.Add(this.coordinatorID_lb);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.add_psy_followup_bt);
            this.Controls.Add(this.followUps_dgv);
            this.Controls.Add(this.detailed_search_bt);
            this.Controls.Add(this.fast_search_bt);
            this.Controls.Add(this.mitmoded_name_tb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PsychiatricShow";
            this.Text = "PsychiatricShow";
            ((System.ComponentModel.ISupportInitialize)(this.followUps_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button detailed_search_bt;
        private System.Windows.Forms.Button fast_search_bt;
        private System.Windows.Forms.TextBox mitmoded_name_tb;
        private System.Windows.Forms.DataGridView followUps_dgv;
        private System.Windows.Forms.Button add_psy_followup_bt;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Label coordinatorID_lb;
    }
}