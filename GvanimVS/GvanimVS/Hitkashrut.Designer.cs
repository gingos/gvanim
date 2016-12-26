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
            this.SuspendLayout();
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(63, 261);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 1;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // show_pdf_bt
            // 
            this.show_pdf_bt.Location = new System.Drawing.Point(482, 83);
            this.show_pdf_bt.Name = "show_pdf_bt";
            this.show_pdf_bt.Size = new System.Drawing.Size(131, 23);
            this.show_pdf_bt.TabIndex = 2;
            this.show_pdf_bt.Text = "הצג הסכם התקשרות";
            this.show_pdf_bt.UseVisualStyleBackColor = true;
            this.show_pdf_bt.Click += new System.EventHandler(this.show_pdf_bt_Click);
            // 
            // Hitkashrut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 323);
            this.Controls.Add(this.show_pdf_bt);
            this.Controls.Add(this.close_bt);
            this.Name = "Hitkashrut";
            this.Text = "Hitkashrut";
            this.Load += new System.EventHandler(this.Hitkashrut_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button show_pdf_bt;
    }
}