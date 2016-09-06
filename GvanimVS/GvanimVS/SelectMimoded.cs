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
        string ID, firstName, lastName, city;
        public SelectMimoded()
        {
            InitializeComponent();
        }
        public SelectMimoded(SqlConnection con):base(con)
        {
            InitializeComponent();
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.MITMODED, "ID, firstName, lastName, city", cmd, da);
            dataGridView1.DataSource = dt;
            changeDataHeadersToHebrew();
        }
        public SelectMimoded(SqlConnection con, string coordinatorID) : base(con)
        {
            InitializeComponent();
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.MITMODED, "ID, firstName, lastName, city", "coordinatorID", coordinatorID , cmd, da);
            dataGridView1.DataSource = dt;
            changeDataHeadersToHebrew();
        }


        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string first = dataGridView1["firstName", e.RowIndex].Value.ToString();
            string last = dataGridView1["lastName", e.RowIndex].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("האם ברצונך לערוך את" + "\n" +first +" " + last, "אישור בחירת מתמודד", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (dialogResult == DialogResult.Yes)
            {
                ID = dataGridView1["ID", e.RowIndex].Value.ToString();
                Console.WriteLine("SelectMitmoded-->click--> ID = " + ID);
                this.Hide();
                using (var mit = new Mitmoded(con, ID))
                {
                    mit.ShowDialog();
                }
                this.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
            
            
            /*
            
            */
        }
        private void changeDataHeadersToHebrew()
        {
            dataGridView1.Columns["ID"].HeaderCell.Value = "תעודת זהות";
            dataGridView1.Columns["firstName"].HeaderCell.Value = "שם פרטי";
            dataGridView1.Columns["lastName"].HeaderCell.Value = "שם משפחה";
            dataGridView1.Columns["city"].HeaderCell.Value = "עיר";
        }

        private void search_bt_Click(object sender, EventArgs e)
        {
            if (verifyFields())
            {
                DataTable dt = (SQLmethods.searchUsersInTable(SQLmethods.MITMODED, ID_tb.Text, firstName_tb.Text,
                    lastName_tb.Text, city_tb.Text, cmd, da));
                dataGridView1.DataSource = dt;
            }
        }
        private bool verifyFields()
        {
            bool nameEmpty = false, cityEmpty = false;

            if (ID_tb.Text.Equals(""))
            {
                if (firstName_tb.Text.Equals(""))
                {
                    DialogResult dialogResult = MessageBox.Show("לא נבחר שם לחיפוש. האם ברצונך להמשיך?", "אישור בחירת שם", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        nameEmpty = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        firstName_tb.Focus();
                        return false;
                    }
                }
                else if (!Tools.IsAlphabets(firstName_tb.Text.ToString()))
                {
                    MessageBox.Show("נא להכניס שם תקין");
                    firstName_tb.Focus();
                    return false;
                }

                if (city_tb.Text.Equals(""))
                {
                    DialogResult dialogResult = MessageBox.Show("לא נבחרה עיר לחיפוש. האם ברצונך להמשיך?", "אישור בחירת עיר", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cityEmpty = true;
                        if (cityEmpty && nameEmpty)
                        {
                            MessageBox.Show("יש להזין לפחות שם או עיר");
                            return false;
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        city_tb.Focus();
                        return false;
                    }
                }
                else if (!Tools.IsAlphabets(city_tb.Text.ToString()))
                {
                    MessageBox.Show("נא להכניס שם תקין");
                    city_tb.Focus();
                    return false;
                }
            }
            else if (!Tools.valid_number(ID_tb.Text.ToString()))
            {
                MessageBox.Show("נא להכניס תעודת זהות תקינה");
                ID_tb.Focus();
                return false;
            }

            return true;
        }

        private void SelectMimoded_Load(object sender, EventArgs e)
        {

        }
    }
}
