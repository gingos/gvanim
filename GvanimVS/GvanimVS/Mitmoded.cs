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
    public partial class Mitmoded : DBform
    {
        private string coordinatorID;
        public Mitmoded()
        {
            InitializeComponent();
        }
        public Mitmoded (SqlConnection con):base(con)
        {
            InitializeComponent();
        }
        public Mitmoded(SqlConnection con, string ID) : base(con)
        {
            InitializeComponent();
            ID_dynamic_lb.Text = ID;
            DataTable dt = SQLmethods.getDataTable(SQLmethods.MITMODED, ID, cmd, da);
            initFieldsFromDT(dt);
        }

        private void initFieldsFromDT(DataTable dt)
        {
            name_dynamic_lb.Text = dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();
            coordinatorID = dt.Rows[0]["coordinatorID"].ToString();
            coordinator_dynamic_lb.Text = getCoordinatorName(coordinatorID);
            if (!(dt.Rows[0]["photo"] is DBNull))
            {
                byte[] bytes = (byte[])dt.Rows[0]["photo"];
                var ms = new System.IO.MemoryStream(bytes);
                profile_pb.Image = Image.FromStream(ms);
            }
            else
                profile_pb.Image = Properties.Resources.anonymous_profile;
        }
        private string getCoordinatorName(string coordinatorID)
        {
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.USERS, "*", "ID", coordinatorID, cmd, da);
            return dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();
        }

        private void employment_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var employmentRec = new EmplyomentRecord(con, ID_dynamic_lb.Text, name_dynamic_lb.Text))
            {
                employmentRec.ShowDialog();
            }
            this.Show();
        }
        private void show_reports_bt_Click(object sender, EventArgs e)
        {

        }
        private void info_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var mitCard = new MitmodedCard(con, ID_dynamic_lb.Text))
            {
                mitCard.ShowDialog();
            }
            this.Show();
        }
        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void change_coordinator_bt_Click(object sender, EventArgs e)
        {
            //TODO
           throw new NotImplementedException();
        }

        private void Mitmoded_Load(object sender, EventArgs e)
        {

        }

        private void add_report_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var report = new Report(con, coordinatorID, ID_dynamic_lb.Text))
            {
                report.ShowDialog();
            }
            this.Show();
        }

        private void coordinator_dynamic_lb_Click(object sender, EventArgs e)
        {

        }
    }
}
