using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GvanimVS
{
    public partial class MitmodedCard : Form
    {
        private string imgLoc;
        public MitmodedCard()
        {
            InitializeComponent();
            Console.Write("MimodedCard-->empty c-tor--> create empty form\n");            
        }
        public MitmodedCard(string ID)
        {
            InitializeComponent();
            Console.Write("MimodedCard-->got ID--> pull data from DB by ID\n");
            /*DataTable dt =*/  getDataTable(ID);
            initFieldsFromDT(/*dt*/);
        }
        
        private void getDataTable(string iD)
        {
            throw new NotImplementedException();
        }
        private void initFieldsFromDT(/*DataTable dt*/)
        {
            throw new NotImplementedException();
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            Console.Write("MimodedCard-->ok button--> Saving to database...\n");

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
            }
        }
        private bool verifyFields()
        {

            if (firstName_tb.Text == null)
            {
                MessageBox.Show("נא הכנס שם פרטי");
                return false;
            }
            else if (!Tools.IsAlphabets(firstName_tb.Text.ToString())) {
                MessageBox.Show("שם פרטי יכול להכיל אותיות בלבד");
                return false;
            }

            if (lastName_tb.Text == null)
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
            if (city_tb == null)
            {
                MessageBox.Show("נא הכנס עיר מגורים");
                return false;
            }
            else if (!Tools.IsAlphabets(city_tb.Text.ToString()))
            {
                MessageBox.Show("עיר המגורים יכולה להכיל אותיות בלבד");
                return false;
            }

            if (address_tb == null)
            {
                MessageBox.Show("נא הכנס כתובת");
                return false;
            }
            if (phone1_tb == null)
            {
                MessageBox.Show("נא הכנס טלפון");
                return false;
            }
            else if (!Tools.valid_number(phone1_tb.Text.ToString()))
            {
                MessageBox.Show("At Product Price");
                return false;
            }
            if (phone2_tb != null)
            {
                if (!Tools.valid_number(phone2_tb.Text.ToString()))
                {
                    MessageBox.Show("At Product Price");
                    return false;
                }
            }
            //TODO: send default photo to SQL
            return true;
        }
    }
}
