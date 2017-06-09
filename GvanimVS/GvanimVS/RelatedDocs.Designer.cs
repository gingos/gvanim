namespace GvanimVS
{
    partial class RelatedDocs
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
            this.id_lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_dynamic_lb = new System.Windows.Forms.Label();
            this.id_dynamic_lb = new System.Windows.Forms.Label();
            this.extra_files_dgv = new System.Windows.Forms.DataGridView();
            this.close_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.officeViewer1 = new Spire.OfficeViewer.Forms.OfficeViewer();
            this.export_bt = new System.Windows.Forms.Button();
            this.browse_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.extra_files_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(1097, 28);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(29, 13);
            this.name_lb.TabIndex = 4;
            this.name_lb.Text = "שם: ";
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Location = new System.Drawing.Point(847, 28);
            this.id_lb.Name = "id_lb";
            this.id_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.id_lb.Size = new System.Drawing.Size(70, 13);
            this.id_lb.TabIndex = 4;
            this.id_lb.Text = "תעודת זהות:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1024, 28);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // name_dynamic_lb
            // 
            this.name_dynamic_lb.AutoSize = true;
            this.name_dynamic_lb.Location = new System.Drawing.Point(973, 28);
            this.name_dynamic_lb.Name = "name_dynamic_lb";
            this.name_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_dynamic_lb.Size = new System.Drawing.Size(45, 13);
            this.name_dynamic_lb.TabIndex = 5;
            this.name_dynamic_lb.Text = "<name>";
            // 
            // id_dynamic_lb
            // 
            this.id_dynamic_lb.AutoSize = true;
            this.id_dynamic_lb.Location = new System.Drawing.Point(754, 28);
            this.id_dynamic_lb.Name = "id_dynamic_lb";
            this.id_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.id_dynamic_lb.Size = new System.Drawing.Size(27, 13);
            this.id_dynamic_lb.TabIndex = 6;
            this.id_dynamic_lb.Text = "<id>";
            // 
            // extra_files_dgv
            // 
            this.extra_files_dgv.AllowUserToAddRows = false;
            this.extra_files_dgv.AllowUserToDeleteRows = false;
            this.extra_files_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.extra_files_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.extra_files_dgv.Location = new System.Drawing.Point(802, 126);
            this.extra_files_dgv.Name = "extra_files_dgv";
            this.extra_files_dgv.ReadOnly = true;
            this.extra_files_dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.extra_files_dgv.Size = new System.Drawing.Size(382, 413);
            this.extra_files_dgv.TabIndex = 7;
            this.extra_files_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.extra_files_dgv_CellDoubleClick);
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(49, 588);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 8;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(873, 93);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "לחיצה כפולה על שם הקובץ לתצוגה מקדימה";
            // 
            // officeViewer1
            // 
            this.officeViewer1.IsToolBarVisible = true;
            this.officeViewer1.Location = new System.Drawing.Point(49, 126);
            this.officeViewer1.Name = "officeViewer1";
            this.officeViewer1.Size = new System.Drawing.Size(686, 413);
            this.officeViewer1.TabIndex = 12;
            this.officeViewer1.Text = "officeViewer1";
            // 
            // export_bt
            // 
            this.export_bt.Location = new System.Drawing.Point(643, 562);
            this.export_bt.Name = "export_bt";
            this.export_bt.Size = new System.Drawing.Size(92, 23);
            this.export_bt.TabIndex = 17;
            this.export_bt.Text = "פתיחה כקובץ";
            this.export_bt.UseVisualStyleBackColor = true;
            this.export_bt.Click += new System.EventHandler(this.export_bt_Click);
            // 
            // browse_bt
            // 
            this.browse_bt.Location = new System.Drawing.Point(1036, 562);
            this.browse_bt.Name = "browse_bt";
            this.browse_bt.Size = new System.Drawing.Size(87, 23);
            this.browse_bt.TabIndex = 16;
            this.browse_bt.Text = "הוספת קובץ";
            this.browse_bt.UseVisualStyleBackColor = true;
            this.browse_bt.Click += new System.EventHandler(this.browse_bt_Click);
            // 
            // RelatedDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 650);
            this.Controls.Add(this.export_bt);
            this.Controls.Add(this.browse_bt);
            this.Controls.Add(this.officeViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.extra_files_dgv);
            this.Controls.Add(this.id_dynamic_lb);
            this.Controls.Add(this.name_dynamic_lb);
            this.Controls.Add(this.id_lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_lb);
            this.Name = "RelatedDocs";
            this.Text = "MiscDocs";
            ((System.ComponentModel.ISupportInitialize)(this.extra_files_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name_dynamic_lb;
        private System.Windows.Forms.Label id_dynamic_lb;
        private System.Windows.Forms.DataGridView extra_files_dgv;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Label label1;
        private Spire.OfficeViewer.Forms.OfficeViewer officeViewer1;
        private System.Windows.Forms.Button export_bt;
        private System.Windows.Forms.Button browse_bt;
    }
}