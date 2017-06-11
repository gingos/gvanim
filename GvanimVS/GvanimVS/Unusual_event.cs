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
    public partial class Unusual_event : DBform
    {
        private SqlConnection con;
        private string mitmodedID;
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
         
        public Unusual_event()
        {
            InitializeComponent();
        }

        public Unusual_event(SqlConnection con, string text):base(con)
        {
            this.con = con;
            this.mitmodedID = text;
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Show();
            textBox3.Show();
            label7.Show();
            checkBox2.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Show();
            checkBox3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = Convert.ToInt32(textBox1.Text);
            dataGridView1.Columns[0].FillWeight = 20;
            dataGridView1.Columns[1].FillWeight = 20;
            dataGridView1.Columns[2].FillWeight = 60;

            dataGridView1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveUnusualEvent();
            this.Close();
        }

        private void saveUnusualEvent()
        {
            string checkedSubjects = WhatIsChecked();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            dt = SQLmethods.getCoordinatorId(this.mitmodedID, da, cmd);
            string coordinatorId = dt.Rows[0]["coordinatorId"].ToString();
            try
            {
                SQLmethods.upsertUE(coordinatorId, this.mitmodedID, dateConverter(dateTimePicker1.Value), textBox6.Text, textBox2.Text, textBox3.Text, checkBoxConverter(checkBox3),
                                textBox4.Text, dgvToXml(dataGridView1), textBox5.Text, checkedSubjects, cmd);
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            catch (TimeoutException)
            {
                System.Windows.Forms.MessageBox.Show("משך הזמן התקין ליצירת קשר עם השרת עבר." + "\n"
                    + "אנא בדקו את חיבור האינטרנט ונסו שוב", "שגיאת חיבור", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error, System.Windows.Forms.MessageBoxDefaultButton.Button1,
                    System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);
            }
        }

        private static string dateConverter(DateTime date)
        {
            return date.Date.ToString("yyyy-MM-dd");
        }

        private static int checkBoxConverter(CheckBox checkbox)
        {
            if (checkbox.Checked)
            {
                return 1;
            }
            return 0;
        }

        private string dgvToXml(DataGridView dgv)
        {

            SerializableDictionary<string, string> xml_tab = new SerializableDictionary<string, string>();
            if (dgv is DataGridView)
            {
                DataTable dt = Tools.GetContentAsDataTable((DataGridView)dgv, true);
                string dtToXml = Tools.SerializeXML<DataTable>(dt);
                xml_tab.Add(dgv.Name, dtToXml);
            }
            string serializedOrganizer = Tools.SerializeXML<SerializableDictionary<string, string>>(xml_tab);
            return serializedOrganizer;
        }

        private string WhatIsChecked()
        {
            string res = null;
            // Display in a message box all the items that are checked.

            // First show the index and check state of all selected items.
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                // The indexChecked variable contains the index of the item.
                MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
                                checkedListBox1.GetItemCheckState(indexChecked).ToString() + ".");
            }

            // Next show the object title and check state for each item selected.
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {

                // Use the IndexOf method to get the index of an item.
                MessageBox.Show("Item with title: \"" + itemChecked.ToString() +
                                "\", is checked. Checked state is: " +
                                checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString() + ".");
                res += itemChecked.ToString() + " ";
            }
            return res;

        }
    }
}
