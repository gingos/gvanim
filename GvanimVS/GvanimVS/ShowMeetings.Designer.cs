namespace GvanimVS
{
    partial class ShowMeetings
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
            this.detailed_search = new System.Windows.Forms.Button();
            this.coordinatorID_lb = new System.Windows.Forms.Label();
            this.add_meeting_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meetings_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(38, 633);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 4;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // meetings_dgv
            // 
            this.meetings_dgv.AllowUserToAddRows = false;
            this.meetings_dgv.AllowUserToDeleteRows = false;
            this.meetings_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.meetings_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meetings_dgv.Location = new System.Drawing.Point(71, 102);
            this.meetings_dgv.Name = "meetings_dgv";
            this.meetings_dgv.ReadOnly = true;
            this.meetings_dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.meetings_dgv.Size = new System.Drawing.Size(1088, 393);
            this.meetings_dgv.TabIndex = 5;
            // 
            // mitmoded_name_tb
            // 
            this.mitmoded_name_tb.Location = new System.Drawing.Point(987, 34);
            this.mitmoded_name_tb.Name = "mitmoded_name_tb";
            this.mitmoded_name_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mitmoded_name_tb.Size = new System.Drawing.Size(172, 20);
            this.mitmoded_name_tb.TabIndex = 7;
            this.mitmoded_name_tb.Text = "חיפוש שם מתמודד";
            // 
            // fast_search_bt
            // 
            this.fast_search_bt.Location = new System.Drawing.Point(896, 34);
            this.fast_search_bt.Name = "fast_search_bt";
            this.fast_search_bt.Size = new System.Drawing.Size(85, 23);
            this.fast_search_bt.TabIndex = 8;
            this.fast_search_bt.Text = "חיפוש מהיר";
            this.fast_search_bt.UseVisualStyleBackColor = true;
            this.fast_search_bt.Click += new System.EventHandler(this.fast_search_bt_Click);
            // 
            // detailed_search
            // 
            this.detailed_search.Location = new System.Drawing.Point(693, 34);
            this.detailed_search.Name = "detailed_search";
            this.detailed_search.Size = new System.Drawing.Size(172, 23);
            this.detailed_search.TabIndex = 9;
            this.detailed_search.Text = "חיפוש לפי פרטים נוספים";
            this.detailed_search.UseVisualStyleBackColor = true;
            this.detailed_search.Click += new System.EventHandler(this.detailed_search_Click);
            // 
            // coordinatorID_lb
            // 
            this.coordinatorID_lb.AutoSize = true;
            this.coordinatorID_lb.Location = new System.Drawing.Point(78, 23);
            this.coordinatorID_lb.Name = "coordinatorID_lb";
            this.coordinatorID_lb.Size = new System.Drawing.Size(142, 13);
            this.coordinatorID_lb.TabIndex = 10;
            this.coordinatorID_lb.Text = "<coordinatorID_dynamic_lb>";
            // 
            // add_meeting_bt
            // 
            this.add_meeting_bt.Location = new System.Drawing.Point(1060, 525);
            this.add_meeting_bt.Name = "add_meeting_bt";
            this.add_meeting_bt.Size = new System.Drawing.Size(99, 23);
            this.add_meeting_bt.TabIndex = 11;
            this.add_meeting_bt.Text = "הוספת פגישה";
            this.add_meeting_bt.UseVisualStyleBackColor = true;
            this.add_meeting_bt.Click += new System.EventHandler(this.add_meeting_bt_Click);
            // 
            // ShowMeetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 714);
            this.Controls.Add(this.add_meeting_bt);
            this.Controls.Add(this.coordinatorID_lb);
            this.Controls.Add(this.detailed_search);
            this.Controls.Add(this.fast_search_bt);
            this.Controls.Add(this.mitmoded_name_tb);
            this.Controls.Add(this.meetings_dgv);
            this.Controls.Add(this.close_bt);
            this.Name = "ShowMeetings";
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
        private System.Windows.Forms.Button detailed_search;
        private System.Windows.Forms.Label coordinatorID_lb;
        private System.Windows.Forms.Button add_meeting_bt;
    }
}