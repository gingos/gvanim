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
        private string managerID;

        public CreateCoordinator()
        {
            InitializeComponent();
        }

        public CreateCoordinator(SqlConnection con, string managerID):base(con)
        {
            InitializeComponent();
            this.managerID = managerID;
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_bt_Click(object sender, EventArgs e)
        {
            string job;

            
            
            if (!verifydata())
            {
                MessageBox.Show("קלט לא תקין, נא בדקו את אותו ונסו שוב");
            }
            else
            {
                if (job_cb.SelectedItem.ToString().Equals("מנהלת"))
                {
                    job = "region manager";
                }
                else
                {
                    job = "coordinator";
                }

                if (!SQLmethods.upsertUser(firstName_tb.Text, lastName_tb.Text, email_tb.Text, identity_tb.Text, password_tb.Text, job, cmd))
                {
                    MessageBox.Show("אירעה שגיאה במהלך הזנת הנתונים, אנא נסו שוב");
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
            if (!Tools.IsValidEmail(email_tb.Text))
            {
                email_exception_lb.Show();
                validation = false;
            }
            else
                email_exception_lb.Hide();

            if (!Tools.verifyID(identity_tb.Text))
            {
                identity_exception_lb.Show();
                validation = false;
            }
            else
                identity_exception_lb.Hide();

            if (job_cb.SelectedItem == null)
            {
                job_exception_lb.Show();
                validation = false;
            }
            else
                job_exception_lb.Hide();

            return validation;

        }

        private void password_tb_Click(object sender, EventArgs e)
        {
            password_tb.Text = "";
        }

        private void identity_tb_Click(object sender, EventArgs e)
        {
            identity_tb.Text = "";
        }

        private void email_tb_Click(object sender, EventArgs e)
        {
            email_tb.Text = "";
        }

        private void lastName_tb_Click(object sender, EventArgs e)
        {
            lastName_tb.Text = "";
        }

        private void close_bt_MouseHover(object sender, EventArgs e)
        {
            close_bt.BackColor = Color.RoyalBlue;
        }

        private void close_bt_MouseLeave(object sender, EventArgs e)
        {
            close_bt.BackColor = Color.CornflowerBlue;
        }

        private void save_bt_MouseHover(object sender, EventArgs e)
        {
            save_bt.BackColor = Color.RoyalBlue;
        }

        private void save_bt_MouseLeave(object sender, EventArgs e)
        {
            save_bt.BackColor = Color.CornflowerBlue;
        }
    }
}
