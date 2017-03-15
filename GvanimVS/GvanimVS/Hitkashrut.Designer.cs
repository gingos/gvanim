namespace GvanimVS
{
    partial class Hitkashrut
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
            this.show_pdf_bt = new System.Windows.Forms.Button();
            this.choose_pdf_bt = new System.Windows.Forms.Button();
            this.last_signed_lb = new System.Windows.Forms.Label();
            this.last_signed_dynamic_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.name_dynamic_lb = new System.Windows.Forms.Label();
            this.ID_dynamic_lb = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.upload_pdf_bt = new System.Windows.Forms.Button();
            this.preview_selected_bt = new System.Windows.Forms.Button();
            this.preview_saved_bt = new System.Windows.Forms.Button();
            this.chosen_file_lb = new System.Windows.Forms.Label();
            this.saved_file__lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(43, 274);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 1;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // show_pdf_bt
            // 
            this.show_pdf_bt.Location = new System.Drawing.Point(21, 21);
            this.show_pdf_bt.Name = "show_pdf_bt";
            this.show_pdf_bt.Size = new System.Drawing.Size(131, 23);
            this.show_pdf_bt.TabIndex = 2;
            this.show_pdf_bt.Text = "הצג הסכם התקשרות";
            this.show_pdf_bt.UseVisualStyleBackColor = true;
            this.show_pdf_bt.Click += new System.EventHandler(this.show_pdf_bt_Click);
            // 
            // choose_pdf_bt
            // 
            this.choose_pdf_bt.Location = new System.Drawing.Point(438, 163);
            this.choose_pdf_bt.Name = "choose_pdf_bt";
            this.choose_pdf_bt.Size = new System.Drawing.Size(109, 23);
            this.choose_pdf_bt.TabIndex = 3;
            this.choose_pdf_bt.Text = "בחר קובץ";
            this.choose_pdf_bt.UseVisualStyleBackColor = true;
            this.choose_pdf_bt.Click += new System.EventHandler(this.choose_file_bt_Click);
            // 
            // last_signed_lb
            // 
            this.last_signed_lb.AutoSize = true;
            this.last_signed_lb.Location = new System.Drawing.Point(500, 103);
            this.last_signed_lb.Name = "last_signed_lb";
            this.last_signed_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.last_signed_lb.Size = new System.Drawing.Size(116, 13);
            this.last_signed_lb.TabIndex = 4;
            this.last_signed_lb.Text = "תאריך חתימה אחרון: ";
            // 
            // last_signed_dynamic_lb
            // 
            this.last_signed_dynamic_lb.AutoSize = true;
            this.last_signed_dynamic_lb.Location = new System.Drawing.Point(344, 103);
            this.last_signed_dynamic_lb.Name = "last_signed_dynamic_lb";
            this.last_signed_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.last_signed_dynamic_lb.Size = new System.Drawing.Size(72, 13);
            this.last_signed_dynamic_lb.TabIndex = 5;
            this.last_signed_dynamic_lb.Text = "<last_signed>";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(537, 21);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(79, 13);
            this.name_lb.TabIndex = 6;
            this.name_lb.Text = "שם המתמודד: ";
            // 
            // name_dynamic_lb
            // 
            this.name_dynamic_lb.AutoSize = true;
            this.name_dynamic_lb.Location = new System.Drawing.Point(537, 51);
            this.name_dynamic_lb.Name = "name_dynamic_lb";
            this.name_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_dynamic_lb.Size = new System.Drawing.Size(45, 13);
            this.name_dynamic_lb.TabIndex = 7;
            this.name_dynamic_lb.Text = "<name>";
            // 
            // ID_dynamic_lb
            // 
            this.ID_dynamic_lb.AutoSize = true;
            this.ID_dynamic_lb.Location = new System.Drawing.Point(367, 51);
            this.ID_dynamic_lb.Name = "ID_dynamic_lb";
            this.ID_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_dynamic_lb.Size = new System.Drawing.Size(30, 13);
            this.ID_dynamic_lb.TabIndex = 9;
            this.ID_dynamic_lb.Text = "<ID>";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(384, 21);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lb.Size = new System.Drawing.Size(28, 13);
            this.ID_lb.TabIndex = 8;
            this.ID_lb.Text = "ת.ז.:";
            // 
            // upload_pdf_bt
            // 
            this.upload_pdf_bt.Location = new System.Drawing.Point(73, 163);
            this.upload_pdf_bt.Name = "upload_pdf_bt";
            this.upload_pdf_bt.Size = new System.Drawing.Size(109, 23);
            this.upload_pdf_bt.TabIndex = 10;
            this.upload_pdf_bt.Text = "שמור";
            this.upload_pdf_bt.UseVisualStyleBackColor = true;
            this.upload_pdf_bt.Click += new System.EventHandler(this.upload_pdf_bt_Click);
            // 
            // preview_selected_bt
            // 
            this.preview_selected_bt.Location = new System.Drawing.Point(439, 192);
            this.preview_selected_bt.Name = "preview_selected_bt";
            this.preview_selected_bt.Size = new System.Drawing.Size(108, 23);
            this.preview_selected_bt.TabIndex = 11;
            this.preview_selected_bt.Text = "הצג קובץ נבחר";
            this.preview_selected_bt.UseVisualStyleBackColor = true;
            this.preview_selected_bt.Click += new System.EventHandler(this.preview_selected_bt_Click);
            // 
            // preview_saved_bt
            // 
            this.preview_saved_bt.Location = new System.Drawing.Point(73, 192);
            this.preview_saved_bt.Name = "preview_saved_bt";
            this.preview_saved_bt.Size = new System.Drawing.Size(108, 23);
            this.preview_saved_bt.TabIndex = 12;
            this.preview_saved_bt.Text = "הצג קובץ שמור";
            this.preview_saved_bt.UseVisualStyleBackColor = true;
            this.preview_saved_bt.Click += new System.EventHandler(this.preview_saved_bt_Click);
            // 
            // chosen_file_lb
            // 
            this.chosen_file_lb.AutoSize = true;
            this.chosen_file_lb.Location = new System.Drawing.Point(442, 231);
            this.chosen_file_lb.Name = "chosen_file_lb";
            this.chosen_file_lb.Size = new System.Drawing.Size(105, 13);
            this.chosen_file_lb.TabIndex = 13;
            this.chosen_file_lb.Text = "<chosen_file_name>";
            // 
            // saved_file__lb
            // 
            this.saved_file__lb.AutoSize = true;
            this.saved_file__lb.Location = new System.Drawing.Point(70, 231);
            this.saved_file__lb.Name = "saved_file__lb";
            this.saved_file__lb.Size = new System.Drawing.Size(99, 13);
            this.saved_file__lb.TabIndex = 14;
            this.saved_file__lb.Text = "<saved_file_name>";
            // 
            // Hitkashrut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 323);
            this.Controls.Add(this.saved_file__lb);
            this.Controls.Add(this.chosen_file_lb);
            this.Controls.Add(this.preview_saved_bt);
            this.Controls.Add(this.preview_selected_bt);
            this.Controls.Add(this.upload_pdf_bt);
            this.Controls.Add(this.ID_dynamic_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.name_dynamic_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.last_signed_dynamic_lb);
            this.Controls.Add(this.last_signed_lb);
            this.Controls.Add(this.choose_pdf_bt);
            this.Controls.Add(this.show_pdf_bt);
            this.Controls.Add(this.close_bt);
            this.Name = "Hitkashrut";
            this.Text = "Hitkashrut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button show_pdf_bt;
        private System.Windows.Forms.Button choose_pdf_bt;
        private System.Windows.Forms.Label last_signed_lb;
        private System.Windows.Forms.Label last_signed_dynamic_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label name_dynamic_lb;
        private System.Windows.Forms.Label ID_dynamic_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Button upload_pdf_bt;
        private System.Windows.Forms.Button preview_selected_bt;
        private System.Windows.Forms.Button preview_saved_bt;
        private System.Windows.Forms.Label chosen_file_lb;
        private System.Windows.Forms.Label saved_file__lb;
    }
}