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
            this.name_lb = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.name_dynamic_lb = new System.Windows.Forms.Label();
            this.ID_dynamic_lb = new System.Windows.Forms.Label();
            this.show_pdf_bt = new System.Windows.Forms.Button();
            this.saved_file__lb = new System.Windows.Forms.Label();
            this.chosen_file_lb = new System.Windows.Forms.Label();
            this.preview_saved_bt = new System.Windows.Forms.Button();
            this.preview_selected_bt = new System.Windows.Forms.Button();
            this.upload_pdf_bt = new System.Windows.Forms.Button();
            this.choose_pdf_bt = new System.Windows.Forms.Button();
            this.close_bt = new System.Windows.Forms.Button();
            this.last_signed_dynamic_lb = new System.Windows.Forms.Label();
            this.last_signed_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(802, 27);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(76, 13);
            this.name_lb.TabIndex = 0;
            this.name_lb.Text = "שם המתמודד:";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(564, 27);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lb.Size = new System.Drawing.Size(28, 13);
            this.ID_lb.TabIndex = 1;
            this.ID_lb.Text = "ת.ז.:";
            // 
            // name_dynamic_lb
            // 
            this.name_dynamic_lb.AutoEllipsis = true;
            this.name_dynamic_lb.AutoSize = true;
            this.name_dynamic_lb.Location = new System.Drawing.Point(802, 56);
            this.name_dynamic_lb.Name = "name_dynamic_lb";
            this.name_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_dynamic_lb.Size = new System.Drawing.Size(45, 13);
            this.name_dynamic_lb.TabIndex = 2;
            this.name_dynamic_lb.Text = "<name>";
            this.name_dynamic_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID_dynamic_lb
            // 
            this.ID_dynamic_lb.AutoEllipsis = true;
            this.ID_dynamic_lb.AutoSize = true;
            this.ID_dynamic_lb.Location = new System.Drawing.Point(547, 56);
            this.ID_dynamic_lb.Name = "ID_dynamic_lb";
            this.ID_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_dynamic_lb.Size = new System.Drawing.Size(30, 13);
            this.ID_dynamic_lb.TabIndex = 3;
            this.ID_dynamic_lb.Text = "<ID>";
            this.ID_dynamic_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show_pdf_bt
            // 
            this.show_pdf_bt.Location = new System.Drawing.Point(12, 22);
            this.show_pdf_bt.Name = "show_pdf_bt";
            this.show_pdf_bt.Size = new System.Drawing.Size(131, 23);
            this.show_pdf_bt.TabIndex = 4;
            this.show_pdf_bt.Text = "הצג הסכם התקשרות";
            this.show_pdf_bt.UseVisualStyleBackColor = true;
            // 
            // saved_file__lb
            // 
            this.saved_file__lb.AutoSize = true;
            this.saved_file__lb.Location = new System.Drawing.Point(764, 286);
            this.saved_file__lb.Name = "saved_file__lb";
            this.saved_file__lb.Size = new System.Drawing.Size(99, 13);
            this.saved_file__lb.TabIndex = 20;
            this.saved_file__lb.Text = "<saved_file_name>";
            // 
            // chosen_file_lb
            // 
            this.chosen_file_lb.AutoSize = true;
            this.chosen_file_lb.Location = new System.Drawing.Point(770, 163);
            this.chosen_file_lb.Name = "chosen_file_lb";
            this.chosen_file_lb.Size = new System.Drawing.Size(105, 13);
            this.chosen_file_lb.TabIndex = 19;
            this.chosen_file_lb.Text = "<chosen_file_name>";
            // 
            // preview_saved_bt
            // 
            this.preview_saved_bt.Location = new System.Drawing.Point(767, 247);
            this.preview_saved_bt.Name = "preview_saved_bt";
            this.preview_saved_bt.Size = new System.Drawing.Size(108, 23);
            this.preview_saved_bt.TabIndex = 18;
            this.preview_saved_bt.Text = "הצג קובץ שמור";
            this.preview_saved_bt.UseVisualStyleBackColor = true;
            // 
            // preview_selected_bt
            // 
            this.preview_selected_bt.Location = new System.Drawing.Point(767, 124);
            this.preview_selected_bt.Name = "preview_selected_bt";
            this.preview_selected_bt.Size = new System.Drawing.Size(108, 23);
            this.preview_selected_bt.TabIndex = 17;
            this.preview_selected_bt.Text = "הצג קובץ נבחר";
            this.preview_selected_bt.UseVisualStyleBackColor = true;
            // 
            // upload_pdf_bt
            // 
            this.upload_pdf_bt.Location = new System.Drawing.Point(767, 218);
            this.upload_pdf_bt.Name = "upload_pdf_bt";
            this.upload_pdf_bt.Size = new System.Drawing.Size(109, 23);
            this.upload_pdf_bt.TabIndex = 16;
            this.upload_pdf_bt.Text = "שמור";
            this.upload_pdf_bt.UseVisualStyleBackColor = true;
            // 
            // choose_pdf_bt
            // 
            this.choose_pdf_bt.Location = new System.Drawing.Point(766, 95);
            this.choose_pdf_bt.Name = "choose_pdf_bt";
            this.choose_pdf_bt.Size = new System.Drawing.Size(109, 23);
            this.choose_pdf_bt.TabIndex = 15;
            this.choose_pdf_bt.Text = "בחר קובץ";
            this.choose_pdf_bt.UseVisualStyleBackColor = true;
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(35, 471);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 21;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // last_signed_dynamic_lb
            // 
            this.last_signed_dynamic_lb.AutoSize = true;
            this.last_signed_dynamic_lb.Location = new System.Drawing.Point(300, 56);
            this.last_signed_dynamic_lb.Name = "last_signed_dynamic_lb";
            this.last_signed_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.last_signed_dynamic_lb.Size = new System.Drawing.Size(72, 13);
            this.last_signed_dynamic_lb.TabIndex = 23;
            this.last_signed_dynamic_lb.Text = "<last_signed>";
            // 
            // last_signed_lb
            // 
            this.last_signed_lb.AutoSize = true;
            this.last_signed_lb.Location = new System.Drawing.Point(300, 27);
            this.last_signed_lb.Name = "last_signed_lb";
            this.last_signed_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.last_signed_lb.Size = new System.Drawing.Size(116, 13);
            this.last_signed_lb.TabIndex = 22;
            this.last_signed_lb.Text = "תאריך חתימה אחרון: ";
            // 
            // Confidentiality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 538);
            this.Controls.Add(this.last_signed_dynamic_lb);
            this.Controls.Add(this.last_signed_lb);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.saved_file__lb);
            this.Controls.Add(this.chosen_file_lb);
            this.Controls.Add(this.preview_saved_bt);
            this.Controls.Add(this.preview_selected_bt);
            this.Controls.Add(this.upload_pdf_bt);
            this.Controls.Add(this.choose_pdf_bt);
            this.Controls.Add(this.show_pdf_bt);
            this.Controls.Add(this.ID_dynamic_lb);
            this.Controls.Add(this.name_dynamic_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.name_lb);
            this.Name = "Confidentiality";
            this.Text = "Confidentiality";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label name_dynamic_lb;
        private System.Windows.Forms.Label ID_dynamic_lb;
        private System.Windows.Forms.Button show_pdf_bt;
        private System.Windows.Forms.Label saved_file__lb;
        private System.Windows.Forms.Label chosen_file_lb;
        private System.Windows.Forms.Button preview_saved_bt;
        private System.Windows.Forms.Button preview_selected_bt;
        private System.Windows.Forms.Button upload_pdf_bt;
        private System.Windows.Forms.Button choose_pdf_bt;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Label last_signed_dynamic_lb;
        private System.Windows.Forms.Label last_signed_lb;
    }
}