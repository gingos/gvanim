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
    public partial class MeetingAdd : DBform
    {
        public string coordinatorID, mitmodedID, meetingID,address, city, topics, tasks;
        public DateTime date;
        public MeetingAdd(string coordinatorID, SqlConnection con):base(con)
        {
            InitializeComponent();
            mitmoded_cb.DataSource = getMitmodedNames();
            this.coordinatorID = coordinatorID;
        }

        /// <summary>
        /// Initialize combox with all mitmoded details
        /// </summary>
        /// <returns>A list of all names and IDs</returns>
        private object getMitmodedNames()
        {
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.MITMODED, "firstName, lastName, ID", cmd, da);
            List<string> names = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                names.Add(dr["firstName"].ToString() + " " + dr["lastName"].ToString() + " - " + dr["ID"].ToString());
            }
            return names;
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMeeting_bt_Click(object sender, EventArgs e)
        {
            date = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day,
                timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);
            if (isValid()){
                //address = address_tb.Text;
                //city = city_tb.Text;
                //topics = topics_tb.Text;
                //tasks = tasks_tb.Text;
                meetingID = String.Concat(date.Day,date.Month,date.Year) + "-" + mitmodedID;

                if (SQLmethods.upsertMeeting (coordinatorID, meetingID, mitmodedID, date, address_tb.Text, occured_ck.Checked ? 1 : 0, city_tb.Text, topics_tb.Text, tasks_tb.Text, cmd))
                {
                    MessageBox.Show("המידע נשמר בהצלחה");
                }
                else
                {
                    MessageBox.Show("אירעה שגיאה בעת שמירת הנתונים");
                }
                this.Close();
            }

        }

        private bool isValid()
        {
            if (!datePicker.Checked)
            {
                MessageBox.Show("נא לאשר את תאריך הפגישה");
                return false;
            }
            if (!timePicker.Checked)
            {
                MessageBox.Show("נא לאשר את שעת הפגישה");
                return false;
            }
            return true;
        }

        private void mitmoded_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            mitmodedID = Tools.getID(mitmoded_cb.SelectedItem.ToString());
            
        }
    }
}
