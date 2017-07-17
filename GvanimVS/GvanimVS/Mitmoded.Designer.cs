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
            this.name_lb.Location = new System.Drawing.Point(813, 49);
            this.name_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(37, 20);
            this.name_lb.TabIndex = 0;
            this.name_lb.Text = "שם: ";
            // 
            // name_dynamic_lb
            // 
            this.name_dynamic_lb.AutoSize = true;
            this.name_dynamic_lb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name_dynamic_lb.Location = new System.Drawing.Point(624, 49);
            this.name_dynamic_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_dynamic_lb.Name = "name_dynamic_lb";
            this.name_dynamic_lb.Size = new System.Drawing.Size(67, 20);
            this.name_dynamic_lb.TabIndex = 1;
            this.name_dynamic_lb.Text = "<name>";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(447, 49);
            this.ID_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lb.Size = new System.Drawing.Size(91, 20);
            this.ID_lb.TabIndex = 2;
            this.ID_lb.Text = "תעודת זהות:";
            // 
            // ID_dynamic_lb
            // 
            this.ID_dynamic_lb.AutoSize = true;
            this.ID_dynamic_lb.Location = new System.Drawing.Point(341, 48);
            this.ID_dynamic_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_dynamic_lb.Name = "ID_dynamic_lb";
            this.ID_dynamic_lb.Size = new System.Drawing.Size(44, 20);
            this.ID_dynamic_lb.TabIndex = 3;
            this.ID_dynamic_lb.Text = "<ID>";
            // 
            // info_bt
            // 
            this.info_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.info_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info_bt.ForeColor = System.Drawing.Color.White;
            this.info_bt.Location = new System.Drawing.Point(279, 25);
            this.info_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.info_bt.Name = "info_bt";
            this.info_bt.Size = new System.Drawing.Size(198, 35);
            this.info_bt.TabIndex = 4;
            this.info_bt.Text = "אינטק מועמד";
            this.info_bt.UseVisualStyleBackColor = false;
            this.info_bt.Click += new System.EventHandler(this.info_bt_Click);
            this.info_bt.MouseLeave += new System.EventHandler(this.info_bt_MouseLeave);
            this.info_bt.MouseHover += new System.EventHandler(this.info_bt_MouseHover);
            // 
            // show_employment_bt
            // 
            this.show_employment_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.show_employment_bt.Enabled = false;
            this.show_employment_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_employment_bt.ForeColor = System.Drawing.Color.White;
            this.show_employment_bt.Location = new System.Drawing.Point(277, 23);
            this.show_employment_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.show_employment_bt.Name = "show_employment_bt";
            this.show_employment_bt.Size = new System.Drawing.Size(221, 35);
            this.show_employment_bt.TabIndex = 6;
            this.show_employment_bt.Text = "הצג פריטי תעסוקה";
            this.show_employment_bt.UseVisualStyleBackColor = false;
            this.show_employment_bt.Click += new System.EventHandler(this.employment_bt_Click);
            this.show_employment_bt.MouseLeave += new System.EventHandler(this.show_employment_bt_MouseLeave);
            this.show_employment_bt.MouseHover += new System.EventHandler(this.show_employment_bt_MouseHover);
            // 
            // show_reports_bt
            // 
            this.show_reports_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.show_reports_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_reports_bt.ForeColor = System.Drawing.Color.White;
            this.show_reports_bt.Location = new System.Drawing.Point(50, 31);
            this.show_reports_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.show_reports_bt.Name = "show_reports_bt";
            this.show_reports_bt.Size = new System.Drawing.Size(221, 35);
            this.show_reports_bt.TabIndex = 7;
            this.show_reports_bt.Text = "הצג דוחות";
            this.show_reports_bt.UseVisualStyleBackColor = false;
            this.show_reports_bt.Click += new System.EventHandler(this.show_reports_bt_Click);
            this.show_reports_bt.MouseLeave += new System.EventHandler(this.show_reports_bt_MouseLeave);
            this.show_reports_bt.MouseHover += new System.EventHandler(this.show_reports_bt_MouseHover);
            // 
            // add_employment_bt
            // 
            this.add_employment_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.add_employment_bt.Enabled = false;
            this.add_employment_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_employment_bt.ForeColor = System.Drawing.Color.White;
            this.add_employment_bt.Location = new System.Drawing.Point(277, 68);
            this.add_employment_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_employment_bt.Name = "add_employment_bt";
            this.add_employment_bt.Size = new System.Drawing.Size(220, 35);
            this.add_employment_bt.TabIndex = 8;
            this.add_employment_bt.Text = "הוסף פריט תעסוקה";
            this.add_employment_bt.UseVisualStyleBackColor = false;
            this.add_employment_bt.MouseLeave += new System.EventHandler(this.add_employment_bt_MouseLeave);
            this.add_employment_bt.MouseHover += new System.EventHandler(this.add_employment_bt_MouseHover);
            // 
            // add_report_bt
            // 
            this.add_report_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.add_report_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_report_bt.ForeColor = System.Drawing.Color.White;
            this.add_report_bt.Location = new System.Drawing.Point(50, 75);
            this.add_report_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_report_bt.Name = "add_report_bt";
            this.add_report_bt.Size = new System.Drawing.Size(221, 35);
            this.add_report_bt.TabIndex = 9;
            this.add_report_bt.Text = "הוסף דוח";
            this.add_report_bt.UseVisualStyleBackColor = false;
            this.add_report_bt.Click += new System.EventHandler(this.add_report_bt_Click);
            this.add_report_bt.MouseLeave += new System.EventHandler(this.add_report_bt_MouseLeave);
            this.add_report_bt.MouseHover += new System.EventHandler(this.add_report_bt_MouseHover);
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(75, 405);
            this.close_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(100, 35);
            this.close_bt.TabIndex = 10;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            this.close_bt.MouseLeave += new System.EventHandler(this.close_bt_MouseLeave);
            this.close_bt.MouseHover += new System.EventHandler(this.close_bt_MouseHover);
            // 
            // change_coordinator_bt
            // 
            this.change_coordinator_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.change_coordinator_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_coordinator_bt.ForeColor = System.Drawing.Color.White;
            this.change_coordinator_bt.Location = new System.Drawing.Point(345, 91);
            this.change_coordinator_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.change_coordinator_bt.Name = "change_coordinator_bt";
            this.change_coordinator_bt.Size = new System.Drawing.Size(100, 35);
            this.change_coordinator_bt.TabIndex = 11;
            this.change_coordinator_bt.Text = "שינוי רכזת";
            this.change_coordinator_bt.UseVisualStyleBackColor = false;
            this.change_coordinator_bt.Click += new System.EventHandler(this.change_coordinator_bt_Click);
            this.change_coordinator_bt.MouseLeave += new System.EventHandler(this.change_coordinator_bt_MouseLeave);
            this.change_coordinator_bt.MouseHover += new System.EventHandler(this.change_coordinator_bt_MouseHover);
            // 
            // coordinator_name_lb
            // 
            this.coordinator_name_lb.AutoSize = true;
            this.coordinator_name_lb.Location = new System.Drawing.Point(805, 98);
            this.coordinator_name_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coordinator_name_lb.Name = "coordinator_name_lb";
            this.coordinator_name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.coordinator_name_lb.Size = new System.Drawing.Size(46, 20);
            this.coordinator_name_lb.TabIndex = 12;
            this.coordinator_name_lb.Text = "רכזת:";
            // 
            // coordinator_dynamic_lb
            // 
            this.coordinator_dynamic_lb.AutoSize = true;
            this.coordinator_dynamic_lb.Location = new System.Drawing.Point(611, 98);
            this.coordinator_dynamic_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coordinator_dynamic_lb.Name = "coordinator_dynamic_lb";
            this.coordinator_dynamic_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.coordinator_dynamic_lb.Size = new System.Drawing.Size(107, 20);
            this.coordinator_dynamic_lb.TabIndex = 13;
            this.coordinator_dynamic_lb.Text = "<coordinator>";
            // 
            // tochnit_bt
            // 
            this.tochnit_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tochnit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tochnit_bt.ForeColor = System.Drawing.Color.White;
            this.tochnit_bt.Location = new System.Drawing.Point(279, 69);
            this.tochnit_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tochnit_bt.Name = "tochnit_bt";
            this.tochnit_bt.Size = new System.Drawing.Size(198, 35);
            this.tochnit_bt.TabIndex = 14;
            this.tochnit_bt.Text = "תכנית אישית";
            this.tochnit_bt.UseVisualStyleBackColor = false;
            this.tochnit_bt.Click += new System.EventHandler(this.btn_tochnit_Click);
            this.tochnit_bt.MouseLeave += new System.EventHandler(this.tochnit_bt_MouseLeave);
            this.tochnit_bt.MouseHover += new System.EventHandler(this.tochnit_bt_MouseHover);
            // 
            // form_categories_tc
            // 
            this.form_categories_tc.Controls.Add(this.cat_personal_tab);
            this.form_categories_tc.Controls.Add(this.cat_report_tab);
            this.form_categories_tc.Controls.Add(this.cat_meeting_tab);
            this.form_categories_tc.Location = new System.Drawing.Point(345, 155);
            this.form_categories_tc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.form_categories_tc.Name = "form_categories_tc";
            this.form_categories_tc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.form_categories_tc.RightToLeftLayout = true;
            this.form_categories_tc.SelectedIndex = 0;
            this.form_categories_tc.Size = new System.Drawing.Size(523, 214);
            this.form_categories_tc.TabIndex = 15;
            // 
            // cat_personal_tab
            // 
            this.cat_personal_tab.Controls.Add(this.confidentiality_bt);
            this.cat_personal_tab.Controls.Add(this.open_hitkashrut_bt);
            this.cat_personal_tab.Controls.Add(this.info_bt);
            this.cat_personal_tab.Controls.Add(this.tochnit_bt);
            this.cat_personal_tab.Location = new System.Drawing.Point(4, 29);
            this.cat_personal_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cat_personal_tab.Name = "cat_personal_tab";
            this.cat_personal_tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cat_personal_tab.Size = new System.Drawing.Size(515, 181);
            this.cat_personal_tab.TabIndex = 0;
            this.cat_personal_tab.Text = "פרטים וקליטה";
            this.cat_personal_tab.UseVisualStyleBackColor = true;
            // 
            // confidentiality_bt
            // 
            this.confidentiality_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.confidentiality_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confidentiality_bt.ForeColor = System.Drawing.Color.White;
            this.confidentiality_bt.Location = new System.Drawing.Point(83, 69);
            this.confidentiality_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confidentiality_bt.Name = "confidentiality_bt";
            this.confidentiality_bt.Size = new System.Drawing.Size(188, 35);
            this.confidentiality_bt.TabIndex = 16;
            this.confidentiality_bt.Text = "ויתור סודיות";
            this.confidentiality_bt.UseVisualStyleBackColor = false;
            this.confidentiality_bt.Click += new System.EventHandler(this.confidentiality_bt_Click);
            this.confidentiality_bt.MouseLeave += new System.EventHandler(this.confidentiality_bt_MouseLeave);
            this.confidentiality_bt.MouseHover += new System.EventHandler(this.confidentiality_bt_MouseHover);
            // 
            // open_hitkashrut_bt
            // 
            this.open_hitkashrut_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.open_hitkashrut_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_hitkashrut_bt.ForeColor = System.Drawing.Color.White;
            this.open_hitkashrut_bt.Location = new System.Drawing.Point(83, 25);
            this.open_hitkashrut_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.open_hitkashrut_bt.Name = "open_hitkashrut_bt";
            this.open_hitkashrut_bt.Size = new System.Drawing.Size(188, 35);
            this.open_hitkashrut_bt.TabIndex = 15;
            this.open_hitkashrut_bt.Text = "הסכם התקשרות";
            this.open_hitkashrut_bt.UseVisualStyleBackColor = false;
            this.open_hitkashrut_bt.Click += new System.EventHandler(this.open_hitkashrut_bt_Click);
            this.open_hitkashrut_bt.MouseLeave += new System.EventHandler(this.open_hitkashrut_bt_MouseLeave);
            this.open_hitkashrut_bt.MouseHover += new System.EventHandler(this.open_hitkashrut_bt_MouseHover);
            // 
            // cat_report_tab
            // 
            this.cat_report_tab.Controls.Add(this.button2);
            this.cat_report_tab.Controls.Add(this.unusual_event_search_bt);
            this.cat_report_tab.Controls.Add(this.show_reports_bt);
            this.cat_report_tab.Controls.Add(this.add_report_bt);
            this.cat_report_tab.Controls.Add(this.button1);
            this.cat_report_tab.Location = new System.Drawing.Point(4, 29);
            this.cat_report_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cat_report_tab.Name = "cat_report_tab";
            this.cat_report_tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cat_report_tab.Size = new System.Drawing.Size(515, 181);
            this.cat_report_tab.TabIndex = 1;
            this.cat_report_tab.Text = "דו\"חות והתראות";
            this.cat_report_tab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(279, 75);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "הוסף אירוע חריג";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.unusual_event_bt_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // unusual_event_search_bt
            // 
            this.unusual_event_search_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.unusual_event_search_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unusual_event_search_bt.ForeColor = System.Drawing.Color.White;
            this.unusual_event_search_bt.Location = new System.Drawing.Point(279, 120);
            this.unusual_event_search_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unusual_event_search_bt.Name = "unusual_event_search_bt";
            this.unusual_event_search_bt.Size = new System.Drawing.Size(203, 35);
            this.unusual_event_search_bt.TabIndex = 11;
            this.unusual_event_search_bt.Text = "חפש אירוע חריג";
            this.unusual_event_search_bt.UseVisualStyleBackColor = false;
            this.unusual_event_search_bt.Click += new System.EventHandler(this.unusual_event_serch_bt_click);
            this.unusual_event_search_bt.MouseLeave += new System.EventHandler(this.unusual_event_search_bt_MouseLeave);
            this.unusual_event_search_bt.MouseHover += new System.EventHandler(this.unusual_event_search_bt_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(279, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "הצג התראות";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // cat_meeting_tab
            // 
            this.cat_meeting_tab.Controls.Add(this.show_meetings_bt);
            this.cat_meeting_tab.Controls.Add(this.cv_generator_bt);
            this.cat_meeting_tab.Controls.Add(this.showPsyCheckUps_btn);
            this.cat_meeting_tab.Controls.Add(this.addPsychiatricCheckUp_btn);
            this.cat_meeting_tab.Controls.Add(this.show_employment_bt);
            this.cat_meeting_tab.Controls.Add(this.add_employment_bt);
            this.cat_meeting_tab.Location = new System.Drawing.Point(4, 29);
            this.cat_meeting_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cat_meeting_tab.Name = "cat_meeting_tab";
            this.cat_meeting_tab.Size = new System.Drawing.Size(515, 181);
            this.cat_meeting_tab.TabIndex = 2;
            this.cat_meeting_tab.Text = "פגישות ומעקבים";
            this.cat_meeting_tab.UseVisualStyleBackColor = true;
            // 
            // show_meetings_bt
            // 
            this.show_meetings_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.show_meetings_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_meetings_bt.ForeColor = System.Drawing.Color.White;
            this.show_meetings_bt.Location = new System.Drawing.Point(49, 112);
            this.show_meetings_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.show_meetings_bt.Name = "show_meetings_bt";
            this.show_meetings_bt.Size = new System.Drawing.Size(220, 35);
            this.show_meetings_bt.TabIndex = 11;
            this.show_meetings_bt.Text = "מעקב פגישות אישיות וקשר";
            this.show_meetings_bt.UseVisualStyleBackColor = false;
            this.show_meetings_bt.Click += new System.EventHandler(this.show_meetings_bt_Click);
            this.show_meetings_bt.MouseLeave += new System.EventHandler(this.show_meetings_bt_MouseLeave);
            this.show_meetings_bt.MouseHover += new System.EventHandler(this.show_meetings_bt_MouseHover);
            // 
            // cv_generator_bt
            // 
            this.cv_generator_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cv_generator_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cv_generator_bt.ForeColor = System.Drawing.Color.White;
            this.cv_generator_bt.Location = new System.Drawing.Point(279, 112);
            this.cv_generator_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cv_generator_bt.Name = "cv_generator_bt";
            this.cv_generator_bt.Size = new System.Drawing.Size(220, 35);
            this.cv_generator_bt.TabIndex = 10;
            this.cv_generator_bt.Text = "קורות חיים";
            this.cv_generator_bt.UseVisualStyleBackColor = false;
            this.cv_generator_bt.Click += new System.EventHandler(this.cv_generator_bt_Click);
            this.cv_generator_bt.MouseLeave += new System.EventHandler(this.cv_generator_bt_MouseLeave);
            this.cv_generator_bt.MouseHover += new System.EventHandler(this.cv_generator_bt_MouseHover);
            // 
            // showPsyCheckUps_btn
            // 
            this.showPsyCheckUps_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.showPsyCheckUps_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPsyCheckUps_btn.ForeColor = System.Drawing.Color.White;
            this.showPsyCheckUps_btn.Location = new System.Drawing.Point(49, 68);
            this.showPsyCheckUps_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showPsyCheckUps_btn.Name = "showPsyCheckUps_btn";
            this.showPsyCheckUps_btn.Size = new System.Drawing.Size(220, 35);
            this.showPsyCheckUps_btn.TabIndex = 9;
            this.showPsyCheckUps_btn.Text = "הצג מעקבים פסיכיאטריים";
            this.showPsyCheckUps_btn.UseVisualStyleBackColor = false;
            this.showPsyCheckUps_btn.Click += new System.EventHandler(this.showPsyCheckUps_btn_Click);
            this.showPsyCheckUps_btn.MouseLeave += new System.EventHandler(this.showPsyCheckUps_btn_MouseLeave);
            this.showPsyCheckUps_btn.MouseHover += new System.EventHandler(this.showPsyCheckUps_btn_MouseHover);
            // 
            // addPsychiatricCheckUp_btn
            // 
            this.addPsychiatricCheckUp_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addPsychiatricCheckUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPsychiatricCheckUp_btn.ForeColor = System.Drawing.Color.White;
            this.addPsychiatricCheckUp_btn.Location = new System.Drawing.Point(49, 23);
            this.addPsychiatricCheckUp_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPsychiatricCheckUp_btn.Name = "addPsychiatricCheckUp_btn";
            this.addPsychiatricCheckUp_btn.Size = new System.Drawing.Size(220, 35);
            this.addPsychiatricCheckUp_btn.TabIndex = 9;
            this.addPsychiatricCheckUp_btn.Text = "צירוף מסמכים";
            this.addPsychiatricCheckUp_btn.UseVisualStyleBackColor = false;
            this.addPsychiatricCheckUp_btn.Click += new System.EventHandler(this.addPsychiatricCheckUp_btn_Click_1);
            this.addPsychiatricCheckUp_btn.MouseLeave += new System.EventHandler(this.addPsychiatricCheckUp_btn_MouseLeave);
            this.addPsychiatricCheckUp_btn.MouseHover += new System.EventHandler(this.addPsychiatricCheckUp_btn_MouseHover);
            // 
            // score_lb
            // 
            this.score_lb.AutoSize = true;
            this.score_lb.Location = new System.Drawing.Point(195, 32);
            this.score_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(101, 20);
            this.score_lb.TabIndex = 16;
            this.score_lb.Text = "דירוג מתמודד";
            // 
            // score_dynamic_lb
            // 
            this.score_dynamic_lb.AutoSize = true;
            this.score_dynamic_lb.Location = new System.Drawing.Point(71, 32);
            this.score_dynamic_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score_dynamic_lb.Name = "score_dynamic_lb";
            this.score_dynamic_lb.Size = new System.Drawing.Size(66, 20);
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
            this.keyword_bt.Location = new System.Drawing.Point(668, 405);
            this.keyword_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.keyword_bt.Name = "keyword_bt";
            this.keyword_bt.Size = new System.Drawing.Size(195, 35);
            this.keyword_bt.TabIndex = 18;
            this.keyword_bt.Text = "סריקה עבור מילות מפתח";
            this.keyword_bt.UseVisualStyleBackColor = false;
            this.keyword_bt.Click += new System.EventHandler(this.keyword_bt_Click);
            // 
            // profile_pb
            // 
            this.profile_pb.Image = global::GvanimVS.Properties.Resources.anonymous_profile;
            this.profile_pb.Location = new System.Drawing.Point(71, 105);
            this.profile_pb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profile_pb.Name = "profile_pb";
            this.profile_pb.Size = new System.Drawing.Size(229, 265);
            this.profile_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_pb.TabIndex = 5;
            this.profile_pb.TabStop = false;
            // 
            // Mitmoded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 551);
            this.ControlBox = false;
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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