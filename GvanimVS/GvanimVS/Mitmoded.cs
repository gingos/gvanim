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

        private void Mitmoded_Load(object sender, EventArgs e)
        {

        }
        private void initFieldsFromDT(DataTable dt)
        {
            name_dynamic_lb.Text = dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();
            if (!(dt.Rows[0]["photo"] is DBNull))
            {
                byte[] bytes = (byte[])dt.Rows[0]["photo"];
                var ms = new System.IO.MemoryStream(bytes);
                profile_pb.Image = Image.FromStream(ms);
            }
            else
                profile_pb.Image = Properties.Resources.anonymous_profile;
        }
        private void employment_bt_Click(object sender, EventArgs e)
        {

        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
