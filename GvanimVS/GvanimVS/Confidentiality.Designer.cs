namespace GvanimVS
{
    partial class Confidentiality
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.name_lb = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.name_dynamic_lb = new System.Windows.Forms.Label();
            this.ID_dynamic_lb = new System.Windows.Forms.Label();
            this.show_pdf_bt = new System.Windows.Forms.Button();
            this.saved_file_lb = new System.Windows.Forms.Label();
            this.chosen_file_lb = new System.Windows.Forms.Label();
            this.preview_saved_bt = new System.Windows.Forms.Button();
            this.preview_selected_bt = new System.Windows.Forms.Button();
            this.upload_file_bt = new System.Windows.Forms.Button();
            this.choose_file_bt = new System.Windows.Forms.Button();
            this.close_bt = new System.Windows.Forms.Button();
            this.last_signed_dynamic_lb = new System.Windows.Forms.Label();
            this.last_signed_lb = new System.Windows.Forms.Label();
            this.staff_dgv = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.export_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staff_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(802, 27);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(97, 20);
            this.name_lb.TabIndex = 0;
            this.name_lb.Text = "שם המתמודד:";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lb.Location = new System.Drawing.Point(564, 27);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lb.Size = new System.Drawing.Size(34, 20);
            this.ID_lb.TabIndex = 1;
            this.ID_lb.Text = "ת.ז.:";
            // 
            // name_dynamic_lb
            // 
            this.name_dynamic_lb.AutoEllipsis = true;
            this.name_dynamic_lb.AutoSize = true;
            this.name_dynamic_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_dynamic_lb.Location = new System.Drawing.Point(802, 56);
            this.name_dynamic_lb.Name = "name_dynamic_lb";
            this.name_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_dynamic_lb.Size = new System.Drawing.Size(65, 20);
            this.name_dynamic_lb.TabIndex = 2;
            this.name_dynamic_lb.Text = "<name>";
            this.name_dynamic_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID_dynamic_lb
            // 
            this.ID_dynamic_lb.AutoEllipsis = true;
            this.ID_dynamic_lb.AutoSize = true;
            this.ID_dynamic_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_dynamic_lb.Location = new System.Drawing.Point(547, 56);
            this.ID_dynamic_lb.Name = "ID_dynamic_lb";
            this.ID_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_dynamic_lb.Size = new System.Drawing.Size(44, 20);
            this.ID_dynamic_lb.TabIndex = 3;
            this.ID_dynamic_lb.Text = "<ID>";
            this.ID_dynamic_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show_pdf_bt
            // 
            this.show_pdf_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.show_pdf_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_pdf_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_pdf_bt.ForeColor = System.Drawing.Color.White;
            this.show_pdf_bt.Location = new System.Drawing.Point(12, 12);
            this.show_pdf_bt.Name = "show_pdf_bt";
            this.show_pdf_bt.Size = new System.Drawing.Size(216, 35);
            this.show_pdf_bt.TabIndex = 4;
            this.show_pdf_bt.Text = "הצג תבנית מסמך ויתור סודיות";
            this.show_pdf_bt.UseVisualStyleBackColor = false;
            this.show_pdf_bt.Click += new System.EventHandler(this.show_pdf_bt_Click_1);
            this.show_pdf_bt.MouseLeave += new System.EventHandler(this.show_pdf_bt_MouseLeave);
            this.show_pdf_bt.MouseHover += new System.EventHandler(this.show_pdf_bt_MouseHover);
            // 
            // saved_file_lb
            // 
            this.saved_file_lb.AutoEllipsis = true;
            this.saved_file_lb.AutoSize = true;
            this.saved_file_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saved_file_lb.Location = new System.Drawing.Point(736, 290);
            this.saved_file_lb.Name = "saved_file_lb";
            this.saved_file_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.saved_file_lb.Size = new System.Drawing.Size(137, 20);
            this.saved_file_lb.TabIndex = 20;
            this.saved_file_lb.Text = "<saved_file_name>";
            this.saved_file_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saved_file_lb.Visible = false;
            // 
            // chosen_file_lb
            // 
            this.chosen_file_lb.AutoEllipsis = true;
            this.chosen_file_lb.AutoSize = true;
            this.chosen_file_lb.Enabled = false;
            this.chosen_file_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosen_file_lb.Location = new System.Drawing.Point(736, 163);
            this.chosen_file_lb.Name = "chosen_file_lb";
            this.chosen_file_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chosen_file_lb.Size = new System.Drawing.Size(142, 20);
            this.chosen_file_lb.TabIndex = 19;
            this.chosen_file_lb.Text = "<chosen_file_name>";
            this.chosen_file_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chosen_file_lb.Visible = false;
            // 
            // preview_saved_bt
            // 
            this.preview_saved_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.preview_saved_bt.Enabled = false;
            this.preview_saved_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preview_saved_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview_saved_bt.ForeColor = System.Drawing.Color.White;
            this.preview_saved_bt.Location = new System.Drawing.Point(757, 247);
            this.preview_saved_bt.Name = "preview_saved_bt";
            this.preview_saved_bt.Size = new System.Drawing.Size(119, 40);
            this.preview_saved_bt.TabIndex = 18;
            this.preview_saved_bt.Text = "הצג קובץ שמור";
            this.preview_saved_bt.UseVisualStyleBackColor = false;
            this.preview_saved_bt.Visible = false;
            this.preview_saved_bt.Click += new System.EventHandler(this.preview_saved_bt_Click);
            this.preview_saved_bt.MouseLeave += new System.EventHandler(this.preview_saved_bt_MouseLeave);
            this.preview_saved_bt.MouseHover += new System.EventHandler(this.preview_saved_bt_MouseHover);
            // 
            // preview_selected_bt
            // 
            this.preview_selected_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.preview_selected_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preview_selected_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview_selected_bt.ForeColor = System.Drawing.Color.White;
            this.preview_selected_bt.Location = new System.Drawing.Point(757, 124);
            this.preview_selected_bt.Name = "preview_selected_bt";
            this.preview_selected_bt.Size = new System.Drawing.Size(119, 36);
            this.preview_selected_bt.TabIndex = 17;
            this.preview_selected_bt.Text = "הצג קובץ נבחר";
            this.preview_selected_bt.UseVisualStyleBackColor = false;
            this.preview_selected_bt.Click += new System.EventHandler(this.preview_selected_bt_Click);
            this.preview_selected_bt.MouseLeave += new System.EventHandler(this.preview_selected_bt_MouseLeave);
            this.preview_selected_bt.MouseHover += new System.EventHandler(this.preview_selected_bt_MouseHover);
            // 
            // upload_file_bt
            // 
            this.upload_file_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.upload_file_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_file_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_file_bt.ForeColor = System.Drawing.Color.White;
            this.upload_file_bt.Location = new System.Drawing.Point(757, 207);
            this.upload_file_bt.Name = "upload_file_bt";
            this.upload_file_bt.Size = new System.Drawing.Size(119, 34);
            this.upload_file_bt.TabIndex = 16;
            this.upload_file_bt.Text = "שמור";
            this.upload_file_bt.UseVisualStyleBackColor = false;
            this.upload_file_bt.Click += new System.EventHandler(this.upload_file_bt_Click);
            this.upload_file_bt.MouseLeave += new System.EventHandler(this.upload_file_bt_MouseLeave);
            this.upload_file_bt.MouseHover += new System.EventHandler(this.upload_file_bt_MouseHover);
            // 
            // choose_file_bt
            // 
            this.choose_file_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.choose_file_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_file_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_file_bt.ForeColor = System.Drawing.Color.White;
            this.choose_file_bt.Location = new System.Drawing.Point(757, 79);
            this.choose_file_bt.Name = "choose_file_bt";
            this.choose_file_bt.Size = new System.Drawing.Size(119, 39);
            this.choose_file_bt.TabIndex = 15;
            this.choose_file_bt.Text = "בחר קובץ";
            this.choose_file_bt.UseVisualStyleBackColor = false;
            this.choose_file_bt.Click += new System.EventHandler(this.choose_file_bt_Click);
            this.choose_file_bt.MouseLeave += new System.EventHandler(this.choose_file_bt_MouseLeave);
            this.choose_file_bt.MouseHover += new System.EventHandler(this.choose_file_bt_MouseHover);
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(35, 471);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(85, 32);
            this.close_bt.TabIndex = 21;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            this.close_bt.MouseLeave += new System.EventHandler(this.close_bt_MouseLeave);
            this.close_bt.MouseHover += new System.EventHandler(this.close_bt_MouseHover);
            // 
            // last_signed_dynamic_lb
            // 
            this.last_signed_dynamic_lb.AutoSize = true;
            this.last_signed_dynamic_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_signed_dynamic_lb.Location = new System.Drawing.Point(300, 56);
            this.last_signed_dynamic_lb.Name = "last_signed_dynamic_lb";
            this.last_signed_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.last_signed_dynamic_lb.Size = new System.Drawing.Size(102, 20);
            this.last_signed_dynamic_lb.TabIndex = 23;
            this.last_signed_dynamic_lb.Text = "<last_signed>";
            // 
            // last_signed_lb
            // 
            this.last_signed_lb.AutoSize = true;
            this.last_signed_lb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_signed_lb.Location = new System.Drawing.Point(300, 27);
            this.last_signed_lb.Name = "last_signed_lb";
            this.last_signed_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.last_signed_lb.Size = new System.Drawing.Size(146, 20);
            this.last_signed_lb.TabIndex = 22;
            this.last_signed_lb.Text = "תאריך חתימה אחרון: ";
            // 
            // staff_dgv
            // 
            this.staff_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staff_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.staff_dgv.BackgroundColor = System.Drawing.Color.White;
            this.staff_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staff_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staff_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.position});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staff_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.staff_dgv.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.staff_dgv.Location = new System.Drawing.Point(105, 105);
            this.staff_dgv.Name = "staff_dgv";
            this.staff_dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.staff_dgv.Size = new System.Drawing.Size(540, 122);
            this.staff_dgv.TabIndex = 24;
            this.staff_dgv.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.staff_dgv_UserAddedRow);
            this.staff_dgv.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.staff_dgv_UserDeletedRow);
            // 
            // name
            // 
            this.name.HeaderText = "שם הגורם";
            this.name.Name = "name";
            // 
            // position
            // 
            this.position.HeaderText = "תפקיד";
            this.position.Name = "position";
            // 
            // export_bt
            // 
            this.export_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.export_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_bt.ForeColor = System.Drawing.Color.White;
            this.export_bt.Location = new System.Drawing.Point(12, 56);
            this.export_bt.Name = "export_bt";
            this.export_bt.Size = new System.Drawing.Size(216, 33);
            this.export_bt.TabIndex = 25;
            this.export_bt.Text = "צור קובץ מוכן להדפסה";
            this.export_bt.UseVisualStyleBackColor = false;
            this.export_bt.Click += new System.EventHandler(this.export_Click);
            this.export_bt.MouseLeave += new System.EventHandler(this.export_bt_MouseLeave);
            this.export_bt.MouseHover += new System.EventHandler(this.export_bt_MouseHover);
            // 
            // Confidentiality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 538);
            this.Controls.Add(this.export_bt);
            this.Controls.Add(this.staff_dgv);
            this.Controls.Add(this.last_signed_dynamic_lb);
            this.Controls.Add(this.last_signed_lb);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.saved_file_lb);
            this.Controls.Add(this.chosen_file_lb);
            this.Controls.Add(this.preview_saved_bt);
            this.Controls.Add(this.preview_selected_bt);
            this.Controls.Add(this.upload_file_bt);
            this.Controls.Add(this.choose_file_bt);
            this.Controls.Add(this.show_pdf_bt);
            this.Controls.Add(this.ID_dynamic_lb);
            this.Controls.Add(this.name_dynamic_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.name_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Confidentiality";
            this.Text = "Confidentiality";
            ((System.ComponentModel.ISupportInitialize)(this.staff_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label name_dynamic_lb;
        private System.Windows.Forms.Label ID_dynamic_lb;
        private System.Windows.Forms.Button show_pdf_bt;
        private System.Windows.Forms.Label saved_file_lb;
        private System.Windows.Forms.Label chosen_file_lb;
        private System.Windows.Forms.Button preview_saved_bt;
        private System.Windows.Forms.Button preview_selected_bt;
        private System.Windows.Forms.Button upload_file_bt;
        private System.Windows.Forms.Button choose_file_bt;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Label last_signed_dynamic_lb;
        private System.Windows.Forms.Label last_signed_lb;
        private System.Windows.Forms.DataGridView staff_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.Button export_bt;
    }
}