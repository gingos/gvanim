namespace GvanimVS
{
    partial class EmplyomentRecord
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
            this.id_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.mitmoded_id_lb = new System.Windows.Forms.Label();
            this.mitmoded_name_lb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Location = new System.Drawing.Point(597, 35);
            this.id_lb.Name = "id_lb";
            this.id_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.id_lb.Size = new System.Drawing.Size(70, 13);
            this.id_lb.TabIndex = 0;
            this.id_lb.Text = "תעודת זהות:";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(629, 71);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(26, 13);
            this.name_lb.TabIndex = 1;
            this.name_lb.Text = "שם:";
            // 
            // mitmoded_id_lb
            // 
            this.mitmoded_id_lb.AutoSize = true;
            this.mitmoded_id_lb.Location = new System.Drawing.Point(518, 35);
            this.mitmoded_id_lb.Name = "mitmoded_id_lb";
            this.mitmoded_id_lb.Size = new System.Drawing.Size(18, 13);
            this.mitmoded_id_lb.TabIndex = 2;
            this.mitmoded_id_lb.Text = "ID";
            // 
            // mitmoded_name_lb
            // 
            this.mitmoded_name_lb.AutoSize = true;
            this.mitmoded_name_lb.Location = new System.Drawing.Point(521, 71);
            this.mitmoded_name_lb.Name = "mitmoded_name_lb";
            this.mitmoded_name_lb.Size = new System.Drawing.Size(49, 13);
            this.mitmoded_name_lb.TabIndex = 3;
            this.mitmoded_name_lb.Text = "full name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 197);
            this.dataGridView1.TabIndex = 4;
            // 
            // EmplyomentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 372);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mitmoded_name_lb);
            this.Controls.Add(this.mitmoded_id_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.id_lb);
            this.Name = "EmplyomentRecord";
            this.Text = "EmplyomentRecord";
            this.Load += new System.EventHandler(this.EmplyomentRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label mitmoded_id_lb;
        private System.Windows.Forms.Label mitmoded_name_lb;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}