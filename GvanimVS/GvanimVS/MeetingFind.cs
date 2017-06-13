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
    public partial class MeetingFind : DBform
    {
        private DataTable dt;
        private string coordinatorID;
        public MeetingFind(SqlConnection con, string coordinatorID) :base(con)
        {
            InitializeComponent();
            dt = new DataTable();
            this.coordinatorID = coordinatorID;
        }

        private void searchMeeting_bt_Click(object sender, EventArgs e)
        {
            dt = DetailedSearch();
            this.Close();
        }

        public DataTable getDetails()
        {
            return dt;
        }

        /// <summary>
        /// return data on mitmoded by multiple paramters
        /// </summary>
        /// Performs JOIN on mitmoded and meeting tables on mitmoded ID and
        ///     [name | ID | occured | date | city | address]
        /// <returns>all columns from meetingTB by mitmoded name</returns>
        private DataTable DetailedSearch()
        {
            string cmdText = "";
            #region sqlQuery
            cmdText =
                "SELECT meeting.* FROM MeetingsTB meeting, MitmodedTb mitmoded WHERE meeting.mitmodedID = mitmoded.ID " +
                "AND (mitmoded.firstName LIKE '%' + @pFirstName + '%' AND mitmoded.lastName LIKE '%' + @pLastName + '%') " +
                "AND meeting.meetingID LIKE '%' + @pMeetingID + '%' " +
                "AND meeting.occured = @pOccured " +
                "AND meeting.date BETWEEN @pStartDate AND @pEndDate " +
                "AND meeting.city LIKE '%' + @pCity + '%' " +
                "AND meeting.address LIKE '%' + @pAddress + '%' " + 
                "AND meeting.coordinatorID = @pCoordinatorID";
            cmd.CommandText = cmdText;
            #endregion
            #region addParamaters
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@pFirstName", firstName_tb.Text);
            cmd.Parameters.AddWithValue("@pLastName", lastName_tb.Text);
            cmd.Parameters.AddWithValue("@pMeetingID", meetingID_tb.Text);
            cmd.Parameters.Add("@pOccured", SqlDbType.Bit).Value = occured_chk.Checked ? true : false;
            cmd.Parameters.Add("@pStartDate", SqlDbType.Date).Value = start_date_dtp.Checked ? start_date_dtp.Value.ToString() : new DateTime (1900,1,1).ToString();
            cmd.Parameters.Add("@pEndDate", SqlDbType.Date).Value = end_date_dtp.Checked ? end_date_dtp.Value.ToString() : DateTime.Now.ToString();
            cmd.Parameters.AddWithValue("@pCity", city_tb.Text);
            cmd.Parameters.AddWithValue("@pAddress", address_tb.Text);
            cmd.Parameters.AddWithValue("@pCoordinatorID", coordinatorID);
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
                System.Windows.Forms.MessageBox.Show("משך הזמן התקין ליצירת קשר עם השרת עבר." + "\n"
                    + "אנא בדקו את חיבור האינטרנט ונסו שוב", "שגיאת חיבור", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error, System.Windows.Forms.MessageBoxDefaultButton.Button1,
                    System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);
                return null;
            }
            #endregion
            return dt;
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
