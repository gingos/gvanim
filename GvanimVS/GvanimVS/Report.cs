using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GvanimVS
{
    public partial class Report : DBform
    {
        string mitmodedID, coordinatorID;
        public Report(SqlConnection con, string coordinatorID):base(con)
        {
            InitializeComponent();
            this.coordinatorID = coordinatorID;
            this.Text = "Report by UserID " + coordinatorID;
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.MITMODED, "*", "coordinatorID", coordinatorID, cmd, da);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["firstName"].ToString() + " " + dr["lastName"].ToString()
                    +", תעודת זהות: " + dr["ID"]);
            }
            DateTime nowTime = DateTime.Now;
            ReportSerialNum_lb.Text = String.Format("{0:yy-dd-MM}", nowTime);

        }
        
        
        public Report(SqlConnection con, string coordinatorID, string mitmodedID):base(con)
        {
            InitializeComponent();
            this.mitmodedID = mitmodedID;
            ID_lb.Text = mitmodedID;
            this.coordinatorID = coordinatorID;
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.MITMODED, "*", "ID", mitmodedID, cmd, da);
            comboBox1.Items.Clear();
            comboBox1.Items.Add(dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString()
                + ", תעודת זהות: " + dt.Rows[0]["ID"].ToString());
            comboBox1.SelectedIndex = 0;
            DateTime nowTime = DateTime.Now;
            ReportSerialNum_lb.Text = String.Format("{0:yy-dd-MM}", nowTime);


        }

        private void Report_Load(object sender, EventArgs e)
        {
            
        }

        private void saveReport_bt_Click(object sender, EventArgs e)
        {
            if (verifyFields())
            {
                if (SQLmethods.upsertReport(ReportSerialNum_lb.Text +"-"+ ID_lb.Text,
                    mitmodedID, dateTimePicker1.Value.Date, reportDiscription_tb.Text,
                    activityDiscription_tb.Text, coordinatorID, cmd))
                    MessageBox.Show("הדוח נשמר בהצלחה");
                else
                    MessageBox.Show("אירעה שגיאה בעת רישום הדוח");
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            mitmodedID = Tools.getID(comboBox1.SelectedItem.ToString());
            ID_lb.Text = mitmodedID;
            ReportSerialNum_lb.Refresh();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private bool verifyFields()
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("יש לבחור מתמודד");
                comboBox1.Focus();
                return false;
            }
            if (!dateTimePicker1.Checked)
            {
                MessageBox.Show("יש לבחור תאריך לדוח");
                dateTimePicker1.Focus();
                return false;
            }
            if (reportDiscription_tb.Text.Equals("") && activityDiscription_tb.Text.Equals(""))
            {
                MessageBox.Show("אנא מלאו לפחות תיבת טקסט אחת");
                reportDiscription_tb.Focus();
                return false;
            }
            if (reportDiscription_tb.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("לא נרשם תיאור. האם ברצונך להמשיך?", "תיאור דוח", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //continue
                }
                else if (dialogResult == DialogResult.No)
                {
                    reportDiscription_tb.Focus();
                    return false;
                }
            }
            if (activityDiscription_tb.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("לא תוארו פעולות שננקטו. האם ברצונך להמשיך?", "תיאור פעולות", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //continue
                }
                else if (dialogResult == DialogResult.No)
                {
                    activityDiscription_tb.Focus();
                    return false;
                }
            }
            return true;
        }
        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
