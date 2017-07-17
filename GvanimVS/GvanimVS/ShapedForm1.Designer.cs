namespace GvanimVS
{
    partial class ShapedForm1
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.headersPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.exit_bt = new System.Windows.Forms.Button();
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.alert_bt = new System.Windows.Forms.Button();
            this.report_show_bt = new System.Windows.Forms.Button();
            this.meeting_show_bt = new System.Windows.Forms.Button();
            this.headersPanel.SuspendLayout();
            this.sideBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(203, 62);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(703, 404);
            this.mainPanel.TabIndex = 3;
            // 
            // headersPanel
            // 
            this.headersPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.headersPanel.Controls.Add(this.logoPanel);
            this.headersPanel.Controls.Add(this.exit_bt);
            this.headersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headersPanel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headersPanel.Location = new System.Drawing.Point(0, 0);
            this.headersPanel.Name = "headersPanel";
            this.headersPanel.Size = new System.Drawing.Size(906, 62);
            this.headersPanel.TabIndex = 4;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoPanel.BackgroundImage = global::GvanimVS.Properties.Resources.logo;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoPanel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoPanel.Location = new System.Drawing.Point(706, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 62);
            this.logoPanel.TabIndex = 3;
            // 
            // exit_bt
            // 
            this.exit_bt.AllowDrop = true;
            this.exit_bt.BackColor = System.Drawing.Color.Transparent;
            this.exit_bt.BackgroundImage = global::GvanimVS.Properties.Resources.Close_Window_50px;
            this.exit_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_bt.FlatAppearance.BorderSize = 0;
            this.exit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_bt.ForeColor = System.Drawing.Color.Transparent;
            this.exit_bt.Location = new System.Drawing.Point(15, 18);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(27, 27);
            this.exit_bt.TabIndex = 2;
            this.exit_bt.UseVisualStyleBackColor = true;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click_1);
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.sideBarPanel.Controls.Add(this.alert_bt);
            this.sideBarPanel.Controls.Add(this.report_show_bt);
            this.sideBarPanel.Controls.Add(this.meeting_show_bt);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideBarPanel.Location = new System.Drawing.Point(0, 62);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(200, 404);
            this.sideBarPanel.TabIndex = 5;
            // 
            // alert_bt
            // 
            this.alert_bt.BackColor = System.Drawing.Color.SlateGray;
            this.alert_bt.BackgroundImage = global::GvanimVS.Properties.Resources.Information_50px;
            this.alert_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alert_bt.FlatAppearance.BorderSize = 0;
            this.alert_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alert_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert_bt.ForeColor = System.Drawing.Color.White;
            this.alert_bt.Location = new System.Drawing.Point(0, 149);
            this.alert_bt.Name = "alert_bt";
            this.alert_bt.Size = new System.Drawing.Size(200, 46);
            this.alert_bt.TabIndex = 0;
            this.alert_bt.Text = "התראות";
            this.alert_bt.UseVisualStyleBackColor = false;
            // 
            // report_show_bt
            // 
            this.report_show_bt.BackColor = System.Drawing.Color.SlateGray;
            this.report_show_bt.BackgroundImage = global::GvanimVS.Properties.Resources.Checklist_50px;
            this.report_show_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.report_show_bt.FlatAppearance.BorderSize = 0;
            this.report_show_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report_show_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_show_bt.ForeColor = System.Drawing.Color.White;
            this.report_show_bt.Location = new System.Drawing.Point(0, 97);
            this.report_show_bt.Name = "report_show_bt";
            this.report_show_bt.Size = new System.Drawing.Size(200, 46);
            this.report_show_bt.TabIndex = 0;
            this.report_show_bt.Text = "הצג דוחות";
            this.report_show_bt.UseVisualStyleBackColor = false;
            // 
            // meeting_show_bt
            // 
            this.meeting_show_bt.BackColor = System.Drawing.Color.SlateGray;
            this.meeting_show_bt.BackgroundImage = global::GvanimVS.Properties.Resources.User_Location_50px;
            this.meeting_show_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.meeting_show_bt.FlatAppearance.BorderSize = 0;
            this.meeting_show_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meeting_show_bt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meeting_show_bt.ForeColor = System.Drawing.Color.White;
            this.meeting_show_bt.Location = new System.Drawing.Point(0, 45);
            this.meeting_show_bt.Name = "meeting_show_bt";
            this.meeting_show_bt.Size = new System.Drawing.Size(200, 46);
            this.meeting_show_bt.TabIndex = 0;
            this.meeting_show_bt.Text = "הצג פגישות";
            this.meeting_show_bt.UseVisualStyleBackColor = false;
            this.meeting_show_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShapedForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 466);
            this.ControlBox = false;
            this.Controls.Add(this.sideBarPanel);
            this.Controls.Add(this.headersPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShapedForm1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.headersPanel.ResumeLayout(false);
            this.sideBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel headersPanel;
        private System.Windows.Forms.Button exit_bt;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Button meeting_show_bt;
        private System.Windows.Forms.Button alert_bt;
        private System.Windows.Forms.Button report_show_bt;
        public System.Windows.Forms.Panel mainPanel;
    }
}
