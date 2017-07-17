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

        // Style Attributes
        private void add_meeting_bt_MouseHover(object sender, EventArgs e)
        {
            add_meeting_bt.BackColor = Color.RoyalBlue;
        }
        private void add_meeting_bt_MouseLeave(object sender, EventArgs e)
        {
            add_meeting_bt.BackColor = Color.CornflowerBlue;
        }
        private void close_bt_MouseHover(object sender, EventArgs e)
        {
            close_bt.BackColor = Color.RoyalBlue;
        }
        private void close_bt_MouseLeave(object sender, EventArgs e)
        {
            close_bt.BackColor = Color.CornflowerBlue;
        }

        public MeetingAdd(string ID, SqlConnection con):base(con)
        {
            InitializeComponent();
            mitmoded_cb.DataSource = getMitmodedNames();
            this.coordinatorID = ID;

        }

        public MeetingAdd(string ID, DataGridViewRow dr, SqlConnection con) : base(con)
        {
            InitializeComponent();
            initFields(dr);
            this.coordinatorID = ID;
        }

        private void initFields(DataGridViewRow dr)
        {
            //update combobox
            mitmoded_cb.Items.Add(dr.Cells["firstName"].Value + " " + dr.Cells["lastName"].Value + " - " + dr.Cells["mitmodedID"].Value);
            mitmoded_cb.SelectedIndex = 0;

            //update city and address
            city_tb.Text = dr.Cells["city"].Value.ToString();
            address_tb.Text = dr.Cells["address"].Value.ToString();

            //update occured button
            occured_ck.Checked = dr.Cells["occured"].Value.ToString().Equals("True") ? true : false;

            //update text boxes
            topics_tb.Text = dr.Cells["topics"].Value.ToString();
            tasks_tb.Text = dr.Cells["tasks"].Value.ToString();

            //datepicker has to be checked for value to change
            datePicker.Checked = true;
            datePicker.Value = (DateTime)dr.Cells["date"].Value;

            meetingID = dr.Cells["meetingID"].Value.ToString();
            

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

        private void addMeeting_bt_Click(object sender, EventArgs e)
        {
            
            if (isValid()){
                // to distinguish between new meeting or existing one,
                // we ask how many users exist in combo box
                // if only one item, it was created from double click on datagrid
                // not the most elegant, but short, without booleans or sort
                if (mitmoded_cb.Items.Count > 1)
                    //many items exist, new meeting
                    meetingID = String.Concat(datePicker.Value.ToShortDateString(), "-", datePicker.Value.ToShortDateString(), "-", mitmodedID);

                if (SQLmethods.upsertMeeting (coordinatorID, meetingID, mitmodedID, datePicker.Value, address_tb.Text, occured_ck.Checked ? 1 : 0, city_tb.Text, topics_tb.Text, tasks_tb.Text, cmd))
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
            return true;
        }

        private void mitmoded_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            mitmodedID = Tools.getID(mitmoded_cb.SelectedItem.ToString());
            
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
