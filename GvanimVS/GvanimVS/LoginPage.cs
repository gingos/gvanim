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
    public partial class LoginPage : DBform
    {
        /* TODO
         * add red\green status button
         * add "accept on enter" to press enter on keyboard and choose OK
         * 
         * 
         */
        public LoginPage(SqlConnection con):base(con)
        {
            InitializeComponent();
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            if (verifyFields())
            {
                DataTable dt = SQLmethods.getDataTable(SQLmethods.USERS, user_tb.Text, password_tb.Text,
                    cmd, da);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("שם משתמש או סיסמא אינם נכונים");
                else
                {
                    DataRow dr = dt.Rows[0];
                    MessageBox.Show("ברוך הבא\n " +
                        dr["firstName"] + " " + dr["lastName"] + "\n" +
                        dr["role"].ToString());
                    this.Hide();
                    openMatchingUserGui(dr);
                    this.Show();
                }
            }
        }
        private bool verifyFields()
        {
            if (user_tb.Text.Equals(""))
            {
                MessageBox.Show("אנא ציינו תעודת זהות או כתובת אימייל");
                user_tb.Focus();
                return false;
            }
            if (password_tb.Text.Equals(""))
            {
                MessageBox.Show("אנו ציינו סיסמא");
                password_tb.Focus();
                return false;
            }
            return true;
        }
        private void openMatchingUserGui (DataRow dr)
        {
            switch (dr["role"].ToString())
            {
                case "region manager":
                    using (var rm = new RegionManager(con, dr["ID"].ToString()))
                    {
                        rm.ShowDialog();
                    }
                    break;
                case "coordinator":
                    using (var c = new Coordinator(con, dr["ID"].ToString()))
                    {
                        c.ShowDialog();
                    }
                    break;
                default:
                    MessageBox.Show("אנא בדקו שוב שם וסיסמא");
                    break;
            }
        }
    }
}
