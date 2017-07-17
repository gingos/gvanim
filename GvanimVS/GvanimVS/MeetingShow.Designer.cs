namespace GvanimVS
{
    partial class MeetingShow
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
            this.close_bt = new System.Windows.Forms.Button();
            this.meetings_dgv = new System.Windows.Forms.DataGridView();
            this.mitmoded_name_tb = new System.Windows.Forms.TextBox();
            this.fast_search_bt = new System.Windows.Forms.Button();
            this.detailed_search_bt = new System.Windows.Forms.Button();
            this.coordinatorID_lb = new System.Windows.Forms.Label();
            this.add_meeting_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meetings_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(71, 452);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(88, 36);
            this.close_bt.TabIndex = 4;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            this.close_bt.MouseLeave += new System.EventHandler(this.close_bt_MouseLeave);
            this.close_bt.MouseHover += new System.EventHandler(this.close_bt_MouseHover);
            // 
            // meetings_dgv
            // 
            this.meetings_dgv.AllowUserToAddRows = false;
            this.meetings_dgv.AllowUserToDeleteRows = false;
            this.meetings_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.meetings_dgv.BackgroundColor = System.Drawing.Color.White;
            this.meetings_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meetings_dgv.Location = new System.Drawing.Point(71, 102);
            this.meetings_dgv.Name = "meetings_dgv";
            this.meetings_dgv.ReadOnly = true;
            this.meetings_dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.meetings_dgv.Size = new System.Drawing.Size(817, 286);
            this.meetings_dgv.TabIndex = 5;
            this.meetings_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meetings_dgv_CellDoubleClick);
            // 
            // mitmoded_name_tb
            // 
            this.mitmoded_name_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mitmoded_name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitmoded_name_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.mitmoded_name_tb.Location = new System.Drawing.Point(716, 43);
            this.mitmoded_name_tb.Name = "mitmoded_name_tb";
            this.mitmoded_name_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mitmoded_name_tb.Size = new System.Drawing.Size(172, 19);
            this.mitmoded_name_tb.TabIndex = 7;
            this.mitmoded_name_tb.Text = "חיפוש שם מתמודד";
            // 
            // fast_search_bt
            // 
            this.fast_search_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.fast_search_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fast_search_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fast_search_bt.ForeColor = System.Drawing.Color.White;
            this.fast_search_bt.Location = new System.Drawing.Point(609, 38);
            this.fast_search_bt.Name = "fast_search_bt";
            this.fast_search_bt.Size = new System.Drawing.Size(101, 31);
            this.fast_search_bt.TabIndex = 8;
            this.fast_search_bt.Text = "חיפוש מהיר";
            this.fast_search_bt.UseVisualStyleBackColor = false;
            this.fast_search_bt.Click += new System.EventHandler(this.fast_search_bt_Click);
            this.fast_search_bt.MouseLeave += new System.EventHandler(this.fast_search_bt_MouseLeave);
            this.fast_search_bt.MouseHover += new System.EventHandler(this.fast_search_bt_MouseHover);
            // 
            // detailed_search_bt
            // 
            this.detailed_search_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.detailed_search_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailed_search_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailed_search_bt.ForeColor = System.Drawing.Color.White;
            this.detailed_search_bt.Location = new System.Drawing.Point(391, 36);
            this.detailed_search_bt.Name = "detailed_search_bt";
            this.detailed_search_bt.Size = new System.Drawing.Size(185, 33);
            this.detailed_search_bt.TabIndex = 9;
            this.detailed_search_bt.Text = "חיפוש לפי פרטים נוספים";
            this.detailed_search_bt.UseVisualStyleBackColor = false;
            this.detailed_search_bt.Click += new System.EventHandler(this.detailed_search_Click);
            this.detailed_search_bt.MouseLeave += new System.EventHandler(this.detailed_search_MouseLeave);
            this.detailed_search_bt.MouseHover += new System.EventHandler(this.detailed_search_MouseHover);
            // 
            // coordinatorID_lb
            // 
            this.coordinatorID_lb.AutoSize = true;
            this.coordinatorID_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordinatorID_lb.Location = new System.Drawing.Point(77, 39);
            this.coordinatorID_lb.Name = "coordinatorID_lb";
            this.coordinatorID_lb.Size = new System.Drawing.Size(212, 20);
            this.coordinatorID_lb.TabIndex = 10;
            this.coordinatorID_lb.Text = "<coordinatorID_dynamic_lb>";
            // 
            // add_meeting_bt
            // 
            this.add_meeting_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.add_meeting_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_meeting_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_meeting_bt.ForeColor = System.Drawing.Color.White;
            this.add_meeting_bt.Location = new System.Drawing.Point(769, 452);
            this.add_meeting_bt.Name = "add_meeting_bt";
            this.add_meeting_bt.Size = new System.Drawing.Size(119, 36);
            this.add_meeting_bt.TabIndex = 11;
            this.add_meeting_bt.Text = "הוספת פגישה";
            this.add_meeting_bt.UseVisualStyleBackColor = false;
            this.add_meeting_bt.Click += new System.EventHandler(this.add_meeting_bt_Click);
            this.add_meeting_bt.MouseLeave += new System.EventHandler(this.add_meeting_bt_MouseLeave);
            this.add_meeting_bt.MouseHover += new System.EventHandler(this.add_meeting_bt_MouseHover);
            // 
            // MeetingShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 530);
            this.ControlBox = false;
            this.Controls.Add(this.add_meeting_bt);
            this.Controls.Add(this.coordinatorID_lb);
            this.Controls.Add(this.detailed_search_bt);
            this.Controls.Add(this.fast_search_bt);
            this.Controls.Add(this.mitmoded_name_tb);
            this.Controls.Add(this.meetings_dgv);
            this.Controls.Add(this.close_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MeetingShow";
            this.Text = "ShowMeetings";
            ((System.ComponentModel.ISupportInitialize)(this.meetings_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.DataGridView meetings_dgv;
        private System.Windows.Forms.TextBox mitmoded_name_tb;
        private System.Windows.Forms.Button fast_search_bt;
        private System.Windows.Forms.Button detailed_search_bt;
        private System.Windows.Forms.Label coordinatorID_lb;
        private System.Windows.Forms.Button add_meeting_bt;
    }
}