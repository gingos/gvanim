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
    public partial class SelectMimoded : DBform
    {
        string type;
        public SelectMimoded()
        {
            InitializeComponent();
        }
        public SelectMimoded(SqlConnection con, string type):base(con)
        {
            InitializeComponent();
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.MITMODED, "ID, firstName, lastName", cmd, da);
            dataGridView1.DataSource = dt;
            changeDataHeadersToHebrew();
            this.type = type;
        }
    

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataGridView1["ID", e.RowIndex].Value.ToString();
            Console.WriteLine("SelectMitmoded-->click--> ID = " +ID);
            this.Hide();
            switch (type)
            {
                case "editMitmoded":
                    this.Hide();
                    using (var mit = new Mitmoded(con, ID))
                    {
                        mit.ShowDialog();
                    }
                    break;
                default:
                    break;
            }

            this.Show();
        }
        private void changeDataHeadersToHebrew()
        {
            dataGridView1.Columns["ID"].HeaderCell.Value = "תעודת זהות";
            dataGridView1.Columns["firstName"].HeaderCell.Value = "שם פרטי";
            dataGridView1.Columns["lastName"].HeaderCell.Value = "שם משפחה";
        }
    }
}
