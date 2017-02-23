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
    public partial class AddMeeting : DBform
    {
        //TODO merge time picker and date picker
        public AddMeeting(SqlConnection con):base(con)
        {
            InitializeComponent();
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMeeting_bt_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day,
                timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);
            if (isValid()){
                MessageBox.Show("valid");
            }

        }

        private bool isValid()
        {
            if (!datePicker.Checked)
            {
                MessageBox.Show("נא לאשר את תאריך הפגישה");
                return false;
            }
            if (!timePicker.Checked)
            {
                MessageBox.Show("נא לאשר את שעת הפגישה");
                return false;
            }
            return true;
        }
    }
}
