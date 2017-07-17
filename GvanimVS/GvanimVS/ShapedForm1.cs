using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GvanimVS
{
    public partial class ShapedForm1 :  DBform
    {
        LoginPage lp;

        public ShapedForm1(SqlConnection con) : base(con)
        {
            InitializeComponent();
            LoginPage lp = new LoginPage(con);
        }

        public ShapedForm1()
        {
            InitializeComponent();
            lp = new LoginPage();
            lp.TopLevel = false;
            lp.AutoScroll = true;
            mainPanel.Controls.Add(lp);
            lp.Show();

        }

        public void headersPanel_TextChanged(string text, object sender, EventArgs e)
        {
            headersPanel.Text = text;
            headersPanel.Refresh();
        }

        private void exit_bt_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
