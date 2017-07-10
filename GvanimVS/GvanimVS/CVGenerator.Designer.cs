namespace GvanimVS
{
    partial class CVGenerator
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
            this.cv_list_dgv = new System.Windows.Forms.DataGridView();
            this.export_bt = new System.Windows.Forms.Button();
            this.browse_bt = new System.Windows.Forms.Button();
            this.close_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_dynamic_lb = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.officeViewer1 = new Spire.OfficeViewer.Forms.OfficeViewer();
            this.name_dynamic_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cv_list_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cv_list_dgv
            // 
            this.cv_list_dgv.AllowUserToResizeColumns = false;
            this.cv_list_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cv_list_dgv.BackgroundColor = System.Drawing.Color.White;
            this.cv_list_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cv_list_dgv.Location = new System.Drawing.Point(919, 133);
            this.cv_list_dgv.Name = "cv_list_dgv";
            this.cv_list_dgv.ReadOnly = true;
            this.cv_list_dgv.Size = new System.Drawing.Size(253, 412);
            this.cv_list_dgv.TabIndex = 17;
            this.cv_list_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cv_list_dgv_CellDoubleClick);
            // 
            // export_bt
            // 
            this.export_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.export_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_bt.ForeColor = System.Drawing.Color.White;
            this.export_bt.Location = new System.Drawing.Point(705, 564);
            this.export_bt.Name = "export_bt";
            this.export_bt.Size = new System.Drawing.Size(117, 34);
            this.export_bt.TabIndex = 15;
            this.export_bt.Text = "פתיחה כקובץ";
            this.export_bt.UseVisualStyleBackColor = false;
            this.export_bt.Click += new System.EventHandler(this.export_bt_Click);
            this.export_bt.MouseLeave += new System.EventHandler(this.export_bt_MouseLeave);
            this.export_bt.MouseHover += new System.EventHandler(this.export_bt_MouseHover);
            // 
            // browse_bt
            // 
            this.browse_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.browse_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_bt.ForeColor = System.Drawing.Color.White;
            this.browse_bt.Location = new System.Drawing.Point(1052, 564);
            this.browse_bt.Name = "browse_bt";
            this.browse_bt.Size = new System.Drawing.Size(120, 34);
            this.browse_bt.TabIndex = 13;
            this.browse_bt.Text = "הוספת קובץ";
            this.browse_bt.UseVisualStyleBackColor = false;
            this.browse_bt.Click += new System.EventHandler(this.browse_bt_Click);
            this.browse_bt.MouseLeave += new System.EventHandler(this.browse_bt_MouseLeave);
            this.browse_bt.MouseHover += new System.EventHandler(this.browse_bt_MouseHover);
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(24, 564);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(84, 34);
            this.close_bt.TabIndex = 11;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            this.close_bt.MouseLeave += new System.EventHandler(this.close_bt_MouseLeave);
            this.close_bt.MouseHover += new System.EventHandler(this.close_bt_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(883, 81);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(293, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "לחיצה כפולה על שם הקובץ לתצוגה מקדימה";
            // 
            // ID_dynamic_lb
            // 
            this.ID_dynamic_lb.AutoSize = true;
            this.ID_dynamic_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_dynamic_lb.Location = new System.Drawing.Point(733, 31);
            this.ID_dynamic_lb.Name = "ID_dynamic_lb";
            this.ID_dynamic_lb.Size = new System.Drawing.Size(44, 20);
            this.ID_dynamic_lb.TabIndex = 7;
            this.ID_dynamic_lb.Text = "<ID>";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lb.Location = new System.Drawing.Point(848, 32);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lb.Size = new System.Drawing.Size(88, 20);
            this.ID_lb.TabIndex = 6;
            this.ID_lb.Text = "תעודת זהות:";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(1138, 31);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(38, 20);
            this.name_lb.TabIndex = 4;
            this.name_lb.Text = "שם: ";
            // 
            // officeViewer1
            // 
            this.officeViewer1.IsToolBarVisible = true;
            this.officeViewer1.Location = new System.Drawing.Point(106, 133);
            this.officeViewer1.Name = "officeViewer1";
            this.officeViewer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.officeViewer1.Size = new System.Drawing.Size(716, 412);
            this.officeViewer1.TabIndex = 19;
            this.officeViewer1.Text = "officeViewer1";
            // 
            // name_dynamic_lb
            // 
            this.name_dynamic_lb.AutoSize = true;
            this.name_dynamic_lb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name_dynamic_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_dynamic_lb.Location = new System.Drawing.Point(1021, 31);
            this.name_dynamic_lb.Name = "name_dynamic_lb";
            this.name_dynamic_lb.Size = new System.Drawing.Size(65, 20);
            this.name_dynamic_lb.TabIndex = 5;
            this.name_dynamic_lb.Text = "<name>";
            // 
            // CVGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 635);
            this.Controls.Add(this.officeViewer1);
            this.Controls.Add(this.cv_list_dgv);
            this.Controls.Add(this.export_bt);
            this.Controls.Add(this.browse_bt);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_dynamic_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.name_dynamic_lb);
            this.Controls.Add(this.name_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CVGenerator";
            this.Text = "CVGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.cv_list_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_dynamic_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button browse_bt;
        private System.Windows.Forms.Button export_bt;
        private System.Windows.Forms.DataGridView cv_list_dgv;
        private Spire.OfficeViewer.Forms.OfficeViewer officeViewer1;
        private System.Windows.Forms.Label name_dynamic_lb;
    }
}