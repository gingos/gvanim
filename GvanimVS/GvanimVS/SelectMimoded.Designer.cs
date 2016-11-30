namespace GvanimVS
{
    partial class SelectMimoded
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
            this.mitmoded_dgv = new System.Windows.Forms.DataGridView();
            this.close_bt = new System.Windows.Forms.Button();
            this.ID_lb = new System.Windows.Forms.Label();
            this.firstName_lb = new System.Windows.Forms.Label();
            this.city_lb = new System.Windows.Forms.Label();
            this.search_bt = new System.Windows.Forms.Button();
            this.ID_tb = new System.Windows.Forms.TextBox();
            this.firstName_tb = new System.Windows.Forms.TextBox();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.lastName_lb = new System.Windows.Forms.Label();
            this.lastName_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mitmoded_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // mitmoded_dgv
            // 
            this.mitmoded_dgv.AllowUserToAddRows = false;
            this.mitmoded_dgv.AllowUserToDeleteRows = false;
            this.mitmoded_dgv.AllowUserToOrderColumns = true;
            this.mitmoded_dgv.AllowUserToResizeRows = false;
            this.mitmoded_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mitmoded_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mitmoded_dgv.Location = new System.Drawing.Point(40, 123);
            this.mitmoded_dgv.Name = "mitmoded_dgv";
            this.mitmoded_dgv.ReadOnly = true;
            this.mitmoded_dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mitmoded_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mitmoded_dgv.Size = new System.Drawing.Size(463, 164);
            this.mitmoded_dgv.TabIndex = 0;
            this.mitmoded_dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(38, 302);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 2;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(436, 24);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lb.Size = new System.Drawing.Size(67, 13);
            this.ID_lb.TabIndex = 3;
            this.ID_lb.Text = "תעודת זהות";
            // 
            // firstName_lb
            // 
            this.firstName_lb.AutoSize = true;
            this.firstName_lb.Location = new System.Drawing.Point(452, 55);
            this.firstName_lb.Name = "firstName_lb";
            this.firstName_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstName_lb.Size = new System.Drawing.Size(51, 13);
            this.firstName_lb.TabIndex = 4;
            this.firstName_lb.Text = "שם פרטי";
            // 
            // city_lb
            // 
            this.city_lb.AutoSize = true;
            this.city_lb.Location = new System.Drawing.Point(233, 24);
            this.city_lb.Name = "city_lb";
            this.city_lb.Size = new System.Drawing.Size(25, 13);
            this.city_lb.TabIndex = 5;
            this.city_lb.Text = "עיר";
            // 
            // search_bt
            // 
            this.search_bt.Location = new System.Drawing.Point(428, 302);
            this.search_bt.Name = "search_bt";
            this.search_bt.Size = new System.Drawing.Size(75, 23);
            this.search_bt.TabIndex = 6;
            this.search_bt.Text = "חיפוש";
            this.search_bt.UseVisualStyleBackColor = true;
            this.search_bt.Click += new System.EventHandler(this.search_bt_Click);
            // 
            // ID_tb
            // 
            this.ID_tb.Location = new System.Drawing.Point(278, 24);
            this.ID_tb.Name = "ID_tb";
            this.ID_tb.Size = new System.Drawing.Size(134, 20);
            this.ID_tb.TabIndex = 7;
            // 
            // firstName_tb
            // 
            this.firstName_tb.Location = new System.Drawing.Point(278, 52);
            this.firstName_tb.Name = "firstName_tb";
            this.firstName_tb.Size = new System.Drawing.Size(134, 20);
            this.firstName_tb.TabIndex = 8;
            // 
            // city_tb
            // 
            this.city_tb.Location = new System.Drawing.Point(38, 24);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(134, 20);
            this.city_tb.TabIndex = 9;
            // 
            // lastName_lb
            // 
            this.lastName_lb.AutoSize = true;
            this.lastName_lb.Location = new System.Drawing.Point(195, 52);
            this.lastName_lb.Name = "lastName_lb";
            this.lastName_lb.Size = new System.Drawing.Size(63, 13);
            this.lastName_lb.TabIndex = 10;
            this.lastName_lb.Text = "שם משפחה";
            // 
            // lastName_tb
            // 
            this.lastName_tb.Location = new System.Drawing.Point(40, 55);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(132, 20);
            this.lastName_tb.TabIndex = 11;
            // 
            // SelectMimoded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 353);
            this.Controls.Add(this.lastName_tb);
            this.Controls.Add(this.lastName_lb);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.firstName_tb);
            this.Controls.Add(this.ID_tb);
            this.Controls.Add(this.search_bt);
            this.Controls.Add(this.city_lb);
            this.Controls.Add(this.firstName_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.mitmoded_dgv);
            this.Name = "SelectMimoded";
            this.Text = "SelectMimoded";
            this.Load += new System.EventHandler(this.SelectMimoded_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mitmoded_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mitmoded_dgv;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label firstName_lb;
        private System.Windows.Forms.Label city_lb;
        private System.Windows.Forms.Button search_bt;
        private System.Windows.Forms.TextBox ID_tb;
        private System.Windows.Forms.TextBox firstName_tb;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.Label lastName_lb;
        private System.Windows.Forms.TextBox lastName_tb;
    }
}