namespace GvanimVS
{
    partial class Unusual_event
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.howMuch_tb = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.hospital_tb = new System.Windows.Forms.TextBox();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.close_bt = new System.Windows.Forms.Button();
            this.save_bt = new System.Windows.Forms.Button();
            this.place_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTextBox,
            this.Phone,
            this.Details});
            this.dataGridView1.Location = new System.Drawing.Point(73, 617);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(839, 163);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.Visible = false;
            // 
            // dgvTextBox
            // 
            this.dgvTextBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTextBox.FillWeight = 20F;
            this.dgvTextBox.HeaderText = "שם";
            this.dgvTextBox.Name = "dgvTextBox";
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.FillWeight = 20F;
            this.Phone.HeaderText = "טלפון";
            this.Phone.Name = "Phone";
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Details.FillWeight = 60F;
            this.Details.HeaderText = "פרטים נוספים";
            this.Details.Name = "Details";
            // 
            // howMuch_tb
            // 
            this.howMuch_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.howMuch_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.howMuch_tb.Location = new System.Drawing.Point(336, 574);
            this.howMuch_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.howMuch_tb.Name = "howMuch_tb";
            this.howMuch_tb.Size = new System.Drawing.Size(132, 18);
            this.howMuch_tb.TabIndex = 12;
            this.howMuch_tb.Text = "_________________________________________________";
            this.howMuch_tb.Click += new System.EventHandler(this.howMuch_tb_Click);
            this.howMuch_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(287, 321);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox3.Size = new System.Drawing.Size(40, 24);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "כן";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(621, 321);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox2.Size = new System.Drawing.Size(40, 24);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "כן";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(635, 272);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(40, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "כן";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(77, 383);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(711, 156);
            this.textBox4.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(689, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "?האם האשפוז היה על רקע נפשי";
            this.label7.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 572);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "?אם כן, כמה";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 323);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "?אם כן, האם הוא היה כפוי";
            this.label8.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "?אם כן, באיזה בית חולים";
            this.label6.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AllowDrop = true;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 5;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "תאונה",
            "פגיעה פיזית",
            "נסיון אובדני",
            "פטירה",
            "אלימות",
            "איום באלימות פיזית",
            "אלימות מילולית",
            "התנהלות  פוגענית של איש צוות",
            "אחזקת חפציים מסוכנים",
            "פגיעה ברכוש",
            "גניבה",
            "הצתה",
            "שימוש בחומרים אסורים",
            "התנהגות מינית לא הולמת",
            "פגיעה מינית",
            "אירוע אונס",
            "היעדרות",
            "עזיבת מסגרת ללא תיאום",
            "טעות בניהול טיפול תרופתי",
            "כוויה חמורה",
            "תחלואה במחלה מדבקת",
            "הרעלת מזון"});
            this.checkedListBox1.Location = new System.Drawing.Point(580, 187);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(228, 44);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // hospital_tb
            // 
            this.hospital_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hospital_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.hospital_tb.Location = new System.Drawing.Point(62, 274);
            this.hospital_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hospital_tb.Name = "hospital_tb";
            this.hospital_tb.Size = new System.Drawing.Size(265, 18);
            this.hospital_tb.TabIndex = 2;
            this.hospital_tb.Text = "_________________________________________________";
            this.hospital_tb.Visible = false;
            // 
            // address_tb
            // 
            this.address_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.address_tb.Location = new System.Drawing.Point(62, 135);
            this.address_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(265, 18);
            this.address_tb.TabIndex = 2;
            this.address_tb.Text = "_________________________________________________";
            this.address_tb.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "כתובת";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(737, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "?האם האירוע כלל אשפוז";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(762, 572);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "?האם היו עדים לאירוע";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(817, 383);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "תיאור האירוע";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(832, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "סוג אירוע";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(813, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "מקום האירוע";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "מועד האירוע";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(561, 68);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(648, 810);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "?האם היו סימנים מקדימים לאירוע";
            this.label12.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(73, 852);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(837, 70);
            this.textBox5.TabIndex = 6;
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(77, 953);
            this.close_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(100, 35);
            this.close_bt.TabIndex = 14;
            this.close_bt.Text = "סגור";
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Click += new System.EventHandler(this.button1_Click);
            this.close_bt.MouseLeave += new System.EventHandler(this.close_bt_MouseLeave);
            this.close_bt.MouseHover += new System.EventHandler(this.close_bt_MouseHover);
            // 
            // save_bt
            // 
            this.save_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.save_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_bt.ForeColor = System.Drawing.Color.White;
            this.save_bt.Location = new System.Drawing.Point(218, 953);
            this.save_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(100, 35);
            this.save_bt.TabIndex = 14;
            this.save_bt.Text = "שמור";
            this.save_bt.UseVisualStyleBackColor = false;
            this.save_bt.Click += new System.EventHandler(this.button2_Click);
            this.save_bt.MouseLeave += new System.EventHandler(this.save_bt_MouseLeave);
            this.save_bt.MouseHover += new System.EventHandler(this.save_bt_MouseHover);
            // 
            // place_tb
            // 
            this.place_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.place_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.place_tb.Location = new System.Drawing.Point(493, 135);
            this.place_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.place_tb.Name = "place_tb";
            this.place_tb.Size = new System.Drawing.Size(265, 18);
            this.place_tb.TabIndex = 2;
            this.place_tb.Text = "_________________________________________________";
            this.place_tb.Click += new System.EventHandler(this.textBox6_Click);
            // 
            // Unusual_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 733);
            this.Controls.Add(this.save_bt);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.howMuch_tb);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.hospital_tb);
            this.Controls.Add(this.place_tb);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Unusual_event";
            this.Text = "טופס אירוע חריג";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hospital_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox howMuch_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button save_bt;
        private System.Windows.Forms.TextBox place_tb;
    }
}