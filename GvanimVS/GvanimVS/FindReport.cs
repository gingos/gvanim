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
    public partial class FindReport : Form
    {
        public FindReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchReport_bt_Click(object sender, EventArgs e)
        {
            //add a search query with the criterias
            this.Close();
        }

        private void reportNum_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
