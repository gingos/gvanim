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
            using (ReportAdd r = new ReportAdd(con, coordinatorID))
            {
                r.ShowDialog();
            }
            this.Show();
        }
        private void editReport_bt_Click(object sender, EventArgs e)
        {
            //TODO: yair : create search by parameter in FindReport for reports and create a full ctor in Report for viewing the report
            this.Hide();
            using (ReportFind fr = new ReportFind(con, coordinatorID))
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
            MeetingFind fm = new MeetingFind(con, coordinatorID);
            fm.Activate();
        }

        private void addMitmoded_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var mc = new MitmodedCard(con, "", coordinatorID))
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
            this.Show();
        }

        private void editCoordinator_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var cc = new CoordinatorCard(con, coordinatorID))
            {
                cc.ShowDialog();
            }
            this.Show();
        }

        private void addMeeting_bt_MouseHover(object sender, EventArgs e)
        {
            addMeeting_bt.BackColor = Color.RoyalBlue;
        }

        private void addMeeting_bt_MouseLeave(object sender, EventArgs e)
        {
            addMeeting_bt.BackColor = Color.CornflowerBlue;
        }

        private void editMeeting_bt_MouseHover(object sender, EventArgs e)
        {
            showMeetings_bt.BackColor = Color.RoyalBlue;
        }

        private void editMeeting_bt_MouseLeave(object sender, EventArgs e)
        {
            showMeetings_bt.BackColor = Color.CornflowerBlue;
        }

        private void writeReport_bt_MouseHover(object sender, EventArgs e)
        {
            writeReport_bt.BackColor = Color.RoyalBlue;
        }

        private void writeReport_bt_MouseLeave(object sender, EventArgs e)
        {
            writeReport_bt.BackColor = Color.CornflowerBlue;
        }

        private void editCoordinator_bt_MouseHover(object sender, EventArgs e)
        {
            editCoordinator_bt.BackColor = Color.RoyalBlue;
        }

        private void editCoordinator_bt_MouseLeave(object sender, EventArgs e)
        {
            editCoordinator_bt.BackColor = Color.CornflowerBlue;
        }

        private void editMitmoded_bt_MouseHover(object sender, EventArgs e)
        {
            editMitmoded_bt.BackColor = Color.RoyalBlue;
        }

        private void editMitmoded_bt_MouseLeave(object sender, EventArgs e)
        {
            editMitmoded_bt.BackColor = Color.CornflowerBlue;
        }

        private void addMitmoded_bt_MouseHover(object sender, EventArgs e)
        {
            addMitmoded_bt.BackColor = Color.RoyalBlue;
        }

        private void addMitmoded_bt_MouseLeave(object sender, EventArgs e)
        {
            addMitmoded_bt.BackColor = Color.CornflowerBlue;
        }
    }
}
