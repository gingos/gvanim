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
            if (dt!=null)
                mitmoded_dgv.DataSource = dt;
            changeDataHeadersToHebrew();
        }
        public SelectMimoded(SqlConnection con, string coordinatorID) : base(con)
        {
            InitializeComponent();
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.MITMODED, "ID, firstName, lastName, city", "coordinatorID", coordinatorID , cmd, da);
            if (dt == null)
                return;
            mitmoded_dgv.DataSource = dt;
            mitmoded_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            changeDataHeadersToHebrew();

        }


        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // column header cell is also a cell, with index -1
            // sorting with double click caused an IndexOutOfBounds error
            // first condition cancels the double-click-sorting bug
            if (e.RowIndex == -1)
                return;
            string first = mitmoded_dgv["firstName", e.RowIndex].Value.ToString();
            string last = mitmoded_dgv["lastName", e.RowIndex].Value.ToString();
            //DialogResult dialogResult = MessageBox.Show("האם ברצונך לערוך את" + "\n" +first +" " + last, "אישור בחירת מתמודד", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (true)// == DialogResult.Yes)
            {
                ID = mitmoded_dgv["ID", e.RowIndex].Value.ToString();
                Console.WriteLine("SelectMitmoded-->click--> ID = " + ID);
                this.Hide();
                using (var mit = new Mitmoded(con, ID))
                {
                    mit.ShowDialog();
                }
                this.Show();
            }
            else// if (dialogResult == DialogResult.No)
            {
                return;
            }
            
            
            
            /*
            
            */
        }
        private void changeDataHeadersToHebrew()
        {
            mitmoded_dgv.Columns["ID"].HeaderCell.Value = "תעודת זהות";
            mitmoded_dgv.Columns["firstName"].HeaderCell.Value = "שם פרטי";
            mitmoded_dgv.Columns["lastName"].HeaderCell.Value = "שם משפחה";
            mitmoded_dgv.Columns["city"].HeaderCell.Value = "עיר";
        }

        private void search_bt_MouseHover(object sender, EventArgs e)
        {
            search_bt.BackColor = Color.RoyalBlue;
        }

        private void search_bt_MouseLeave(object sender, EventArgs e)
        {
            search_bt.BackColor = Color.CornflowerBlue;
        }

        private void close_bt_MouseHover(object sender, EventArgs e)
        {
            close_bt.BackColor = Color.RoyalBlue;
        }

        private void close_bt_MouseLeave(object sender, EventArgs e)
        {
            close_bt.BackColor = Color.CornflowerBlue;
        }

        private void search_bt_Click(object sender, EventArgs e)
        {
            if (verifyFields())
            {
                DataTable dt = (SQLmethods.searchUsersInTable(SQLmethods.MITMODED, ID_tb.Text, firstName_tb.Text,
                    lastName_tb.Text, city_tb.Text, cmd, da));
                if (dt == null)
                    return;
                mitmoded_dgv.DataSource = dt;
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
