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
    public partial class FindReport : DBform
    {
        public FindReport(SqlConnection con) : base(con)
        {
            InitializeComponent();
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.REPORTS, "Id, mitmodedID, firstName, lastName, Created, Report, actions", cmd, da);
            dataGridView1.DataSource = dt;
            changeDataHeadersToHebrew();

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
           DataTable dt = SQLmethods.findReport(reportNum_tb.Text, comboBox1.SelectedItem.ToString(), dateTimePicker1.Value.Date, cmd, da);
           dataGridView1.DataSource = dt;
           changeDataHeadersToHebrew();
            
        }

        private void reportNum_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void FindReport_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show all mitmodedim for coordinator
            // message from yoad: use sql method
            // SQLmethods.getColsFromTable() second overload (with key-value search)

          
            //change mitmoded name to mitmodedID from sql
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void changeDataHeadersToHebrew()
        {
            dataGridView1.Columns["Id"].HeaderCell.Value ="מספר דוח";
            dataGridView1.Columns["mitmodedID"].HeaderCell.Value = "תעודת זהות מתמודד";
            dataGridView1.Columns["firstName"].HeaderCell.Value = "שם פרטי";
            dataGridView1.Columns["lastName"].HeaderCell.Value = "שם משפחה";
            dataGridView1.Columns["Created"].HeaderCell.Value = "תאריך";
            dataGridView1.Columns["Report"].HeaderCell.Value = "פרטי הדוח";
            dataGridView1.Columns["actions"].HeaderCell.Value = "פעולות שננקטו";
        }
    }
}
