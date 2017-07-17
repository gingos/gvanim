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
    public partial class ReportFind : DBform
    {
        string coordinatorID;
        public ReportFind(SqlConnection con, string coordinatorID) : base(con)
        {
            InitializeComponent();
            this.coordinatorID = coordinatorID;
            //DataTable formDT = fastSearch();
            DataTable formDT = SQLmethods.findReport(coordinatorID,cmd,da);
            if (formDT != null)
            {
                reports_dgv.DataSource = formDT;
                reports_dgv.Columns["coordinatorID"].Visible = false;
                changeDataHeadersToHebrew();
                mitmoded_name_cb.DataSource = getMitmodedNames(formDT);
            }

        }

        /// <summary>
        /// Initialize combobox with mitmoded names
        /// </summary>
        /// format: first last - mitmodedID
        /// <param name="dt">datatable representing ReportsTB by coordinator ID</param>
        /// <returns></returns>
        private object getMitmodedNames(DataTable dt)
        {
            List<string> names = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                names.Add(dr["firstName"].ToString() + " " + dr["lastName"].ToString() + " - " + dr["mitmodedID"].ToString());
            }
            return names;
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchReport_bt_Click(object sender, EventArgs e)
        {
            string mitmodedID = mitmoded_name_cb.SelectedItem.ToString();
            //extract ID: first last - ID, so ID is at "-"+space+1
            mitmodedID = mitmodedID.Substring(mitmodedID.IndexOf("-")+2);

            //to make date of meeting optional, we overload SQL.findReport with nullable options
            DataTable dt;
            if (datepicker_dtp.Checked)
                dt = SQLmethods.findReport(report_id_tb.Text,coordinatorID ,mitmodedID ,
                    datepicker_dtp.Value.Date, cmd, da);
            else
                dt = SQLmethods.findReport(report_id_tb.Text, coordinatorID, mitmodedID,
                   null, cmd, da);
            if (dt == null)
               return;
           reports_dgv.DataSource = dt;
           changeDataHeadersToHebrew();
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: create third ctor for report
            //Report r = new Report()
        }

        private void searchReport_bt_MouseHover(object sender, EventArgs e)
        {
            searchReport_bt.BackColor = Color.RoyalBlue;
        }

        private void searchReport_bt_MouseLeave(object sender, EventArgs e)
        {
            searchReport_bt.BackColor = Color.CornflowerBlue;
        }

        private void cancel_bt_MouseHover(object sender, EventArgs e)
        {
            cancel_bt.BackColor = Color.RoyalBlue;
        }

        private void cancel_bt_MouseLeave(object sender, EventArgs e)
        {
            cancel_bt.BackColor = Color.CornflowerBlue;
        }

        private void addReport_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ReportAdd r = new ReportAdd(con, coordinatorID))
            {
                r.ShowDialog();
            }
            this.Show();
        }

        private void changeDataHeadersToHebrew()
        {
            reports_dgv.Columns["Id"].HeaderCell.Value ="מספר דוח";
            reports_dgv.Columns["mitmodedID"].HeaderCell.Value = "ת.ז. מתמודד";
            reports_dgv.Columns["firstName"].HeaderCell.Value = "שם פרטי";
            reports_dgv.Columns["lastName"].HeaderCell.Value = "שם משפחה";
            reports_dgv.Columns["Created"].HeaderCell.Value = "תאריך";
            reports_dgv.Columns["Report"].HeaderCell.Value = "פרטי הדוח";
            reports_dgv.Columns["actions"].HeaderCell.Value = "פעולות שננקטו";
            reports_dgv.Columns["coordinatorID"].HeaderCell.Value = "ת.ז. רכז";
        }
    }
}
