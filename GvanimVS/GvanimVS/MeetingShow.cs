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
    public partial class MeetingShow : DBform
    {
        public MeetingShow(SqlConnection con, string coordinatorID) : base(con)
        {
            InitializeComponent();
            coordinatorID_lb.Text = coordinatorID;
        }

        public MeetingShow (SqlConnection con, string coordinatorID, string mitmodedID): base(con)
        {
            InitializeComponent();
            coordinatorID_lb.Text = coordinatorID;
            mitmoded_name_tb.Text = mitmodedID;
            mitmoded_name_tb.Enabled = false;
            DataTable dt = fastSearch();
            if (dt.Rows.Count != 0)
            {
                meetings_dgv.DataSource = dt;
            }
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fast_search_bt_Click(object sender, EventArgs e)
        {
            DataTable dt = fastSearch();
            if (dt != null)
            {
                meetings_dgv.DataSource = dt;
            }
        }

        /// <summary>
        /// return data on mitmoded by name
        /// </summary>
        /// Performs JOIN on mitmoded and meeting tables on mitmoded ID and name
        /// <returns>all columns from meetingTB by mitmoded name</returns>
        private DataTable fastSearch()
        {
            DataTable dt = new DataTable();
            string cmdText = "";
            #region sqlQuery
            cmdText =
                "SELECT mitmoded.firstName, mitmoded.lastName, meeting.* FROM MeetingsTB meeting, MitmodedTb mitmoded " +
                "WHERE meeting.mitmodedID = mitmoded.ID " +
                "AND mitmoded.coordinatorID = @pCoordinator " +
                "AND " +
                "( (mitmoded.firstName + ' ' + mitmoded.lastName LIKE '%' + @pName + '%') " +
                "OR (mitmoded.lastName + ' ' + mitmoded.firstName LIKE '%' + @pName + '%') " +
                "OR (mitmoded.ID = @pName ) ) ";
                
            cmd.CommandText = cmdText;
            #endregion
            #region addParamaters
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@pName", mitmoded_name_tb.Text);
            cmd.Parameters.AddWithValue("@pCoordinator", coordinatorID_lb.Text);
            #endregion
            #region execute
            da.SelectCommand = cmd;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return null;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("משך הזמן התקין ליצירת קשר עם השרת עבר." + "\n"
                    + "אנא בדקו את חיבור האינטרנט ונסו שוב", "שגיאת חיבור", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error, System.Windows.Forms.MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                return null;
            }
            #endregion
            return dt;
        }

        private void detailed_search_Click(object sender, EventArgs e)
        {
            MeetingFind find;
            DataTable dt;
            this.Hide();
            //to determine if opened via coordinator or mitmoded
            if (mitmoded_name_tb.Enabled)
                //mitmoded is inserted by cooridnator
                find = new MeetingFind(con, coordinatorID_lb.Text);
            else
                //text box disabled, because it is locked for specific mitmoded ID
                find = new MeetingFind(con, coordinatorID_lb.Text, mitmoded_name_tb.Text);
            using (find)
            {
                find.ShowDialog();
                 dt = find.getDetails();
                if (dt.Rows.Count != 0)
                    meetings_dgv.DataSource = dt;
            }
            this.Show();
        }

        private void add_meeting_bt_Click(object sender, EventArgs e)
        {
            /*
            AddMeeting meeting = new AddMeeting(coordinatorID_lb.Text, con);
            meeting.ShowDialog();
            meeting.Dispose();
            */
            using (MeetingAdd meeting = new MeetingAdd(coordinatorID_lb.Text, con))
            {
                meeting.ShowDialog();
            }
        }

        private void close_bt_MouseHover(object sender, EventArgs e)
        {
            close_bt.BackColor = Color.RoyalBlue;
        }
        private void close_bt_MouseLeave(object sender, EventArgs e)
        {
            close_bt.BackColor = Color.CornflowerBlue;
        }
        private void add_meeting_bt_MouseHover(object sender, EventArgs e)
        {
            add_meeting_bt.BackColor = Color.RoyalBlue;
        }
        private void add_meeting_bt_MouseLeave(object sender, EventArgs e)
        {
            add_meeting_bt.BackColor = Color.CornflowerBlue;
        }
        private void fast_search_bt_MouseHover(object sender, EventArgs e)
        {
            fast_search_bt.BackColor = Color.RoyalBlue;
        }
        private void fast_search_bt_MouseLeave(object sender, EventArgs e)
        {
            fast_search_bt.BackColor = Color.CornflowerBlue;
        }
        private void detailed_search_MouseHover(object sender, EventArgs e)
        {
            detailed_search_bt.BackColor = Color.RoyalBlue;
        }
        private void detailed_search_MouseLeave(object sender, EventArgs e)
        {
            detailed_search_bt.BackColor = Color.CornflowerBlue;
        }

        private void meetings_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = meetings_dgv["firstName", e.RowIndex].Value.ToString() + " " + meetings_dgv["lastName", e.RowIndex].Value.ToString();
            //message box: do you wish to edit $mitmodedID
            DialogResult dialogResult = MessageBox.Show(String.Format("{0}:\n{1}","האם ברצונכם לערוך את המתמודד",name), "אישור בחירת מתמודד", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            if (dialogResult == DialogResult.Yes)
            {
                //open mitmodedAdd with c-tor for meetings : (meetings_dgv[meetingIDColumn, e.RowIndex].Value.ToString(), con) 
                this.Hide();
                //using (MeetingAdd meetingEdit = new MeetingAdd (meetings_dgv["mitmodedID", e.RowIndex].Value.ToString(), "mitmoded", con))
                using (MeetingAdd meetingEdit = new MeetingAdd(coordinatorID_lb.Text, meetings_dgv.Rows[e.RowIndex], con))
                {
                    meetingEdit.ShowDialog();
                }
                this.Show();
                //refresh datagrid after returning from meeting edit
                DataTable dt = fastSearch();
                if (dt.Rows.Count != 0)
                {
                    meetings_dgv.DataSource = dt;
                }
            }
            
        }
    }
}