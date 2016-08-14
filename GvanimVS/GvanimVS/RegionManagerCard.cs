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
    public partial class RegionManagerCard : DBform
    {
        private string imgLoc;
        private bool imgChanged;
        private string ID;

        public RegionManagerCard(SqlConnection con):base(con)
        {
            InitializeComponent();
            Console.Write("RegionManagerCard-->empty c-tor--> create empty form\n");
        }

        public RegionManagerCard(SqlConnection con, string ID):base(con)
        {
            InitializeComponent();
            this.ID = ID;
            Console.Write("MimodedCard-->got " + ID + "--> pull data from DB by ID\n");
            firstName_tb.Text = ID;
            /*DataTable dt =*/ getDataTable(ID);
            initFieldsFromDT(/*dt*/);
        }
        private void getDataTable(string iD)
        {
            Console.WriteLine("RegionManagerCard--> getDataTable (not implemented)");
        }
        private void initFieldsFromDT(/*DataTable dt*/)
        {
            Console.WriteLine("RegionManagerCard--> initFields (not implemented)");
        }
        private void ok_bt_Click(object sender, EventArgs e)
        {
            Console.Write("MimodedCard-->ok button--> Saving to database...\n");
            if (verifyFields())
                this.Close();

        }
        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void profile_pb_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName.ToString();
                imgLoc = fileToOpen;
                profile_pb.ImageLocation = imgLoc;
                imgChanged = true;
            }
        }
        private bool verifyFields()
        {

            if (firstName_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס שם פרטי");
                return false;
            }
            else if (!Tools.IsAlphabets(firstName_tb.Text.ToString()))
            {
                MessageBox.Show("שם פרטי יכול להכיל אותיות בלבד");
                return false;
            }

            if (lastName_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס שם משפחה");
                return false;
            }
            else if (!Tools.IsAlphabets(lastName_tb.Text.ToString()))
            {
                MessageBox.Show("שם משפחה יכול להכיל אותיות בלבד");
                return false;
            }
            if (!dateTimePicker1.Checked)
            {
                MessageBox.Show("נא לבחור תאריך לידה");
                return false;
            }

            if (ID_tb == null)
            {
                MessageBox.Show("נא הכנס תעודת זהות");
                return false;
            }
            else if (!Tools.valid_number(ID_tb.Text.ToString()))
            {
                MessageBox.Show("על תעודת הזהות להכיל ספרות בלבד");
                return false;
            }
            else if (ID_tb.Text.ToString().Length != 9)
            {
                MessageBox.Show("על תעודת הזהות להכיל 9 ספרות בדיוק");
                return false;
            }

            if (city_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס עיר מגורים");
                return false;
            }
            else if (!Tools.IsAlphabets(city_tb.Text.ToString()))
            {
                MessageBox.Show("עיר המגורים יכולה להכיל אותיות בלבד");
                return false;
            }

            if (address_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס כתובת");
                return false;
            }
            if (phone1_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס טלפון");
                return false;
            }
            else if (!Tools.valid_number(phone1_tb.Text.ToString()))
            {
                MessageBox.Show("נא הכנס מספר טלפון תקני");
                return false;
            }
            if (!phone2_tb.Text.Equals(""))
            {
                if (!Tools.valid_number(phone2_tb.Text.ToString()))
                {
                    MessageBox.Show("נא הכנס מספר טלפון תקני");
                    return false;
                }
            }
            if (!imgChanged)
            {
                DialogResult dialogResult = MessageBox.Show("לא נבחרה תמונה. האם ברצונך להמשיך?", "אישור בחירת תמונה", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // no option
                }
                else if (dialogResult == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
