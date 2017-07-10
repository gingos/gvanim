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
    public partial class RegionManager : DBform
    {
        string ID;
        public RegionManager():base()
        {
            InitializeComponent();
        }
        public RegionManager(SqlConnection con) : base(con)
        {
            InitializeComponent();
        }
        public RegionManager(SqlConnection con, string ID) : base(con)
        {
            InitializeComponent();
            this.ID = ID;
            this.Text += ": " + ID;
        }

        private void addMitmoded_bt_Click(object sender, EventArgs e)
        {
            using (var mitCard = new MitmodedCard(con))
            {
                mitCard.ShowDialog();
            }
        }

        private void info_bt_Click(object sender, EventArgs e)
        {
            using (var rmCard = new RegionManagerCard(con, ID))
            {
                rmCard.ShowDialog();
            }
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCoordinator_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var newCoordinator = new CreateCoordinator(con, ID))
            {
                newCoordinator.ShowDialog();
            }
            this.Close();
        }

        private void showReports_bt_Click(object sender, EventArgs e)
        {

        }

        private void showMeetings_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var meetings = new MeetingShow(con, ID))
            {
                meetings.ShowDialog();
            }
            this.Close();
        }

        private void info_bt_MouseHover(object sender, EventArgs e)
        {
            info_bt.BackColor = Color.RoyalBlue;
        }

        private void info_bt_MouseLeave(object sender, EventArgs e)
        {
            info_bt.BackColor = Color.CornflowerBlue;
        }

        private void addMitmoded_bt_MouseHover(object sender, EventArgs e)
        {
            addMitmoded_bt.BackColor = Color.RoyalBlue;
        }

        private void addMitmoded_bt_MouseLeave(object sender, EventArgs e)
        {
            addMitmoded_bt.BackColor = Color.CornflowerBlue;
        }

        private void addCoordinator_bt_MouseHover(object sender, EventArgs e)
        {
            addCoordinator_bt.BackColor = Color.RoyalBlue;
        }

        private void addCoordinator_bt_MouseLeave(object sender, EventArgs e)
        {
            addCoordinator_bt.BackColor = Color.CornflowerBlue;
        }

        private void showReports_bt_MouseHover(object sender, EventArgs e)
        {
            showReports_bt.BackColor = Color.RoyalBlue;
        }

        private void showReports_bt_MouseLeave(object sender, EventArgs e)
        {
            showReports_bt.BackColor = Color.CornflowerBlue;
        }

        private void showMeetings_bt_MouseHover(object sender, EventArgs e)
        {
            showMeetings_bt.BackColor = Color.RoyalBlue;
        }

        private void showMeetings_bt_MouseLeave(object sender, EventArgs e)
        {
            showMeetings_bt.BackColor = Color.CornflowerBlue;
        }

        private void ok_bt_MouseHover(object sender, EventArgs e)
        {
            ok_bt.BackColor = Color.RoyalBlue;
        }

        private void ok_bt_MouseLeave(object sender, EventArgs e)
        {
            ok_bt.BackColor = Color.CornflowerBlue;
        }
    }
}
