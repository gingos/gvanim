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
            this.name_dynamic_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            ((System.ComponentModel.ISupportInitialize)(this.cv_list_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cv_list_dgv
            // 
            this.cv_list_dgv.AllowUserToResizeColumns = false;
            this.cv_list_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cv_list_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cv_list_dgv.Location = new System.Drawing.Point(154, 106);
            this.cv_list_dgv.Name = "cv_list_dgv";
            this.cv_list_dgv.ReadOnly = true;
            this.cv_list_dgv.Size = new System.Drawing.Size(253, 412);
            this.cv_list_dgv.TabIndex = 17;
            this.cv_list_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cv_list_dgv_CellDoubleClick);
            // 
            // export_bt
            // 
            this.export_bt.Location = new System.Drawing.Point(1087, 532);
            this.export_bt.Name = "export_bt";
            this.export_bt.Size = new System.Drawing.Size(92, 23);
            this.export_bt.TabIndex = 15;
            this.export_bt.Text = "פתיחה כקובץ";
            this.export_bt.UseVisualStyleBackColor = true;
            this.export_bt.Click += new System.EventHandler(this.export_bt_Click);
            // 
            // browse_bt
            // 
            this.browse_bt.Location = new System.Drawing.Point(320, 532);
            this.browse_bt.Name = "browse_bt";
            this.browse_bt.Size = new System.Drawing.Size(87, 23);
            this.browse_bt.TabIndex = 13;
            this.browse_bt.Text = "הוספת קובץ";
            this.browse_bt.UseVisualStyleBackColor = true;
            this.browse_bt.Click += new System.EventHandler(this.browse_bt_Click);
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(22, 589);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 11;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(513, 64);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "לחיצה כפולה על שם הקובץ לתצוגה מקדימה";
            // 
            // ID_dynamic_lb
            // 
            this.ID_dynamic_lb.AutoSize = true;
            this.ID_dynamic_lb.Location = new System.Drawing.Point(792, 31);
            this.ID_dynamic_lb.Name = "ID_dynamic_lb";
            this.ID_dynamic_lb.Size = new System.Drawing.Size(30, 13);
            this.ID_dynamic_lb.TabIndex = 7;
            this.ID_dynamic_lb.Text = "<ID>";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(848, 32);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lb.Size = new System.Drawing.Size(70, 13);
            this.ID_lb.TabIndex = 6;
            this.ID_lb.Text = "תעודת זהות:";
            // 
            // name_dynamic_lb
            // 
            this.name_dynamic_lb.AutoSize = true;
            this.name_dynamic_lb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name_dynamic_lb.Location = new System.Drawing.Point(1004, 32);
            this.name_dynamic_lb.Name = "name_dynamic_lb";
            this.name_dynamic_lb.Size = new System.Drawing.Size(45, 13);
            this.name_dynamic_lb.TabIndex = 5;
            this.name_dynamic_lb.Text = "<name>";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(1146, 32);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(29, 13);
            this.name_lb.TabIndex = 4;
            this.name_lb.Text = "שם: ";
            // 
            // pdfDocumentViewer1
            // 
            this.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pdfDocumentViewer1.Location = new System.Drawing.Point(463, 106);
            this.pdfDocumentViewer1.MultiPagesThreshold = 60;
            this.pdfDocumentViewer1.Name = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Size = new System.Drawing.Size(716, 412);
            this.pdfDocumentViewer1.TabIndex = 18;
            this.pdfDocumentViewer1.Text = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Threshold = 60;
            this.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;
            // 
            // CVGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 635);
            this.Controls.Add(this.pdfDocumentViewer1);
            this.Controls.Add(this.cv_list_dgv);
            this.Controls.Add(this.export_bt);
            this.Controls.Add(this.browse_bt);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_dynamic_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.name_dynamic_lb);
            this.Controls.Add(this.name_lb);
            this.Name = "CVGenerator";
            this.Text = "CVGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.cv_list_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_dynamic_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label name_dynamic_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button browse_bt;
        private System.Windows.Forms.Button export_bt;
        private System.Windows.Forms.DataGridView cv_list_dgv;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
    }
}