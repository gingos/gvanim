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
        string mitmodedID, coordinatorID, mitmodedFirst, mitmodedLast;
        public Report(SqlConnection con, string coordinatorID):base(con)
        {
            InitializeComponent();
            this.coordinatorID = coordinatorID;
            initFields("from coordinator");
        }
        public Report(SqlConnection con, string coordinatorID, string mitmodedID):base(con)
        {
            InitializeComponent();
            this.mitmodedID = mitmodedID; 
            this.coordinatorID = coordinatorID;
            initFields("from mitmoded");
            
        }
        private void initFields(string caller)
        {
            this.Text = "Report by UserID " + coordinatorID;
            comboBox1.Items.Clear();
            DateTime nowTime = DateTime.Now;
            ReportSerialNum_lb.Text = String.Format("{0:yy-dd-MM}", nowTime);
            if (caller.Equals("from coordinator"))
            {
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.MITMODED, "*", "coordinatorID", coordinatorID, cmd, da);
            if (dt == null)
                return;
            foreach (DataRow dr in dt.Rows)
            {
                    comboBox1.Items.Add(dr["firstName"].ToString() + " " + dr["lastName"].ToString() + " " + dr["ID"]);
            }
        }
            else if (caller.Equals("from mitmoded"))
        {
            ID_lb.Text = mitmodedID;
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.MITMODED, "*", "ID", mitmodedID, cmd, da);
            if (dt == null)
                return;
            mitmodedFirst = dt.Rows[0]["firstName"].ToString();
            mitmodedLast = dt.Rows[0]["lastName"].ToString();
            comboBox1.Items.Add(mitmodedFirst + " " + mitmodedLast + " " + mitmodedID);
            comboBox1.SelectedIndex = 0;
            }
        }
        private void Report_Load(object sender, EventArgs e)
        {
            
        }
        private void saveReport_bt_Click(object sender, EventArgs e)
        {
            if (verifyFields())
            {
                if (SQLmethods.upsertReport(ReportSerialNum_lb.Text +"-"+ ID_lb.Text,
                    mitmodedID, mitmodedFirst, mitmodedLast, dateTimePicker1.Value.Date, reportDiscription_tb.Text,
                    activityDiscription_tb.Text, coordinatorID, cmd))
                    MessageBox.Show("הדוח נשמר בהצלחה");
                else
                    MessageBox.Show("אירעה שגיאה בעת רישום הדוח");
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            string[] parsedName = comboBox1.SelectedItem.ToString().Split(' ');
            mitmodedFirst = parsedName[0];
            mitmodedLast = parsedName[1];
            mitmodedID = parsedName[2];
            ID_lb.Text = mitmodedID;
            ReportSerialNum_lb.Refresh();
        }

        private void saveReport_bt_MouseHover(object sender, EventArgs e)
        {
            saveReport_bt.BackColor = Color.RoyalBlue;
        }

        private void saveReport_bt_MouseLeave(object sender, EventArgs e)
        {
            saveReport_bt.BackColor = Color.CornflowerBlue;
        }

        private void cancel_bt_MouseHover(object sender, EventArgs e)
        {
            cancel_bt.BackColor = Color.RoyalBlue;
        }

        private void cancel_bt_MouseLeave(object sender, EventArgs e)
        {
            cancel_bt.BackColor = Color.CornflowerBlue;
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
