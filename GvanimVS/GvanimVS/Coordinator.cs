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
    public partial class Coordinator : DBform
    {
        string coordinatorID;
        public Coordinator(SqlConnection con):base(con)
        {
            InitializeComponent();
        }
        public Coordinator(SqlConnection con, string ID) : base(con)
        {
            InitializeComponent();
            this.coordinatorID = ID;
            this.Text += ": " + ID;
        }

        private void writeReport_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Report r = new Report(con, coordinatorID))
            {
                r.ShowDialog();
            }
            this.Show();
        }
        private void editReport_bt_Click(object sender, EventArgs e)
        {
            //TODO: yair : create search by parameter in FindReport for reports and create a full ctor in Report for viewing the report
            this.Hide();
            using (FindReport fr = new FindReport(con, coordinatorID))
            {
                fr.ShowDialog();
            }
            this.Show();
           
                
        }
    
        private void addMeeting_bt_Click(object sender, EventArgs e)
        {
            /*
            // Nothing happens in the GUI :(
            AddMeeting am = new AddMeeting();
            am.Activate();
            */
            this.Hide();
            using (var am = new MeetingAdd(coordinatorID, con))
            {
                am.ShowDialog();
            }
            this.Show();
        }
        private void editMeeting_bt_Click(object sender, EventArgs e)
        {
            FindMeeting fm = new FindMeeting(con, coordinatorID);
            fm.Activate();
        }

        private void addMitmoded_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var mc = new MitmodedCard(con))
            {
                mc.ShowDialog();
            }
            this.Show();
        }
        private void editMitmoded_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var select = new SelectMimoded(con, coordinatorID))
            {
                select.ShowDialog();
            }
            this.Show();
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Coordinator_Load(object sender, EventArgs e)
        {

        }

        private void showMeetings_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var meetings = new MeetingShow(con, coordinatorID))
            {
                meetings.ShowDialog();
            }
            this.Close();
        }
    }
}
