namespace GvanimVS
{
    partial class Alerts
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
            this.name_dynamic_lb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alert_description_lb = new System.Windows.Forms.Label();
            this.close_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(699, 45);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(61, 13);
            this.name_lb.TabIndex = 0;
            this.name_lb.Text = "שם הרכזת:";
            // 
            // name_dynamic_lb
            // 
            this.name_dynamic_lb.AutoSize = true;
            this.name_dynamic_lb.Location = new System.Drawing.Point(529, 45);
            this.name_dynamic_lb.Name = "name_dynamic_lb";
            this.name_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_dynamic_lb.Size = new System.Drawing.Size(90, 13);
            this.name_dynamic_lb.TabIndex = 1;
            this.name_dynamic_lb.Text = "<name_dynamic>";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 201);
            this.dataGridView1.TabIndex = 2;
            // 
            // alert_description_lb
            // 
            this.alert_description_lb.AutoSize = true;
            this.alert_description_lb.Location = new System.Drawing.Point(305, 81);
            this.alert_description_lb.Name = "alert_description_lb";
            this.alert_description_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.alert_description_lb.Size = new System.Drawing.Size(455, 13);
            this.alert_description_lb.TabIndex = 3;
            this.alert_description_lb.Text = "ריכוז התראות עבור מתמודדים (מתמודדים אשר תוקף אישור ההתקשרות שלהם פג בקרוב)";
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(25, 349);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 4;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // Alerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 400);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.alert_description_lb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.name_dynamic_lb);
            this.Controls.Add(this.name_lb);
            this.Name = "Alerts";
            this.Text = "Alerts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label name_dynamic_lb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label alert_description_lb;
        private System.Windows.Forms.Button close_bt;
    }
}