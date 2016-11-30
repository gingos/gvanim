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
    public partial class PersonalPlan : DBform
    {
        private SerializableDictionary<string, SerializableDictionary<string, string>> xml_organizer;
        private DataTable dat;
        private SqlConnection con;

        public PersonalPlan(SqlConnection con) : base(con)
        {
            InitializeComponent();
            this.con = con;
           
        }

        public PersonalPlan(SqlConnection con, string text) : base(con)
        {
            InitializeComponent();
            this.con = con;
            ID_tb.Text = text;
            DataTable dt = SQLmethods.getColsFromTable(SQLmethods.MITMODED, "*", "ID", text, cmd, da);
            firstName_tb.Text = dt.Rows[0]["firstName"].ToString();
            lastName_tb.Text = dt.Rows[0]["lastName"].ToString();
            DataTable dt1 = SQLmethods.getColsFromTable(SQLmethods.USERS, "*", "ID", dt.Rows[0]["coordinatorID"].ToString(), cmd, da);
            coord_tb.Text = dt1.Rows[0]["firstName"].ToString() + " " + dt1.Rows[0]["lastName"].ToString();
        }

        private string textBoxesToDictionary()
        {
            //creates a dictionary of dictionarys, per tab, per text controls
            //using custom class - serializable dictionary 
            //returns the serialization xml as string
            xml_organizer = new SerializableDictionary<string, SerializableDictionary<string, string>>();
            foreach (TabPage page in this.tabControl1.TabPages)
            {
                SerializableDictionary<string, string> xml_tab = new SerializableDictionary<string, string>();
                foreach (Control control in page.Controls)
                {
                    if (control is TextBox)
                        if (control.Name.StartsWith("xml"))
                            xml_tab.Add(control.Name, control.Text);
                    if (control is DateTimePicker)
                        xml_tab.Add(control.Name, ((DateTimePicker)control).Value.ToShortDateString());
                    if (control is DataGridView)
                        if(control.Name.StartsWith("xmlg"))
                    {
                        dat = Tools.GetContentAsDataTable(xmlg_dataGridView1, false);
                        string dataGrid = Tools.SerializeXML(dat);
                        xml_tab.Add(control.Name, dataGrid);
                    }

                }
                xml_organizer.Add(page.Name, xml_tab);

                
            }
            foreach (TabPage page in this.tabControl2.TabPages)
            {
                SerializableDictionary<string, string> xml_tab = new SerializableDictionary<string, string>();
                foreach (Control control in page.Controls)
                {
                    if (control is TextBox)
                        if (control.Name.StartsWith("xml"))
                            xml_tab.Add(control.Name, control.Text);

                }
                xml_organizer.Add(page.Name, xml_tab);
            }

            foreach (TabPage page in this.tabControl2.TabPages)
            {
                SerializableDictionary<string, string> xml_tab = new SerializableDictionary<string, string>();
                foreach (CheckedListBox box in this.tabControl2.Controls)
                {
                    if (box.Name.StartsWith("xmlc"))
                        xml_tab.Add(box.Name, box.CheckedItems.ToString());
                }
                xml_organizer.Add(page.Name, xml_tab);

            }
            string serializedOrganizer = Tools.SerializeXML<SerializableDictionary<string, SerializableDictionary<string, string>>>(xml_organizer);
            return serializedOrganizer;

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PersonalPlan_Load(object sender, EventArgs e)
        {
            xmlg_dataGridView1.Rows.Add(new string[] { "1", "", "", "", "" });
            xmlg_dataGridView1.Rows.Add(new string[] { "2", "", "", "", "" });
            xmlg_dataGridView1.Rows.Add(new string[] { "3", "", "", "", "" });
            xmlg_dataGridView1.Rows.Add(new string[] { "4", "", "", "", "" });
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox31_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_update_Click(object sender, EventArgs e)
        {
           string information = textBoxesToDictionary();
            
            //insert data into SQL server
            if (SQLmethods.updateXMLFormInDB(SQLmethods.MITMODED, "personalPlanXML", "ID", ID_tb.Text, information, cmd))
                MessageBox.Show("המידע נשמר בהצלחה");
            else
                MessageBox.Show("אירעה שגיאה בעת שמירת הנתונים");
            this.Close();
        }
    }
}
