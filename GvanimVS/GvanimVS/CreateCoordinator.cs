using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GvanimVS
{
    public partial class CreateCoordinator : DBform
    {
        private SqlConnection con;
        private string managerID;

        public CreateCoordinator()
        {
            InitializeComponent();
        }

        public CreateCoordinator(SqlConnection con, string managerID)
        {
            this.con = con;
            this.managerID = managerID;
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_bt_Click(object sender, EventArgs e)
        {
            bool locker;
            string job;
            if (job_cb.SelectedItem.ToString().Equals("מנהלת"))
            {
                job = "region manager";
            }
            else
            {
                job = "coordinator";
            }

            locker = verifydata();
            if (locker == false)
            {
                MessageBox.Show("please fix input");
            }
            else
            {
                bool end = SQLmethods.upsertUser(firstName_tb.Text, lastName_tb.Text, email_tb.Text, identity_tb.Text, password_tb.Text, job, cmd);
                if (end == false)
                {
                    MessageBox.Show("אירעה שגיאה במהלך הזנת הנתונים, אנא נסי שוב");
                }
                else
                {
                    MessageBox.Show("הנתונים נשמרו בהצלחה");
                    this.Close();
                }
            }
        }

        private bool verifydata()
        {
            bool validation = true;
            validation = verifyEmail(email_tb.Text);
            if (validation == false)
            {
                email_exception_lb.Show();
            }

            validation = verifyID(identity_tb.Text);
            if (validation == false)
            {
                identity_exception_lb.Show();
            }

            return validation;

        }

        private bool verifyID(string identity)
        {
            Regex reg = new Regex(@"\b[0-9]{9}\b");
            if (!reg.IsMatch(identity))
            {
                return false;
            }
            return true;
        }

        private bool verifyEmail(string email)
        {
            Regex reg = new Regex(@"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z.-]{2,5}\b");
            if (!reg.IsMatch(email))
            {
                return false;
            }
            return true;
        }
    }
}
