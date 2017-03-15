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
            if (dt == null)
                return;
            firstName_tb.Text = dt.Rows[0]["firstName"].ToString();
            lastName_tb.Text = dt.Rows[0]["lastName"].ToString();
            DataTable dt1 = SQLmethods.getColsFromTable(SQLmethods.USERS, "*", "ID", dt.Rows[0]["coordinatorID"].ToString(), cmd, da);
            if (dt1 == null)
                return;
            coord_tb.Text = dt1.Rows[0]["firstName"].ToString() + " " + dt1.Rows[0]["lastName"].ToString();
            updateFieldsFromDB(dt.Rows[0]["personalPlanXML"].ToString());
        }

        private string textBoxesToDictionary()
        {
            //creates a dictionary of dictionarys, per tab, per text controls
            //using custom class - serializable dictionary 
            //returns the serialization xml as string
            xml_organizer = new SerializableDictionary<string, SerializableDictionary<string, string>>();
            SerializableDictionary<string, string> xml_tab;
            foreach (TabPage page in this.personal_plan_tc.TabPages)
            {
                xml_tab = new SerializableDictionary<string, string>();
                foreach (Control control in page.Controls)
                {
                    if (control.Name.StartsWith("xml"))
                    {
                        if (control is TextBox)
                            xml_tab.Add(control.Name, control.Text);
                        else if (control is DateTimePicker)
                            xml_tab.Add(control.Name, ((DateTimePicker)control).Value.ToShortDateString());
                        else if (control is DataGridView)
                        {
                            dat = Tools.GetContentAsDataTable((DataGridView)xml_rehab_dgv, false);
                            string dataGrid = Tools.SerializeXML<DataTable>(dat);
                            xml_tab.Add(control.Name, dataGrid);
                        }
                        else if (control is TabControl)
                        {
                            string test = Tools.SerializeXML(control.Controls);
                            xml_tab.Add(control.Name, test);
                        }
                    }
                }
                xml_organizer.Add(page.Name, xml_tab);
            }
            
            foreach (TabPage page in this.mazav_tc.TabPages)
            {
                xml_tab = new SerializableDictionary<string, string>();
                foreach (Control control in page.Controls)
                {
                    if (control is TextBox)
                        if (control.Name.StartsWith("xml"))
                            xml_tab.Add(control.Name, control.Text);
                    if (control is GroupBox)
                    {
                        if (control.Name.StartsWith("xml"))
                        {
                            if (control.Controls.OfType<RadioButton>().Any(r => r.Checked))
                                xml_tab.Add(control.Name, (control.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name));
                        }
                    }
                }
                xml_organizer.Add(page.Name, xml_tab);
            }
            string serializedOrganizer = Tools.SerializeXML<SerializableDictionary<string, SerializableDictionary<string, string>>>(xml_organizer);
            return serializedOrganizer;
        }

        private void PersonalPlan_Load(object sender, EventArgs e)
        {
            xml_rehab_dgv.Rows.Add(new string[] { "1", "", "", "", "" });
            xml_rehab_dgv.Rows.Add(new string[] { "2", "", "", "", "" });
            xml_rehab_dgv.Rows.Add(new string[] { "3", "", "", "", "" });
            xml_rehab_dgv.Rows.Add(new string[] { "4", "", "", "", "" });
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

        /// <summary>
        /// Get XML file from the DataBase, DeSerialize the XML file and update every fiels in the form by its name.
        /// </summary>
        /// <param name=""></param>

        private void updateFieldsFromDB(string OrganzierToDeserialize)
        {
            //get XML file from DB

            string orgenizer = SQLmethods.getXMLFromDB(SQLmethods.MITMODED, "personalPlanXML", ID_tb.Text, cmd);
            //DeSerialize XML file
            xml_organizer = Tools.DeserializeXML<SerializableDictionary<string, SerializableDictionary<string, string>>>(orgenizer);
            //Update every field by xml_tab.name
            foreach (KeyValuePair<string, SerializableDictionary<string, string>> dic in xml_organizer)
            {
                TabPage page1 = personal_plan_tc.TabPages[dic.Key];
                SerializableDictionary<string, string> xml_tab = dic.Value;
                foreach (KeyValuePair<string, string> controlKVP in xml_tab)
                {
                    if (controlKVP.Key.EndsWith("tb"))
                    {
                        if (page1.Controls.ContainsKey(controlKVP.Key))
                            page1.Controls[controlKVP.Key].Text = controlKVP.Value;
                    }
                    else if ((page1.Controls[controlKVP.Key] is DateTimePicker))
                    {
                        ((DateTimePicker)page1.Controls[controlKVP.Key]).Checked = true;
                        ((DateTimePicker)page1.Controls[controlKVP.Key]).Value =
                            DateTime.Parse(controlKVP.Value); //DateTime.ParseExact("dd/MM/yyyy", controlKVP.Value, System.Globalization.CultureInfo.InvariantCulture);
                    }
                    else if (controlKVP.Key.EndsWith("dgv"))
                    {
                        if (page1.Controls.ContainsKey(controlKVP.Key))
                            Tools.initDataGridFromXML(controlKVP.Value, (DataGridView)page1.Controls[controlKVP.Key]);
                    }
                    else if ((page1.Controls[controlKVP.Key] is GroupBox))
                    {
                        //xml_tab.Add(control.Name, ((Panel)control).Controls.OfType<RadioButton>().First(r => r.Checked).Name);
                        RadioButton rb = (RadioButton)((GroupBox)page1.Controls[controlKVP.Key]).Controls[controlKVP.Value];
                        rb.Checked = true;
                    }



                }
            }
        }

        private void quit_page_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox31_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void xmlgr_groupBox19_Enter(object sender, EventArgs e)
        {

        }
    }
}
