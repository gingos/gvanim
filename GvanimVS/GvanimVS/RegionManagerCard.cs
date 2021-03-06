﻿using System;
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
            DataTable dt = SQLmethods.getDataTable(SQLmethods.USERS, ID, cmd, da);
            if (dt!= null)
                initFieldsFromDT(dt);
        }
        private void getDataTable(string iD)
        {
            Console.WriteLine("RegionManagerCard--> getDataTable (not implemented)");
        }
        private void initFieldsFromDT(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                firstName_tb.Text = dr["firstName"].ToString();
                lastName_tb.Text = dr["lastName"].ToString();
                dateTimePicker1.Value = (DateTime)dr["birthday"];
                city_tb.Text = dr["city"].ToString();
                address_tb.Text = dr["streetAddress"].ToString();
                phone1_tb.Text = dr["phone1"].ToString();
                phone2_tb.Text = dr["phone2"].ToString();
                email_tb.Text = dr["email"].ToString();
                //if (dr["photo"] != null)
                if (!(dr["photo"] is DBNull))
                {
                    byte[] bytes = (byte[])dr["photo"];
                    var ms = new System.IO.MemoryStream(bytes);
                    profile_pb.Image = Image.FromStream(ms);
                }
                else
                    profile_pb.Image = Properties.Resources.anonymous_profile;

            }
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
                firstName_tb.Focus();
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
                lastName_tb.Focus();
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
                dateTimePicker1.Focus();
                return false;
            }

            if (ID_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס תעודת זהות");
                ID_tb.Focus();
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
                city_tb.Focus();
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
                address_tb.Focus();
                return false;
            }
            if (phone1_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס טלפון");
                phone1_tb.Focus();
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
                    phone2_tb.Focus();
                    return false;
                }
            }
            if (email_tb.Text.Equals(""))
            {
                MessageBox.Show("נא הכנס כתובת אימייל");
                address_tb.Focus();
                return false;
            }
            else if (!Tools.IsValidEmail(email_tb.Text))
            {
                MessageBox.Show("נא הכנס כתובת אימייל תקנית");
                address_tb.Focus();
                return false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var UP = new UpdatePassword(con, ID))
            {
                UP.ShowDialog();
            }
            this.Close();
        }

        private void firstName_tb_Click(object sender, EventArgs e)
        {
            firstName_tb.Text = "";
        }

        private void lastName_tb_Click(object sender, EventArgs e)
        {
            lastName_tb.Text = "";
        }

        private void ID_tb_Click(object sender, EventArgs e)
        {
            ID_tb.Text = "";
        }

        private void city_tb_Click(object sender, EventArgs e)
        {
            city_tb.Text = "";
        }

        private void address_tb_Click(object sender, EventArgs e)
        {
            address_tb.Text = "";
        }

        private void phone1_tb_Click(object sender, EventArgs e)
        {
            phone1_tb.Text = "";
        }

        private void phone2_tb_Click(object sender, EventArgs e)
        {
            phone2_tb.Text = "";
        }

        private void email_tb_Click(object sender, EventArgs e)
        {
            email_tb.Text = "";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.CornflowerBlue;
        }

        private void ok_bt_MouseHover(object sender, EventArgs e)
        {
            ok_bt.BackColor = Color.RoyalBlue;
        }

        private void ok_bt_MouseLeave(object sender, EventArgs e)
        {
            ok_bt.BackColor = Color.CornflowerBlue;
        }

        private void cancel_bt_MouseHover(object sender, EventArgs e)
        {
            cancel_bt.BackColor = Color.RoyalBlue;
        }

        private void cancel_bt_MouseLeave(object sender, EventArgs e)
        {
            cancel_bt.BackColor = Color.CornflowerBlue;
        }
    }
}
