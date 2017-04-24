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
            this.ID_dynamic_lb = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.name_dynamic_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.cv1_pb = new System.Windows.Forms.PictureBox();
            this.cv2_pb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close_bt = new System.Windows.Forms.Button();
            this.browse_bt = new System.Windows.Forms.Button();
            this.docDocumentViewer1 = new Spire.DocViewer.Forms.DocDocumentViewer();
            this.cv1_bt = new System.Windows.Forms.Button();
            this.cv2_bt = new System.Windows.Forms.Button();
            this.cv_list_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cv1_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cv2_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cv_list_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_dynamic_lb
            // 
            this.ID_dynamic_lb.AutoSize = true;
            this.ID_dynamic_lb.Location = new System.Drawing.Point(474, 31);
            this.ID_dynamic_lb.Name = "ID_dynamic_lb";
            this.ID_dynamic_lb.Size = new System.Drawing.Size(30, 13);
            this.ID_dynamic_lb.TabIndex = 7;
            this.ID_dynamic_lb.Text = "<ID>";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(530, 32);
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
            this.name_dynamic_lb.Location = new System.Drawing.Point(686, 32);
            this.name_dynamic_lb.Name = "name_dynamic_lb";
            this.name_dynamic_lb.Size = new System.Drawing.Size(45, 13);
            this.name_dynamic_lb.TabIndex = 5;
            this.name_dynamic_lb.Text = "<name>";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(828, 32);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(29, 13);
            this.name_lb.TabIndex = 4;
            this.name_lb.Text = "שם: ";
            // 
            // cv1_pb
            // 
            this.cv1_pb.BackgroundImage = global::GvanimVS.Properties.Resources.cv1_thumb;
            this.cv1_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cv1_pb.Location = new System.Drawing.Point(320, 32);
            this.cv1_pb.Name = "cv1_pb";
            this.cv1_pb.Size = new System.Drawing.Size(66, 51);
            this.cv1_pb.TabIndex = 8;
            this.cv1_pb.TabStop = false;
            this.cv1_pb.Click += new System.EventHandler(this.cv1_pb_Click);
            // 
            // cv2_pb
            // 
            this.cv2_pb.BackgroundImage = global::GvanimVS.Properties.Resources.cv2_thumb;
            this.cv2_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cv2_pb.Location = new System.Drawing.Point(223, 32);
            this.cv2_pb.Name = "cv2_pb";
            this.cv2_pb.Size = new System.Drawing.Size(70, 51);
            this.cv2_pb.TabIndex = 9;
            this.cv2_pb.TabStop = false;
            this.cv2_pb.Click += new System.EventHandler(this.cv2_pb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(513, 64);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(312, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "לחצו על כל תמונה כדי לקבל את קובץ התבנית המלאה:";
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(27, 306);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 11;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // browse_bt
            // 
            this.browse_bt.Location = new System.Drawing.Point(27, 21);
            this.browse_bt.Name = "browse_bt";
            this.browse_bt.Size = new System.Drawing.Size(75, 23);
            this.browse_bt.TabIndex = 13;
            this.browse_bt.Text = "browse";
            this.browse_bt.UseVisualStyleBackColor = true;
            this.browse_bt.Click += new System.EventHandler(this.browse_bt_Click);
            // 
            // docDocumentViewer1
            // 
            this.docDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docDocumentViewer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.docDocumentViewer1.EnableHandTools = false;
            this.docDocumentViewer1.Location = new System.Drawing.Point(457, 106);
            this.docDocumentViewer1.Name = "docDocumentViewer1";
            this.docDocumentViewer1.Size = new System.Drawing.Size(740, 412);
            this.docDocumentViewer1.TabIndex = 14;
            this.docDocumentViewer1.Text = "docDocumentViewer1";
            this.docDocumentViewer1.ToPdfParameterList = null;
            this.docDocumentViewer1.ZoomMode = Spire.DocViewer.Forms.ZoomMode.Default;
            // 
            // cv1_bt
            // 
            this.cv1_bt.Location = new System.Drawing.Point(27, 64);
            this.cv1_bt.Name = "cv1_bt";
            this.cv1_bt.Size = new System.Drawing.Size(75, 23);
            this.cv1_bt.TabIndex = 15;
            this.cv1_bt.Text = "cv1_bt";
            this.cv1_bt.UseVisualStyleBackColor = true;
            this.cv1_bt.Click += new System.EventHandler(this.cv1_bt_Click);
            // 
            // cv2_bt
            // 
            this.cv2_bt.Location = new System.Drawing.Point(27, 106);
            this.cv2_bt.Name = "cv2_bt";
            this.cv2_bt.Size = new System.Drawing.Size(75, 23);
            this.cv2_bt.TabIndex = 16;
            this.cv2_bt.Text = "cv2_bt";
            this.cv2_bt.UseVisualStyleBackColor = true;
            // 
            // cv_list_dgv
            // 
            this.cv_list_dgv.AllowUserToResizeColumns = false;
            this.cv_list_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cv_list_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cv_list_dgv.Location = new System.Drawing.Point(154, 106);
            this.cv_list_dgv.Name = "cv_list_dgv";
            this.cv_list_dgv.ReadOnly = true;
            this.cv_list_dgv.Size = new System.Drawing.Size(253, 176);
            this.cv_list_dgv.TabIndex = 17;
            this.cv_list_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cv_list_dgv_CellDoubleClick);
            // 
            // CVGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 635);
            this.Controls.Add(this.cv_list_dgv);
            this.Controls.Add(this.cv2_bt);
            this.Controls.Add(this.cv1_bt);
            this.Controls.Add(this.docDocumentViewer1);
            this.Controls.Add(this.browse_bt);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cv2_pb);
            this.Controls.Add(this.cv1_pb);
            this.Controls.Add(this.ID_dynamic_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.name_dynamic_lb);
            this.Controls.Add(this.name_lb);
            this.Name = "CVGenerator";
            this.Text = "CVGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.cv1_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cv2_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cv_list_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_dynamic_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label name_dynamic_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.PictureBox cv1_pb;
        private System.Windows.Forms.PictureBox cv2_pb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button browse_bt;
        private Spire.DocViewer.Forms.DocDocumentViewer docDocumentViewer1;
        private System.Windows.Forms.Button cv1_bt;
        private System.Windows.Forms.Button cv2_bt;
        private System.Windows.Forms.DataGridView cv_list_dgv;
    }
}