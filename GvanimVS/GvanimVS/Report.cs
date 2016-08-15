using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GvanimVS
{
    public partial class Report : DBform
    {
        public Report()
        {
            InitializeComponent();
        }

        public Report(int reportID)
        {
            InitializeComponent();
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
