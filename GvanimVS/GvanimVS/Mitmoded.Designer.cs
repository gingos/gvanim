namespace GvanimVS
{
    partial class Mitmoded
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
            this.ID_lb = new System.Windows.Forms.Label();
            this.ID_dynamic_lb = new System.Windows.Forms.Label();
            this.info_bt = new System.Windows.Forms.Button();
            this.show_employment_bt = new System.Windows.Forms.Button();
            this.show_reports_bt = new System.Windows.Forms.Button();
            this.add_employment_bt = new System.Windows.Forms.Button();
            this.add_report_bt = new System.Windows.Forms.Button();
            this.close_bt = new System.Windows.Forms.Button();
            this.change_coordinator_bt = new System.Windows.Forms.Button();
            this.coordinator_name_lb = new System.Windows.Forms.Label();
            this.coordinator_dynamic_lb = new System.Windows.Forms.Label();
            this.tochnit_bt = new System.Windows.Forms.Button();
            this.form_categories_tc = new System.Windows.Forms.TabControl();
            this.cat_personal_tab = new System.Windows.Forms.TabPage();
            this.confidentiality_bt = new System.Windows.Forms.Button();
            this.open_hitkashrut_bt = new System.Windows.Forms.Button();
            this.cat_report_tab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.unusual_event_search_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cat_meeting_tab = new System.Windows.Forms.TabPage();
            this.show_meetings_bt = new System.Windows.Forms.Button();
            this.cv_generator_bt = new System.Windows.Forms.Button();
            this.showPsyCheckUps_btn = new System.Windows.Forms.Button();
            this.addPsychiatricCheckUp_btn = new System.Windows.Forms.Button();
            this.score_lb = new System.Windows.Forms.Label();
            this.score_dynamic_lb = new System.Windows.Forms.Label();
            this.keyword_bt = new System.Windows.Forms.Button();
            this.profile_pb = new System.Windows.Forms.PictureBox();
            this.form_categories_tc.SuspendLayout();
            this.cat_personal_tab.SuspendLayout();
            this.cat_report_tab.SuspendLayout();
            this.cat_meeting_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(610, 32);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(29, 13);
            this.name_lb.TabIndex = 0;
            this.name_lb.Text = "שם: ";
            // 
            // name_dynamic_lb
            // 
            this.name_dynamic_lb.AutoSize = true;
            this.name_dynamic_lb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name_dynamic_lb.Location = new System.Drawing.Point(468, 32);
            this.name_dynamic_lb.Name = "name_dynamic_lb";
            this.name_dynamic_lb.Size = new System.Drawing.Size(45, 13);
            this.name_dynamic_lb.TabIndex = 1;
            this.name_dynamic_lb.Text = "<name>";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(312, 32);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lb.Size = new System.Drawing.Size(70, 13);
            this.ID_lb.TabIndex = 2;
            this.ID_lb.Text = "תעודת זהות:";
            // 
            // ID_dynamic_lb
            // 
            this.ID_dynamic_lb.AutoSize = true;
            this.ID_dynamic_lb.Location = new System.Drawing.Point(256, 31);
            this.ID_dynamic_lb.Name = "ID_dynamic_lb";
            this.ID_dynamic_lb.Size = new System.Drawing.Size(30, 13);
            this.ID_dynamic_lb.TabIndex = 3;
            this.ID_dynamic_lb.Text = "<ID>";
            // 
            // info_bt
            // 
            this.info_bt.Location = new System.Drawing.Point(250, 16);
            this.info_bt.Name = "info_bt";
            this.info_bt.Size = new System.Drawing.Size(108, 23);
            this.info_bt.TabIndex = 4;
            this.info_bt.Text = "אינטק מועמד";
            this.info_bt.UseVisualStyleBackColor = true;
            this.info_bt.Click += new System.EventHandler(this.info_bt_Click);
            // 
            // show_employment_bt
            // 
            this.show_employment_bt.Enabled = false;
            this.show_employment_bt.Location = new System.Drawing.Point(208, 15);
            this.show_employment_bt.Name = "show_employment_bt";
            this.show_employment_bt.Size = new System.Drawing.Size(166, 23);
            this.show_employment_bt.TabIndex = 6;
            this.show_employment_bt.Text = "הצג פריטי תעסוקה";
            this.show_employment_bt.UseVisualStyleBackColor = true;
            this.show_employment_bt.Click += new System.EventHandler(this.employment_bt_Click);
            // 
            // show_reports_bt
            // 
            this.show_reports_bt.Location = new System.Drawing.Point(21, 20);
            this.show_reports_bt.Name = "show_reports_bt";
            this.show_reports_bt.Size = new System.Drawing.Size(166, 23);
            this.show_reports_bt.TabIndex = 7;
            this.show_reports_bt.Text = "הצג דוחות";
            this.show_reports_bt.UseVisualStyleBackColor = true;
            this.show_reports_bt.Click += new System.EventHandler(this.show_reports_bt_Click);
            // 
            // add_employment_bt
            // 
            this.add_employment_bt.Enabled = false;
            this.add_employment_bt.Location = new System.Drawing.Point(208, 44);
            this.add_employment_bt.Name = "add_employment_bt";
            this.add_employment_bt.Size = new System.Drawing.Size(165, 23);
            this.add_employment_bt.TabIndex = 8;
            this.add_employment_bt.Text = "הוסף פריט תעסוקה";
            this.add_employment_bt.UseVisualStyleBackColor = true;
            // 
            // add_report_bt
            // 
            this.add_report_bt.Location = new System.Drawing.Point(21, 49);
            this.add_report_bt.Name = "add_report_bt";
            this.add_report_bt.Size = new System.Drawing.Size(166, 23);
            this.add_report_bt.TabIndex = 9;
            this.add_report_bt.Text = "הוסף דוח";
            this.add_report_bt.UseVisualStyleBackColor = true;
            this.add_report_bt.Click += new System.EventHandler(this.add_report_bt_Click);
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(53, 297);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 10;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // change_coordinator_bt
            // 
            this.change_coordinator_bt.Location = new System.Drawing.Point(259, 59);
            this.change_coordinator_bt.Name = "change_coordinator_bt";
            this.change_coordinator_bt.Size = new System.Drawing.Size(75, 23);
            this.change_coordinator_bt.TabIndex = 11;
            this.change_coordinator_bt.Text = "שינוי רכזת";
            this.change_coordinator_bt.UseVisualStyleBackColor = true;
            this.change_coordinator_bt.Click += new System.EventHandler(this.change_coordinator_bt_Click);
            // 
            // coordinator_name_lb
            // 
            this.coordinator_name_lb.AutoSize = true;
            this.coordinator_name_lb.Location = new System.Drawing.Point(604, 64);
            this.coordinator_name_lb.Name = "coordinator_name_lb";
            this.coordinator_name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.coordinator_name_lb.Size = new System.Drawing.Size(35, 13);
            this.coordinator_name_lb.TabIndex = 12;
            this.coordinator_name_lb.Text = "רכזת:";
            // 
            // coordinator_dynamic_lb
            // 
            this.coordinator_dynamic_lb.AutoSize = true;
            this.coordinator_dynamic_lb.Location = new System.Drawing.Point(458, 64);
            this.coordinator_dynamic_lb.Name = "coordinator_dynamic_lb";
            this.coordinator_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.coordinator_dynamic_lb.Size = new System.Drawing.Size(72, 13);
            this.coordinator_dynamic_lb.TabIndex = 13;
            this.coordinator_dynamic_lb.Text = "<coordinator>";
            // 
            // tochnit_bt
            // 
            this.tochnit_bt.Location = new System.Drawing.Point(250, 45);
            this.tochnit_bt.Name = "tochnit_bt";
            this.tochnit_bt.Size = new System.Drawing.Size(108, 23);
            this.tochnit_bt.TabIndex = 14;
            this.tochnit_bt.Text = "תכנית אישית";
            this.tochnit_bt.UseVisualStyleBackColor = true;
            this.tochnit_bt.Click += new System.EventHandler(this.btn_tochnit_Click);
            // 
            // form_categories_tc
            // 
            this.form_categories_tc.Controls.Add(this.cat_personal_tab);
            this.form_categories_tc.Controls.Add(this.cat_report_tab);
            this.form_categories_tc.Controls.Add(this.cat_meeting_tab);
            this.form_categories_tc.Location = new System.Drawing.Point(259, 101);
            this.form_categories_tc.Name = "form_categories_tc";
            this.form_categories_tc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.form_categories_tc.RightToLeftLayout = true;
            this.form_categories_tc.SelectedIndex = 0;
            this.form_categories_tc.Size = new System.Drawing.Size(392, 139);
            this.form_categories_tc.TabIndex = 15;
            // 
            // cat_personal_tab
            // 
            this.cat_personal_tab.Controls.Add(this.confidentiality_bt);
            this.cat_personal_tab.Controls.Add(this.open_hitkashrut_bt);
            this.cat_personal_tab.Controls.Add(this.info_bt);
            this.cat_personal_tab.Controls.Add(this.tochnit_bt);
            this.cat_personal_tab.Location = new System.Drawing.Point(4, 22);
            this.cat_personal_tab.Name = "cat_personal_tab";
            this.cat_personal_tab.Padding = new System.Windows.Forms.Padding(3);
            this.cat_personal_tab.Size = new System.Drawing.Size(384, 113);
            this.cat_personal_tab.TabIndex = 0;
            this.cat_personal_tab.Text = "פרטים וקליטה";
            this.cat_personal_tab.UseVisualStyleBackColor = true;
            // 
            // confidentiality_bt
            // 
            this.confidentiality_bt.Location = new System.Drawing.Point(122, 45);
            this.confidentiality_bt.Name = "confidentiality_bt";
            this.confidentiality_bt.Size = new System.Drawing.Size(106, 23);
            this.confidentiality_bt.TabIndex = 16;
            this.confidentiality_bt.Text = "ויתור סודיות";
            this.confidentiality_bt.UseVisualStyleBackColor = true;
            this.confidentiality_bt.Click += new System.EventHandler(this.confidentiality_bt_Click);
            // 
            // open_hitkashrut_bt
            // 
            this.open_hitkashrut_bt.Location = new System.Drawing.Point(122, 16);
            this.open_hitkashrut_bt.Name = "open_hitkashrut_bt";
            this.open_hitkashrut_bt.Size = new System.Drawing.Size(106, 23);
            this.open_hitkashrut_bt.TabIndex = 15;
            this.open_hitkashrut_bt.Text = "הסכם התקשרות";
            this.open_hitkashrut_bt.UseVisualStyleBackColor = true;
            this.open_hitkashrut_bt.Click += new System.EventHandler(this.open_hitkashrut_bt_Click);
            // 
            // cat_report_tab
            // 
            this.cat_report_tab.Controls.Add(this.button2);
            this.cat_report_tab.Controls.Add(this.unusual_event_search_bt);
            this.cat_report_tab.Controls.Add(this.show_reports_bt);
            this.cat_report_tab.Controls.Add(this.add_report_bt);
            this.cat_report_tab.Controls.Add(this.button1);
            this.cat_report_tab.Location = new System.Drawing.Point(4, 22);
            this.cat_report_tab.Name = "cat_report_tab";
            this.cat_report_tab.Padding = new System.Windows.Forms.Padding(3);
            this.cat_report_tab.Size = new System.Drawing.Size(384, 113);
            this.cat_report_tab.TabIndex = 1;
            this.cat_report_tab.Text = "דו\"חות והתראות";
            this.cat_report_tab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "הוסף אירוע חריג";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.unusual_event_bt_Click);
            // 
            // unusual_event_search_bt
            // 
            this.unusual_event_search_bt.Location = new System.Drawing.Point(229, 78);
            this.unusual_event_search_bt.Name = "unusual_event_search_bt";
            this.unusual_event_search_bt.Size = new System.Drawing.Size(133, 23);
            this.unusual_event_search_bt.TabIndex = 11;
            this.unusual_event_search_bt.Text = "חפש אירוע חריג";
            this.unusual_event_search_bt.UseVisualStyleBackColor = true;
            this.unusual_event_search_bt.Click += new System.EventHandler(this.unusual_event_serch_bt_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "הצג התראות";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cat_meeting_tab
            // 
            this.cat_meeting_tab.Controls.Add(this.show_meetings_bt);
            this.cat_meeting_tab.Controls.Add(this.cv_generator_bt);
            this.cat_meeting_tab.Controls.Add(this.showPsyCheckUps_btn);
            this.cat_meeting_tab.Controls.Add(this.addPsychiatricCheckUp_btn);
            this.cat_meeting_tab.Controls.Add(this.show_employment_bt);
            this.cat_meeting_tab.Controls.Add(this.add_employment_bt);
            this.cat_meeting_tab.Location = new System.Drawing.Point(4, 22);
            this.cat_meeting_tab.Name = "cat_meeting_tab";
            this.cat_meeting_tab.Size = new System.Drawing.Size(384, 113);
            this.cat_meeting_tab.TabIndex = 2;
            this.cat_meeting_tab.Text = "פגישות ומעקבים";
            this.cat_meeting_tab.UseVisualStyleBackColor = true;
            // 
            // show_meetings_bt
            // 
            this.show_meetings_bt.Location = new System.Drawing.Point(37, 73);
            this.show_meetings_bt.Name = "show_meetings_bt";
            this.show_meetings_bt.Size = new System.Drawing.Size(165, 23);
            this.show_meetings_bt.TabIndex = 11;
            this.show_meetings_bt.Text = "מעקב פגישות אישיות וקשר";
            this.show_meetings_bt.UseVisualStyleBackColor = true;
            // 
            // cv_generator_bt
            // 
            this.cv_generator_bt.Location = new System.Drawing.Point(209, 73);
            this.cv_generator_bt.Name = "cv_generator_bt";
            this.cv_generator_bt.Size = new System.Drawing.Size(165, 23);
            this.cv_generator_bt.TabIndex = 10;
            this.cv_generator_bt.Text = "קורות חיים";
            this.cv_generator_bt.UseVisualStyleBackColor = true;
            this.cv_generator_bt.Click += new System.EventHandler(this.cv_generator_bt_Click);
            // 
            // showPsyCheckUps_btn
            // 
            this.showPsyCheckUps_btn.Location = new System.Drawing.Point(37, 44);
            this.showPsyCheckUps_btn.Name = "showPsyCheckUps_btn";
            this.showPsyCheckUps_btn.Size = new System.Drawing.Size(165, 23);
            this.showPsyCheckUps_btn.TabIndex = 9;
            this.showPsyCheckUps_btn.Text = "הצג מעקבים פסיכיאטריים";
            this.showPsyCheckUps_btn.UseVisualStyleBackColor = true;
            this.showPsyCheckUps_btn.Click += new System.EventHandler(this.showPsyCheckUps_btn_Click);
            // 
            // addPsychiatricCheckUp_btn
            // 
            this.addPsychiatricCheckUp_btn.Location = new System.Drawing.Point(37, 15);
            this.addPsychiatricCheckUp_btn.Name = "addPsychiatricCheckUp_btn";
            this.addPsychiatricCheckUp_btn.Size = new System.Drawing.Size(165, 23);
            this.addPsychiatricCheckUp_btn.TabIndex = 9;
            this.addPsychiatricCheckUp_btn.Text = "צירוף מסמכים";
            this.addPsychiatricCheckUp_btn.UseVisualStyleBackColor = true;
            this.addPsychiatricCheckUp_btn.Click += new System.EventHandler(this.addPsychiatricCheckUp_btn_Click_1);
            // 
            // score_lb
            // 
            this.score_lb.AutoSize = true;
            this.score_lb.Location = new System.Drawing.Point(146, 21);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(79, 13);
            this.score_lb.TabIndex = 16;
            this.score_lb.Text = "דירוג מתמודד";
            // 
            // score_dynamic_lb
            // 
            this.score_dynamic_lb.AutoSize = true;
            this.score_dynamic_lb.Location = new System.Drawing.Point(53, 21);
            this.score_dynamic_lb.Name = "score_dynamic_lb";
            this.score_dynamic_lb.Size = new System.Drawing.Size(45, 13);
            this.score_dynamic_lb.TabIndex = 17;
            this.score_dynamic_lb.Text = "<score>";
            // 
            // keyword_bt
            // 
            this.keyword_bt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.keyword_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keyword_bt.Cursor = System.Windows.Forms.Cursors.Default;
            this.keyword_bt.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.keyword_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyword_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.keyword_bt.Location = new System.Drawing.Point(501, 263);
            this.keyword_bt.Name = "keyword_bt";
            this.keyword_bt.Size = new System.Drawing.Size(146, 23);
            this.keyword_bt.TabIndex = 18;
            this.keyword_bt.Text = "סריקה עבור מילות מפתח";
            this.keyword_bt.UseVisualStyleBackColor = false;
            // 
            // profile_pb
            // 
            this.profile_pb.Image = global::GvanimVS.Properties.Resources.anonymous_profile;
            this.profile_pb.Location = new System.Drawing.Point(53, 68);
            this.profile_pb.Name = "profile_pb";
            this.profile_pb.Size = new System.Drawing.Size(172, 172);
            this.profile_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_pb.TabIndex = 5;
            this.profile_pb.TabStop = false;
            // 
            // Mitmoded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 358);
            this.Controls.Add(this.keyword_bt);
            this.Controls.Add(this.score_dynamic_lb);
            this.Controls.Add(this.score_lb);
            this.Controls.Add(this.form_categories_tc);
            this.Controls.Add(this.coordinator_dynamic_lb);
            this.Controls.Add(this.coordinator_name_lb);
            this.Controls.Add(this.change_coordinator_bt);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.profile_pb);
            this.Controls.Add(this.ID_dynamic_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.name_dynamic_lb);
            this.Controls.Add(this.name_lb);
            this.Name = "Mitmoded";
            this.Text = "Mitmoded";
            this.form_categories_tc.ResumeLayout(false);
            this.cat_personal_tab.ResumeLayout(false);
            this.cat_report_tab.ResumeLayout(false);
            this.cat_meeting_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label name_dynamic_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label ID_dynamic_lb;
        private System.Windows.Forms.Button info_bt;
        private System.Windows.Forms.PictureBox profile_pb;
        private System.Windows.Forms.Button show_employment_bt;
        private System.Windows.Forms.Button show_reports_bt;
        private System.Windows.Forms.Button add_employment_bt;
        private System.Windows.Forms.Button add_report_bt;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button change_coordinator_bt;
        private System.Windows.Forms.Label coordinator_name_lb;
        private System.Windows.Forms.Label coordinator_dynamic_lb;
        private System.Windows.Forms.Button tochnit_bt;
        private System.Windows.Forms.TabControl form_categories_tc;
        private System.Windows.Forms.TabPage cat_personal_tab;
        private System.Windows.Forms.TabPage cat_report_tab;
        private System.Windows.Forms.TabPage cat_meeting_tab;
        private System.Windows.Forms.Button open_hitkashrut_bt;
        private System.Windows.Forms.Button confidentiality_bt;
        private System.Windows.Forms.Button addPsychiatricCheckUp_btn;
        private System.Windows.Forms.Button cv_generator_bt;
        private System.Windows.Forms.Button showPsyCheckUps_btn;
        private System.Windows.Forms.Button show_meetings_bt;
        private System.Windows.Forms.Label score_lb;
        private System.Windows.Forms.Label score_dynamic_lb;
        private System.Windows.Forms.Button keyword_bt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button unusual_event_search_bt;
        private System.Windows.Forms.Button button2;
    }
}