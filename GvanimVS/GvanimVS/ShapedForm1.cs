using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace GvanimVS
{
    public partial class ShapedForm1 :  DBform
    {
        string CONNECTION_STRING = "Data Source= gingos.database.windows.net;Initial Catalog=gvanimDB;Persist Security Info=True;User ID=gingos;Password=wolf20Schneid!";
        volatile bool connected;

        public ShapedForm1(SqlConnection con) : base(con)
        {
            LoginPage lp = new LoginPage(con);
            InitializeComponent();
        }

        public ShapedForm1()
        {
            InitializeComponent();
            //con = new SqlConnection(CONNECTION_STRING);
            connected = false;
            LoginPage lp = new LoginPage(panel1);
            lp.TopLevel = false;
            lp.AutoScroll = true;
            panel1.Controls.Add(lp);
            lp.Show();

        }

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string headerText
        {
            get{return headersPanel.Text;}
            set{headersPanel.Text = value;}
        }

        public void headersPanel_TextChanged(string text, object sender, EventArgs e)
        {
            headersPanel.Text = text;
            headersPanel.Refresh();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
