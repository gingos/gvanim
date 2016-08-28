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
    public partial class EmplyomentRecord : DBform
    {
        public EmplyomentRecord():base()
        {
            InitializeComponent();
        }
        public EmplyomentRecord(SqlConnection con, string ID, string name) : base(con)
        {
            InitializeComponent();
            mitmoded_id_lb.Text = ID;
            mitmoded_name_lb.Text = name;
            DataTable dt = SQLmethods.getEmploymentRecordTable(mitmoded_id_lb.Text, cmd, da);
            dataGridView1.DataSource = dt;
            changeDataHeadersToHebrew();

        }

        private void changeDataHeadersToHebrew()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "שם המעסיק";
            dataGridView1.Columns[1].HeaderCell.Value = "תאריך התחלה";
            dataGridView1.Columns[2].HeaderCell.Value = "תאריך סיום";
            dataGridView1.Columns[3].HeaderCell.Value = "תיאור המשרה";
            dataGridView1.Columns[4].HeaderCell.Value = "תחומי אחריות";
            dataGridView1.Columns[5].HeaderCell.Value = "הישגים משמעותיים";
            
        }

        private void EmplyomentRecord_Load(object sender, EventArgs e)
        {
            

        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
