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
    public partial class Report : DBform
    {
        public Report(SqlConnection con):base(con)
        {
            InitializeComponent();
            DataTable dt = SQLmethods.getDataTable(SQLmethods.MITMODED, cmd, da);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["firstName"].ToString() + " " + dr["lastName"].ToString());
            }
            
        }

        public Report(SqlConnection con, int reportID):base(con)
        {
            InitializeComponent();
            DataTable dt = SQLmethods.getDataTable(SQLmethods.MITMODED, reportID.ToString(), cmd, da);
            //TODO: init fields
            // ReportSerialNum_lb = 
            // reportDiscription_tb = 
            // activityDiscription_tb = 
        }

        private void Report_Load(object sender, EventArgs e)
        {
            
        }

        private void saveReport_bt_Click(object sender, EventArgs e)
        {
            //enter the report to sqlreports for the mitmoded
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get list of mitmodedim to pick
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
