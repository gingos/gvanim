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
        string ID;
        public Coordinator(SqlConnection con):base(con)
        {
            InitializeComponent();
        }
        public Coordinator(SqlConnection con, string ID) : base(con)
        {
            InitializeComponent();
            this.ID = ID;
            this.Text += ": " + ID;
        }

        private void writeReport_bt_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Activate();
        }

        private void Coordinator_Load(object sender, EventArgs e)
        {

        }

        private void editReport_bt_Click(object sender, EventArgs e)
        {
            FindReport fr = new FindReport();
            fr.Activate();
        }

        private void addMeeting_bt_Click(object sender, EventArgs e)
        {
            AddMeeting am = new AddMeeting();
            am.Activate();
        }

        private void editMeeting_bt_Click(object sender, EventArgs e)
        {
            FindMeeting fm = new FindMeeting();
            fm.Activate();
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
